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
    /// 文件夹重定向配置(v2)。
    /// </summary>
    public class FolderRedirectionV2Options 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_data_roaming_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public AppDataRoamingConfigurations AppDataRoamingConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("desktop_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public DesktopConfigurations DesktopConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("start_menu_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public StartMenuConfigurations StartMenuConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("documents_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public DocumentsConfigurations DocumentsConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pictures_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public PicturesConfigurations PicturesConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("music_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public MusicConfigurations MusicConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("videos_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public VideosConfigurations VideosConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("favorites_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public FavoritesConfigurations FavoritesConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contacts_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public ContactsConfigurations ContactsConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("downloads_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public DownloadsConfigurations DownloadsConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public LinksConfigurations LinksConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("searches_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public SearchesConfigurations SearchesConfigurations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("saved_games_configurations", NullValueHandling = NullValueHandling.Ignore)]
        public SavedGamesConfigurations SavedGamesConfigurations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderRedirectionV2Options {\n");
            sb.Append("  appDataRoamingConfigurations: ").Append(AppDataRoamingConfigurations).Append("\n");
            sb.Append("  desktopConfigurations: ").Append(DesktopConfigurations).Append("\n");
            sb.Append("  startMenuConfigurations: ").Append(StartMenuConfigurations).Append("\n");
            sb.Append("  documentsConfigurations: ").Append(DocumentsConfigurations).Append("\n");
            sb.Append("  picturesConfigurations: ").Append(PicturesConfigurations).Append("\n");
            sb.Append("  musicConfigurations: ").Append(MusicConfigurations).Append("\n");
            sb.Append("  videosConfigurations: ").Append(VideosConfigurations).Append("\n");
            sb.Append("  favoritesConfigurations: ").Append(FavoritesConfigurations).Append("\n");
            sb.Append("  contactsConfigurations: ").Append(ContactsConfigurations).Append("\n");
            sb.Append("  downloadsConfigurations: ").Append(DownloadsConfigurations).Append("\n");
            sb.Append("  linksConfigurations: ").Append(LinksConfigurations).Append("\n");
            sb.Append("  searchesConfigurations: ").Append(SearchesConfigurations).Append("\n");
            sb.Append("  savedGamesConfigurations: ").Append(SavedGamesConfigurations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FolderRedirectionV2Options);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FolderRedirectionV2Options input)
        {
            if (input == null) return false;
            if (this.AppDataRoamingConfigurations != input.AppDataRoamingConfigurations || (this.AppDataRoamingConfigurations != null && !this.AppDataRoamingConfigurations.Equals(input.AppDataRoamingConfigurations))) return false;
            if (this.DesktopConfigurations != input.DesktopConfigurations || (this.DesktopConfigurations != null && !this.DesktopConfigurations.Equals(input.DesktopConfigurations))) return false;
            if (this.StartMenuConfigurations != input.StartMenuConfigurations || (this.StartMenuConfigurations != null && !this.StartMenuConfigurations.Equals(input.StartMenuConfigurations))) return false;
            if (this.DocumentsConfigurations != input.DocumentsConfigurations || (this.DocumentsConfigurations != null && !this.DocumentsConfigurations.Equals(input.DocumentsConfigurations))) return false;
            if (this.PicturesConfigurations != input.PicturesConfigurations || (this.PicturesConfigurations != null && !this.PicturesConfigurations.Equals(input.PicturesConfigurations))) return false;
            if (this.MusicConfigurations != input.MusicConfigurations || (this.MusicConfigurations != null && !this.MusicConfigurations.Equals(input.MusicConfigurations))) return false;
            if (this.VideosConfigurations != input.VideosConfigurations || (this.VideosConfigurations != null && !this.VideosConfigurations.Equals(input.VideosConfigurations))) return false;
            if (this.FavoritesConfigurations != input.FavoritesConfigurations || (this.FavoritesConfigurations != null && !this.FavoritesConfigurations.Equals(input.FavoritesConfigurations))) return false;
            if (this.ContactsConfigurations != input.ContactsConfigurations || (this.ContactsConfigurations != null && !this.ContactsConfigurations.Equals(input.ContactsConfigurations))) return false;
            if (this.DownloadsConfigurations != input.DownloadsConfigurations || (this.DownloadsConfigurations != null && !this.DownloadsConfigurations.Equals(input.DownloadsConfigurations))) return false;
            if (this.LinksConfigurations != input.LinksConfigurations || (this.LinksConfigurations != null && !this.LinksConfigurations.Equals(input.LinksConfigurations))) return false;
            if (this.SearchesConfigurations != input.SearchesConfigurations || (this.SearchesConfigurations != null && !this.SearchesConfigurations.Equals(input.SearchesConfigurations))) return false;
            if (this.SavedGamesConfigurations != input.SavedGamesConfigurations || (this.SavedGamesConfigurations != null && !this.SavedGamesConfigurations.Equals(input.SavedGamesConfigurations))) return false;

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
                if (this.AppDataRoamingConfigurations != null) hashCode = hashCode * 59 + this.AppDataRoamingConfigurations.GetHashCode();
                if (this.DesktopConfigurations != null) hashCode = hashCode * 59 + this.DesktopConfigurations.GetHashCode();
                if (this.StartMenuConfigurations != null) hashCode = hashCode * 59 + this.StartMenuConfigurations.GetHashCode();
                if (this.DocumentsConfigurations != null) hashCode = hashCode * 59 + this.DocumentsConfigurations.GetHashCode();
                if (this.PicturesConfigurations != null) hashCode = hashCode * 59 + this.PicturesConfigurations.GetHashCode();
                if (this.MusicConfigurations != null) hashCode = hashCode * 59 + this.MusicConfigurations.GetHashCode();
                if (this.VideosConfigurations != null) hashCode = hashCode * 59 + this.VideosConfigurations.GetHashCode();
                if (this.FavoritesConfigurations != null) hashCode = hashCode * 59 + this.FavoritesConfigurations.GetHashCode();
                if (this.ContactsConfigurations != null) hashCode = hashCode * 59 + this.ContactsConfigurations.GetHashCode();
                if (this.DownloadsConfigurations != null) hashCode = hashCode * 59 + this.DownloadsConfigurations.GetHashCode();
                if (this.LinksConfigurations != null) hashCode = hashCode * 59 + this.LinksConfigurations.GetHashCode();
                if (this.SearchesConfigurations != null) hashCode = hashCode * 59 + this.SearchesConfigurations.GetHashCode();
                if (this.SavedGamesConfigurations != null) hashCode = hashCode * 59 + this.SavedGamesConfigurations.GetHashCode();
                return hashCode;
            }
        }
    }
}
