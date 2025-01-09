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
    public class BatchRebuildDesktopsSystemDiskResponse : SdkResponse
    {

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 加密后的详细拒绝原因，用户可以自行调用STS服务的decode-authorization-message接口进行解密。
        /// </summary>
        [JsonProperty("encoded_authorization_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EncodedAuthorizationMessage { get; set; }

        /// <summary>
        /// 重建系统盘总任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 云运营平台CBC获取到JobId后，会使用getJobEndpoint当做URL，调用云服务，查询获取Job结果。
        /// </summary>
        [JsonProperty("get_job_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string GetJobEndpoint { get; set; }

        /// <summary>
        /// 在线开通最大时间。
        /// </summary>
        [JsonProperty("max_provision_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxProvisionTime { get; set; }

        /// <summary>
        /// 开通最小时间（云服务最快开通时长，或一般开通时长）。
        /// </summary>
        [JsonProperty("min_provision_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinProvisionTime { get; set; }

        /// <summary>
        /// Job周期性查询时间。
        /// </summary>
        [JsonProperty("periodic_query_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodicQueryTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRebuildDesktopsSystemDiskResponse {\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  encodedAuthorizationMessage: ").Append(EncodedAuthorizationMessage).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  getJobEndpoint: ").Append(GetJobEndpoint).Append("\n");
            sb.Append("  maxProvisionTime: ").Append(MaxProvisionTime).Append("\n");
            sb.Append("  minProvisionTime: ").Append(MinProvisionTime).Append("\n");
            sb.Append("  periodicQueryTime: ").Append(PeriodicQueryTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRebuildDesktopsSystemDiskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRebuildDesktopsSystemDiskResponse input)
        {
            if (input == null) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.EncodedAuthorizationMessage != input.EncodedAuthorizationMessage || (this.EncodedAuthorizationMessage != null && !this.EncodedAuthorizationMessage.Equals(input.EncodedAuthorizationMessage))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.GetJobEndpoint != input.GetJobEndpoint || (this.GetJobEndpoint != null && !this.GetJobEndpoint.Equals(input.GetJobEndpoint))) return false;
            if (this.MaxProvisionTime != input.MaxProvisionTime || (this.MaxProvisionTime != null && !this.MaxProvisionTime.Equals(input.MaxProvisionTime))) return false;
            if (this.MinProvisionTime != input.MinProvisionTime || (this.MinProvisionTime != null && !this.MinProvisionTime.Equals(input.MinProvisionTime))) return false;
            if (this.PeriodicQueryTime != input.PeriodicQueryTime || (this.PeriodicQueryTime != null && !this.PeriodicQueryTime.Equals(input.PeriodicQueryTime))) return false;

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
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.EncodedAuthorizationMessage != null) hashCode = hashCode * 59 + this.EncodedAuthorizationMessage.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.GetJobEndpoint != null) hashCode = hashCode * 59 + this.GetJobEndpoint.GetHashCode();
                if (this.MaxProvisionTime != null) hashCode = hashCode * 59 + this.MaxProvisionTime.GetHashCode();
                if (this.MinProvisionTime != null) hashCode = hashCode * 59 + this.MinProvisionTime.GetHashCode();
                if (this.PeriodicQueryTime != null) hashCode = hashCode * 59 + this.PeriodicQueryTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
