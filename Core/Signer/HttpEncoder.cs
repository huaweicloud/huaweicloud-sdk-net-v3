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
                return (char)(n + (int)'0');
            else
                return (char)(n - 10 + (int)'A');
        }

        private static bool IsUrlSafeChar(char ch)
        {
            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch >= '0' && ch <= '9')
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
            int cUnsafe = 0;

            // count them first
            for (int i = 0; i < count; i++)
            {
                char ch = (char)bytes[offset + i];

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
                else
                {
                    var subarray = new byte[count];
                    Buffer.BlockCopy(bytes, offset, subarray, 0, count);
                    return subarray;
                }
            }

            // expand not 'safe' characters into %XX, spaces to +s
            byte[] expandedBytes = new byte[count + cUnsafe * 2];
            int pos = 0;

            for (int i = 0; i < count; i++)
            {
                byte b = bytes[offset + i];
                char ch = (char)b;

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

            byte[] bytes = Encoding.UTF8.GetBytes(value);
            return Encoding.UTF8.GetString(UrlEncode(bytes, 0, bytes.Length));
        }
    }
}