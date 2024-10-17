using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPasswordlessConfigResponse : SdkResponse
    {

        /// <summary>
        /// 免密配置,IP与网段的列表,仅支持ipv4的IP或网段。
        /// </summary>
        [JsonProperty("config_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConfigIps { get; set; }

        /// <summary>
        /// 免密配置的总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPasswordlessConfigResponse {\n");
            sb.Append("  configIps: ").Append(ConfigIps).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPasswordlessConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPasswordlessConfigResponse input)
        {
            if (input == null) return false;
            if (this.ConfigIps != input.ConfigIps || (this.ConfigIps != null && input.ConfigIps != null && !this.ConfigIps.SequenceEqual(input.ConfigIps))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.ConfigIps != null) hashCode = hashCode * 59 + this.ConfigIps.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
