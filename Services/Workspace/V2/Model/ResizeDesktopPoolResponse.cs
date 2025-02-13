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
    public class ResizeDesktopPoolResponse : SdkResponse
    {

        /// <summary>
        /// 创建云桌面总任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 【CBC回调】包周期创建桌面的任务ID
        /// </summary>
        [JsonProperty("cbcJobId", NullValueHandling = NullValueHandling.Ignore)]
        public string CbcJobId { get; set; }

        /// <summary>
        /// 【CBC回调】云运营平台CBC获取到JobId后，会使用getJobEndpoint当做URL，调用云服务，查询获取Job结果。
        /// </summary>
        [JsonProperty("getJobEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string GetJobEndpoint { get; set; }

        /// <summary>
        /// 【CBC回调】在线开通最大时间，在maxProvisionTime时间范围内，CBC会周期性的查询云服务开通结果；超过maxProvisionTime还没有开通成功，CBC会发失败工单，人工去分析处理。
        /// </summary>
        [JsonProperty("maxProvisionTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxProvisionTime { get; set; }

        /// <summary>
        /// 【CBC回调】开通最小时间（云服务最快开通时长，或一般开通时长）。获取到JobId后，经过minProvisionTime时间后，才来查询获取云服务开通结果。如果为空，云运营平台获取到JobId后，就去查询云服务开通结果。
        /// </summary>
        [JsonProperty("minProvisionTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinProvisionTime { get; set; }

        /// <summary>
        /// 【CBC回调】云运营平台会使用getJobEndpoint(Job查询接口)、每隔periodicQueryTime时间去查询云服务开通结果。
        /// </summary>
        [JsonProperty("periodicQueryTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodicQueryTime { get; set; }

        /// <summary>
        /// 变更订单错误处理策略。cbc调用返回值。设置为 NO_WORKORDER。云运营平台会认为无法开通成功，退费给客户后，不会再发运维工单给云服务，而由云服务自己去闭环处理对应问题。
        /// </summary>
        [JsonProperty("error_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorPolicy { get; set; }

        /// <summary>
        /// 按需桌面变更规格返回的任务信息。
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResizeDesktopPoolJobResponse> Jobs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeDesktopPoolResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  cbcJobId: ").Append(CbcJobId).Append("\n");
            sb.Append("  getJobEndpoint: ").Append(GetJobEndpoint).Append("\n");
            sb.Append("  maxProvisionTime: ").Append(MaxProvisionTime).Append("\n");
            sb.Append("  minProvisionTime: ").Append(MinProvisionTime).Append("\n");
            sb.Append("  periodicQueryTime: ").Append(PeriodicQueryTime).Append("\n");
            sb.Append("  errorPolicy: ").Append(ErrorPolicy).Append("\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeDesktopPoolResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeDesktopPoolResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.CbcJobId != input.CbcJobId || (this.CbcJobId != null && !this.CbcJobId.Equals(input.CbcJobId))) return false;
            if (this.GetJobEndpoint != input.GetJobEndpoint || (this.GetJobEndpoint != null && !this.GetJobEndpoint.Equals(input.GetJobEndpoint))) return false;
            if (this.MaxProvisionTime != input.MaxProvisionTime || (this.MaxProvisionTime != null && !this.MaxProvisionTime.Equals(input.MaxProvisionTime))) return false;
            if (this.MinProvisionTime != input.MinProvisionTime || (this.MinProvisionTime != null && !this.MinProvisionTime.Equals(input.MinProvisionTime))) return false;
            if (this.PeriodicQueryTime != input.PeriodicQueryTime || (this.PeriodicQueryTime != null && !this.PeriodicQueryTime.Equals(input.PeriodicQueryTime))) return false;
            if (this.ErrorPolicy != input.ErrorPolicy || (this.ErrorPolicy != null && !this.ErrorPolicy.Equals(input.ErrorPolicy))) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;

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
                if (this.CbcJobId != null) hashCode = hashCode * 59 + this.CbcJobId.GetHashCode();
                if (this.GetJobEndpoint != null) hashCode = hashCode * 59 + this.GetJobEndpoint.GetHashCode();
                if (this.MaxProvisionTime != null) hashCode = hashCode * 59 + this.MaxProvisionTime.GetHashCode();
                if (this.MinProvisionTime != null) hashCode = hashCode * 59 + this.MinProvisionTime.GetHashCode();
                if (this.PeriodicQueryTime != null) hashCode = hashCode * 59 + this.PeriodicQueryTime.GetHashCode();
                if (this.ErrorPolicy != null) hashCode = hashCode * 59 + this.ErrorPolicy.GetHashCode();
                if (this.Jobs != null) hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                return hashCode;
            }
        }
    }
}
