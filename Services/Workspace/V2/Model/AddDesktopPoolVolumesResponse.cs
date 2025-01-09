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
    public class AddDesktopPoolVolumesResponse : SdkResponse
    {

        /// <summary>
        /// 错误码，失败时返回。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 创建云桌面总任务ID，CBC根据此ID定期查询任务是否成功
        /// </summary>
        [JsonProperty("cbcJobId", NullValueHandling = NullValueHandling.Ignore)]
        public string CbcJobId { get; set; }

        /// <summary>
        /// 云运营平台CBC获取到JobId后，会使用getJobEndpoint当做URL，调用云服务，查询获取Job结果
        /// </summary>
        [JsonProperty("getJobEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string GetJobEndpoint { get; set; }

        /// <summary>
        /// 在线开通最大时间 在maxProvisionTime时间范围内，CBC会周期性的查询云服务开通结果；超过maxProvisionTime还没有开通成功，CBC会发失败工单，人工去分析处理。 单位：分钟。 如果为空，CBC默认为6小时。 取值范围（0,43200]，即30天。
        /// </summary>
        [JsonProperty("maxProvisionTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxProvisionTime { get; set; }

        /// <summary>
        /// 开通最小时间（云服务最快开通时长，或一般开通时长） 获取到JobId后，经过minProvisionTime时间后，才来查询获取云服务开通结果。如果为空，云运营平台获取到JobId后，就去查询云服务开通结果。 单位：分钟。 取值范围：(0, 43200)
        /// </summary>
        [JsonProperty("minProvisionTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinProvisionTime { get; set; }

        /// <summary>
        /// Job周期性查询时间，默认2分钟查询一次 云运营平台会使用getJobEndpoint(Job查询接口)、每隔periodicQueryTime时间去查询云服务开通结果。 单位：分钟。 如果为空，则使用CBC默认的间隔时间（1分钟，2分钟，4分钟……15分钟）来查询云服务开通结果。 取值范围：(0, 43200)
        /// </summary>
        [JsonProperty("periodicQueryTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodicQueryTime { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDesktopPoolVolumesResponse {\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  cbcJobId: ").Append(CbcJobId).Append("\n");
            sb.Append("  getJobEndpoint: ").Append(GetJobEndpoint).Append("\n");
            sb.Append("  maxProvisionTime: ").Append(MaxProvisionTime).Append("\n");
            sb.Append("  minProvisionTime: ").Append(MinProvisionTime).Append("\n");
            sb.Append("  periodicQueryTime: ").Append(PeriodicQueryTime).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDesktopPoolVolumesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDesktopPoolVolumesResponse input)
        {
            if (input == null) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.CbcJobId != input.CbcJobId || (this.CbcJobId != null && !this.CbcJobId.Equals(input.CbcJobId))) return false;
            if (this.GetJobEndpoint != input.GetJobEndpoint || (this.GetJobEndpoint != null && !this.GetJobEndpoint.Equals(input.GetJobEndpoint))) return false;
            if (this.MaxProvisionTime != input.MaxProvisionTime || (this.MaxProvisionTime != null && !this.MaxProvisionTime.Equals(input.MaxProvisionTime))) return false;
            if (this.MinProvisionTime != input.MinProvisionTime || (this.MinProvisionTime != null && !this.MinProvisionTime.Equals(input.MinProvisionTime))) return false;
            if (this.PeriodicQueryTime != input.PeriodicQueryTime || (this.PeriodicQueryTime != null && !this.PeriodicQueryTime.Equals(input.PeriodicQueryTime))) return false;
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
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.CbcJobId != null) hashCode = hashCode * 59 + this.CbcJobId.GetHashCode();
                if (this.GetJobEndpoint != null) hashCode = hashCode * 59 + this.GetJobEndpoint.GetHashCode();
                if (this.MaxProvisionTime != null) hashCode = hashCode * 59 + this.MaxProvisionTime.GetHashCode();
                if (this.MinProvisionTime != null) hashCode = hashCode * 59 + this.MinProvisionTime.GetHashCode();
                if (this.PeriodicQueryTime != null) hashCode = hashCode * 59 + this.PeriodicQueryTime.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
