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
    /// Response Object
    /// </summary>
    public class ListFoldersAndFilesResponse : SdkResponse
    {

        /// <summary>
        /// 文件系统所在区域代号。
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// 文件名的绝对路径的前缀。
        /// </summary>
        [JsonProperty("prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string Prefix { get; set; }

        /// <summary>
        /// 文件信息列表。
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<FileInfo> Files { get; set; }

        /// <summary>
        /// 文件夹信息列表。
        /// </summary>
        [JsonProperty("folders", NullValueHandling = NullValueHandling.Ignore)]
        public List<FolderInfo> Folders { get; set; }

        /// <summary>
        /// 本次列举的文件的起始位置，默认为空。
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 下次列举请求的的起始位置，默认为空。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 本次列举可以返回的最大文件数量，非本次列举返回的数量，取入参与系统默认值的小值为准。
        /// </summary>
        [JsonProperty("max_keys", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFoldersAndFilesResponse {\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  prefix: ").Append(Prefix).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("  folders: ").Append(Folders).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("  maxKeys: ").Append(MaxKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFoldersAndFilesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFoldersAndFilesResponse input)
        {
            if (input == null) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.Prefix != input.Prefix || (this.Prefix != null && !this.Prefix.Equals(input.Prefix))) return false;
            if (this.Files != input.Files || (this.Files != null && input.Files != null && !this.Files.SequenceEqual(input.Files))) return false;
            if (this.Folders != input.Folders || (this.Folders != null && input.Folders != null && !this.Folders.SequenceEqual(input.Folders))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.NextMarker != input.NextMarker || (this.NextMarker != null && !this.NextMarker.Equals(input.NextMarker))) return false;
            if (this.MaxKeys != input.MaxKeys || (this.MaxKeys != null && !this.MaxKeys.Equals(input.MaxKeys))) return false;

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
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.Prefix != null) hashCode = hashCode * 59 + this.Prefix.GetHashCode();
                if (this.Files != null) hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.Folders != null) hashCode = hashCode * 59 + this.Folders.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.MaxKeys != null) hashCode = hashCode * 59 + this.MaxKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
