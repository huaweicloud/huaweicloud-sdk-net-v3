using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// start_offset和end_offset均为-1，表示该行不是缺陷片段或者整行都是，需要结合DefectInfoV2中的line_number属性一起判断哪一行是具体的缺陷片段。
    /// </summary>
    public class DefectFragmentV2 
    {

        /// <summary>
        /// 行号
        /// </summary>
        [JsonProperty("line_num", NullValueHandling = NullValueHandling.Ignore)]
        public string LineNum { get; set; }

        /// <summary>
        /// 该行代码内容
        /// </summary>
        [JsonProperty("line_content", NullValueHandling = NullValueHandling.Ignore)]
        public string LineContent { get; set; }

        /// <summary>
        /// 缺陷开始列号
        /// </summary>
        [JsonProperty("start_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartOffset { get; set; }

        /// <summary>
        /// 缺陷结束列号
        /// </summary>
        [JsonProperty("end_offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndOffset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefectFragmentV2 {\n");
            sb.Append("  lineNum: ").Append(LineNum).Append("\n");
            sb.Append("  lineContent: ").Append(LineContent).Append("\n");
            sb.Append("  startOffset: ").Append(StartOffset).Append("\n");
            sb.Append("  endOffset: ").Append(EndOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DefectFragmentV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DefectFragmentV2 input)
        {
            if (input == null) return false;
            if (this.LineNum != input.LineNum || (this.LineNum != null && !this.LineNum.Equals(input.LineNum))) return false;
            if (this.LineContent != input.LineContent || (this.LineContent != null && !this.LineContent.Equals(input.LineContent))) return false;
            if (this.StartOffset != input.StartOffset || (this.StartOffset != null && !this.StartOffset.Equals(input.StartOffset))) return false;
            if (this.EndOffset != input.EndOffset || (this.EndOffset != null && !this.EndOffset.Equals(input.EndOffset))) return false;

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
                if (this.LineNum != null) hashCode = hashCode * 59 + this.LineNum.GetHashCode();
                if (this.LineContent != null) hashCode = hashCode * 59 + this.LineContent.GetHashCode();
                if (this.StartOffset != null) hashCode = hashCode * 59 + this.StartOffset.GetHashCode();
                if (this.EndOffset != null) hashCode = hashCode * 59 + this.EndOffset.GetHashCode();
                return hashCode;
            }
        }
    }
}
