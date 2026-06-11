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
    /// “搜索”文件夹重定向配置
    /// </summary>
    public class SearchesConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("searches_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchesStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("searches_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchesRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("searches_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchesStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("searches_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchesRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("searches_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchesExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("searches_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchesMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("searches_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? SearchesMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchesConfigurations {\n");
            sb.Append("  searchesStatus: ").Append(SearchesStatus).Append("\n");
            sb.Append("  searchesRedirectionType: ").Append(SearchesRedirectionType).Append("\n");
            sb.Append("  searchesStoragePath: ").Append(SearchesStoragePath).Append("\n");
            sb.Append("  searchesRelativePath: ").Append(SearchesRelativePath).Append("\n");
            sb.Append("  searchesExclusiveRights: ").Append(SearchesExclusiveRights).Append("\n");
            sb.Append("  searchesMoveContents: ").Append(SearchesMoveContents).Append("\n");
            sb.Append("  searchesMoveContentOnPolicyRemoval: ").Append(SearchesMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchesConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchesConfigurations input)
        {
            if (input == null) return false;
            if (this.SearchesStatus != input.SearchesStatus || (this.SearchesStatus != null && !this.SearchesStatus.Equals(input.SearchesStatus))) return false;
            if (this.SearchesRedirectionType != input.SearchesRedirectionType || (this.SearchesRedirectionType != null && !this.SearchesRedirectionType.Equals(input.SearchesRedirectionType))) return false;
            if (this.SearchesStoragePath != input.SearchesStoragePath || (this.SearchesStoragePath != null && !this.SearchesStoragePath.Equals(input.SearchesStoragePath))) return false;
            if (this.SearchesRelativePath != input.SearchesRelativePath || (this.SearchesRelativePath != null && !this.SearchesRelativePath.Equals(input.SearchesRelativePath))) return false;
            if (this.SearchesExclusiveRights != input.SearchesExclusiveRights || (this.SearchesExclusiveRights != null && !this.SearchesExclusiveRights.Equals(input.SearchesExclusiveRights))) return false;
            if (this.SearchesMoveContents != input.SearchesMoveContents || (this.SearchesMoveContents != null && !this.SearchesMoveContents.Equals(input.SearchesMoveContents))) return false;
            if (this.SearchesMoveContentOnPolicyRemoval != input.SearchesMoveContentOnPolicyRemoval || (this.SearchesMoveContentOnPolicyRemoval != null && !this.SearchesMoveContentOnPolicyRemoval.Equals(input.SearchesMoveContentOnPolicyRemoval))) return false;

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
                if (this.SearchesStatus != null) hashCode = hashCode * 59 + this.SearchesStatus.GetHashCode();
                if (this.SearchesRedirectionType != null) hashCode = hashCode * 59 + this.SearchesRedirectionType.GetHashCode();
                if (this.SearchesStoragePath != null) hashCode = hashCode * 59 + this.SearchesStoragePath.GetHashCode();
                if (this.SearchesRelativePath != null) hashCode = hashCode * 59 + this.SearchesRelativePath.GetHashCode();
                if (this.SearchesExclusiveRights != null) hashCode = hashCode * 59 + this.SearchesExclusiveRights.GetHashCode();
                if (this.SearchesMoveContents != null) hashCode = hashCode * 59 + this.SearchesMoveContents.GetHashCode();
                if (this.SearchesMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.SearchesMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
