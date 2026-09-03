using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AlertExpression 
    {

        /// <summary>
        /// 表达式操作符
        /// </summary>
        [JsonProperty("expression_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpressionOperator { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标操作符
        /// </summary>
        [JsonProperty("metric_operator", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricOperator { get; set; }

        /// <summary>
        /// 指标阈值
        /// </summary>
        [JsonProperty("metric_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? MetricThreshold { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertExpression {\n");
            sb.Append("  expressionOperator: ").Append(ExpressionOperator).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  metricOperator: ").Append(MetricOperator).Append("\n");
            sb.Append("  metricThreshold: ").Append(MetricThreshold).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlertExpression);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlertExpression input)
        {
            if (input == null) return false;
            if (this.ExpressionOperator != input.ExpressionOperator || (this.ExpressionOperator != null && !this.ExpressionOperator.Equals(input.ExpressionOperator))) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.MetricOperator != input.MetricOperator || (this.MetricOperator != null && !this.MetricOperator.Equals(input.MetricOperator))) return false;
            if (this.MetricThreshold != input.MetricThreshold || (this.MetricThreshold != null && !this.MetricThreshold.Equals(input.MetricThreshold))) return false;

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
                if (this.ExpressionOperator != null) hashCode = hashCode * 59 + this.ExpressionOperator.GetHashCode();
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.MetricOperator != null) hashCode = hashCode * 59 + this.MetricOperator.GetHashCode();
                if (this.MetricThreshold != null) hashCode = hashCode * 59 + this.MetricThreshold.GetHashCode();
                return hashCode;
            }
        }
    }
}
