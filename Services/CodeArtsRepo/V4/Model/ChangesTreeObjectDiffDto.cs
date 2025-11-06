using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangesTreeObjectDiffDto 
    {

        /// <summary>
        /// **参数解释：** 变更内容。
        /// </summary>
        [JsonProperty("diff", NullValueHandling = NullValueHandling.Ignore)]
        public string Diff { get; set; }

        /// <summary>
        /// **参数解释：** 变更新路径。
        /// </summary>
        [JsonProperty("new_path", NullValueHandling = NullValueHandling.Ignore)]
        public string NewPath { get; set; }

        /// <summary>
        /// **参数解释：** 变更旧。
        /// </summary>
        [JsonProperty("old_path", NullValueHandling = NullValueHandling.Ignore)]
        public string OldPath { get; set; }

        /// <summary>
        /// **参数解释：** 旧文件权限。
        /// </summary>
        [JsonProperty("a_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AMode { get; set; }

        /// <summary>
        /// **参数解释：** 新文件权限。
        /// </summary>
        [JsonProperty("b_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string BMode { get; set; }

        /// <summary>
        /// **参数解释：** 是否是新文件。
        /// </summary>
        [JsonProperty("new_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewFile { get; set; }

        /// <summary>
        /// **参数解释：** 是否是改名文件。
        /// </summary>
        [JsonProperty("renamed_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RenamedFile { get; set; }

        /// <summary>
        /// **参数解释：** 是否是删除文件。
        /// </summary>
        [JsonProperty("deleted_file", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletedFile { get; set; }

        /// <summary>
        /// **参数解释：** 是否内容过长。
        /// </summary>
        [JsonProperty("too_large", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TooLarge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangesTreeObjectDiffDto {\n");
            sb.Append("  diff: ").Append(Diff).Append("\n");
            sb.Append("  newPath: ").Append(NewPath).Append("\n");
            sb.Append("  oldPath: ").Append(OldPath).Append("\n");
            sb.Append("  aMode: ").Append(AMode).Append("\n");
            sb.Append("  bMode: ").Append(BMode).Append("\n");
            sb.Append("  newFile: ").Append(NewFile).Append("\n");
            sb.Append("  renamedFile: ").Append(RenamedFile).Append("\n");
            sb.Append("  deletedFile: ").Append(DeletedFile).Append("\n");
            sb.Append("  tooLarge: ").Append(TooLarge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangesTreeObjectDiffDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangesTreeObjectDiffDto input)
        {
            if (input == null) return false;
            if (this.Diff != input.Diff || (this.Diff != null && !this.Diff.Equals(input.Diff))) return false;
            if (this.NewPath != input.NewPath || (this.NewPath != null && !this.NewPath.Equals(input.NewPath))) return false;
            if (this.OldPath != input.OldPath || (this.OldPath != null && !this.OldPath.Equals(input.OldPath))) return false;
            if (this.AMode != input.AMode || (this.AMode != null && !this.AMode.Equals(input.AMode))) return false;
            if (this.BMode != input.BMode || (this.BMode != null && !this.BMode.Equals(input.BMode))) return false;
            if (this.NewFile != input.NewFile || (this.NewFile != null && !this.NewFile.Equals(input.NewFile))) return false;
            if (this.RenamedFile != input.RenamedFile || (this.RenamedFile != null && !this.RenamedFile.Equals(input.RenamedFile))) return false;
            if (this.DeletedFile != input.DeletedFile || (this.DeletedFile != null && !this.DeletedFile.Equals(input.DeletedFile))) return false;
            if (this.TooLarge != input.TooLarge || (this.TooLarge != null && !this.TooLarge.Equals(input.TooLarge))) return false;

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
                if (this.Diff != null) hashCode = hashCode * 59 + this.Diff.GetHashCode();
                if (this.NewPath != null) hashCode = hashCode * 59 + this.NewPath.GetHashCode();
                if (this.OldPath != null) hashCode = hashCode * 59 + this.OldPath.GetHashCode();
                if (this.AMode != null) hashCode = hashCode * 59 + this.AMode.GetHashCode();
                if (this.BMode != null) hashCode = hashCode * 59 + this.BMode.GetHashCode();
                if (this.NewFile != null) hashCode = hashCode * 59 + this.NewFile.GetHashCode();
                if (this.RenamedFile != null) hashCode = hashCode * 59 + this.RenamedFile.GetHashCode();
                if (this.DeletedFile != null) hashCode = hashCode * 59 + this.DeletedFile.GetHashCode();
                if (this.TooLarge != null) hashCode = hashCode * 59 + this.TooLarge.GetHashCode();
                return hashCode;
            }
        }
    }
}
