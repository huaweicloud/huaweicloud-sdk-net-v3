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
    /// **参数解释：** 代码导航定义相关信息
    /// </summary>
    public class RefEntryDto 
    {

        /// <summary>
        /// **参数解释：** 标记名称。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("tag_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TagName { get; set; }

        /// <summary>
        /// **参数解释：** 文件路径。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// **参数解释：** blob文件ID。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("blob", NullValueHandling = NullValueHandling.Ignore)]
        public string Blob { get; set; }

        /// <summary>
        /// **参数解释：** 索引行简要内容。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("line_image", NullValueHandling = NullValueHandling.Ignore)]
        public string LineImage { get; set; }

        /// <summary>
        /// **参数解释：** 行号。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("line_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// **参数解释：** 语法类型。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("syntax_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SyntaxType { get; set; }

        /// <summary>
        /// **参数解释：** 所在版本号（commit id）。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("revision", NullValueHandling = NullValueHandling.Ignore)]
        public string Revision { get; set; }

        /// <summary>
        /// **参数解释：** 其他信息。 **约束限制：** 不涉及。    
        /// </summary>
        [JsonProperty("extend", NullValueHandling = NullValueHandling.Ignore)]
        public string Extend { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefEntryDto {\n");
            sb.Append("  tagName: ").Append(TagName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  blob: ").Append(Blob).Append("\n");
            sb.Append("  lineImage: ").Append(LineImage).Append("\n");
            sb.Append("  lineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  syntaxType: ").Append(SyntaxType).Append("\n");
            sb.Append("  revision: ").Append(Revision).Append("\n");
            sb.Append("  extend: ").Append(Extend).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RefEntryDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RefEntryDto input)
        {
            if (input == null) return false;
            if (this.TagName != input.TagName || (this.TagName != null && !this.TagName.Equals(input.TagName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.Blob != input.Blob || (this.Blob != null && !this.Blob.Equals(input.Blob))) return false;
            if (this.LineImage != input.LineImage || (this.LineImage != null && !this.LineImage.Equals(input.LineImage))) return false;
            if (this.LineNumber != input.LineNumber || (this.LineNumber != null && !this.LineNumber.Equals(input.LineNumber))) return false;
            if (this.SyntaxType != input.SyntaxType || (this.SyntaxType != null && !this.SyntaxType.Equals(input.SyntaxType))) return false;
            if (this.Revision != input.Revision || (this.Revision != null && !this.Revision.Equals(input.Revision))) return false;
            if (this.Extend != input.Extend || (this.Extend != null && !this.Extend.Equals(input.Extend))) return false;

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
                if (this.TagName != null) hashCode = hashCode * 59 + this.TagName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.Blob != null) hashCode = hashCode * 59 + this.Blob.GetHashCode();
                if (this.LineImage != null) hashCode = hashCode * 59 + this.LineImage.GetHashCode();
                if (this.LineNumber != null) hashCode = hashCode * 59 + this.LineNumber.GetHashCode();
                if (this.SyntaxType != null) hashCode = hashCode * 59 + this.SyntaxType.GetHashCode();
                if (this.Revision != null) hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Extend != null) hashCode = hashCode * 59 + this.Extend.GetHashCode();
                return hashCode;
            }
        }
    }
}
