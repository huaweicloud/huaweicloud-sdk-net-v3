using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 文件变更详情
    /// </summary>
    public class FileChangeDto 
    {

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 变更文件源分支路径
        /// </summary>
        [JsonProperty("old_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPath { get; set; }

        /// <summary>
        /// 变更文件目标分支路径
        /// </summary>
        [JsonProperty("new_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPath { get; set; }

        /// <summary>
        /// 旧文件权限
        /// </summary>
        [JsonProperty("a_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AMode { get; set; }

        /// <summary>
        /// 新文件权限
        /// </summary>
        [JsonProperty("b_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string BMode { get; set; }

        /// <summary>
        /// 文件权限是否变更
        /// </summary>
        [JsonProperty("mode_changed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModeChanged { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 是否为新增文件
        /// </summary>
        [JsonProperty("new_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewFile { get; set; }

        /// <summary>
        /// 是否为重命名文件
        /// </summary>
        [JsonProperty("renamed_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenamedFile { get; set; }

        /// <summary>
        /// 是否为删除文件
        /// </summary>
        [JsonProperty("deleted_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletedFile { get; set; }

        /// <summary>
        /// 变更文件内容
        /// </summary>
        [JsonProperty("diff", NullValueHandling = NullValueHandling.Ignore)]
        public string Diff { get; set; }

        /// <summary>
        /// 是否为二进制文件
        /// </summary>
        [JsonProperty("binary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Binary { get; set; }

        /// <summary>
        /// 是否为大文件
        /// </summary>
        [JsonProperty("too_large", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TooLarge { get; set; }

        /// <summary>
        /// 是否折叠文件
        /// </summary>
        [JsonProperty("collapsed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Collapsed { get; set; }

        /// <summary>
        /// 文件新增行
        /// </summary>
        [JsonProperty("added_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddedLines { get; set; }

        /// <summary>
        /// 文件删除行
        /// </summary>
        [JsonProperty("removed_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemovedLines { get; set; }

        /// <summary>
        /// 文件最新commitId
        /// </summary>
        [JsonProperty("content_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentSha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("diff_refs", NullValueHandling = NullValueHandling.Ignore)]
        public DiffRefDto DiffRefs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileChangeDto {\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  oldPath: ").Append(OldPath).Append("\n");
            sb.Append("  newPath: ").Append(NewPath).Append("\n");
            sb.Append("  aMode: ").Append(AMode).Append("\n");
            sb.Append("  bMode: ").Append(BMode).Append("\n");
            sb.Append("  modeChanged: ").Append(ModeChanged).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  newFile: ").Append(NewFile).Append("\n");
            sb.Append("  renamedFile: ").Append(RenamedFile).Append("\n");
            sb.Append("  deletedFile: ").Append(DeletedFile).Append("\n");
            sb.Append("  diff: ").Append(Diff).Append("\n");
            sb.Append("  binary: ").Append(Binary).Append("\n");
            sb.Append("  tooLarge: ").Append(TooLarge).Append("\n");
            sb.Append("  collapsed: ").Append(Collapsed).Append("\n");
            sb.Append("  addedLines: ").Append(AddedLines).Append("\n");
            sb.Append("  removedLines: ").Append(RemovedLines).Append("\n");
            sb.Append("  contentSha: ").Append(ContentSha).Append("\n");
            sb.Append("  diffRefs: ").Append(DiffRefs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileChangeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FileChangeDto input)
        {
            if (input == null) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.OldPath != input.OldPath || (this.OldPath != null && !this.OldPath.Equals(input.OldPath))) return false;
            if (this.NewPath != input.NewPath || (this.NewPath != null && !this.NewPath.Equals(input.NewPath))) return false;
            if (this.AMode != input.AMode || (this.AMode != null && !this.AMode.Equals(input.AMode))) return false;
            if (this.BMode != input.BMode || (this.BMode != null && !this.BMode.Equals(input.BMode))) return false;
            if (this.ModeChanged != input.ModeChanged || (this.ModeChanged != null && !this.ModeChanged.Equals(input.ModeChanged))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.NewFile != input.NewFile || (this.NewFile != null && !this.NewFile.Equals(input.NewFile))) return false;
            if (this.RenamedFile != input.RenamedFile || (this.RenamedFile != null && !this.RenamedFile.Equals(input.RenamedFile))) return false;
            if (this.DeletedFile != input.DeletedFile || (this.DeletedFile != null && !this.DeletedFile.Equals(input.DeletedFile))) return false;
            if (this.Diff != input.Diff || (this.Diff != null && !this.Diff.Equals(input.Diff))) return false;
            if (this.Binary != input.Binary || (this.Binary != null && !this.Binary.Equals(input.Binary))) return false;
            if (this.TooLarge != input.TooLarge || (this.TooLarge != null && !this.TooLarge.Equals(input.TooLarge))) return false;
            if (this.Collapsed != input.Collapsed || (this.Collapsed != null && !this.Collapsed.Equals(input.Collapsed))) return false;
            if (this.AddedLines != input.AddedLines || (this.AddedLines != null && !this.AddedLines.Equals(input.AddedLines))) return false;
            if (this.RemovedLines != input.RemovedLines || (this.RemovedLines != null && !this.RemovedLines.Equals(input.RemovedLines))) return false;
            if (this.ContentSha != input.ContentSha || (this.ContentSha != null && !this.ContentSha.Equals(input.ContentSha))) return false;
            if (this.DiffRefs != input.DiffRefs || (this.DiffRefs != null && !this.DiffRefs.Equals(input.DiffRefs))) return false;

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
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.OldPath != null) hashCode = hashCode * 59 + this.OldPath.GetHashCode();
                if (this.NewPath != null) hashCode = hashCode * 59 + this.NewPath.GetHashCode();
                if (this.AMode != null) hashCode = hashCode * 59 + this.AMode.GetHashCode();
                if (this.BMode != null) hashCode = hashCode * 59 + this.BMode.GetHashCode();
                if (this.ModeChanged != null) hashCode = hashCode * 59 + this.ModeChanged.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.NewFile != null) hashCode = hashCode * 59 + this.NewFile.GetHashCode();
                if (this.RenamedFile != null) hashCode = hashCode * 59 + this.RenamedFile.GetHashCode();
                if (this.DeletedFile != null) hashCode = hashCode * 59 + this.DeletedFile.GetHashCode();
                if (this.Diff != null) hashCode = hashCode * 59 + this.Diff.GetHashCode();
                if (this.Binary != null) hashCode = hashCode * 59 + this.Binary.GetHashCode();
                if (this.TooLarge != null) hashCode = hashCode * 59 + this.TooLarge.GetHashCode();
                if (this.Collapsed != null) hashCode = hashCode * 59 + this.Collapsed.GetHashCode();
                if (this.AddedLines != null) hashCode = hashCode * 59 + this.AddedLines.GetHashCode();
                if (this.RemovedLines != null) hashCode = hashCode * 59 + this.RemovedLines.GetHashCode();
                if (this.ContentSha != null) hashCode = hashCode * 59 + this.ContentSha.GetHashCode();
                if (this.DiffRefs != null) hashCode = hashCode * 59 + this.DiffRefs.GetHashCode();
                return hashCode;
            }
        }
    }
}
