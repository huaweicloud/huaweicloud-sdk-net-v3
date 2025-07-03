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
    /// 详情视图配置。
    /// </summary>
    public class DetailViewConfigModel 
    {

        /// <summary>
        /// 视图对应的指标集的名称。
        /// </summary>
        [JsonProperty("metric_set", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricSet { get; set; }

        /// <summary>
        /// 过滤参数。
        /// </summary>
        [JsonProperty("filter_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string FilterPrefix { get; set; }

        /// <summary>
        /// 视图函数集合。
        /// </summary>
        [JsonProperty("detail_view_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DetailViewItem> DetailViewItemList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailViewConfigModel {\n");
            sb.Append("  metricSet: ").Append(MetricSet).Append("\n");
            sb.Append("  filterPrefix: ").Append(FilterPrefix).Append("\n");
            sb.Append("  detailViewItemList: ").Append(DetailViewItemList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetailViewConfigModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetailViewConfigModel input)
        {
            if (input == null) return false;
            if (this.MetricSet != input.MetricSet || (this.MetricSet != null && !this.MetricSet.Equals(input.MetricSet))) return false;
            if (this.FilterPrefix != input.FilterPrefix || (this.FilterPrefix != null && !this.FilterPrefix.Equals(input.FilterPrefix))) return false;
            if (this.DetailViewItemList != input.DetailViewItemList || (this.DetailViewItemList != null && input.DetailViewItemList != null && !this.DetailViewItemList.SequenceEqual(input.DetailViewItemList))) return false;

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
                if (this.MetricSet != null) hashCode = hashCode * 59 + this.MetricSet.GetHashCode();
                if (this.FilterPrefix != null) hashCode = hashCode * 59 + this.FilterPrefix.GetHashCode();
                if (this.DetailViewItemList != null) hashCode = hashCode * 59 + this.DetailViewItemList.GetHashCode();
                return hashCode;
            }
        }
    }
}
