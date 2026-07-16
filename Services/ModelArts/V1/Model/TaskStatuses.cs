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
    /// 训练在子任务状态信息。
    /// </summary>
    public class TaskStatuses 
    {

        /// <summary>
        /// 训练作业子任务名称。
        /// </summary>
        [JsonProperty("task", NullValueHandling = NullValueHandling.Ignore)]
        public string Task { get; set; }

        /// <summary>
        /// 训练作业子任务退出码。
        /// </summary>
        [JsonProperty("exit_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExitCode { get; set; }

        /// <summary>
        /// 训练作业子任务错误消息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskStatuses {\n");
            sb.Append("  task: ").Append(Task).Append("\n");
            sb.Append("  exitCode: ").Append(ExitCode).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskStatuses);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskStatuses input)
        {
            if (input == null) return false;
            if (this.Task != input.Task || (this.Task != null && !this.Task.Equals(input.Task))) return false;
            if (this.ExitCode != input.ExitCode || (this.ExitCode != null && !this.ExitCode.Equals(input.ExitCode))) return false;
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
                if (this.Task != null) hashCode = hashCode * 59 + this.Task.GetHashCode();
                if (this.ExitCode != null) hashCode = hashCode * 59 + this.ExitCode.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
