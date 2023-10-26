using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.AntiDDoS.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowNewTaskStatusResponse : SdkResponse
    {

        /// <summary>
        /// 任务状态，有以下几种： - success - failed - waiting - running - preprocess - ready
        /// </summary>
        [JsonProperty("task_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务的附加信息
        /// </summary>
        [JsonProperty("task_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNewTaskStatusResponse {\n");
            sb.Append("  taskStatus: ").Append(TaskStatus).Append("\n");
            sb.Append("  taskMsg: ").Append(TaskMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNewTaskStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNewTaskStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskStatus == input.TaskStatus ||
                    (this.TaskStatus != null &&
                    this.TaskStatus.Equals(input.TaskStatus))
                ) && 
                (
                    this.TaskMsg == input.TaskMsg ||
                    (this.TaskMsg != null &&
                    this.TaskMsg.Equals(input.TaskMsg))
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
                if (this.TaskStatus != null)
                    hashCode = hashCode * 59 + this.TaskStatus.GetHashCode();
                if (this.TaskMsg != null)
                    hashCode = hashCode * 59 + this.TaskMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
