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
    public class ShowMonitorItemViewConfigResponse : SdkResponse
    {

        /// <summary>
        /// 标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 采集器名称。
        /// </summary>
        [JsonProperty("collector_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectorName { get; set; }

        /// <summary>
        /// 视图的列表，内部每个List代表的是一行图表。
        /// </summary>
        [JsonProperty("view_row_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ViewRow> ViewRowList { get; set; }

        /// <summary>
        /// 类型。
        /// </summary>
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public string Style { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMonitorItemViewConfigResponse {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  collectorName: ").Append(CollectorName).Append("\n");
            sb.Append("  viewRowList: ").Append(ViewRowList).Append("\n");
            sb.Append("  style: ").Append(Style).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMonitorItemViewConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMonitorItemViewConfigResponse input)
        {
            if (input == null) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.CollectorName != input.CollectorName || (this.CollectorName != null && !this.CollectorName.Equals(input.CollectorName))) return false;
            if (this.ViewRowList != input.ViewRowList || (this.ViewRowList != null && input.ViewRowList != null && !this.ViewRowList.SequenceEqual(input.ViewRowList))) return false;
            if (this.Style != input.Style || (this.Style != null && !this.Style.Equals(input.Style))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.CollectorName != null) hashCode = hashCode * 59 + this.CollectorName.GetHashCode();
                if (this.ViewRowList != null) hashCode = hashCode * 59 + this.ViewRowList.GetHashCode();
                if (this.Style != null) hashCode = hashCode * 59 + this.Style.GetHashCode();
                return hashCode;
            }
        }
    }
}
