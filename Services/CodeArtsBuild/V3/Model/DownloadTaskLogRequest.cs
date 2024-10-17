using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DownloadTaskLogRequest 
    {

        /// <summary>
        /// 记录ID,36位数字、小写字母、&#39;-&#39;组组合。
        /// </summary>
        [SDKProperty("record_id", IsPath = true)]
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// 步骤名称
        /// </summary>
        [SDKProperty("task_name", IsQuery = true)]
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 日志等级 值为INFO | DEBUG。
        /// </summary>
        [SDKProperty("log_level", IsQuery = true)]
        [JsonProperty("log_level", NullValueHandling = NullValueHandling.Ignore)]
        public string LogLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadTaskLogRequest {\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  logLevel: ").Append(LogLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadTaskLogRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadTaskLogRequest input)
        {
            if (input == null) return false;
            if (this.RecordId != input.RecordId || (this.RecordId != null && !this.RecordId.Equals(input.RecordId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.LogLevel != input.LogLevel || (this.LogLevel != null && !this.LogLevel.Equals(input.LogLevel))) return false;

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
                if (this.RecordId != null) hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.LogLevel != null) hashCode = hashCode * 59 + this.LogLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
