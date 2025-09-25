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
    /// Response Object
    /// </summary>
    public class ShowCommitDiffMetadataResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 差异信息。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("diffs", NullValueHandling = NullValueHandling.Ignore)]
        public List<DiffDto> Diffs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("diff_refs", NullValueHandling = NullValueHandling.Ignore)]
        public DiffRefsDto DiffRefs { get; set; }

        /// <summary>
        /// **参数解释：** 增加行数。
        /// </summary>
        [JsonProperty("added_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddedLines { get; set; }

        /// <summary>
        /// **参数解释：** 删除行数。
        /// </summary>
        [JsonProperty("removed_lines", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemovedLines { get; set; }

        /// <summary>
        /// **参数解释：** 修改文件数量。
        /// </summary>
        [JsonProperty("change_file_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChangeFileCount { get; set; }

        /// <summary>
        /// **参数解释：** 改变行数数量。
        /// </summary>
        [JsonProperty("change_line_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChangeLineCount { get; set; }

        /// <summary>
        /// **参数解释：** 是否为大文件。 **取值范围：** - true，大文件。 - false，非大文件
        /// </summary>
        [JsonProperty("too_large", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TooLarge { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCommitDiffMetadataResponse {\n");
            sb.Append("  diffs: ").Append(Diffs).Append("\n");
            sb.Append("  diffRefs: ").Append(DiffRefs).Append("\n");
            sb.Append("  addedLines: ").Append(AddedLines).Append("\n");
            sb.Append("  removedLines: ").Append(RemovedLines).Append("\n");
            sb.Append("  changeFileCount: ").Append(ChangeFileCount).Append("\n");
            sb.Append("  changeLineCount: ").Append(ChangeLineCount).Append("\n");
            sb.Append("  tooLarge: ").Append(TooLarge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCommitDiffMetadataResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCommitDiffMetadataResponse input)
        {
            if (input == null) return false;
            if (this.Diffs != input.Diffs || (this.Diffs != null && input.Diffs != null && !this.Diffs.SequenceEqual(input.Diffs))) return false;
            if (this.DiffRefs != input.DiffRefs || (this.DiffRefs != null && !this.DiffRefs.Equals(input.DiffRefs))) return false;
            if (this.AddedLines != input.AddedLines || (this.AddedLines != null && !this.AddedLines.Equals(input.AddedLines))) return false;
            if (this.RemovedLines != input.RemovedLines || (this.RemovedLines != null && !this.RemovedLines.Equals(input.RemovedLines))) return false;
            if (this.ChangeFileCount != input.ChangeFileCount || (this.ChangeFileCount != null && !this.ChangeFileCount.Equals(input.ChangeFileCount))) return false;
            if (this.ChangeLineCount != input.ChangeLineCount || (this.ChangeLineCount != null && !this.ChangeLineCount.Equals(input.ChangeLineCount))) return false;
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
                if (this.Diffs != null) hashCode = hashCode * 59 + this.Diffs.GetHashCode();
                if (this.DiffRefs != null) hashCode = hashCode * 59 + this.DiffRefs.GetHashCode();
                if (this.AddedLines != null) hashCode = hashCode * 59 + this.AddedLines.GetHashCode();
                if (this.RemovedLines != null) hashCode = hashCode * 59 + this.RemovedLines.GetHashCode();
                if (this.ChangeFileCount != null) hashCode = hashCode * 59 + this.ChangeFileCount.GetHashCode();
                if (this.ChangeLineCount != null) hashCode = hashCode * 59 + this.ChangeLineCount.GetHashCode();
                if (this.TooLarge != null) hashCode = hashCode * 59 + this.TooLarge.GetHashCode();
                return hashCode;
            }
        }
    }
}
