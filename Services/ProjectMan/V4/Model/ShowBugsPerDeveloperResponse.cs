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
    /// Response Object
    /// </summary>
    public class ShowBugsPerDeveloperResponse : SdkResponse
    {

        /// <summary>
        /// 指标分子数值
        /// </summary>
        [JsonProperty("dividend_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DividendValue { get; set; }

        /// <summary>
        /// 指标分母数值
        /// </summary>
        [JsonProperty("divisor_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DivisorValue { get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 指标数值
        /// </summary>
        [JsonProperty("metric_value", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricValue { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBugsPerDeveloperResponse {\n");
            sb.Append("  dividendValue: ").Append(DividendValue).Append("\n");
            sb.Append("  divisorValue: ").Append(DivisorValue).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  metricValue: ").Append(MetricValue).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBugsPerDeveloperResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBugsPerDeveloperResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DividendValue == input.DividendValue ||
                    (this.DividendValue != null &&
                    this.DividendValue.Equals(input.DividendValue))
                ) && 
                (
                    this.DivisorValue == input.DivisorValue ||
                    (this.DivisorValue != null &&
                    this.DivisorValue.Equals(input.DivisorValue))
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.MetricValue == input.MetricValue ||
                    (this.MetricValue != null &&
                    this.MetricValue.Equals(input.MetricValue))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
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
                if (this.DividendValue != null)
                    hashCode = hashCode * 59 + this.DividendValue.GetHashCode();
                if (this.DivisorValue != null)
                    hashCode = hashCode * 59 + this.DivisorValue.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.MetricValue != null)
                    hashCode = hashCode * 59 + this.MetricValue.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                return hashCode;
            }
        }
    }
}
