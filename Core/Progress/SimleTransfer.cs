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
using System.IO;

namespace HuaweiCloud.SDK.Core
{
    internal class TransferStream : Stream
    {
        private long _readBytes;

        private bool _readFlag;
        private bool _writeFlag;

        public TransferStream(Stream originStream)
        {
            OriginStream = originStream;
        }

        private Stream OriginStream { get; set; }

        public override bool CanRead => OriginStream.CanRead;

        public override bool CanSeek => OriginStream.CanSeek;

        public override bool CanWrite => OriginStream.CanWrite;

        public override long Length => OriginStream.Length;

        public override long Position
        {
            get => OriginStream.Position;
            set
            {
                _writeFlag = false;
                _readFlag = false;
                OriginStream.Position = value;
            }
        }

        internal event BytesTransferred BytesRead;
        internal event BytesTransferred BytesWritten;
        internal event BytesAction BytesReset;
        internal event EventDelegate StartWrite;
        internal event EventDelegate StartRead;
        internal event EventDelegate CloseStream;

        public override void Flush()
        {
            OriginStream.Flush();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            _writeFlag = false;
            _readFlag = false;
            return OriginStream.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            OriginStream.SetLength(value);
        }

        public void ResetReadProgress()
        {
            BytesReset?.Invoke(_readBytes);
            _readBytes = 0;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (!_readFlag)
            {
                _readFlag = true;
                StartRead?.Invoke();
            }
            var bytes = OriginStream.Read(buffer, offset, count);
            _readBytes += bytes;
            BytesRead?.Invoke(bytes);
            return bytes;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (!_writeFlag)
            {
                _writeFlag = true;
                StartWrite?.Invoke();
            }
            OriginStream.Write(buffer, offset, count);
            BytesWritten?.Invoke(count);
        }

        public override void Close()
        {
            try
            {
                OriginStream.Close();
            }
            finally
            {
                CloseStream?.Invoke();
            }
        }

        internal delegate void BytesTransferred(int bytes);

        internal delegate void BytesAction(long bytes);

        internal delegate void EventDelegate();
    }

    internal class BytesUnit
    {
        public DateTime DateTime { get; set; }

        public long Bytes { set; get; }
    }

    internal abstract class TransferStreamManager
    {
        protected readonly EventHandler<TransferStatus> Handler;
        protected readonly object Sender;
        protected readonly long TotalBytes;
        protected double Interval;
        protected DateTime LastCheckpoint;
        protected volatile IList<BytesUnit> LastInstantaneousBytes;
        protected long NewlyTransferredBytes;
        protected DateTime StartCheckpoint;
        protected long TransferredBytes;

        protected TransferStreamManager(object sender, EventHandler<TransferStatus> handler, long totalBytes,
            long transferredBytes)
        {
            Sender = sender;
            Handler = handler;
            TotalBytes = totalBytes;
            TransferredBytes = transferredBytes < 0 ? 0 : transferredBytes;
            StartCheckpoint = DateTime.Now;
            LastCheckpoint = DateTime.Now;
        }

        public virtual void TransferStart()
        {
            StartCheckpoint = DateTime.Now;
            LastCheckpoint = DateTime.Now;
            LastInstantaneousBytes = new List<BytesUnit>();
        }

        public virtual void TransferReset(long resetBytes)
        {
            StartCheckpoint = DateTime.Now;
            LastCheckpoint = DateTime.Now;
            LastInstantaneousBytes = new List<BytesUnit>();
            NewlyTransferredBytes = 0;
            TransferredBytes -= resetBytes;
        }

        protected IList<BytesUnit> CreateCurrentInstantaneousBytes(long bytes, DateTime now)
        {
            var currentInstantaneousBytes = new List<BytesUnit>();
            var lastInstantaneousBytes = LastInstantaneousBytes;
            if (lastInstantaneousBytes != null)
            {
                foreach (var item in lastInstantaneousBytes)
                {
                    if ((now - item.DateTime).TotalMilliseconds < 1000)
                    {
                        currentInstantaneousBytes.Add(item);
                    }
                }
            }
            var unit = new BytesUnit();
            unit.DateTime = now;
            unit.Bytes = bytes;
            currentInstantaneousBytes.Add(unit);
            return currentInstantaneousBytes;
        }

        public virtual void TransferEnd()
        {
            if (Handler == null)
            {
                return;
            }
            var now = DateTime.Now;
            var status = new TransferStatus(NewlyTransferredBytes,
                TransferredBytes, TotalBytes, (now - LastCheckpoint).TotalSeconds, (now - StartCheckpoint).TotalSeconds);
            status.SetInstantaneousBytes(CreateCurrentInstantaneousBytes(NewlyTransferredBytes, now));
            Handler(Sender, status);
        }

        public void BytesTransferred(int bytes)
        {
            if (Handler == null)
            {
                return;
            }

            if (bytes > 0)
            {
                DoBytesTransferred(bytes);
            }
        }

        protected abstract void DoBytesTransferred(int bytes);
    }

    internal class TransferStreamByBytes : TransferStreamManager
    {
        public TransferStreamByBytes(object sender, EventHandler<TransferStatus> handler, long totalBytes,
            long transferredBytes, double intervalByBytes) : base(sender, handler, totalBytes, transferredBytes)
        {
            Interval = intervalByBytes;
        }

        protected override void DoBytesTransferred(int bytes)
        {
            TransferredBytes += bytes;
            NewlyTransferredBytes += bytes;
            var now = DateTime.Now;
            var currentInstantaneousBytes = CreateCurrentInstantaneousBytes(bytes, now);
            LastInstantaneousBytes = currentInstantaneousBytes;
            if (NewlyTransferredBytes >= Interval || TransferredBytes == TotalBytes)
            {
                var status = new TransferStatus(NewlyTransferredBytes,
                    TransferredBytes, TotalBytes, (now - LastCheckpoint).TotalSeconds, (now - StartCheckpoint).TotalSeconds);
                status.SetInstantaneousBytes(currentInstantaneousBytes);
                Handler(Sender, status);
                // Reset
                NewlyTransferredBytes = 0;
                LastCheckpoint = now;
            }
        }
    }
}
