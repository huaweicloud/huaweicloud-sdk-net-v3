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
    /// 用户数据漫游选项。
    /// </summary>
    public class PoliciesPersonalizedDataMgmtUserDataRoamingOptions 
    {

        /// <summary>
        /// 配置文件流式处理启用。
        /// </summary>
        [JsonProperty("profile_streaming_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProfileStreamingEnable { get; set; }

        /// <summary>
        /// 漫游文件本地路径。
        /// </summary>
        [JsonProperty("roamed_files_local_path", NullValueHandling = NullValueHandling.Ignore)]
        public string RoamedFilesLocalPath { get; set; }

        /// <summary>
        /// 排除文件夹路径。
        /// </summary>
        [JsonProperty("exclude_folders_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeFoldersPath { get; set; }

        /// <summary>
        /// 排除文件夹路径。
        /// </summary>
        [JsonProperty("roaming_registry_method", NullValueHandling = NullValueHandling.Ignore)]
        public string RoamingRegistryMethod { get; set; }

        /// <summary>
        /// 漫游注册路径。
        /// </summary>
        [JsonProperty("roaming_registry_path", NullValueHandling = NullValueHandling.Ignore)]
        public string RoamingRegistryPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPersonalizedDataMgmtUserDataRoamingOptions {\n");
            sb.Append("  profileStreamingEnable: ").Append(ProfileStreamingEnable).Append("\n");
            sb.Append("  roamedFilesLocalPath: ").Append(RoamedFilesLocalPath).Append("\n");
            sb.Append("  excludeFoldersPath: ").Append(ExcludeFoldersPath).Append("\n");
            sb.Append("  roamingRegistryMethod: ").Append(RoamingRegistryMethod).Append("\n");
            sb.Append("  roamingRegistryPath: ").Append(RoamingRegistryPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPersonalizedDataMgmtUserDataRoamingOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPersonalizedDataMgmtUserDataRoamingOptions input)
        {
            if (input == null) return false;
            if (this.ProfileStreamingEnable != input.ProfileStreamingEnable || (this.ProfileStreamingEnable != null && !this.ProfileStreamingEnable.Equals(input.ProfileStreamingEnable))) return false;
            if (this.RoamedFilesLocalPath != input.RoamedFilesLocalPath || (this.RoamedFilesLocalPath != null && !this.RoamedFilesLocalPath.Equals(input.RoamedFilesLocalPath))) return false;
            if (this.ExcludeFoldersPath != input.ExcludeFoldersPath || (this.ExcludeFoldersPath != null && !this.ExcludeFoldersPath.Equals(input.ExcludeFoldersPath))) return false;
            if (this.RoamingRegistryMethod != input.RoamingRegistryMethod || (this.RoamingRegistryMethod != null && !this.RoamingRegistryMethod.Equals(input.RoamingRegistryMethod))) return false;
            if (this.RoamingRegistryPath != input.RoamingRegistryPath || (this.RoamingRegistryPath != null && !this.RoamingRegistryPath.Equals(input.RoamingRegistryPath))) return false;

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
                if (this.ProfileStreamingEnable != null) hashCode = hashCode * 59 + this.ProfileStreamingEnable.GetHashCode();
                if (this.RoamedFilesLocalPath != null) hashCode = hashCode * 59 + this.RoamedFilesLocalPath.GetHashCode();
                if (this.ExcludeFoldersPath != null) hashCode = hashCode * 59 + this.ExcludeFoldersPath.GetHashCode();
                if (this.RoamingRegistryMethod != null) hashCode = hashCode * 59 + this.RoamingRegistryMethod.GetHashCode();
                if (this.RoamingRegistryPath != null) hashCode = hashCode * 59 + this.RoamingRegistryPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
