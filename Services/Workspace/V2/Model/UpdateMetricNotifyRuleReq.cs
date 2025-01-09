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
    /// 设置通知规则
    /// </summary>
    public class UpdateMetricNotifyRuleReq 
    {

        /// <summary>
        /// 统计指标名称，目前仅支持固定值：desktop_idle_duration 同一指标的规则不允许重复 * &#x60;desktop_idle_duration&#x60; -  桌面空闲时长
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 规则配置-阈值(天)
        /// </summary>
        [JsonProperty("threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threshold { get; set; }

        /// <summary>
        /// 统计指标对应的统计值和threshold进行比较的条件 * &#x60;&gt;&#x3D;&#x60; -  统计指标大于等于threshold时触发 * &#x60;&gt;&#x60; -   统计指标大于threshold时触发 * &#x60;&#x3D;&#x60; -  统计指标等于threshold时触发 * &#x60;&lt;&#x3D;&#x60; -  统计指标小于等于threshold时触发 * &#x60;&lt;&#x60; -  统计指标小于threshold时触发
        /// </summary>
        [JsonProperty("comparison_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// 触发通知后；下次通知的间隔时间;默认每天一次
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 启禁用规则 true:启用 false:禁用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 通知对象;smn的主题urn
        /// </summary>
        [JsonProperty("notify_object", NullValueHandling = NullValueHandling.Ignore)]
        public string NotifyObject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMetricNotifyRuleReq {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  threshold: ").Append(Threshold).Append("\n");
            sb.Append("  comparisonOperator: ").Append(ComparisonOperator).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  notifyObject: ").Append(NotifyObject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMetricNotifyRuleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMetricNotifyRuleReq input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.Threshold != input.Threshold || (this.Threshold != null && !this.Threshold.Equals(input.Threshold))) return false;
            if (this.ComparisonOperator != input.ComparisonOperator || (this.ComparisonOperator != null && !this.ComparisonOperator.Equals(input.ComparisonOperator))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.NotifyObject != input.NotifyObject || (this.NotifyObject != null && !this.NotifyObject.Equals(input.NotifyObject))) return false;

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
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Threshold != null) hashCode = hashCode * 59 + this.Threshold.GetHashCode();
                if (this.ComparisonOperator != null) hashCode = hashCode * 59 + this.ComparisonOperator.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.NotifyObject != null) hashCode = hashCode * 59 + this.NotifyObject.GetHashCode();
                return hashCode;
            }
        }
    }
}
