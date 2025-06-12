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
    /// 任务状态返回体
    /// </summary>
    public class JobStatusBody 
    {

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务终止状态
        /// </summary>
        [JsonProperty("abort_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AbortStatus { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobStatusBody {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  abortStatus: ").Append(AbortStatus).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobStatusBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobStatusBody input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AbortStatus != input.AbortStatus || (this.AbortStatus != null && !this.AbortStatus.Equals(input.AbortStatus))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AbortStatus != null) hashCode = hashCode * 59 + this.AbortStatus.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                return hashCode;
            }
        }
    }
}
