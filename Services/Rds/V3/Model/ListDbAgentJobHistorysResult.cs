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
    public class ListDbAgentJobHistorysResult 
    {

        /// <summary>
        /// 作业历史记录id。
        /// </summary>
        [JsonProperty("history_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HistoryId { get; set; }

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
            sb.Append("class ListDbAgentJobHistorysResult {\n");
            sb.Append("  historyId: ").Append(HistoryId).Append("\n");
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
            return this.Equals(input as ListDbAgentJobHistorysResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDbAgentJobHistorysResult input)
        {
            if (input == null) return false;
            if (this.HistoryId != input.HistoryId || (this.HistoryId != null && !this.HistoryId.Equals(input.HistoryId))) return false;
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
                if (this.HistoryId != null) hashCode = hashCode * 59 + this.HistoryId.GetHashCode();
                if (this.RunStatus != null) hashCode = hashCode * 59 + this.RunStatus.GetHashCode();
                if (this.RunTime != null) hashCode = hashCode * 59 + this.RunTime.GetHashCode();
                if (this.RunDuration != null) hashCode = hashCode * 59 + this.RunDuration.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
