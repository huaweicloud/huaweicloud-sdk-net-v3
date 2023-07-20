using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CancelScheduleTaskResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID，表示成功取消定时调度任务的ID。
        /// </summary>
        [JsonProperty("job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelScheduleTaskResponse {\n");
            sb.Append("  jobIds: ").Append(JobIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelScheduleTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CancelScheduleTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobIds == input.JobIds ||
                    this.JobIds != null &&
                    input.JobIds != null &&
                    this.JobIds.SequenceEqual(input.JobIds)
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
                if (this.JobIds != null)
                    hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
