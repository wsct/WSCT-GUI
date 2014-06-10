using System;
using System.Linq;
using System.Linq.Expressions;
using WSCT.Core;
using WSCT.Core.Events;
using WSCT.Helpers.Events;
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

        /// <inheritdoc />
        public string LayerId
        {
            get { return "IAL"; }
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
            BeforeCancelEvent.Raise(this, new BeforeCancelEventArgs());

            var ret = _stack.RequestLayer(this, SearchMode.Next).Cancel();

            AfterCancelEvent.Raise(this, new AfterCancelEventArgs { ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Establish()
        {
            BeforeEstablishEvent.Raise(this, new BeforeEstablishEventArgs());

            var ret = _stack.RequestLayer(this, SearchMode.Next).Establish();

            AfterEstablishEvent.Raise(this, new AfterEstablishEventArgs { ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode GetStatusChange(uint timeout, AbstractReaderState[] readerStates)
        {
            ErrorCode ret;

            BeforeGetStatusChangeEvent.Raise(this, new BeforeGetStatusChangeEventArgs { TimeOut = timeout, ReaderStates = readerStates });

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

            AfterGetStatusChangeEvent.Raise(this, new AfterGetStatusChangeEventArgs { TimeOut = timeout, ReaderStates = readerStates, ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode IsValid()
        {
            BeforeIsValidEvent.Raise(this, new BeforeIsValidEventArgs());

            var ret = _stack.RequestLayer(this, SearchMode.Next).IsValid();

            AfterIsValidEvent.Raise(this, new AfterIsValidEventArgs { ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode ListReaders(string group)
        {
            BeforeListReadersEvent.Raise(this, new BeforeListReadersEventArgs { Group = group });

            var ret = _stack.RequestLayer(this, SearchMode.Next).ListReaders(group);

            if (InteractiveController.UseFakeReader)
            {
                // If Interactive Layer is used, the dedicated fake reader is always present.
                ret = ErrorCode.Success;
            }

            AfterListReadersEvent.Raise(this, new AfterListReadersEventArgs { Group = group, ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode ListReaderGroups()
        {
            BeforeListReaderGroupsEvent.Raise(this, new BeforeListReaderGroupsEventArgs());

            var ret = _stack.RequestLayer(this, SearchMode.Next).ListReaderGroups();

            AfterListReaderGroupsEvent.Raise(this, new AfterListReaderGroupsEventArgs { ReturnValue = ret });

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode Release()
        {
            BeforeReleaseEvent.Raise(this, new BeforeReleaseEventArgs());

            var ret = _stack.RequestLayer(this, SearchMode.Next).Release();

            AfterReleaseEvent.Raise(this, new AfterReleaseEventArgs { ReturnValue = ret });

            return ret;
        }

        #endregion

        #region >> ICardContextObservable

        /// <inheritdoc />
        public event EventHandler<BeforeCancelEventArgs> BeforeCancelEvent;

        /// <inheritdoc />
        public event EventHandler<AfterCancelEventArgs> AfterCancelEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeEstablishEventArgs> BeforeEstablishEvent;

        /// <inheritdoc />
        public event EventHandler<AfterEstablishEventArgs> AfterEstablishEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeGetStatusChangeEventArgs> BeforeGetStatusChangeEvent;

        /// <inheritdoc />
        public event EventHandler<AfterGetStatusChangeEventArgs> AfterGetStatusChangeEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeIsValidEventArgs> BeforeIsValidEvent;

        /// <inheritdoc />
        public event EventHandler<AfterIsValidEventArgs> AfterIsValidEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeListReaderGroupsEventArgs> BeforeListReaderGroupsEvent;

        /// <inheritdoc />
        public event EventHandler<AfterListReaderGroupsEventArgs> AfterListReaderGroupsEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeListReadersEventArgs> BeforeListReadersEvent;

        /// <inheritdoc />
        public event EventHandler<AfterListReadersEventArgs> AfterListReadersEvent;

        /// <inheritdoc />
        public event EventHandler<BeforeReleaseEventArgs> BeforeReleaseEvent;

        /// <inheritdoc />
        public event EventHandler<AfterReleaseEventArgs> AfterReleaseEvent;

        #endregion
    }
}