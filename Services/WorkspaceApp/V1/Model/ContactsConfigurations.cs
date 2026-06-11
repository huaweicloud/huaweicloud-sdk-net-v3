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
    /// “联系人”文件夹重定向配置
    /// </summary>
    public class ContactsConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("contacts_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContactsStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("contacts_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContactsRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("contacts_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactsStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("contacts_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactsRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("contacts_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContactsExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("contacts_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContactsMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("contacts_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContactsMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactsConfigurations {\n");
            sb.Append("  contactsStatus: ").Append(ContactsStatus).Append("\n");
            sb.Append("  contactsRedirectionType: ").Append(ContactsRedirectionType).Append("\n");
            sb.Append("  contactsStoragePath: ").Append(ContactsStoragePath).Append("\n");
            sb.Append("  contactsRelativePath: ").Append(ContactsRelativePath).Append("\n");
            sb.Append("  contactsExclusiveRights: ").Append(ContactsExclusiveRights).Append("\n");
            sb.Append("  contactsMoveContents: ").Append(ContactsMoveContents).Append("\n");
            sb.Append("  contactsMoveContentOnPolicyRemoval: ").Append(ContactsMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ContactsConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ContactsConfigurations input)
        {
            if (input == null) return false;
            if (this.ContactsStatus != input.ContactsStatus || (this.ContactsStatus != null && !this.ContactsStatus.Equals(input.ContactsStatus))) return false;
            if (this.ContactsRedirectionType != input.ContactsRedirectionType || (this.ContactsRedirectionType != null && !this.ContactsRedirectionType.Equals(input.ContactsRedirectionType))) return false;
            if (this.ContactsStoragePath != input.ContactsStoragePath || (this.ContactsStoragePath != null && !this.ContactsStoragePath.Equals(input.ContactsStoragePath))) return false;
            if (this.ContactsRelativePath != input.ContactsRelativePath || (this.ContactsRelativePath != null && !this.ContactsRelativePath.Equals(input.ContactsRelativePath))) return false;
            if (this.ContactsExclusiveRights != input.ContactsExclusiveRights || (this.ContactsExclusiveRights != null && !this.ContactsExclusiveRights.Equals(input.ContactsExclusiveRights))) return false;
            if (this.ContactsMoveContents != input.ContactsMoveContents || (this.ContactsMoveContents != null && !this.ContactsMoveContents.Equals(input.ContactsMoveContents))) return false;
            if (this.ContactsMoveContentOnPolicyRemoval != input.ContactsMoveContentOnPolicyRemoval || (this.ContactsMoveContentOnPolicyRemoval != null && !this.ContactsMoveContentOnPolicyRemoval.Equals(input.ContactsMoveContentOnPolicyRemoval))) return false;

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
                if (this.ContactsStatus != null) hashCode = hashCode * 59 + this.ContactsStatus.GetHashCode();
                if (this.ContactsRedirectionType != null) hashCode = hashCode * 59 + this.ContactsRedirectionType.GetHashCode();
                if (this.ContactsStoragePath != null) hashCode = hashCode * 59 + this.ContactsStoragePath.GetHashCode();
                if (this.ContactsRelativePath != null) hashCode = hashCode * 59 + this.ContactsRelativePath.GetHashCode();
                if (this.ContactsExclusiveRights != null) hashCode = hashCode * 59 + this.ContactsExclusiveRights.GetHashCode();
                if (this.ContactsMoveContents != null) hashCode = hashCode * 59 + this.ContactsMoveContents.GetHashCode();
                if (this.ContactsMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.ContactsMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
