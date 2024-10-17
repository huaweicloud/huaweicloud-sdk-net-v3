using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskStatus 
    {

        /// <summary>
        /// 任务ID，供调用者查询任务进度。
        /// </summary>
        [JsonProperty("jobID", NullValueHandling = NullValueHandling.Ignore)]
        public string JobID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskStatus {\n");
            sb.Append("  jobID: ").Append(JobID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskStatus input)
        {
            if (input == null) return false;
            if (this.JobID != input.JobID || (this.JobID != null && !this.JobID.Equals(input.JobID))) return false;

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
                if (this.JobID != null) hashCode = hashCode * 59 + this.JobID.GetHashCode();
                return hashCode;
            }
        }
    }
}
