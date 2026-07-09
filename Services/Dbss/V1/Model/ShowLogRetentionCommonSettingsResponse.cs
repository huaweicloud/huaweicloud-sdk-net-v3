using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLogRetentionCommonSettingsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_retention", NullValueHandling = NullValueHandling.Ignore)]
        public CommonSettingsResponseLogRetention LogRetention { get; set; }

        /// <summary>
        /// 日志存储磁盘占用上限
        /// </summary>
        [JsonProperty("data_usage_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? DataUsageLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLogRetentionCommonSettingsResponse {\n");
            sb.Append("  logRetention: ").Append(LogRetention).Append("\n");
            sb.Append("  dataUsageLimit: ").Append(DataUsageLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLogRetentionCommonSettingsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLogRetentionCommonSettingsResponse input)
        {
            if (input == null) return false;
            if (this.LogRetention != input.LogRetention || (this.LogRetention != null && !this.LogRetention.Equals(input.LogRetention))) return false;
            if (this.DataUsageLimit != input.DataUsageLimit || (this.DataUsageLimit != null && !this.DataUsageLimit.Equals(input.DataUsageLimit))) return false;

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
                if (this.LogRetention != null) hashCode = hashCode * 59 + this.LogRetention.GetHashCode();
                if (this.DataUsageLimit != null) hashCode = hashCode * 59 + this.DataUsageLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
