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
using System.Threading;

namespace HuaweiCloud.SDK.Core
{
    internal class ThreadSafeTransferStreamByBytes : TransferStreamManager
    {

        protected readonly object Lock = new object();
        protected bool Flag;

        protected ThreadSafeTransferStreamByBytes(object sender, EventHandler<TransferStatus> handler, long totalBytes,
            long transferredBytes, double intervalByBytes) : base(sender, handler, totalBytes, transferredBytes)
        {
            Interval = intervalByBytes;
        }

        public override void TransferStart()
        {
            if (!Flag)
            {
                lock (Lock)
                {
                    Flag = true;
                    base.TransferStart();
                }
            }
        }

        public override void TransferReset(long resetBytes)
        {
            Interlocked.Add(ref TransferredBytes, -resetBytes);
        }

        public override void TransferEnd()
        {
            lock (Lock)
            {
                base.TransferEnd();
            }
        }

        protected override void DoBytesTransferred(int bytes)
        {
            Interlocked.Add(ref TransferredBytes, bytes);
            Interlocked.Add(ref NewlyTransferredBytes, bytes);
            var now = DateTime.Now;
            var currentInstantaneousBytes = CreateCurrentInstantaneousBytes(bytes, now);
            LastInstantaneousBytes = currentInstantaneousBytes;

            var newlyTransferredBytes = Interlocked.Read(ref NewlyTransferredBytes);
            var transferredBytes = Interlocked.Read(ref TransferredBytes);
            if (newlyTransferredBytes >= Interval && (transferredBytes < TotalBytes || TotalBytes == -1))
            {
                if (Interlocked.CompareExchange(ref NewlyTransferredBytes, 0, newlyTransferredBytes) == newlyTransferredBytes)
                {
                    var status = new TransferStatus(newlyTransferredBytes,
                        transferredBytes, TotalBytes, (now - LastCheckpoint).TotalSeconds, (now - StartCheckpoint).TotalSeconds);
                    status.SetInstantaneousBytes(currentInstantaneousBytes);
                    Handler(Sender, status);
                    LastCheckpoint = now;
                }
            }
        }
    }


    internal class ThreadSafeTransferStreamBySeconds : ThreadSafeTransferStreamByBytes
    {

        private Timer _timer;

        public ThreadSafeTransferStreamBySeconds(object sender, EventHandler<TransferStatus> handler, long totalBytes,
            long transferredBytes, double intervalBySeconds) : base(sender, handler, totalBytes, transferredBytes, intervalBySeconds)
        {
        }

        private void DoRecord(object state)
        {
            var now = DateTime.Now;
            var transferredBytes = Interlocked.Read(ref TransferredBytes);
            if (transferredBytes < TotalBytes)
            {
                var newlyTransferredBytes = Interlocked.Read(ref NewlyTransferredBytes);
                var status = new TransferStatus(newlyTransferredBytes,
                    transferredBytes, TotalBytes, Interval, (now - StartCheckpoint).TotalSeconds);
                Handler(Sender, status);
                // Reset
                Interlocked.Add(ref NewlyTransferredBytes, -newlyTransferredBytes);
                LastCheckpoint = now;
            }
        }

        public override void TransferStart()
        {
            if (!Flag)
            {
                lock (Lock)
                {
                    Flag = true;
                    StartCheckpoint = DateTime.Now;
                    LastCheckpoint = DateTime.Now;
                    _timer = new Timer(DoRecord, null, 0, Convert.ToInt32(Interval * 1000));
                }
            }
        }

        public override void TransferEnd()
        {
            lock (Lock)
            {
                _timer?.Dispose();
                var now = DateTime.Now;
                var status = new TransferStatus(Interlocked.Read(ref NewlyTransferredBytes),
                    Interlocked.Read(ref TransferredBytes), TotalBytes, (now - LastCheckpoint).TotalSeconds, (now - StartCheckpoint).TotalSeconds);
                Handler(Sender, status);
            }
        }

        protected override void DoBytesTransferred(int bytes)
        {
            Interlocked.Add(ref TransferredBytes, bytes);
            Interlocked.Add(ref NewlyTransferredBytes, bytes);
        }
    }
}
