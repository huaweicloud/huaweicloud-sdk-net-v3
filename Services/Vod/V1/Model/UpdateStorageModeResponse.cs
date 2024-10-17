using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateStorageModeResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("task_result_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskResult> TaskResultArray { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateStorageModeResponse {\n");
            sb.Append("  taskResultArray: ").Append(TaskResultArray).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateStorageModeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateStorageModeResponse input)
        {
            if (input == null) return false;
            if (this.TaskResultArray != input.TaskResultArray || (this.TaskResultArray != null && input.TaskResultArray != null && !this.TaskResultArray.SequenceEqual(input.TaskResultArray))) return false;

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
                if (this.TaskResultArray != null) hashCode = hashCode * 59 + this.TaskResultArray.GetHashCode();
                return hashCode;
            }
        }
    }
}
