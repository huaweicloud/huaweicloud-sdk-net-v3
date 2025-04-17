using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// 配额信息
    /// </summary>
    public class QuotaResponseDdosQuota 
    {

        /// <summary>
        /// 当前用户已使用配额
        /// </summary>
        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public int? Current { get; set; }

        /// <summary>
        /// 最大配额
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaResponseDdosQuota {\n");
            sb.Append("  current: ").Append(Current).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuotaResponseDdosQuota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuotaResponseDdosQuota input)
        {
            if (input == null) return false;
            if (this.Current != input.Current || (this.Current != null && !this.Current.Equals(input.Current))) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;

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
                if (this.Current != null) hashCode = hashCode * 59 + this.Current.GetHashCode();
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                return hashCode;
            }
        }
    }
}
