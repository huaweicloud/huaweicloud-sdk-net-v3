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
    public class ShowMonitorItemDetailResponse : SdkResponse
    {

        /// <summary>
        /// 采集间隔
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public long? Interval { get; set; }

        /// <summary>
        /// 采集器ID
        /// </summary>
        [JsonProperty("collector_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? CollectorId { get; set; }

        /// <summary>
        /// 采集参数配置列表
        /// </summary>
        [JsonProperty("config_item_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigItemValue> ConfigItemList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMonitorItemDetailResponse {\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  collectorId: ").Append(CollectorId).Append("\n");
            sb.Append("  configItemList: ").Append(ConfigItemList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMonitorItemDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMonitorItemDetailResponse input)
        {
            if (input == null) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.CollectorId != input.CollectorId || (this.CollectorId != null && !this.CollectorId.Equals(input.CollectorId))) return false;
            if (this.ConfigItemList != input.ConfigItemList || (this.ConfigItemList != null && input.ConfigItemList != null && !this.ConfigItemList.SequenceEqual(input.ConfigItemList))) return false;

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
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.CollectorId != null) hashCode = hashCode * 59 + this.CollectorId.GetHashCode();
                if (this.ConfigItemList != null) hashCode = hashCode * 59 + this.ConfigItemList.GetHashCode();
                return hashCode;
            }
        }
    }
}
