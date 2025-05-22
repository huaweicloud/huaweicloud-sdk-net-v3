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
    /// 构建成功率
    /// </summary>
    public class ShowRunningStatusResult 
    {

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("last_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastJobId { get; set; }

        /// <summary>
        /// 最新构建编号
        /// </summary>
        [JsonProperty("last_build_no", NullValueHandling = NullValueHandling.Ignore)]
        public string LastBuildNo { get; set; }

        /// <summary>
        /// 最新构建状态
        /// </summary>
        [JsonProperty("last_build_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LastBuildStatus { get; set; }

        /// <summary>
        /// 是否在运行中
        /// </summary>
        [JsonProperty("is_running", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRunning { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRunningStatusResult {\n");
            sb.Append("  lastJobId: ").Append(LastJobId).Append("\n");
            sb.Append("  lastBuildNo: ").Append(LastBuildNo).Append("\n");
            sb.Append("  lastBuildStatus: ").Append(LastBuildStatus).Append("\n");
            sb.Append("  isRunning: ").Append(IsRunning).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRunningStatusResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRunningStatusResult input)
        {
            if (input == null) return false;
            if (this.LastJobId != input.LastJobId || (this.LastJobId != null && !this.LastJobId.Equals(input.LastJobId))) return false;
            if (this.LastBuildNo != input.LastBuildNo || (this.LastBuildNo != null && !this.LastBuildNo.Equals(input.LastBuildNo))) return false;
            if (this.LastBuildStatus != input.LastBuildStatus || (this.LastBuildStatus != null && !this.LastBuildStatus.Equals(input.LastBuildStatus))) return false;
            if (this.IsRunning != input.IsRunning || (this.IsRunning != null && !this.IsRunning.Equals(input.IsRunning))) return false;

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
                if (this.LastJobId != null) hashCode = hashCode * 59 + this.LastJobId.GetHashCode();
                if (this.LastBuildNo != null) hashCode = hashCode * 59 + this.LastBuildNo.GetHashCode();
                if (this.LastBuildStatus != null) hashCode = hashCode * 59 + this.LastBuildStatus.GetHashCode();
                if (this.IsRunning != null) hashCode = hashCode * 59 + this.IsRunning.GetHashCode();
                return hashCode;
            }
        }
    }
}
