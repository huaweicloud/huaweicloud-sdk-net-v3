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
    /// Request Object
    /// </summary>
    public class NotifyTrainingJobInformationRequest 
    {

        /// <summary>
        /// **参数解释**：训练作业ID。获取方法请参见[查询训练作业列表](ListTrainingJobs.xml)。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("training_job_id", IsPath = true)]
        [JsonProperty("training_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingJobId { get; set; }

        /// <summary>
        /// **参数解释**：训练作业的任务名称。可从训练作业详情中的status.tasks字段中获取。 **约束限制**：单节点默认为\&quot;worker-0\&quot;，多节点则为\&quot;worker-0\&quot;、\&quot;worker-1\&quot;，依次类推。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("task_id", IsPath = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// **参数解释**：事件上报类型。 **约束限制**：不涉及。 **取值范围**：取\&quot;training-event\&quot;。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("report_type", IsPath = true)]
        [JsonProperty("report_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ReportEventBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotifyTrainingJobInformationRequest {\n");
            sb.Append("  trainingJobId: ").Append(TrainingJobId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  reportType: ").Append(ReportType).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotifyTrainingJobInformationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotifyTrainingJobInformationRequest input)
        {
            if (input == null) return false;
            if (this.TrainingJobId != input.TrainingJobId || (this.TrainingJobId != null && !this.TrainingJobId.Equals(input.TrainingJobId))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.ReportType != input.ReportType || (this.ReportType != null && !this.ReportType.Equals(input.ReportType))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.TrainingJobId != null) hashCode = hashCode * 59 + this.TrainingJobId.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.ReportType != null) hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
