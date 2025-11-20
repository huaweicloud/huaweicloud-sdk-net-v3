using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckPreliminaryResultsResponse : SdkResponse
    {

        /// <summary>
        /// 关联的后端DN信息。
        /// </summary>
        [JsonProperty("pre_check_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<PreCheckResult> PreCheckResults { get; set; }

        /// <summary>
        /// 工作流id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckPreliminaryResultsResponse {\n");
            sb.Append("  preCheckResults: ").Append(PreCheckResults).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckPreliminaryResultsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckPreliminaryResultsResponse input)
        {
            if (input == null) return false;
            if (this.PreCheckResults != input.PreCheckResults || (this.PreCheckResults != null && input.PreCheckResults != null && !this.PreCheckResults.SequenceEqual(input.PreCheckResults))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;

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
                if (this.PreCheckResults != null) hashCode = hashCode * 59 + this.PreCheckResults.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
