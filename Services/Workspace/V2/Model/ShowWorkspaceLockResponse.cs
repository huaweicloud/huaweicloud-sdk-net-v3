using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowWorkspaceLockResponse : SdkResponse
    {

        /// <summary>
        /// 云办公服务是否被锁定，0代表未锁定，1代表锁定。
        /// </summary>
        [JsonProperty("is_lock", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsLock { get; set; }

        /// <summary>
        /// 云办公服务锁定时间，格式：yyyy-MM-dd HH:mm:ss，时区：UTC。
        /// </summary>
        [JsonProperty("lock_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LockTime { get; set; }

        /// <summary>
        /// 云办公服务锁定原因。
        /// </summary>
        [JsonProperty("lock_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string LockReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWorkspaceLockResponse {\n");
            sb.Append("  isLock: ").Append(IsLock).Append("\n");
            sb.Append("  lockTime: ").Append(LockTime).Append("\n");
            sb.Append("  lockReason: ").Append(LockReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWorkspaceLockResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWorkspaceLockResponse input)
        {
            if (input == null) return false;
            if (this.IsLock != input.IsLock || (this.IsLock != null && !this.IsLock.Equals(input.IsLock))) return false;
            if (this.LockTime != input.LockTime || (this.LockTime != null && !this.LockTime.Equals(input.LockTime))) return false;
            if (this.LockReason != input.LockReason || (this.LockReason != null && !this.LockReason.Equals(input.LockReason))) return false;

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
                if (this.LockTime != null) hashCode = hashCode * 59 + this.LockTime.GetHashCode();
                if (this.LockReason != null) hashCode = hashCode * 59 + this.LockReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
