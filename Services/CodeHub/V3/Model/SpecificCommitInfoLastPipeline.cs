using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 流水线信息
    /// </summary>
    public class SpecificCommitInfoLastPipeline 
    {

        /// <summary>
        /// 流水线id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 提交对应的SHA id
        /// </summary>
        [JsonProperty("sha", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha { get; set; }

        /// <summary>
        /// 分支名
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }

        /// <summary>
        /// 流水线状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 流水线url
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecificCommitInfoLastPipeline {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  sha: ").Append(Sha).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpecificCommitInfoLastPipeline);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpecificCommitInfoLastPipeline input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Sha != input.Sha || (this.Sha != null && !this.Sha.Equals(input.Sha))) return false;
            if (this.Ref != input.Ref || (this.Ref != null && !this.Ref.Equals(input.Ref))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Sha != null) hashCode = hashCode * 59 + this.Sha.GetHashCode();
                if (this.Ref != null) hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
