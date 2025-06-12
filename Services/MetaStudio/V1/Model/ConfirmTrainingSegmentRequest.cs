using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ConfirmTrainingSegmentRequest 
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [SDKProperty("job_id", IsQuery = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 语句索引。
        /// </summary>
        [SDKProperty("index", IsQuery = true)]
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmTrainingSegmentRequest {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfirmTrainingSegmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfirmTrainingSegmentRequest input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Index != input.Index || (this.Index != null && !this.Index.Equals(input.Index))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Index != null) hashCode = hashCode * 59 + this.Index.GetHashCode();
                return hashCode;
            }
        }
    }
}
