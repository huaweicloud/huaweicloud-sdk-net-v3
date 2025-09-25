using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeRequestDiffFileDto 
    {

        /// <summary>
        /// 合并请求head sha
        /// </summary>
        [JsonProperty("content_sha", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentSha { get; set; }

        /// <summary>
        /// 是否为submodule
        /// </summary>
        [JsonProperty("submodule", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Submodule { get; set; }

        /// <summary>
        /// 内容是否扩展
        /// </summary>
        [JsonProperty("expanded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expanded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("diff_refs", NullValueHandling = NullValueHandling.Ignore)]
        public DiffRefsDto DiffRefs { get; set; }

        /// <summary>
        /// mode是否修改
        /// </summary>
        [JsonProperty("mode_changed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModeChanged { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 旧路径
        /// </summary>
        [JsonProperty("old_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPath { get; set; }

        /// <summary>
        /// 新路径
        /// </summary>
        [JsonProperty("new_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPath { get; set; }

        /// <summary>
        /// 旧mode
        /// </summary>
        [JsonProperty("a_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AMode { get; set; }

        /// <summary>
        /// 新mode
        /// </summary>
        [JsonProperty("b_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string BMode { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

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
        /// 文件变更内容
        /// </summary>
        [JsonProperty("diff", NullValueHandling = NullValueHandling.Ignore)]
        public string Diff { get; set; }

        /// <summary>
        /// 是否为二进制文件
        /// </summary>
        [JsonProperty("binary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Binary { get; set; }

        /// <summary>
        /// 是否过大
        /// </summary>
        [JsonProperty("too_large", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TooLarge { get; set; }

        /// <summary>
        /// 是否折叠
        /// </summary>
        [JsonProperty("collapsed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Collapsed { get; set; }

        /// <summary>
        /// 单个文件可取行数范围
        /// </summary>
        [JsonProperty("line_count", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> LineCount { get; set; }

        /// <summary>
        /// 新增行数
        /// </summary>
        [JsonProperty("added_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddedLines { get; set; }

        /// <summary>
        /// 删除行数
        /// </summary>
        [JsonProperty("removed_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemovedLines { get; set; }

        /// <summary>
        /// 文件blob_id
        /// </summary>
        [JsonProperty("blob_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeRequestDiffFileDto {\n");
            sb.Append("  contentSha: ").Append(ContentSha).Append("\n");
            sb.Append("  submodule: ").Append(Submodule).Append("\n");
            sb.Append("  expanded: ").Append(Expanded).Append("\n");
            sb.Append("  diffRefs: ").Append(DiffRefs).Append("\n");
            sb.Append("  modeChanged: ").Append(ModeChanged).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  oldPath: ").Append(OldPath).Append("\n");
            sb.Append("  newPath: ").Append(NewPath).Append("\n");
            sb.Append("  aMode: ").Append(AMode).Append("\n");
            sb.Append("  bMode: ").Append(BMode).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  newFile: ").Append(NewFile).Append("\n");
            sb.Append("  renamedFile: ").Append(RenamedFile).Append("\n");
            sb.Append("  deletedFile: ").Append(DeletedFile).Append("\n");
            sb.Append("  diff: ").Append(Diff).Append("\n");
            sb.Append("  binary: ").Append(Binary).Append("\n");
            sb.Append("  tooLarge: ").Append(TooLarge).Append("\n");
            sb.Append("  collapsed: ").Append(Collapsed).Append("\n");
            sb.Append("  lineCount: ").Append(LineCount).Append("\n");
            sb.Append("  addedLines: ").Append(AddedLines).Append("\n");
            sb.Append("  removedLines: ").Append(RemovedLines).Append("\n");
            sb.Append("  blobId: ").Append(BlobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeRequestDiffFileDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeRequestDiffFileDto input)
        {
            if (input == null) return false;
            if (this.ContentSha != input.ContentSha || (this.ContentSha != null && !this.ContentSha.Equals(input.ContentSha))) return false;
            if (this.Submodule != input.Submodule || (this.Submodule != null && !this.Submodule.Equals(input.Submodule))) return false;
            if (this.Expanded != input.Expanded || (this.Expanded != null && !this.Expanded.Equals(input.Expanded))) return false;
            if (this.DiffRefs != input.DiffRefs || (this.DiffRefs != null && !this.DiffRefs.Equals(input.DiffRefs))) return false;
            if (this.ModeChanged != input.ModeChanged || (this.ModeChanged != null && !this.ModeChanged.Equals(input.ModeChanged))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.OldPath != input.OldPath || (this.OldPath != null && !this.OldPath.Equals(input.OldPath))) return false;
            if (this.NewPath != input.NewPath || (this.NewPath != null && !this.NewPath.Equals(input.NewPath))) return false;
            if (this.AMode != input.AMode || (this.AMode != null && !this.AMode.Equals(input.AMode))) return false;
            if (this.BMode != input.BMode || (this.BMode != null && !this.BMode.Equals(input.BMode))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.NewFile != input.NewFile || (this.NewFile != null && !this.NewFile.Equals(input.NewFile))) return false;
            if (this.RenamedFile != input.RenamedFile || (this.RenamedFile != null && !this.RenamedFile.Equals(input.RenamedFile))) return false;
            if (this.DeletedFile != input.DeletedFile || (this.DeletedFile != null && !this.DeletedFile.Equals(input.DeletedFile))) return false;
            if (this.Diff != input.Diff || (this.Diff != null && !this.Diff.Equals(input.Diff))) return false;
            if (this.Binary != input.Binary || (this.Binary != null && !this.Binary.Equals(input.Binary))) return false;
            if (this.TooLarge != input.TooLarge || (this.TooLarge != null && !this.TooLarge.Equals(input.TooLarge))) return false;
            if (this.Collapsed != input.Collapsed || (this.Collapsed != null && !this.Collapsed.Equals(input.Collapsed))) return false;
            if (this.LineCount != input.LineCount || (this.LineCount != null && input.LineCount != null && !this.LineCount.SequenceEqual(input.LineCount))) return false;
            if (this.AddedLines != input.AddedLines || (this.AddedLines != null && !this.AddedLines.Equals(input.AddedLines))) return false;
            if (this.RemovedLines != input.RemovedLines || (this.RemovedLines != null && !this.RemovedLines.Equals(input.RemovedLines))) return false;
            if (this.BlobId != input.BlobId || (this.BlobId != null && !this.BlobId.Equals(input.BlobId))) return false;

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
                if (this.ContentSha != null) hashCode = hashCode * 59 + this.ContentSha.GetHashCode();
                if (this.Submodule != null) hashCode = hashCode * 59 + this.Submodule.GetHashCode();
                if (this.Expanded != null) hashCode = hashCode * 59 + this.Expanded.GetHashCode();
                if (this.DiffRefs != null) hashCode = hashCode * 59 + this.DiffRefs.GetHashCode();
                if (this.ModeChanged != null) hashCode = hashCode * 59 + this.ModeChanged.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.OldPath != null) hashCode = hashCode * 59 + this.OldPath.GetHashCode();
                if (this.NewPath != null) hashCode = hashCode * 59 + this.NewPath.GetHashCode();
                if (this.AMode != null) hashCode = hashCode * 59 + this.AMode.GetHashCode();
                if (this.BMode != null) hashCode = hashCode * 59 + this.BMode.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.NewFile != null) hashCode = hashCode * 59 + this.NewFile.GetHashCode();
                if (this.RenamedFile != null) hashCode = hashCode * 59 + this.RenamedFile.GetHashCode();
                if (this.DeletedFile != null) hashCode = hashCode * 59 + this.DeletedFile.GetHashCode();
                if (this.Diff != null) hashCode = hashCode * 59 + this.Diff.GetHashCode();
                if (this.Binary != null) hashCode = hashCode * 59 + this.Binary.GetHashCode();
                if (this.TooLarge != null) hashCode = hashCode * 59 + this.TooLarge.GetHashCode();
                if (this.Collapsed != null) hashCode = hashCode * 59 + this.Collapsed.GetHashCode();
                if (this.LineCount != null) hashCode = hashCode * 59 + this.LineCount.GetHashCode();
                if (this.AddedLines != null) hashCode = hashCode * 59 + this.AddedLines.GetHashCode();
                if (this.RemovedLines != null) hashCode = hashCode * 59 + this.RemovedLines.GetHashCode();
                if (this.BlobId != null) hashCode = hashCode * 59 + this.BlobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
