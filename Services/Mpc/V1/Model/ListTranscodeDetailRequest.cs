using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTranscodeDetailRequest 
    {

        /// <summary>
        /// 转码服务接受任务后产生的任务ID。一次最多10个 
        /// </summary>
        [SDKProperty("task_id", IsQuery = true)]
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TaskId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTranscodeDetailRequest {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTranscodeDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTranscodeDetailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    this.TaskId != null &&
                    input.TaskId != null &&
                    this.TaskId.SequenceEqual(input.TaskId)
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
