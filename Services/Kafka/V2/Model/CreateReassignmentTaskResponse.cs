using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateReassignmentTaskResponse : SdkResponse
    {

        /// <summary>
        /// 任务ID（当执行重平衡任务时仅返回job_id）。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 预估时间，单位为秒（当执行预估时间任务时仅返回reassignment_time）。
        /// </summary>
        [JsonProperty("reassignment_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReassignmentTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateReassignmentTaskResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  reassignmentTime: ").Append(ReassignmentTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateReassignmentTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateReassignmentTaskResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ReassignmentTime == input.ReassignmentTime ||
                    (this.ReassignmentTime != null &&
                    this.ReassignmentTime.Equals(input.ReassignmentTime))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ReassignmentTime != null)
                    hashCode = hashCode * 59 + this.ReassignmentTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
