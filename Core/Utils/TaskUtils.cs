/*
 * Copyright 2023 Huawei Technologies Co.,Ltd.
 *
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HuaweiCloud.SDK.Core
{
    public static class TaskUtils
    {
        /// <summary>
        /// Synchronously execute an async Task method which has a void return value.
        /// </summary>
        /// <param name="task">The Task method to execute.</param>
        public static void RunSync(Func<Task> task)
        {
            var oldContext = SynchronizationContext.Current;
            if (oldContext == null)
            {
                task.Invoke().Wait();
                return;
            }

            var exclusiveContext = new ExclusiveSynchronizationContext();
            SynchronizationContext.SetSynchronizationContext(exclusiveContext);
            exclusiveContext.Post(async _ =>
            {
                try
                {
                    await task();
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
        }

        /// <summary>
        /// Synchronously execute an async Task method and return a value of type T.
        /// </summary>
        /// <param name="task">The Task method to execute.</param>
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

            private readonly Queue<Tuple<SendOrPostCallback, object>> _items = new Queue<Tuple<SendOrPostCallback, object>>();

            private readonly AutoResetEvent _workItemsWaiting = new AutoResetEvent(false);

            private bool _done;
            public Exception InnerException { get; set; }

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
