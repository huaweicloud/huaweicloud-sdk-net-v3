using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 创建自定义告警模板的告警策略。
    /// </summary>
    public class AlarmTemplateCondition 
    {

        /// <summary>
        /// 告警阈值的比较条件，可以是&gt;、&#x3D;、&lt;、&gt;&#x3D;、&lt;&#x3D;。
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// 触发告警的连续发生次数，取值范围[1, 5]。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 数据聚合的方式，支持max、min、average、sum、variance，分别表示最大值、最小值、平均值、求和值、方差值。
        /// </summary>
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public string Filter { get; set; }

        /// <summary>
        /// 告警条件判断周期，单位为秒，支持的值为1，300，1200，3600，14400，86400。说明：当period设置为1时，表示以原始的指标数据判断告警。当alarm_type为（EVENT.SYS| EVENT.CUSTOM）时允许为0。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 数据的单位，最大长度为32位。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 告警阈值，取值范围[0, Number.MAX_VALUE]，Number.MAX_VALUE值为1.7976931348623157e+108。具体阈值取值请参见附录中各服务监控指标中取值范围，如支持监控的服务列表中ECS的CPU使用率cpu_util取值范围可配置80。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        /// <summary>
        /// 发送告警的周期，值可为0, 300, 600, 900, 1800, 3600, 10800, 21600, 43200, 86400；0表示只告警一次，300表示每5分钟告警一次，600表示每10分钟告警一次，900表示每15分钟告警一次，1800表示每30分钟告警一次，3600表示每1小时告警一次，10800表示每3小时告警一次，21600表示每6小时告警一次，43200表示每12小时告警一次，86400表示每1天告警一次。
        /// </summary>
        [JsonProperty("suppress_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuppressDuration { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmTemplateCondition {\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  suppressDuration: ").Append(SuppressDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmTemplateCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmTemplateCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComparisonOperator == input.ComparisonOperator ||
                    (this.ComparisonOperator != null &&
                    this.ComparisonOperator.Equals(input.ComparisonOperator))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.SuppressDuration == input.SuppressDuration ||
                    (this.SuppressDuration != null &&
                    this.SuppressDuration.Equals(input.SuppressDuration))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ComparisonOperator != null)
                    hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.SuppressDuration != null)
                    hashCode = hashCode * 59 + this.SuppressDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
