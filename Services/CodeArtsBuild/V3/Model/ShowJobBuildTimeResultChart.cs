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
    /// 
    /// </summary>
    public class ShowJobBuildTimeResultChart 
    {

        /// <summary>
        /// 构建每日编号
        /// </summary>
        [JsonProperty("daily_build_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DailyBuildNumber { get; set; }

        /// <summary>
        /// 构建编号
        /// </summary>
        [JsonProperty("build_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNumber { get; set; }

        /// <summary>
        /// 步骤执行时长，单位s
        /// </summary>
        [JsonProperty("build_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildTime { get; set; }

        /// <summary>
        /// 构建结果
        /// </summary>
        [JsonProperty("build_result", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobBuildTimeResultChart {\n");
            sb.Append("  dailyBuildNumber: ").Append(DailyBuildNumber).Append("\n");
            sb.Append("  buildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  buildTime: ").Append(BuildTime).Append("\n");
            sb.Append("  buildResult: ").Append(BuildResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobBuildTimeResultChart);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobBuildTimeResultChart input)
        {
            if (input == null) return false;
            if (this.DailyBuildNumber != input.DailyBuildNumber || (this.DailyBuildNumber != null && !this.DailyBuildNumber.Equals(input.DailyBuildNumber))) return false;
            if (this.BuildNumber != input.BuildNumber || (this.BuildNumber != null && !this.BuildNumber.Equals(input.BuildNumber))) return false;
            if (this.BuildTime != input.BuildTime || (this.BuildTime != null && !this.BuildTime.Equals(input.BuildTime))) return false;
            if (this.BuildResult != input.BuildResult || (this.BuildResult != null && !this.BuildResult.Equals(input.BuildResult))) return false;

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
                if (this.DailyBuildNumber != null) hashCode = hashCode * 59 + this.DailyBuildNumber.GetHashCode();
                if (this.BuildNumber != null) hashCode = hashCode * 59 + this.BuildNumber.GetHashCode();
                if (this.BuildTime != null) hashCode = hashCode * 59 + this.BuildTime.GetHashCode();
                if (this.BuildResult != null) hashCode = hashCode * 59 + this.BuildResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
