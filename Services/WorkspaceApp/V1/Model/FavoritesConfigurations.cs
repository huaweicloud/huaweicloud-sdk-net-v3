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
    /// “收藏夹”文件夹重定向配置
    /// </summary>
    public class FavoritesConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("favorites_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? FavoritesStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("favorites_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? FavoritesRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("favorites_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FavoritesStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("favorites_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FavoritesRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("favorites_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? FavoritesExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("favorites_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? FavoritesMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("favorites_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? FavoritesMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FavoritesConfigurations {\n");
            sb.Append("  favoritesStatus: ").Append(FavoritesStatus).Append("\n");
            sb.Append("  favoritesRedirectionType: ").Append(FavoritesRedirectionType).Append("\n");
            sb.Append("  favoritesStoragePath: ").Append(FavoritesStoragePath).Append("\n");
            sb.Append("  favoritesRelativePath: ").Append(FavoritesRelativePath).Append("\n");
            sb.Append("  favoritesExclusiveRights: ").Append(FavoritesExclusiveRights).Append("\n");
            sb.Append("  favoritesMoveContents: ").Append(FavoritesMoveContents).Append("\n");
            sb.Append("  favoritesMoveContentOnPolicyRemoval: ").Append(FavoritesMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FavoritesConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FavoritesConfigurations input)
        {
            if (input == null) return false;
            if (this.FavoritesStatus != input.FavoritesStatus || (this.FavoritesStatus != null && !this.FavoritesStatus.Equals(input.FavoritesStatus))) return false;
            if (this.FavoritesRedirectionType != input.FavoritesRedirectionType || (this.FavoritesRedirectionType != null && !this.FavoritesRedirectionType.Equals(input.FavoritesRedirectionType))) return false;
            if (this.FavoritesStoragePath != input.FavoritesStoragePath || (this.FavoritesStoragePath != null && !this.FavoritesStoragePath.Equals(input.FavoritesStoragePath))) return false;
            if (this.FavoritesRelativePath != input.FavoritesRelativePath || (this.FavoritesRelativePath != null && !this.FavoritesRelativePath.Equals(input.FavoritesRelativePath))) return false;
            if (this.FavoritesExclusiveRights != input.FavoritesExclusiveRights || (this.FavoritesExclusiveRights != null && !this.FavoritesExclusiveRights.Equals(input.FavoritesExclusiveRights))) return false;
            if (this.FavoritesMoveContents != input.FavoritesMoveContents || (this.FavoritesMoveContents != null && !this.FavoritesMoveContents.Equals(input.FavoritesMoveContents))) return false;
            if (this.FavoritesMoveContentOnPolicyRemoval != input.FavoritesMoveContentOnPolicyRemoval || (this.FavoritesMoveContentOnPolicyRemoval != null && !this.FavoritesMoveContentOnPolicyRemoval.Equals(input.FavoritesMoveContentOnPolicyRemoval))) return false;

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
                if (this.FavoritesStatus != null) hashCode = hashCode * 59 + this.FavoritesStatus.GetHashCode();
                if (this.FavoritesRedirectionType != null) hashCode = hashCode * 59 + this.FavoritesRedirectionType.GetHashCode();
                if (this.FavoritesStoragePath != null) hashCode = hashCode * 59 + this.FavoritesStoragePath.GetHashCode();
                if (this.FavoritesRelativePath != null) hashCode = hashCode * 59 + this.FavoritesRelativePath.GetHashCode();
                if (this.FavoritesExclusiveRights != null) hashCode = hashCode * 59 + this.FavoritesExclusiveRights.GetHashCode();
                if (this.FavoritesMoveContents != null) hashCode = hashCode * 59 + this.FavoritesMoveContents.GetHashCode();
                if (this.FavoritesMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.FavoritesMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
