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
    /// Response Object
    /// </summary>
    public class BatchDetachInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 操作失败桌面列表。
        /// </summary>
        [JsonProperty("failed_operation_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<VmOperateResult> FailedOperationList { get; set; }

        /// <summary>
        /// 任务ID,池桌面返回job_id,普通桌面job_id为空。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 内部服务操作成功jobId
        /// </summary>
        [JsonProperty("success_job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SuccessJobIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDetachInstancesResponse {\n");
            sb.Append("  failedOperationList: ").Append(FailedOperationList).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  successJobIds: ").Append(SuccessJobIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDetachInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDetachInstancesResponse input)
        {
            if (input == null) return false;
            if (this.FailedOperationList != input.FailedOperationList || (this.FailedOperationList != null && input.FailedOperationList != null && !this.FailedOperationList.SequenceEqual(input.FailedOperationList))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.SuccessJobIds != input.SuccessJobIds || (this.SuccessJobIds != null && input.SuccessJobIds != null && !this.SuccessJobIds.SequenceEqual(input.SuccessJobIds))) return false;

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
                if (this.FailedOperationList != null) hashCode = hashCode * 59 + this.FailedOperationList.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.SuccessJobIds != null) hashCode = hashCode * 59 + this.SuccessJobIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
