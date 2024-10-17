using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLtsConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 实例LTS日志配置列表
        /// </summary>
        [JsonProperty("instance_lts_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<LtsConfigsV3> InstanceLtsConfigs { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLtsConfigsResponse {\n");
            sb.Append("  instanceLtsConfigs: ").Append(InstanceLtsConfigs).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLtsConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLtsConfigsResponse input)
        {
            if (input == null) return false;
            if (this.InstanceLtsConfigs != input.InstanceLtsConfigs || (this.InstanceLtsConfigs != null && input.InstanceLtsConfigs != null && !this.InstanceLtsConfigs.SequenceEqual(input.InstanceLtsConfigs))) return false;
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
                if (this.InstanceLtsConfigs != null) hashCode = hashCode * 59 + this.InstanceLtsConfigs.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
