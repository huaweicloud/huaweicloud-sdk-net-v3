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
    /// “文档”文件夹重定向配置
    /// </summary>
    public class DocumentsConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("documents_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? DocumentsStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("documents_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DocumentsRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("documents_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentsStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("documents_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentsRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("documents_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? DocumentsExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("documents_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? DocumentsMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("documents_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? DocumentsMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentsConfigurations {\n");
            sb.Append("  documentsStatus: ").Append(DocumentsStatus).Append("\n");
            sb.Append("  documentsRedirectionType: ").Append(DocumentsRedirectionType).Append("\n");
            sb.Append("  documentsStoragePath: ").Append(DocumentsStoragePath).Append("\n");
            sb.Append("  documentsRelativePath: ").Append(DocumentsRelativePath).Append("\n");
            sb.Append("  documentsExclusiveRights: ").Append(DocumentsExclusiveRights).Append("\n");
            sb.Append("  documentsMoveContents: ").Append(DocumentsMoveContents).Append("\n");
            sb.Append("  documentsMoveContentOnPolicyRemoval: ").Append(DocumentsMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DocumentsConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DocumentsConfigurations input)
        {
            if (input == null) return false;
            if (this.DocumentsStatus != input.DocumentsStatus || (this.DocumentsStatus != null && !this.DocumentsStatus.Equals(input.DocumentsStatus))) return false;
            if (this.DocumentsRedirectionType != input.DocumentsRedirectionType || (this.DocumentsRedirectionType != null && !this.DocumentsRedirectionType.Equals(input.DocumentsRedirectionType))) return false;
            if (this.DocumentsStoragePath != input.DocumentsStoragePath || (this.DocumentsStoragePath != null && !this.DocumentsStoragePath.Equals(input.DocumentsStoragePath))) return false;
            if (this.DocumentsRelativePath != input.DocumentsRelativePath || (this.DocumentsRelativePath != null && !this.DocumentsRelativePath.Equals(input.DocumentsRelativePath))) return false;
            if (this.DocumentsExclusiveRights != input.DocumentsExclusiveRights || (this.DocumentsExclusiveRights != null && !this.DocumentsExclusiveRights.Equals(input.DocumentsExclusiveRights))) return false;
            if (this.DocumentsMoveContents != input.DocumentsMoveContents || (this.DocumentsMoveContents != null && !this.DocumentsMoveContents.Equals(input.DocumentsMoveContents))) return false;
            if (this.DocumentsMoveContentOnPolicyRemoval != input.DocumentsMoveContentOnPolicyRemoval || (this.DocumentsMoveContentOnPolicyRemoval != null && !this.DocumentsMoveContentOnPolicyRemoval.Equals(input.DocumentsMoveContentOnPolicyRemoval))) return false;

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
                if (this.DocumentsStatus != null) hashCode = hashCode * 59 + this.DocumentsStatus.GetHashCode();
                if (this.DocumentsRedirectionType != null) hashCode = hashCode * 59 + this.DocumentsRedirectionType.GetHashCode();
                if (this.DocumentsStoragePath != null) hashCode = hashCode * 59 + this.DocumentsStoragePath.GetHashCode();
                if (this.DocumentsRelativePath != null) hashCode = hashCode * 59 + this.DocumentsRelativePath.GetHashCode();
                if (this.DocumentsExclusiveRights != null) hashCode = hashCode * 59 + this.DocumentsExclusiveRights.GetHashCode();
                if (this.DocumentsMoveContents != null) hashCode = hashCode * 59 + this.DocumentsMoveContents.GetHashCode();
                if (this.DocumentsMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.DocumentsMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
