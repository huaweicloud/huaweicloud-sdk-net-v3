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
    /// 个性化数据管理。
    /// </summary>
    public class PoliciesPersonalizedDataMgmt 
    {

        /// <summary>
        /// 个性化数据管理路径。
        /// </summary>
        [JsonProperty("personalized_data_mgmt_path", NullValueHandling = NullValueHandling.Ignore)]
        public string PersonalizedDataMgmtPath { get; set; }

        /// <summary>
        /// 用户数据漫游。
        /// </summary>
        [JsonProperty("user_data_roaming_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserDataRoamingEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_data_roaming_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPersonalizedDataMgmtUserDataRoamingOptions UserDataRoamingOptions { get; set; }

        /// <summary>
        /// 启用用户文件夹重定向。
        /// </summary>
        [JsonProperty("user_folder_redirection_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserFolderRedirectionEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_folder_redirection_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPersonalizedDataMgmtUserFolderRedirectionOptions UserFolderRedirectionOptions { get; set; }

        /// <summary>
        /// 启用用户文件夹重定向。
        /// </summary>
        [JsonProperty("logoff_delete_user_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogoffDeleteUserConfiguration { get; set; }

        /// <summary>
        /// 启用用户文件夹重定向。
        /// </summary>
        [JsonProperty("network_drive_mapping_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NetworkDriveMappingEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network_drive_mapping_options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesPersonalizedDataMgmtNetworkDriveMappingOptions NetworkDriveMappingOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPersonalizedDataMgmt {\n");
            sb.Append("  personalizedDataMgmtPath: ").Append(PersonalizedDataMgmtPath).Append("\n");
            sb.Append("  userDataRoamingEnable: ").Append(UserDataRoamingEnable).Append("\n");
            sb.Append("  userDataRoamingOptions: ").Append(UserDataRoamingOptions).Append("\n");
            sb.Append("  userFolderRedirectionEnable: ").Append(UserFolderRedirectionEnable).Append("\n");
            sb.Append("  userFolderRedirectionOptions: ").Append(UserFolderRedirectionOptions).Append("\n");
            sb.Append("  logoffDeleteUserConfiguration: ").Append(LogoffDeleteUserConfiguration).Append("\n");
            sb.Append("  networkDriveMappingEnable: ").Append(NetworkDriveMappingEnable).Append("\n");
            sb.Append("  networkDriveMappingOptions: ").Append(NetworkDriveMappingOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPersonalizedDataMgmt);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPersonalizedDataMgmt input)
        {
            if (input == null) return false;
            if (this.PersonalizedDataMgmtPath != input.PersonalizedDataMgmtPath || (this.PersonalizedDataMgmtPath != null && !this.PersonalizedDataMgmtPath.Equals(input.PersonalizedDataMgmtPath))) return false;
            if (this.UserDataRoamingEnable != input.UserDataRoamingEnable || (this.UserDataRoamingEnable != null && !this.UserDataRoamingEnable.Equals(input.UserDataRoamingEnable))) return false;
            if (this.UserDataRoamingOptions != input.UserDataRoamingOptions || (this.UserDataRoamingOptions != null && !this.UserDataRoamingOptions.Equals(input.UserDataRoamingOptions))) return false;
            if (this.UserFolderRedirectionEnable != input.UserFolderRedirectionEnable || (this.UserFolderRedirectionEnable != null && !this.UserFolderRedirectionEnable.Equals(input.UserFolderRedirectionEnable))) return false;
            if (this.UserFolderRedirectionOptions != input.UserFolderRedirectionOptions || (this.UserFolderRedirectionOptions != null && !this.UserFolderRedirectionOptions.Equals(input.UserFolderRedirectionOptions))) return false;
            if (this.LogoffDeleteUserConfiguration != input.LogoffDeleteUserConfiguration || (this.LogoffDeleteUserConfiguration != null && !this.LogoffDeleteUserConfiguration.Equals(input.LogoffDeleteUserConfiguration))) return false;
            if (this.NetworkDriveMappingEnable != input.NetworkDriveMappingEnable || (this.NetworkDriveMappingEnable != null && !this.NetworkDriveMappingEnable.Equals(input.NetworkDriveMappingEnable))) return false;
            if (this.NetworkDriveMappingOptions != input.NetworkDriveMappingOptions || (this.NetworkDriveMappingOptions != null && !this.NetworkDriveMappingOptions.Equals(input.NetworkDriveMappingOptions))) return false;

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
                if (this.PersonalizedDataMgmtPath != null) hashCode = hashCode * 59 + this.PersonalizedDataMgmtPath.GetHashCode();
                if (this.UserDataRoamingEnable != null) hashCode = hashCode * 59 + this.UserDataRoamingEnable.GetHashCode();
                if (this.UserDataRoamingOptions != null) hashCode = hashCode * 59 + this.UserDataRoamingOptions.GetHashCode();
                if (this.UserFolderRedirectionEnable != null) hashCode = hashCode * 59 + this.UserFolderRedirectionEnable.GetHashCode();
                if (this.UserFolderRedirectionOptions != null) hashCode = hashCode * 59 + this.UserFolderRedirectionOptions.GetHashCode();
                if (this.LogoffDeleteUserConfiguration != null) hashCode = hashCode * 59 + this.LogoffDeleteUserConfiguration.GetHashCode();
                if (this.NetworkDriveMappingEnable != null) hashCode = hashCode * 59 + this.NetworkDriveMappingEnable.GetHashCode();
                if (this.NetworkDriveMappingOptions != null) hashCode = hashCode * 59 + this.NetworkDriveMappingOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
