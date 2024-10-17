using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowWorkFlowMetricRequest 
    {

        /// <summary>
        /// 函数工作流URN, 格式为： urn:fss:&lt;region_id&gt;:&lt;project_id&gt;:workflow:\\&lt;package\\&gt;:&lt;workflow_name&gt;:\\&lt;version\\&gt; 注意： package当前只支持default version当前只支持latest
        /// </summary>
        [SDKProperty("workflow_urn", IsPath = true)]
        [JsonProperty("workflow_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowUrn { get; set; }

        /// <summary>
        /// 时间段，单位为分钟
        /// </summary>
        [SDKProperty("period", IsQuery = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 开始时间，精确到ms的时间戳
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间，精确到ms的时间戳
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWorkFlowMetricRequest {\n");
            sb.Append("  workflowUrn: ").Append(WorkflowUrn).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWorkFlowMetricRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWorkFlowMetricRequest input)
        {
            if (input == null) return false;
            if (this.WorkflowUrn != input.WorkflowUrn || (this.WorkflowUrn != null && !this.WorkflowUrn.Equals(input.WorkflowUrn))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                if (this.WorkflowUrn != null) hashCode = hashCode * 59 + this.WorkflowUrn.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
