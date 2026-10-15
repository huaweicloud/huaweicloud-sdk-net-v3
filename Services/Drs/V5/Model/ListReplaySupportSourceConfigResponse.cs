using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListReplaySupportSourceConfigResponse : SdkResponse
    {

        /// <summary>
        /// 流量回放源数据配置信息
        /// </summary>
        [JsonProperty("config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplaySourceConfigResp> ConfigList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListReplaySupportSourceConfigResponse {\n");
            sb.Append("  configList: ").Append(ConfigList).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListReplaySupportSourceConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListReplaySupportSourceConfigResponse input)
        {
            if (input == null) return false;
            if (this.ConfigList != input.ConfigList || (this.ConfigList != null && input.ConfigList != null && !this.ConfigList.SequenceEqual(input.ConfigList))) return false;
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
                if (this.ConfigList != null) hashCode = hashCode * 59 + this.ConfigList.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
