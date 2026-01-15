using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 配置文件漫游技术配置。
    /// </summary>
    public class PoliciesUserProfileOptions 
    {

        /// <summary>
        /// 配置项内容。json格式
        /// </summary>
        [JsonProperty("user_profile_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string UserProfileRule { get; set; }

        /// <summary>
        /// 排除常用文件夹。json格式
        /// </summary>
        [JsonProperty("redir_exclude_common_folders", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirExcludeCommonFolders { get; set; }

        /// <summary>
        /// 禁止自定义文件夹/copy base &#x3D; 0,copy back &#x3D; 0。json格式
        /// </summary>
        [JsonProperty("redir_exclude_copy0s", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirExcludeCopy0s { get; set; }

        /// <summary>
        /// 禁止自定义文件夹/copy base &#x3D; 0,copy back &#x3D; 1。json格式
        /// </summary>
        [JsonProperty("redir_exclude_copy1s", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirExcludeCopy1s { get; set; }

        /// <summary>
        /// 禁止自定义文件夹/copy base &#x3D; 1,copy back &#x3D; 0。json格式
        /// </summary>
        [JsonProperty("redir_exclude_copy2s", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirExcludeCopy2s { get; set; }

        /// <summary>
        /// 禁止自定义文件夹/copy base &#x3D; 1,copy back &#x3D; 1。json格式
        /// </summary>
        [JsonProperty("redir_exclude_copy3s", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirExcludeCopy3s { get; set; }

        /// <summary>
        /// 允许自定义文件夹 json格式
        /// </summary>
        [JsonProperty("redir_exclude_includes", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirExcludeIncludes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesUserProfileOptions {\n");
            sb.Append("  userProfileRule: ").Append(UserProfileRule).Append("\n");
            sb.Append("  redirExcludeCommonFolders: ").Append(RedirExcludeCommonFolders).Append("\n");
            sb.Append("  redirExcludeCopy0s: ").Append(RedirExcludeCopy0s).Append("\n");
            sb.Append("  redirExcludeCopy1s: ").Append(RedirExcludeCopy1s).Append("\n");
            sb.Append("  redirExcludeCopy2s: ").Append(RedirExcludeCopy2s).Append("\n");
            sb.Append("  redirExcludeCopy3s: ").Append(RedirExcludeCopy3s).Append("\n");
            sb.Append("  redirExcludeIncludes: ").Append(RedirExcludeIncludes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesUserProfileOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesUserProfileOptions input)
        {
            if (input == null) return false;
            if (this.UserProfileRule != input.UserProfileRule || (this.UserProfileRule != null && !this.UserProfileRule.Equals(input.UserProfileRule))) return false;
            if (this.RedirExcludeCommonFolders != input.RedirExcludeCommonFolders || (this.RedirExcludeCommonFolders != null && !this.RedirExcludeCommonFolders.Equals(input.RedirExcludeCommonFolders))) return false;
            if (this.RedirExcludeCopy0s != input.RedirExcludeCopy0s || (this.RedirExcludeCopy0s != null && !this.RedirExcludeCopy0s.Equals(input.RedirExcludeCopy0s))) return false;
            if (this.RedirExcludeCopy1s != input.RedirExcludeCopy1s || (this.RedirExcludeCopy1s != null && !this.RedirExcludeCopy1s.Equals(input.RedirExcludeCopy1s))) return false;
            if (this.RedirExcludeCopy2s != input.RedirExcludeCopy2s || (this.RedirExcludeCopy2s != null && !this.RedirExcludeCopy2s.Equals(input.RedirExcludeCopy2s))) return false;
            if (this.RedirExcludeCopy3s != input.RedirExcludeCopy3s || (this.RedirExcludeCopy3s != null && !this.RedirExcludeCopy3s.Equals(input.RedirExcludeCopy3s))) return false;
            if (this.RedirExcludeIncludes != input.RedirExcludeIncludes || (this.RedirExcludeIncludes != null && !this.RedirExcludeIncludes.Equals(input.RedirExcludeIncludes))) return false;

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
                if (this.UserProfileRule != null) hashCode = hashCode * 59 + this.UserProfileRule.GetHashCode();
                if (this.RedirExcludeCommonFolders != null) hashCode = hashCode * 59 + this.RedirExcludeCommonFolders.GetHashCode();
                if (this.RedirExcludeCopy0s != null) hashCode = hashCode * 59 + this.RedirExcludeCopy0s.GetHashCode();
                if (this.RedirExcludeCopy1s != null) hashCode = hashCode * 59 + this.RedirExcludeCopy1s.GetHashCode();
                if (this.RedirExcludeCopy2s != null) hashCode = hashCode * 59 + this.RedirExcludeCopy2s.GetHashCode();
                if (this.RedirExcludeCopy3s != null) hashCode = hashCode * 59 + this.RedirExcludeCopy3s.GetHashCode();
                if (this.RedirExcludeIncludes != null) hashCode = hashCode * 59 + this.RedirExcludeIncludes.GetHashCode();
                return hashCode;
            }
        }
    }
}
