using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 告警触发条件。
    /// </summary>
    public class AlarmCondition 
    {

        /// <summary>
        /// 指标周期，单位是秒； 0是默认值，例如事件类告警该字段就用0即可； 1代表指标的原始周期，比如RDS监控指标原始周期是60s，表示该RDS指标按60s周期为一个数据点参与告警计算；
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 聚合方式, 支持的值为(average|min|max|sum)。
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 阈值符号,支持的值为(&gt;|&lt;|&gt;&#x3D;|&lt;&#x3D;|&#x3D;|!&#x3D;|cycle_decrease|cycle_increase|cycle_wave);cycle_decrease为环比下降,cycle_increase为环比上升,cycle_wave为环比波动。
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// 告警阈值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        /// <summary>
        /// 数据的单位，最大长度为32位。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 次数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 告警抑制时间，单位为秒，对应页面上创建告警规则时告警策略最后一个字段，该字段主要为解决告警频繁的问题，0代表不抑制，满足条件即告警；300代表满足告警触发条件后每5分钟告警一次。
        /// </summary>
        [JsonProperty("suppress_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuppressDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmCondition {\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  suppressDuration: ").Append(SuppressDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmCondition input)
        {
            if (input == null) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.Filter != input.Filter || (this.Filter != null && !this.Filter.Equals(input.Filter))) return false;
            if (this.ComparisonOperator != input.ComparisonOperator || (this.ComparisonOperator != null && !this.ComparisonOperator.Equals(input.ComparisonOperator))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.SuppressDuration != input.SuppressDuration || (this.SuppressDuration != null && !this.SuppressDuration.Equals(input.SuppressDuration))) return false;

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
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Filter != null) hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.ComparisonOperator != null) hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.SuppressDuration != null) hashCode = hashCode * 59 + this.SuppressDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
