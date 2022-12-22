using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MetricRequest2 
    {

        /// <summary>
        /// 指标类型
        /// </summary>
        [JsonProperty("metric_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricType { get; set; }

        /// <summary>
        /// 迭代ID
        /// </summary>
        [JsonProperty("sprint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SprintId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dividend", NullValueHandling = NullValueHandling.Ignore)]
        public MetricRequest2Dividend Dividend { get; set; }

        /// <summary>
        /// 指标分母过滤条件
        /// </summary>
        [JsonProperty("divisor", NullValueHandling = NullValueHandling.Ignore)]
        public Object Divisor { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricRequest2 {\n");
            sb.Append("  metricType: ").Append(MetricType).Append("\n");
            sb.Append("  sprintId: ").Append(SprintId).Append("\n");
            sb.Append("  dividend: ").Append(Dividend).Append("\n");
            sb.Append("  divisor: ").Append(Divisor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricRequest2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricRequest2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MetricType == input.MetricType ||
                    (this.MetricType != null &&
                    this.MetricType.Equals(input.MetricType))
                ) && 
                (
                    this.SprintId == input.SprintId ||
                    (this.SprintId != null &&
                    this.SprintId.Equals(input.SprintId))
                ) && 
                (
                    this.Dividend == input.Dividend ||
                    (this.Dividend != null &&
                    this.Dividend.Equals(input.Dividend))
                ) && 
                (
                    this.Divisor == input.Divisor ||
                    (this.Divisor != null &&
                    this.Divisor.Equals(input.Divisor))
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
                if (this.MetricType != null)
                    hashCode = hashCode * 59 + this.MetricType.GetHashCode();
                if (this.SprintId != null)
                    hashCode = hashCode * 59 + this.SprintId.GetHashCode();
                if (this.Dividend != null)
                    hashCode = hashCode * 59 + this.Dividend.GetHashCode();
                if (this.Divisor != null)
                    hashCode = hashCode * 59 + this.Divisor.GetHashCode();
                return hashCode;
            }
        }
    }
}
