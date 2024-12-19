using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowEvaluationStateByAssignmentIdResponse : SdkResponse
    {

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentId { get; set; }

        /// <summary>
        /// 评估任务执行状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 评估任务开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 评估任务结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 评估任务失败信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowEvaluationStateByAssignmentIdResponse {\n");
            sb.Append("  policyAssignmentId: ").Append(PolicyAssignmentId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowEvaluationStateByAssignmentIdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowEvaluationStateByAssignmentIdResponse input)
        {
            if (input == null) return false;
            if (this.PolicyAssignmentId != input.PolicyAssignmentId || (this.PolicyAssignmentId != null && !this.PolicyAssignmentId.Equals(input.PolicyAssignmentId))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;

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
                if (this.PolicyAssignmentId != null) hashCode = hashCode * 59 + this.PolicyAssignmentId.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
