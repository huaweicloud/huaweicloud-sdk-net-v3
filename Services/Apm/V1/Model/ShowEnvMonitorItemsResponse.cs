using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowEnvMonitorItemsResponse : SdkResponse
    {

        /// <summary>
        /// 采集器类别集合。
        /// </summary>
        [JsonProperty("category_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CollectorCategoryInfo> CategoryInfoList { get; set; }

        /// <summary>
        /// 监控项集合。
        /// </summary>
        [JsonProperty("monitor_item_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MonitorItemEntity> MonitorItemInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEnvMonitorItemsResponse {\n");
            sb.Append("  categoryInfoList: ").Append(CategoryInfoList).Append("\n");
            sb.Append("  monitorItemInfoList: ").Append(MonitorItemInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEnvMonitorItemsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEnvMonitorItemsResponse input)
        {
            if (input == null) return false;
            if (this.CategoryInfoList != input.CategoryInfoList || (this.CategoryInfoList != null && input.CategoryInfoList != null && !this.CategoryInfoList.SequenceEqual(input.CategoryInfoList))) return false;
            if (this.MonitorItemInfoList != input.MonitorItemInfoList || (this.MonitorItemInfoList != null && input.MonitorItemInfoList != null && !this.MonitorItemInfoList.SequenceEqual(input.MonitorItemInfoList))) return false;

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
                if (this.CategoryInfoList != null) hashCode = hashCode * 59 + this.CategoryInfoList.GetHashCode();
                if (this.MonitorItemInfoList != null) hashCode = hashCode * 59 + this.MonitorItemInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
