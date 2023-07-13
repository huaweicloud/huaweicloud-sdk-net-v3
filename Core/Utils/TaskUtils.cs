using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HuaweiCloud.SDK.Core
{
    public static class TaskUtils
    {
        public static T RunSync<T>(Func<Task<T>> task)
        {
            var oldContext = SynchronizationContext.Current;
            if (oldContext == null)
            {
                return task.Invoke().Result;
            }

            var exclusiveContext = new ExclusiveSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(exclusiveContext);
            var result = default(T);
            exclusiveContext.Post(async _ =>
            {
                try
                {
                    result = await task();
                }
                catch (Exception e)
                {
                    exclusiveContext.InnerException = e;
                    throw;
                }
                finally
                {
                    exclusiveContext.EndMessageLoop();
                }
            }, null);
            exclusiveContext.BeginMessageLoop();
            SynchronizationContext.SetSynchronizationContext(oldContext);
            return result;
        }

        private class ExclusiveSynchronizationContext : SynchronizationContext
        {
            public Exception InnerException { get; set; }

            private bool _done;

            private readonly AutoResetEvent _workItemsWaiting = new AutoResetEvent(false);

            private readonly Queue<Tuple<SendOrPostCallback, object>> _items = new Queue<Tuple<SendOrPostCallback, object>>();

            public override void Send(SendOrPostCallback d, object state)
            {
                throw new NotSupportedException("Cannot send to the same thread");
            }

            public override void Post(SendOrPostCallback d, object state)
            {
                lock (_items)
                {
                    _items.Enqueue(Tuple.Create(d, state));
                }
                _workItemsWaiting.Set();
            }

            public void EndMessageLoop()
            {
                Post(_ => _done = true, null);
            }

            public void BeginMessageLoop()
            {
                while (!_done)
                {
                    Tuple<SendOrPostCallback, object> task = null;
                    lock (_items)
                    {
                        if (_items.Count > 0)
                        {
                            task = _items.Dequeue();
                        }
                    }
                    if (task != null)
                    {
                        task.Item1(task.Item2);
                        if (InnerException != null)
                        {
                            throw new AggregateException(InnerException);
                        }
                    }
                    else
                    {
                        _workItemsWaiting.WaitOne();
                    }
                }
            }

            public override SynchronizationContext CreateCopy()
            {
                return this;
            }
        }
    }
}
