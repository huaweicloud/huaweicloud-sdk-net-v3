//------------------------------------------------------------------------------
// based on https://github.com/Microsoft/referencesource/blob/master/System.Web/Util/HttpEncoder.cs
//   and https://github.com/Microsoft/referencesource/blob/master/System.Web/Util/HttpEncoderUtility.cs
//
// <copyright file="HttpEncoder.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <copyright file="HttpEncoderUtility.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

/*
 * Copyright (c) 2009 Microsoft Corporation
 */

using System;
using System.Text;

namespace HuaweiCloud.SDK.Core
{
    public partial class Signer
    {
        private static char IntToHex(int n)
        {
            if (n <= 9)
                return (char)(n + '0');

            return (char)(n - 10 + 'A');
        }

        private static bool IsUrlSafeChar(char ch)
        {
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9'))
                return true;

            switch (ch)
            {
                case '-':
                case '_':
                case '.':
                case '~':
                    return true;
            }

            return false;
        }

        private static byte[] UrlEncode(byte[] bytes, int offset, int count)
        {
            var cUnsafe = 0;

            // count them first
            for (var i = 0; i < count; i++)
            {
                var ch = (char)bytes[offset + i];

                if (!IsUrlSafeChar(ch))
                    cUnsafe++;
            }

            // nothing to expand?
            if (cUnsafe == 0)
            {
                // DevDiv 912606: respect "offset" and "count"
                if (0 == offset && bytes.Length == count)
                {
                    return bytes;
                }
                var subarray = new byte[count];
                Buffer.BlockCopy(bytes, offset, subarray, 0, count);
                return subarray;
            }

            // expand not 'safe' characters into %XX, spaces to +s
            var expandedBytes = new byte[count + cUnsafe * 2];
            var pos = 0;

            for (var i = 0; i < count; i++)
            {
                var b = bytes[offset + i];
                var ch = (char)b;

                if (IsUrlSafeChar(ch))
                {
                    expandedBytes[pos++] = b;
                }
                else
                {
                    expandedBytes[pos++] = (byte)'%';
                    expandedBytes[pos++] = (byte)IntToHex((b >> 4) & 0xf);
                    expandedBytes[pos++] = (byte)IntToHex(b & 0x0f);
                }
            }

            return expandedBytes;
        }

        protected static string UrlEncode(string value)
        {
            if (value == null)
                return null;

            var bytes = Encoding.UTF8.GetBytes(value);
            return Encoding.UTF8.GetString(UrlEncode(bytes, 0, bytes.Length));
        }
    }
}
