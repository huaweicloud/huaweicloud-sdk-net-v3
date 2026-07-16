using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// workflow condition execution
    /// </summary>
    public class WorkflowConditionExecution 
    {

        /// <summary>
        /// 执行结果。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 工作流度量信息列表。
        /// </summary>
        [JsonProperty("metric_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<WorkflowMetricPair> MetricList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowConditionExecution {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  metricList: ").Append(MetricList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowConditionExecution);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowConditionExecution input)
        {
            if (input == null) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.MetricList != input.MetricList || (this.MetricList != null && input.MetricList != null && !this.MetricList.SequenceEqual(input.MetricList))) return false;

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
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.MetricList != null) hashCode = hashCode * 59 + this.MetricList.GetHashCode();
                return hashCode;
            }
        }
    }
}
