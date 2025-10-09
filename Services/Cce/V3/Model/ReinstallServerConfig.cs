using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点重装场景服务器配置
    /// </summary>
    public class ReinstallServerConfig 
    {

        /// <summary>
        /// **参数解释**： 云服务器标签（资源标签）。 **约束限制**： 键必须唯一，CCE支持的最大用户自定义标签数量依region而定，自定义标签数上限为8个。
        /// </summary>
        [JsonProperty("userTags", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTag> UserTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rootVolume", NullValueHandling = NullValueHandling.Ignore)]
        public ReinstallVolumeSpec RootVolume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReinstallServerConfig {\n");
            sb.Append("  userTags: ").Append(UserTags).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallServerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallServerConfig input)
        {
            if (input == null) return false;
            if (this.UserTags != input.UserTags || (this.UserTags != null && input.UserTags != null && !this.UserTags.SequenceEqual(input.UserTags))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;

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
                if (this.UserTags != null) hashCode = hashCode * 59 + this.UserTags.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                return hashCode;
            }
        }
    }
}
