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
    /// 数据库代理作业响应信息。
    /// </summary>
    public class ListDbAgentJobsResult 
    {

        /// <summary>
        /// 作业id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 作业名。
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 是否可用。  true：可用。 false：不可用。
        /// </summary>
        [JsonProperty("is_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 最新执行时间。格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("run_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RunTime { get; set; }

        /// <summary>
        /// 作业执行状态。取值如下:  failed:失败。 succeeded:成功。 retrying:重试中。 canceled:已取消。 in_progress:正在运行。
        /// </summary>
        [JsonProperty("run_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RunStatus { get; set; }

        /// <summary>
        /// 最近失败时间。格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("last_failure_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastFailureTime { get; set; }

        /// <summary>
        /// 历史失败次数。
        /// </summary>
        [JsonProperty("failure_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailureCount { get; set; }

        /// <summary>
        /// 作业代理的类型。  snapshot：快照代理 log_reader：日志读取器代理 distribution：分发代理 merge:合并代理 queue_reader：队列读取器代理。
        /// </summary>
        [JsonProperty("agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentType { get; set; }

        /// <summary>
        /// 配置文件id。作业类型为replication时特有。
        /// </summary>
        [JsonProperty("profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileId { get; set; }

        /// <summary>
        /// 配置文件名。作业类型为replication时特有。
        /// </summary>
        [JsonProperty("profile_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDbAgentJobsResult {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  isEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  runTime: ").Append(RunTime).Append("\n");
            sb.Append("  runStatus: ").Append(RunStatus).Append("\n");
            sb.Append("  lastFailureTime: ").Append(LastFailureTime).Append("\n");
            sb.Append("  failureCount: ").Append(FailureCount).Append("\n");
            sb.Append("  agentType: ").Append(AgentType).Append("\n");
            sb.Append("  profileId: ").Append(ProfileId).Append("\n");
            sb.Append("  profileName: ").Append(ProfileName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDbAgentJobsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDbAgentJobsResult input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.IsEnabled != input.IsEnabled || (this.IsEnabled != null && !this.IsEnabled.Equals(input.IsEnabled))) return false;
            if (this.RunTime != input.RunTime || (this.RunTime != null && !this.RunTime.Equals(input.RunTime))) return false;
            if (this.RunStatus != input.RunStatus || (this.RunStatus != null && !this.RunStatus.Equals(input.RunStatus))) return false;
            if (this.LastFailureTime != input.LastFailureTime || (this.LastFailureTime != null && !this.LastFailureTime.Equals(input.LastFailureTime))) return false;
            if (this.FailureCount != input.FailureCount || (this.FailureCount != null && !this.FailureCount.Equals(input.FailureCount))) return false;
            if (this.AgentType != input.AgentType || (this.AgentType != null && !this.AgentType.Equals(input.AgentType))) return false;
            if (this.ProfileId != input.ProfileId || (this.ProfileId != null && !this.ProfileId.Equals(input.ProfileId))) return false;
            if (this.ProfileName != input.ProfileName || (this.ProfileName != null && !this.ProfileName.Equals(input.ProfileName))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.IsEnabled != null) hashCode = hashCode * 59 + this.IsEnabled.GetHashCode();
                if (this.RunTime != null) hashCode = hashCode * 59 + this.RunTime.GetHashCode();
                if (this.RunStatus != null) hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.LastFailureTime != null) hashCode = hashCode * 59 + this.LastFailureTime.GetHashCode();
                if (this.FailureCount != null) hashCode = hashCode * 59 + this.FailureCount.GetHashCode();
                if (this.AgentType != null) hashCode = hashCode * 59 + this.AgentType.GetHashCode();
                if (this.ProfileId != null) hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.ProfileName != null) hashCode = hashCode * 59 + this.ProfileName.GetHashCode();
                return hashCode;
            }
        }
    }
}
