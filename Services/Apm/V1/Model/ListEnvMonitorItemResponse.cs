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
    public class ListEnvMonitorItemResponse : SdkResponse
    {

        /// <summary>
        /// 监控项列表。
        /// </summary>
        [JsonProperty("monitor_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MonitorItem> MonitorItemList { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 总页数。
        /// </summary>
        [JsonProperty("totalPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnvMonitorItemResponse {\n");
            sb.Append("  monitorItemList: ").Append(MonitorItemList).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  totalPage: ").Append(TotalPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnvMonitorItemResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnvMonitorItemResponse input)
        {
            if (input == null) return false;
            if (this.MonitorItemList != input.MonitorItemList || (this.MonitorItemList != null && input.MonitorItemList != null && !this.MonitorItemList.SequenceEqual(input.MonitorItemList))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.TotalPage != input.TotalPage || (this.TotalPage != null && !this.TotalPage.Equals(input.TotalPage))) return false;

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
                if (this.MonitorItemList != null) hashCode = hashCode * 59 + this.MonitorItemList.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.TotalPage != null) hashCode = hashCode * 59 + this.TotalPage.GetHashCode();
                return hashCode;
            }
        }
    }
}
