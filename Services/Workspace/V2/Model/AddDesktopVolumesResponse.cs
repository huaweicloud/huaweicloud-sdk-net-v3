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
    public class AddDesktopVolumesResponse : SdkResponse
    {

        /// <summary>
        /// 增加磁盘任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 云运营平台CBC获取到JobId后，会使用getJobEndpoint当做URL，调用云服务，查询获取Job结果
        /// </summary>
        [JsonProperty("getJobEndpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string GetJobEndpoint { get; set; }

        /// <summary>
        /// 在线开通最大时间
        /// </summary>
        [JsonProperty("maxProvisionTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxProvisionTime { get; set; }

        /// <summary>
        /// 开通最小时间（云服务最快开通时长，或一般开通时长）
        /// </summary>
        [JsonProperty("minProvisionTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinProvisionTime { get; set; }

        /// <summary>
        /// Job周期性查询时间，默认1分钟查询一次
        /// </summary>
        [JsonProperty("periodicQueryTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodicQueryTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDesktopVolumesResponse {\n");
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
            return this.Equals(input as AddDesktopVolumesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDesktopVolumesResponse input)
        {
            if (input == null) return false;
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
