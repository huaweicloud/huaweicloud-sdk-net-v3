using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GitRepositorySpec 
    {

        /// <summary>
        /// Git仓库地址
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public GitRepositoryRef Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("secretRef", NullValueHandling = NullValueHandling.Ignore)]
        public LocalObjectReference SecretRef { get; set; }

        /// <summary>
        /// 周期性检查仓库更新的时间间隔，格式如 \&quot;1m\&quot; 表示1分钟
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public string Interval { get; set; }

        /// <summary>
        /// Git 操作（如克隆）的超时时间，默认60秒
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public string Timeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GitRepositorySpec {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  secretRef: ").Append(SecretRef).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GitRepositorySpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GitRepositorySpec input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Ref != input.Ref || (this.Ref != null && !this.Ref.Equals(input.Ref))) return false;
            if (this.SecretRef != input.SecretRef || (this.SecretRef != null && !this.SecretRef.Equals(input.SecretRef))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Ref != null) hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.SecretRef != null) hashCode = hashCode * 59 + this.SecretRef.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
