using System;
using System.Linq;
using WSCT.Stack;
using WSCT.Wrapper;

namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Interactive context layer capable of saving data exchanges with the reader and replaying it later.
    /// Also install a fake reader, allowing replay mode to be used without physical reader.
    /// </summary>
    public class CardContextLayer : ICardContextLayer
    {
        #region >> Fields

        private ICardContextStack stack;

        #endregion

        #region >> ICardContextLayer

        /// <inheritdoc/>
        public void SetStack(ICardContextStack stack)
        {
            this.stack = stack;
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
            get { return stack.RequestLayer(this, SearchMode.Next).Context; }
        }

        /// <inheritdoc />
        public string[] Groups
        {
            get { return stack.RequestLayer(this, SearchMode.Next).Groups; }
        }

        /// <inheritdoc />
        public int GroupsCount
        {
            get { return stack.RequestLayer(this, SearchMode.Next).GroupsCount; }
        }

        /// <inheritdoc />
        public string[] Readers
        {
            get
            {
                var readers = stack.RequestLayer(this, SearchMode.Next).Readers;

                if (InteractiveController.UseFakeReader)
                {
                    readers = readers.Concat(new[] { InteractiveController.FakeReaderName }).ToArray();
                }

                return readers;
            }
        }

        /// <inheritdoc />
        public int ReadersCount
        {
            get
            {
                var readersCount = stack.RequestLayer(this, SearchMode.Next).ReadersCount;

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
            return stack.RequestLayer(this, SearchMode.Next).Cancel();
        }

        /// <inheritdoc />
        public ErrorCode Establish()
        {
            return stack.RequestLayer(this, SearchMode.Next).Establish();
        }

        /// <inheritdoc />
        public ErrorCode GetStatusChange(uint timeout, AbstractReaderState[] readerStates)
        {
            // Filtering fakeReader
            var fakeReaderState = readerStates.FirstOrDefault(rs => rs.ReaderName == InteractiveController.FakeReaderName);

            // TODO: To be improved to wait for eventState occuring on fake reader ?
            if (fakeReaderState == null)
            {
                return stack.RequestLayer(this, SearchMode.Next).GetStatusChange(timeout, readerStates);
            }

            if (readerStates.Length <= 1)
            {
                return ErrorCode.Success;
            }

            // Sending getStatusChange of other readers to the next layer
            var filteredReaderStates = readerStates.Where(rs => rs.ReaderName != InteractiveController.FakeReaderName).ToArray();

            return stack.RequestLayer(this, SearchMode.Next).GetStatusChange(timeout, filteredReaderStates);
        }

        /// <inheritdoc />
        public ErrorCode IsValid()
        {
            return stack.RequestLayer(this, SearchMode.Next).IsValid();
        }

        /// <inheritdoc />
        public ErrorCode ListReaders(string group)
        {
            var ret = stack.RequestLayer(this, SearchMode.Next).ListReaders(group);

            if (InteractiveController.UseFakeReader)
            {
                // If Interactive Layer is used, the dedicated fake reader is always present.
                ret = ErrorCode.Success;
            }

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode ListReaderGroups()
        {
            return stack.RequestLayer(this, SearchMode.Next).ListReaderGroups();
        }

        /// <inheritdoc />
        public ErrorCode Release()
        {
            return stack.RequestLayer(this, SearchMode.Next).Release();
        }

        #endregion
    }
}