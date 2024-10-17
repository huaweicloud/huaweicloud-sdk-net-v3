using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CacheConfigRequest 
    {

        /// <summary>
        /// 是否忽略url中的参数。
        /// </summary>
        [JsonProperty("ignore_url_parameter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreUrlParameter { get; set; }

        /// <summary>
        /// 缓存规则是否遵循源站。
        /// </summary>
        [JsonProperty("follow_origin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FollowOrigin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compress", NullValueHandling = NullValueHandling.Ignore)]
        public CompressRequest Compress { get; set; }

        /// <summary>
        /// 缓存规则，将覆盖之前的规则配置。规则为空重置为默认规则。
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<Rules> Rules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CacheConfigRequest {\n");
            sb.Append("  ignoreUrlParameter: ").Append(IgnoreUrlParameter).Append("\n");
            sb.Append("  followOrigin: ").Append(FollowOrigin).Append("\n");
            sb.Append("  compress: ").Append(Compress).Append("\n");
            sb.Append("  rules: ").Append(Rules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CacheConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CacheConfigRequest input)
        {
            if (input == null) return false;
            if (this.IgnoreUrlParameter != input.IgnoreUrlParameter || (this.IgnoreUrlParameter != null && !this.IgnoreUrlParameter.Equals(input.IgnoreUrlParameter))) return false;
            if (this.FollowOrigin != input.FollowOrigin || (this.FollowOrigin != null && !this.FollowOrigin.Equals(input.FollowOrigin))) return false;
            if (this.Compress != input.Compress || (this.Compress != null && !this.Compress.Equals(input.Compress))) return false;
            if (this.Rules != input.Rules || (this.Rules != null && input.Rules != null && !this.Rules.SequenceEqual(input.Rules))) return false;

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
                if (this.IgnoreUrlParameter != null) hashCode = hashCode * 59 + this.IgnoreUrlParameter.GetHashCode();
                if (this.FollowOrigin != null) hashCode = hashCode * 59 + this.FollowOrigin.GetHashCode();
                if (this.Compress != null) hashCode = hashCode * 59 + this.Compress.GetHashCode();
                if (this.Rules != null) hashCode = hashCode * 59 + this.Rules.GetHashCode();
                return hashCode;
            }
        }
    }
}
