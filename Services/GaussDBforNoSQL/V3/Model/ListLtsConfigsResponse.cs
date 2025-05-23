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
    public class ListLtsConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 实例总记录数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 实例-LTS日志配置信息列表。
        /// </summary>
        [JsonProperty("instance_lts_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceLogConfig> InstanceLtsConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLtsConfigsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  instanceLtsConfigs: ").Append(InstanceLtsConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLtsConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLtsConfigsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.InstanceLtsConfigs != input.InstanceLtsConfigs || (this.InstanceLtsConfigs != null && input.InstanceLtsConfigs != null && !this.InstanceLtsConfigs.SequenceEqual(input.InstanceLtsConfigs))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.InstanceLtsConfigs != null) hashCode = hashCode * 59 + this.InstanceLtsConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
