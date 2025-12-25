using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepoFileDOV5 
    {

        /// <summary>
        /// **参数解释**: id。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**: 文件id。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// **参数解释**: 仓库id。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("repo_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoName { get; set; }

        /// <summary>
        /// **参数解释**: 项目名称。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// **参数解释**: 父级目录ID。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**: 文件名。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**: 文件名。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// **参数解释**: 文件类型, folder代表是目录,file代表文件。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**: 发布包状态 test为测试包 prod为发布包。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**: 文件扩展名。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("extension", NullValueHandling = NullValueHandling.Ignore)]
        public string Extension { get; set; }

        /// <summary>
        /// **参数解释**: 文件路径。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释**: 文件路径(含项目)。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("full_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FullPath { get; set; }

        /// <summary>
        /// **参数解释**: 文件大小,单位为byte。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// **参数解释**: md5校验和。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("md5", NullValueHandling = NullValueHandling.Ignore)]
        public string Md5 { get; set; }

        /// <summary>
        /// **参数解释**: sha256校验和。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("sha256", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha256 { get; set; }

        /// <summary>
        /// **参数解释**: 下载地址。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// **参数解释**: 带有id的下载地址。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("download_url_with_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrlWithId { get; set; }

        /// <summary>
        /// **参数解释**: 历史版本遗留字段，请忽略。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// **参数解释**: 判断当前文件或文件夹父目录是否为版本路径，即仓库下第一层子目录。 **取值范围**: - true：父目录是版本路径。 - false：父目录不是版本路径。 
        /// </summary>
        [JsonProperty("version_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VersionEnable { get; set; }

        /// <summary>
        /// **参数解释**: migrated_state。 **取值范围**: 该参数为内部数据改造参数，无业务含义，请忽略。 
        /// </summary>
        [JsonProperty("migrated_state", NullValueHandling = NullValueHandling.Ignore)]
        public int? MigratedState { get; set; }

        /// <summary>
        /// **参数解释**: 该参数无返回值，请忽略。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("upload_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UploadId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoFileDOV5 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  repoName: ").Append(RepoName).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  extension: ").Append(Extension).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  fullPath: ").Append(FullPath).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  md5: ").Append(Md5).Append("\n");
            sb.Append("  sha256: ").Append(Sha256).Append("\n");
            sb.Append("  downloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  downloadUrlWithId: ").Append(DownloadUrlWithId).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  versionEnable: ").Append(VersionEnable).Append("\n");
            sb.Append("  migratedState: ").Append(MigratedState).Append("\n");
            sb.Append("  uploadId: ").Append(UploadId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoFileDOV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoFileDOV5 input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.RepoName != input.RepoName || (this.RepoName != null && !this.RepoName.Equals(input.RepoName))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Extension != input.Extension || (this.Extension != null && !this.Extension.Equals(input.Extension))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.FullPath != input.FullPath || (this.FullPath != null && !this.FullPath.Equals(input.FullPath))) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Md5 != input.Md5 || (this.Md5 != null && !this.Md5.Equals(input.Md5))) return false;
            if (this.Sha256 != input.Sha256 || (this.Sha256 != null && !this.Sha256.Equals(input.Sha256))) return false;
            if (this.DownloadUrl != input.DownloadUrl || (this.DownloadUrl != null && !this.DownloadUrl.Equals(input.DownloadUrl))) return false;
            if (this.DownloadUrlWithId != input.DownloadUrlWithId || (this.DownloadUrlWithId != null && !this.DownloadUrlWithId.Equals(input.DownloadUrlWithId))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.VersionEnable != input.VersionEnable || (this.VersionEnable != null && !this.VersionEnable.Equals(input.VersionEnable))) return false;
            if (this.MigratedState != input.MigratedState || (this.MigratedState != null && !this.MigratedState.Equals(input.MigratedState))) return false;
            if (this.UploadId != input.UploadId || (this.UploadId != null && !this.UploadId.Equals(input.UploadId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.RepoName != null) hashCode = hashCode * 59 + this.RepoName.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Extension != null) hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.FullPath != null) hashCode = hashCode * 59 + this.FullPath.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Md5 != null) hashCode = hashCode * 59 + this.Md5.GetHashCode();
                if (this.Sha256 != null) hashCode = hashCode * 59 + this.Sha256.GetHashCode();
                if (this.DownloadUrl != null) hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                if (this.DownloadUrlWithId != null) hashCode = hashCode * 59 + this.DownloadUrlWithId.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.VersionEnable != null) hashCode = hashCode * 59 + this.VersionEnable.GetHashCode();
                if (this.MigratedState != null) hashCode = hashCode * 59 + this.MigratedState.GetHashCode();
                if (this.UploadId != null) hashCode = hashCode * 59 + this.UploadId.GetHashCode();
                return hashCode;
            }
        }
    }
}
