using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 锁定会议请求。
    /// </summary>
    public class RestLockReqBody 
    {

        /// <summary>
        /// - 0: 解锁 - 1: 锁定
        /// </summary>
        [JsonProperty("isLock", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsLock { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestLockReqBody {\n");
            sb.Append("  isLock: ").Append(IsLock).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestLockReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestLockReqBody input)
        {
            if (input == null) return false;
            if (this.IsLock != input.IsLock || (this.IsLock != null && !this.IsLock.Equals(input.IsLock))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.IsLock != null) hashCode = hashCode * 59 + this.IsLock.GetHashCode();
                return hashCode;
            }
        }
    }
}
