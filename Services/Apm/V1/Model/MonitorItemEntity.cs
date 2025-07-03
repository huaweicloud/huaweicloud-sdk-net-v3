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
    /// 
    /// </summary>
    public class MonitorItemEntity 
    {

        /// <summary>
        /// 采集器类别id。
        /// </summary>
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// 采集器名称。
        /// </summary>
        [JsonProperty("collector_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CollectorName { get; set; }

        /// <summary>
        /// 采集器类别展示名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 是否展示标题。
        /// </summary>
        [JsonProperty("show_in_total", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowInTotal { get; set; }

        /// <summary>
        /// 监控项id。
        /// </summary>
        [JsonProperty("monitor_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MonitorItemId { get; set; }

        /// <summary>
        /// 是否禁用。
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 采集器id。
        /// </summary>
        [JsonProperty("collector_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CollectorId { get; set; }

        /// <summary>
        /// 序列号。
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// 默认数据采集间隔。
        /// </summary>
        [JsonProperty("collect_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? CollectInterval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonitorItemEntity {\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  collectorName: ").Append(CollectorName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  showInTotal: ").Append(ShowInTotal).Append("\n");
            sb.Append("  monitorItemId: ").Append(MonitorItemId).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  collectorId: ").Append(CollectorId).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  collectInterval: ").Append(CollectInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MonitorItemEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MonitorItemEntity input)
        {
            if (input == null) return false;
            if (this.CategoryId != input.CategoryId || (this.CategoryId != null && !this.CategoryId.Equals(input.CategoryId))) return false;
            if (this.CollectorName != input.CollectorName || (this.CollectorName != null && !this.CollectorName.Equals(input.CollectorName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.ShowInTotal != input.ShowInTotal || (this.ShowInTotal != null && !this.ShowInTotal.Equals(input.ShowInTotal))) return false;
            if (this.MonitorItemId != input.MonitorItemId || (this.MonitorItemId != null && !this.MonitorItemId.Equals(input.MonitorItemId))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.CollectorId != input.CollectorId || (this.CollectorId != null && !this.CollectorId.Equals(input.CollectorId))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.CollectInterval != input.CollectInterval || (this.CollectInterval != null && !this.CollectInterval.Equals(input.CollectInterval))) return false;

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
                if (this.CategoryId != null) hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CollectorName != null) hashCode = hashCode * 59 + this.CollectorName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.ShowInTotal != null) hashCode = hashCode * 59 + this.ShowInTotal.GetHashCode();
                if (this.MonitorItemId != null) hashCode = hashCode * 59 + this.MonitorItemId.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.CollectorId != null) hashCode = hashCode * 59 + this.CollectorId.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.CollectInterval != null) hashCode = hashCode * 59 + this.CollectInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
