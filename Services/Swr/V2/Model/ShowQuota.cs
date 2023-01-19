using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowQuota 
    {

        /// <summary>
        /// 配额限制
        /// </summary>
        [JsonProperty("quota_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaLimit { get; set; }

        /// <summary>
        /// 配额类型
        /// </summary>
        [JsonProperty("quota_key", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaKey { get; set; }

        /// <summary>
        /// 单位 
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 已用配额
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQuota {\n");
            sb.Append("  quotaLimit: ").Append(QuotaLimit).Append("\n");
            sb.Append("  quotaKey: ").Append(QuotaKey).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuota);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuota input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuotaLimit == input.QuotaLimit ||
                    (this.QuotaLimit != null &&
                    this.QuotaLimit.Equals(input.QuotaLimit))
                ) && 
                (
                    this.QuotaKey == input.QuotaKey ||
                    (this.QuotaKey != null &&
                    this.QuotaKey.Equals(input.QuotaKey))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.QuotaLimit != null)
                    hashCode = hashCode * 59 + this.QuotaLimit.GetHashCode();
                if (this.QuotaKey != null)
                    hashCode = hashCode * 59 + this.QuotaKey.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                return hashCode;
            }
        }
    }
}
