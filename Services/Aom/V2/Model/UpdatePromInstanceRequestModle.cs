using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdatePromInstanceRequestModle 
    {

        /// <summary>
        /// 待修改的普罗实例id。
        /// </summary>
        [JsonProperty("prom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prom_limits", NullValueHandling = NullValueHandling.Ignore)]
        public PromLimits PromLimits { get; set; }

        /// <summary>
        /// 待修改的普罗实例名称，名称不能以下划线或中划线开头和结尾，只含有中文，英文，数字，下划线，中划线，长度1-100。
        /// </summary>
        [JsonProperty("prom_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PromName { get; set; }

        /// <summary>
        /// 被聚合的账号和普罗实例列表。
        /// </summary>
        [JsonProperty("aggr_prometheus_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<AggrPrometheusInfo> AggrPrometheusInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePromInstanceRequestModle {\n");
            sb.Append("  promId: ").Append(PromId).Append("\n");
            sb.Append("  promLimits: ").Append(PromLimits).Append("\n");
            sb.Append("  promName: ").Append(PromName).Append("\n");
            sb.Append("  aggrPrometheusInfo: ").Append(AggrPrometheusInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePromInstanceRequestModle);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePromInstanceRequestModle input)
        {
            if (input == null) return false;
            if (this.PromId != input.PromId || (this.PromId != null && !this.PromId.Equals(input.PromId))) return false;
            if (this.PromLimits != input.PromLimits || (this.PromLimits != null && !this.PromLimits.Equals(input.PromLimits))) return false;
            if (this.PromName != input.PromName || (this.PromName != null && !this.PromName.Equals(input.PromName))) return false;
            if (this.AggrPrometheusInfo != input.AggrPrometheusInfo || (this.AggrPrometheusInfo != null && input.AggrPrometheusInfo != null && !this.AggrPrometheusInfo.SequenceEqual(input.AggrPrometheusInfo))) return false;

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
                if (this.PromId != null) hashCode = hashCode * 59 + this.PromId.GetHashCode();
                if (this.PromLimits != null) hashCode = hashCode * 59 + this.PromLimits.GetHashCode();
                if (this.PromName != null) hashCode = hashCode * 59 + this.PromName.GetHashCode();
                if (this.AggrPrometheusInfo != null) hashCode = hashCode * 59 + this.AggrPrometheusInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
