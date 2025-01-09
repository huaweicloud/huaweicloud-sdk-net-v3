using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteSubJobsReq 
    {

        /// <summary>
        /// 任务ID列表，只能删除SUCCESS、FAILED两种状态。job_ids和delete_by_status必传一个。
        /// </summary>
        [JsonProperty("job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// 通过任务状态删除，只能删除以下的两种状态 SUCCESS：成功。 FAILED：失败。job_ids和delete_by_status必传一个。
        /// </summary>
        [JsonProperty("delete_by_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DeleteByStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSubJobsReq {\n");
            sb.Append("  jobIds: ").Append(JobIds).Append("\n");
            sb.Append("  deleteByStatus: ").Append(DeleteByStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSubJobsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSubJobsReq input)
        {
            if (input == null) return false;
            if (this.JobIds != input.JobIds || (this.JobIds != null && input.JobIds != null && !this.JobIds.SequenceEqual(input.JobIds))) return false;
            if (this.DeleteByStatus != input.DeleteByStatus || (this.DeleteByStatus != null && !this.DeleteByStatus.Equals(input.DeleteByStatus))) return false;

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
                if (this.JobIds != null) hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                if (this.DeleteByStatus != null) hashCode = hashCode * 59 + this.DeleteByStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
