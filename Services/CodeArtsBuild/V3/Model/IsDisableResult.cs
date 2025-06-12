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
    /// 返回结果
    /// </summary>
    public class IsDisableResult 
    {

        /// <summary>
        /// 禁用者
        /// </summary>
        [JsonProperty("forbiddener", NullValueHandling = NullValueHandling.Ignore)]
        public string Forbiddener { get; set; }

        /// <summary>
        /// 禁用描述
        /// </summary>
        [JsonProperty("reson", NullValueHandling = NullValueHandling.Ignore)]
        public string Reson { get; set; }

        /// <summary>
        /// 禁用标识
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public int? Disabled { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 明文名称
        /// </summary>
        [JsonProperty("job_name", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// 禁用时间
        /// </summary>
        [JsonProperty("forbidden_time", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ForbiddenTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsDisableResult {\n");
            sb.Append("  forbiddener: ").Append(Forbiddener).Append("\n");
            sb.Append("  reson: ").Append(Reson).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  forbiddenTime: ").Append(ForbiddenTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IsDisableResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IsDisableResult input)
        {
            if (input == null) return false;
            if (this.Forbiddener != input.Forbiddener || (this.Forbiddener != null && !this.Forbiddener.Equals(input.Forbiddener))) return false;
            if (this.Reson != input.Reson || (this.Reson != null && !this.Reson.Equals(input.Reson))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.ForbiddenTime != input.ForbiddenTime || (this.ForbiddenTime != null && !this.ForbiddenTime.Equals(input.ForbiddenTime))) return false;

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
                if (this.Forbiddener != null) hashCode = hashCode * 59 + this.Forbiddener.GetHashCode();
                if (this.Reson != null) hashCode = hashCode * 59 + this.Reson.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.ForbiddenTime != null) hashCode = hashCode * 59 + this.ForbiddenTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
