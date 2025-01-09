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
    /// 用户文件夹重定向选项。
    /// </summary>
    public class PoliciesPersonalizedDataMgmtUserFolderRedirectionOptions 
    {

        /// <summary>
        /// 还原本地目录启用
        /// </summary>
        [JsonProperty("restore_local_directories_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestoreLocalDirectoriesEnable { get; set; }

        /// <summary>
        /// 应用数据漫游启用
        /// </summary>
        [JsonProperty("appData_roaming_enale", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppDataRoamingEnale { get; set; }

        /// <summary>
        /// 桌面重定向
        /// </summary>
        [JsonProperty("redirec_desktop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecDesktop { get; set; }

        /// <summary>
        /// 开始菜单
        /// </summary>
        [JsonProperty("redirec_start_menu", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecStartMenu { get; set; }

        /// <summary>
        /// 文档
        /// </summary>
        [JsonProperty("redirec_documents", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecDocuments { get; set; }

        /// <summary>
        /// 照片
        /// </summary>
        [JsonProperty("redirec_pictures", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecPictures { get; set; }

        /// <summary>
        /// 音乐
        /// </summary>
        [JsonProperty("redirec_music", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecMusic { get; set; }

        /// <summary>
        /// 录音
        /// </summary>
        [JsonProperty("redirec_videos", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecVideos { get; set; }

        /// <summary>
        /// 最爱
        /// </summary>
        [JsonProperty("redirec_favorites", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecFavorites { get; set; }

        /// <summary>
        /// 录音
        /// </summary>
        [JsonProperty("redirec_contacts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecContacts { get; set; }

        /// <summary>
        /// 下载
        /// </summary>
        [JsonProperty("redirec_downloads", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecDownloads { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        [JsonProperty("redirec_links", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecLinks { get; set; }

        /// <summary>
        /// 查找
        /// </summary>
        [JsonProperty("redirec_searches", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecSearches { get; set; }

        /// <summary>
        /// 游戏存储
        /// </summary>
        [JsonProperty("redirec_saved_games", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RedirecSavedGames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesPersonalizedDataMgmtUserFolderRedirectionOptions {\n");
            sb.Append("  restoreLocalDirectoriesEnable: ").Append(RestoreLocalDirectoriesEnable).Append("\n");
            sb.Append("  appDataRoamingEnale: ").Append(AppDataRoamingEnale).Append("\n");
            sb.Append("  redirecDesktop: ").Append(RedirecDesktop).Append("\n");
            sb.Append("  redirecStartMenu: ").Append(RedirecStartMenu).Append("\n");
            sb.Append("  redirecDocuments: ").Append(RedirecDocuments).Append("\n");
            sb.Append("  redirecPictures: ").Append(RedirecPictures).Append("\n");
            sb.Append("  redirecMusic: ").Append(RedirecMusic).Append("\n");
            sb.Append("  redirecVideos: ").Append(RedirecVideos).Append("\n");
            sb.Append("  redirecFavorites: ").Append(RedirecFavorites).Append("\n");
            sb.Append("  redirecContacts: ").Append(RedirecContacts).Append("\n");
            sb.Append("  redirecDownloads: ").Append(RedirecDownloads).Append("\n");
            sb.Append("  redirecLinks: ").Append(RedirecLinks).Append("\n");
            sb.Append("  redirecSearches: ").Append(RedirecSearches).Append("\n");
            sb.Append("  redirecSavedGames: ").Append(RedirecSavedGames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesPersonalizedDataMgmtUserFolderRedirectionOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesPersonalizedDataMgmtUserFolderRedirectionOptions input)
        {
            if (input == null) return false;
            if (this.RestoreLocalDirectoriesEnable != input.RestoreLocalDirectoriesEnable || (this.RestoreLocalDirectoriesEnable != null && !this.RestoreLocalDirectoriesEnable.Equals(input.RestoreLocalDirectoriesEnable))) return false;
            if (this.AppDataRoamingEnale != input.AppDataRoamingEnale || (this.AppDataRoamingEnale != null && !this.AppDataRoamingEnale.Equals(input.AppDataRoamingEnale))) return false;
            if (this.RedirecDesktop != input.RedirecDesktop || (this.RedirecDesktop != null && !this.RedirecDesktop.Equals(input.RedirecDesktop))) return false;
            if (this.RedirecStartMenu != input.RedirecStartMenu || (this.RedirecStartMenu != null && !this.RedirecStartMenu.Equals(input.RedirecStartMenu))) return false;
            if (this.RedirecDocuments != input.RedirecDocuments || (this.RedirecDocuments != null && !this.RedirecDocuments.Equals(input.RedirecDocuments))) return false;
            if (this.RedirecPictures != input.RedirecPictures || (this.RedirecPictures != null && !this.RedirecPictures.Equals(input.RedirecPictures))) return false;
            if (this.RedirecMusic != input.RedirecMusic || (this.RedirecMusic != null && !this.RedirecMusic.Equals(input.RedirecMusic))) return false;
            if (this.RedirecVideos != input.RedirecVideos || (this.RedirecVideos != null && !this.RedirecVideos.Equals(input.RedirecVideos))) return false;
            if (this.RedirecFavorites != input.RedirecFavorites || (this.RedirecFavorites != null && !this.RedirecFavorites.Equals(input.RedirecFavorites))) return false;
            if (this.RedirecContacts != input.RedirecContacts || (this.RedirecContacts != null && !this.RedirecContacts.Equals(input.RedirecContacts))) return false;
            if (this.RedirecDownloads != input.RedirecDownloads || (this.RedirecDownloads != null && !this.RedirecDownloads.Equals(input.RedirecDownloads))) return false;
            if (this.RedirecLinks != input.RedirecLinks || (this.RedirecLinks != null && !this.RedirecLinks.Equals(input.RedirecLinks))) return false;
            if (this.RedirecSearches != input.RedirecSearches || (this.RedirecSearches != null && !this.RedirecSearches.Equals(input.RedirecSearches))) return false;
            if (this.RedirecSavedGames != input.RedirecSavedGames || (this.RedirecSavedGames != null && !this.RedirecSavedGames.Equals(input.RedirecSavedGames))) return false;

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
                if (this.RestoreLocalDirectoriesEnable != null) hashCode = hashCode * 59 + this.RestoreLocalDirectoriesEnable.GetHashCode();
                if (this.AppDataRoamingEnale != null) hashCode = hashCode * 59 + this.AppDataRoamingEnale.GetHashCode();
                if (this.RedirecDesktop != null) hashCode = hashCode * 59 + this.RedirecDesktop.GetHashCode();
                if (this.RedirecStartMenu != null) hashCode = hashCode * 59 + this.RedirecStartMenu.GetHashCode();
                if (this.RedirecDocuments != null) hashCode = hashCode * 59 + this.RedirecDocuments.GetHashCode();
                if (this.RedirecPictures != null) hashCode = hashCode * 59 + this.RedirecPictures.GetHashCode();
                if (this.RedirecMusic != null) hashCode = hashCode * 59 + this.RedirecMusic.GetHashCode();
                if (this.RedirecVideos != null) hashCode = hashCode * 59 + this.RedirecVideos.GetHashCode();
                if (this.RedirecFavorites != null) hashCode = hashCode * 59 + this.RedirecFavorites.GetHashCode();
                if (this.RedirecContacts != null) hashCode = hashCode * 59 + this.RedirecContacts.GetHashCode();
                if (this.RedirecDownloads != null) hashCode = hashCode * 59 + this.RedirecDownloads.GetHashCode();
                if (this.RedirecLinks != null) hashCode = hashCode * 59 + this.RedirecLinks.GetHashCode();
                if (this.RedirecSearches != null) hashCode = hashCode * 59 + this.RedirecSearches.GetHashCode();
                if (this.RedirecSavedGames != null) hashCode = hashCode * 59 + this.RedirecSavedGames.GetHashCode();
                return hashCode;
            }
        }
    }
}
