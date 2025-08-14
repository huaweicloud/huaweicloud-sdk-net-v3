using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 配置文件漫游技术配置。
    /// </summary>
    public class PoliciesUserProfile 
    {

        /// <summary>
        /// 配置文件漫游技术配置开关： false: 表示关闭 true: 表示开启
        /// </summary>
        [JsonProperty("user_profile_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserProfileEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public UpmOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesUserProfile {\n");
            sb.Append("  userProfileEnable: ").Append(UserProfileEnable).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesUserProfile);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesUserProfile input)
        {
            if (input == null) return false;
            if (this.UserProfileEnable != input.UserProfileEnable || (this.UserProfileEnable != null && !this.UserProfileEnable.Equals(input.UserProfileEnable))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.UserProfileEnable != null) hashCode = hashCode * 59 + this.UserProfileEnable.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
