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

namespace HuaweiCloud.SDK.Core
{
    public class TransferStatus : EventArgs
    {
        private IList<BytesUnit> _instantaneousBytes;
        private readonly double _intervalSeconds;
        private readonly double _totalSeconds;

        internal TransferStatus(long newlyTransferredBytes, long transferredBytes, long totalBytes,
            double intervalSeconds, double totalSeconds)
        {
            NewlyTransferredBytes = newlyTransferredBytes;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
            _intervalSeconds = intervalSeconds;
            _totalSeconds = totalSeconds;
        }

        /// <summary>
        ///     Instantaneous rate
        /// </summary>
        public double InstantaneousSpeed
        {
            get
            {
                if (_instantaneousBytes != null)
                {
                    long instantaneousSpeed = 0;
                    foreach (var item in _instantaneousBytes)
                    {
                        instantaneousSpeed += item.Bytes;
                    }
                    return instantaneousSpeed;
                }
                return NewlyTransferredBytes / _intervalSeconds;
            }
        }

        /// <summary>
        ///     Average rate
        /// </summary>
        public double AverageSpeed => TransferredBytes / _totalSeconds;

        /// <summary>
        ///     Transmission progress
        /// </summary>
        public int TransferPercentage
        {
            get
            {
                if (TotalBytes < 0)
                {
                    return -1;
                }
                if (TotalBytes == 0)
                {
                    return 100;
                }
                return (int)(TransferredBytes * 100 / TotalBytes);
            }
        }

        /// <summary>
        ///     Number of bytes transmitted since last progress refresh
        /// </summary>
        public long NewlyTransferredBytes { get; }

        /// <summary>
        ///     Number of bytes that have been transmitted
        /// </summary>
        public long TransferredBytes { get; }

        /// <summary>
        ///     Number of bytes being transmitted
        /// </summary>
        public long TotalBytes { get; }

        internal void SetInstantaneousBytes(IList<BytesUnit> instantaneousBytes)
        {
            _instantaneousBytes = instantaneousBytes;
        }
    }
}
