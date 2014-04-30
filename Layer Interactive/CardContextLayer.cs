using System;
using System.Linq;
using WSCT.Core;
using WSCT.Stack;
using WSCT.Wrapper;

namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Interactive context layer capable of saving data exchanges with the reader and replaying it later.
    /// Also install a fake reader, allowing replay mode to be used without physical reader.
    /// </summary>
    public class CardContextLayer : ICardContextLayer, ICardContextObservable
    {
        #region >> Fields

        private ICardContextStack _stack;

        #endregion

        #region >> ICardContextLayer

        /// <inheritdoc/>
        public void SetStack(ICardContextStack stack)
        {
            _stack = stack;
        }

        #endregion

        #region >> ICardContext

        /// <inheritdoc />
        public IntPtr Context
        {
            get { return _stack.RequestLayer(this, SearchMode.Next).Context; }
        }

        /// <inheritdoc />
        public string[] Groups
        {
            get { return _stack.RequestLayer(this, SearchMode.Next).Groups; }
        }

        /// <inheritdoc />
        public int GroupsCount
        {
            get { return _stack.RequestLayer(this, SearchMode.Next).GroupsCount; }
        }

        /// <inheritdoc />
        public string[] Readers
        {
            get
            {
                var readers = _stack.RequestLayer(this, SearchMode.Next).Readers;

                if (InteractiveController.UseFakeReader)
                {
                    readers = readers.Union(new[] { InteractiveController.FakeReaderName }).ToArray();
                }

                return readers;
            }
        }

        /// <inheritdoc />
        public int ReadersCount
        {
            get
            {
                var readersCount = _stack.RequestLayer(this, SearchMode.Next).ReadersCount;

                if (InteractiveController.UseFakeReader)
                {
                    readersCount += 1;
                }

                return readersCount;
            }
        }

        /// <inheritdoc />
        public ErrorCode Cancel()
        {
            if (BeforeCancelEvent != null)
            {
                BeforeCancelEvent(this);
            }

            var ret = _stack.RequestLayer(this, SearchMode.Next).Cancel();

            if (AfterCancelEvent != null)
            {
                AfterCancelEvent(this, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Establish()
        {
            if (BeforeEstablishEvent != null)
            {
                BeforeEstablishEvent(this);
            }

            var ret = _stack.RequestLayer(this, SearchMode.Next).Establish();

            if (AfterEstablishEvent != null)
            {
                AfterEstablishEvent(this, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode GetStatusChange(uint timeout, AbstractReaderState[] readerStates)
        {
            ErrorCode ret;

            if (BeforeGetStatusChangeEvent != null)
            {
                BeforeGetStatusChangeEvent(this, timeout, readerStates);
            }

            // Filtering fakeReader
            var fakeReaderState = readerStates.FirstOrDefault(rs => rs.ReaderName == InteractiveController.FakeReaderName);
            if (fakeReaderState != null)
            {
                // To be improved to wait for eventState occuring on fake reader
                if (readerStates.Length > 1)
                {
                    // Sending getStatusChange of other readers to the next layer
                    var filteredReaderStates = readerStates.Where(rs => rs.ReaderName != InteractiveController.FakeReaderName).ToArray();
                    ret = _stack.RequestLayer(this, SearchMode.Next).GetStatusChange(timeout, filteredReaderStates);
                }
                else
                {
                    ret = ErrorCode.Success;
                }
            }
            else
            {
                ret = _stack.RequestLayer(this, SearchMode.Next).GetStatusChange(timeout, readerStates);
            }

            if (AfterGetStatusChangeEvent != null)
            {
                AfterGetStatusChangeEvent(this, timeout, readerStates, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode IsValid()
        {
            if (BeforeIsValidEvent != null)
            {
                BeforeIsValidEvent(this);
            }

            var ret = _stack.RequestLayer(this, SearchMode.Next).IsValid();

            if (AfterIsValidEvent != null)
            {
                AfterIsValidEvent(this, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode ListReaders(string group)
        {
            if (BeforeListReadersEvent != null)
            {
                BeforeListReadersEvent(this, group);
            }

            var ret = _stack.RequestLayer(this, SearchMode.Next).ListReaders(group);

            if (InteractiveController.UseFakeReader)
            {
                // If Interactive Layer is used, the dedicated fake reader is always present.
                ret = ErrorCode.Success;
            }

            if (AfterListReadersEvent != null)
            {
                AfterListReadersEvent(this, group, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode ListReaderGroups()
        {
            if (BeforeListReaderGroupsEvent != null)
            {
                BeforeListReaderGroupsEvent(this);
            }

            var ret = _stack.RequestLayer(this, SearchMode.Next).ListReaderGroups();

            if (AfterListReaderGroupsEvent != null)
            {
                AfterListReaderGroupsEvent(this, ret);
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Release()
        {
            if (BeforeReleaseEvent != null)
            {
                BeforeReleaseEvent(this);
            }

            var ret = _stack.RequestLayer(this, SearchMode.Next).Release();

            if (AfterReleaseEvent != null)
            {
                AfterReleaseEvent(this, ret);
            }

            return ret;
        }

        #endregion

        #region >> ICardContextObservable

        /// <inheritdoc />
        public event BeforeCancel BeforeCancelEvent;

        /// <inheritdoc />
        public event AfterCancel AfterCancelEvent;

        /// <inheritdoc />
        public event BeforeEstablish BeforeEstablishEvent;

        /// <inheritdoc />
        public event AfterEstablish AfterEstablishEvent;

        /// <inheritdoc />
        public event BeforeGetStatusChange BeforeGetStatusChangeEvent;

        /// <inheritdoc />
        public event AfterGetStatusChange AfterGetStatusChangeEvent;

        /// <inheritdoc />
        public event BeforeIsValid BeforeIsValidEvent;

        /// <inheritdoc />
        public event AfterIsValid AfterIsValidEvent;

        /// <inheritdoc />
        public event BeforeListReaderGroups BeforeListReaderGroupsEvent;

        /// <inheritdoc />
        public event AfterListReaderGroups AfterListReaderGroupsEvent;

        /// <inheritdoc />
        public event BeforeListReaders BeforeListReadersEvent;

        /// <inheritdoc />
        public event AfterListReaders AfterListReadersEvent;

        /// <inheritdoc />
        public event BeforeRelease BeforeReleaseEvent;

        /// <inheritdoc />
        public event AfterRelease AfterReleaseEvent;

        #endregion
    }
}