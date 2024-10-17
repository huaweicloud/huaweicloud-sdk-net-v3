using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteCaptureTaskDto 
    {

        /// <summary>
        /// 抓包任务id列表
        /// </summary>
        [JsonProperty("task_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteCaptureTaskDto {\n");
            sb.Append("  taskIds: ").Append(TaskIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteCaptureTaskDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteCaptureTaskDto input)
        {
            if (input == null) return false;
            if (this.TaskIds != input.TaskIds || (this.TaskIds != null && input.TaskIds != null && !this.TaskIds.SequenceEqual(input.TaskIds))) return false;

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
                if (this.TaskIds != null) hashCode = hashCode * 59 + this.TaskIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
