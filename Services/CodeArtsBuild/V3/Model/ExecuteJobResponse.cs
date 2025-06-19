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
    /// Response Object
    /// </summary>
    public class ExecuteJobResponse : SdkResponse
    {

        /// <summary>
        /// 临时任务名称
        /// </summary>
        [JsonProperty("octopus_job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OctopusJobName { get; set; }

        /// <summary>
        /// 实际构建次数
        /// </summary>
        [JsonProperty("actual_build_number", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualBuildNumber { get; set; }

        /// <summary>
        /// 构建每日编号
        /// </summary>
        [JsonProperty("daily_build_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyBuildNumber { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteJobResponse {\n");
            sb.Append("  octopusJobName: ").Append(OctopusJobName).Append("\n");
            sb.Append("  actualBuildNumber: ").Append(ActualBuildNumber).Append("\n");
            sb.Append("  dailyBuildNumber: ").Append(DailyBuildNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteJobResponse input)
        {
            if (input == null) return false;
            if (this.OctopusJobName != input.OctopusJobName || (this.OctopusJobName != null && !this.OctopusJobName.Equals(input.OctopusJobName))) return false;
            if (this.ActualBuildNumber != input.ActualBuildNumber || (this.ActualBuildNumber != null && !this.ActualBuildNumber.Equals(input.ActualBuildNumber))) return false;
            if (this.DailyBuildNumber != input.DailyBuildNumber || (this.DailyBuildNumber != null && !this.DailyBuildNumber.Equals(input.DailyBuildNumber))) return false;

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
                if (this.OctopusJobName != null) hashCode = hashCode * 59 + this.OctopusJobName.GetHashCode();
                if (this.ActualBuildNumber != null) hashCode = hashCode * 59 + this.ActualBuildNumber.GetHashCode();
                if (this.DailyBuildNumber != null) hashCode = hashCode * 59 + this.DailyBuildNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
