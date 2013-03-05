using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using WSCT.Helpers;
using WSCT.Wrapper;
using WSCT.Core;
using WSCT.Stack;

namespace WSCT.Layers.Interactive
{
    /// <summary>
    /// Interactive context layer capable of saving data exchanges with the reader and replaying it later.
    /// Also install a fake reader, allowing replay mode to be used without physical reader.
    /// </summary>
    public class CardContextLayer : ICardContextLayer, ICardContextObservable
    {
        #region >> Fields

        ICardContextStack _stack;

        #endregion

        #region >> ICardContextLayer

        /// <inheritdoc/>
        public void setStack(ICardContextStack stack)
        {
            _stack = stack;
        }

        #endregion

        #region >> ICardContext

        /// <inheritdoc />
        public IntPtr context
        {
            get
            {
                return _stack.requestLayer(this, SearchMode.next).context;
            }
        }

        /// <inheritdoc />
        public string[] groups
        {
            get
            {
                return _stack.requestLayer(this, SearchMode.next).groups;
            }
        }

        /// <inheritdoc />
        public int groupsCount
        {
            get
            {
                return _stack.requestLayer(this, SearchMode.next).groupsCount;
            }
        }

        /// <inheritdoc />
        public string[] readers
        {
            get
            {
                String[] readers = _stack.requestLayer(this, SearchMode.next).readers;
                if (InteractiveController.useFakeReader)
                {
                    Array.Resize(ref readers, readers.Length + 1);
                    readers[readers.Length - 1] = InteractiveController.fakeReaderName;
                }
                return readers;
            }
        }

        /// <inheritdoc />
        public int readersCount
        {
            get
            {
                int readersCount = _stack.requestLayer(this, SearchMode.next).readersCount;
                if (InteractiveController.useFakeReader)
                    readersCount += 1;
                return readersCount;
            }
        }

        /// <inheritdoc />
        public Wrapper.ErrorCode cancel()
        {
            if (beforeCancelEvent != null) beforeCancelEvent(this);

            ErrorCode ret = _stack.requestLayer(this, SearchMode.next).cancel();

            if (afterCancelEvent != null) afterCancelEvent(this, ret);

            return ret;
        }

        /// <inheritdoc />
        public Wrapper.ErrorCode establish()
        {
            if (beforeEstablishEvent != null) beforeEstablishEvent(this);

            ErrorCode ret = _stack.requestLayer(this, SearchMode.next).establish();

            if (afterEstablishEvent != null) afterEstablishEvent(this, ret);

            return ret;
        }

        /// <inheritdoc />
        public ErrorCode getStatusChange(uint timeout, AbstractReaderState[] readerStates)
        {
            ErrorCode ret;

            if (beforeGetStatusChangeEvent != null) beforeGetStatusChangeEvent(this, timeout, readerStates);

            // Filtering fakeReader
            AbstractReaderState fakeReaderState = readerStates.FirstOrDefault(rs => rs.readerName == InteractiveController.fakeReaderName);
            if (fakeReaderState != null)
            {
                // To be improved to wait for eventState occuring on fake reader
                if (readerStates.Length > 1)
                {
                    // Sending getStatusChange of other readers to the next layer
                    AbstractReaderState[] filteredReaderStates = readerStates.Where(rs => rs.readerName != InteractiveController.fakeReaderName).ToArray();
                    ret = _stack.requestLayer(this, SearchMode.next).getStatusChange(timeout, filteredReaderStates);
                }
                else
                {
                    ret = ErrorCode.SCARD_S_SUCCESS;
                }
            }
            else
            {
                ret = _stack.requestLayer(this, SearchMode.next).getStatusChange(timeout, readerStates);
            }

            if (afterGetStatusChangeEvent != null) afterGetStatusChangeEvent(this, timeout, readerStates, ret);

            return ret;
        }

        /// <inheritdoc />
        public Wrapper.ErrorCode isValid()
        {
            if (beforeIsValidEvent != null) beforeIsValidEvent(this);

            ErrorCode ret = _stack.requestLayer(this, SearchMode.next).isValid();

            if (afterIsValidEvent != null) afterIsValidEvent(this, ret);

            return ret;
        }

        /// <inheritdoc />
        public Wrapper.ErrorCode listReaders(string group)
        {
            if (beforeListReadersEvent != null) beforeListReadersEvent(this, group);

            ErrorCode ret = _stack.requestLayer(this, SearchMode.next).listReaders(group);

            if (afterListReadersEvent != null) afterListReadersEvent(this, group, ret);

            return ret;
        }

        /// <inheritdoc />
        public Wrapper.ErrorCode listReaderGroups()
        {
            if (beforeListReaderGroupsEvent != null) beforeListReaderGroupsEvent(this);

            ErrorCode ret = _stack.requestLayer(this, SearchMode.next).listReaderGroups();

            if (afterListReaderGroupsEvent != null) afterListReaderGroupsEvent(this, ret);

            return ret;
        }

        /// <inheritdoc />
        public Wrapper.ErrorCode release()
        {
            if (beforeReleaseEvent != null) beforeReleaseEvent(this);

            ErrorCode ret = _stack.requestLayer(this, SearchMode.next).release();

            if (afterReleaseEvent != null) afterReleaseEvent(this, ret);

            return ret;
        }

        #endregion

        #region >> ICardContextObservable

        /// <inheritdoc />
        public event beforeCancel beforeCancelEvent;

        /// <inheritdoc />
        public event afterCancel afterCancelEvent;

        /// <inheritdoc />
        public event beforeEstablish beforeEstablishEvent;

        /// <inheritdoc />
        public event afterEstablish afterEstablishEvent;

        /// <inheritdoc />
        public event beforeGetStatusChange beforeGetStatusChangeEvent;

        /// <inheritdoc />
        public event afterGetStatusChange afterGetStatusChangeEvent;

        /// <inheritdoc />
        public event beforeIsValid beforeIsValidEvent;

        /// <inheritdoc />
        public event afterIsValid afterIsValidEvent;

        /// <inheritdoc />
        public event beforeListReaderGroups beforeListReaderGroupsEvent;

        /// <inheritdoc />
        public event afterListReaderGroups afterListReaderGroupsEvent;

        /// <inheritdoc />
        public event beforeListReaders beforeListReadersEvent;

        /// <inheritdoc />
        public event afterListReaders afterListReadersEvent;

        /// <inheritdoc />
        public event beforeRelease beforeReleaseEvent;

        /// <inheritdoc />
        public event afterRelease afterReleaseEvent;

        #endregion
    }
}
