using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 结果
    /// </summary>
    public class JobUpdateRecordListVoResult 
    {

        /// <summary>
        /// job_update_records
        /// </summary>
        [JsonProperty("job_update_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobUpdateRecordListVoResultJobUpdateRecords> JobUpdateRecords { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobUpdateRecordListVoResult {\n");
            sb.Append("  jobUpdateRecords: ").Append(JobUpdateRecords).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobUpdateRecordListVoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobUpdateRecordListVoResult input)
        {
            if (input == null) return false;
            if (this.JobUpdateRecords != input.JobUpdateRecords || (this.JobUpdateRecords != null && input.JobUpdateRecords != null && !this.JobUpdateRecords.SequenceEqual(input.JobUpdateRecords))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.JobUpdateRecords != null) hashCode = hashCode * 59 + this.JobUpdateRecords.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
