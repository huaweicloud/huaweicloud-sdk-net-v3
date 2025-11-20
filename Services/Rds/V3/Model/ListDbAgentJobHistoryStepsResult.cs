using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 数据库代理作业执行历史步骤。
    /// </summary>
    public class ListDbAgentJobHistoryStepsResult 
    {

        /// <summary>
        /// 步骤id。
        /// </summary>
        [JsonProperty("step_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StepId { get; set; }

        /// <summary>
        /// 步骤名。
        /// </summary>
        [JsonProperty("step_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StepName { get; set; }

        /// <summary>
        /// 作业执行状态。取值如下:  failed:失败。 succeeded:成功。 retrying:重试中。 canceled:已取消。 in_progress:正在运行。
        /// </summary>
        [JsonProperty("run_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RunStatus { get; set; }

        /// <summary>
        /// 作业执行开始时间。格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("run_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RunTime { get; set; }

        /// <summary>
        /// 作业执行时长。格式为hh:mm:ss
        /// </summary>
        [JsonProperty("run_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string RunDuration { get; set; }

        /// <summary>
        /// 执行信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDbAgentJobHistoryStepsResult {\n");
            sb.Append("  stepId: ").Append(StepId).Append("\n");
            sb.Append("  stepName: ").Append(StepName).Append("\n");
            sb.Append("  runStatus: ").Append(RunStatus).Append("\n");
            sb.Append("  runTime: ").Append(RunTime).Append("\n");
            sb.Append("  runDuration: ").Append(RunDuration).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDbAgentJobHistoryStepsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDbAgentJobHistoryStepsResult input)
        {
            if (input == null) return false;
            if (this.StepId != input.StepId || (this.StepId != null && !this.StepId.Equals(input.StepId))) return false;
            if (this.StepName != input.StepName || (this.StepName != null && !this.StepName.Equals(input.StepName))) return false;
            if (this.RunStatus != input.RunStatus || (this.RunStatus != null && !this.RunStatus.Equals(input.RunStatus))) return false;
            if (this.RunTime != input.RunTime || (this.RunTime != null && !this.RunTime.Equals(input.RunTime))) return false;
            if (this.RunDuration != input.RunDuration || (this.RunDuration != null && !this.RunDuration.Equals(input.RunDuration))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.StepId != null) hashCode = hashCode * 59 + this.StepId.GetHashCode();
                if (this.StepName != null) hashCode = hashCode * 59 + this.StepName.GetHashCode();
                if (this.RunStatus != null) hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.RunTime != null) hashCode = hashCode * 59 + this.RunTime.GetHashCode();
                if (this.RunDuration != null) hashCode = hashCode * 59 + this.RunDuration.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
