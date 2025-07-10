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
    public class ResizeDesktopResponse : SdkResponse
    {

        /// <summary>
        /// 按需桌面变更规格返回的任务信息（jobs字段后续会下线，请使用job_id字段）。
        /// </summary>
        [JsonProperty("jobs", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResizeDesktopJobResponse> Jobs { get; set; }

        /// <summary>
        /// 变更规格任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeDesktopResponse {\n");
            sb.Append("  jobs: ").Append(Jobs).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeDesktopResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeDesktopResponse input)
        {
            if (input == null) return false;
            if (this.Jobs != input.Jobs || (this.Jobs != null && input.Jobs != null && !this.Jobs.SequenceEqual(input.Jobs))) return false;
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
                if (this.Jobs != null) hashCode = hashCode * 59 + this.Jobs.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
