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
    /// 
    /// </summary>
    public class DefectEvents 
    {

        /// <summary>
        /// 调用链信息
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<DefectEvents> Events { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// fix suggestions
        /// </summary>
        [JsonProperty("fix_suggestions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FixSuggestions { get; set; }

        /// <summary>
        /// 缺陷所在行
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public int? Line { get; set; }

        /// <summary>
        /// 缺陷结束行
        /// </summary>
        [JsonProperty("end_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndLine { get; set; }

        /// <summary>
        /// 缺陷开始行
        /// </summary>
        [JsonProperty("code_context_start_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? CodeContextStartLine { get; set; }

        /// <summary>
        /// 代码片段
        /// </summary>
        [JsonProperty("main", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Main { get; set; }

        /// <summary>
        /// file path
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// main buggy code
        /// </summary>
        [JsonProperty("main_buggy_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MainBuggyCode { get; set; }

        /// <summary>
        /// code context
        /// </summary>
        [JsonProperty("code_context", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeContext { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefectEvents {\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  fixSuggestions: ").Append(FixSuggestions).Append("\n");
            sb.Append("  line: ").Append(Line).Append("\n");
            sb.Append("  endLine: ").Append(EndLine).Append("\n");
            sb.Append("  codeContextStartLine: ").Append(CodeContextStartLine).Append("\n");
            sb.Append("  main: ").Append(Main).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  mainBuggyCode: ").Append(MainBuggyCode).Append("\n");
            sb.Append("  codeContext: ").Append(CodeContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DefectEvents);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DefectEvents input)
        {
            if (input == null) return false;
            if (this.Events != input.Events || (this.Events != null && input.Events != null && !this.Events.SequenceEqual(input.Events))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.FixSuggestions != input.FixSuggestions || (this.FixSuggestions != null && input.FixSuggestions != null && !this.FixSuggestions.SequenceEqual(input.FixSuggestions))) return false;
            if (this.Line != input.Line || (this.Line != null && !this.Line.Equals(input.Line))) return false;
            if (this.EndLine != input.EndLine || (this.EndLine != null && !this.EndLine.Equals(input.EndLine))) return false;
            if (this.CodeContextStartLine != input.CodeContextStartLine || (this.CodeContextStartLine != null && !this.CodeContextStartLine.Equals(input.CodeContextStartLine))) return false;
            if (this.Main != input.Main || (this.Main != null && !this.Main.Equals(input.Main))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.MainBuggyCode != input.MainBuggyCode || (this.MainBuggyCode != null && !this.MainBuggyCode.Equals(input.MainBuggyCode))) return false;
            if (this.CodeContext != input.CodeContext || (this.CodeContext != null && !this.CodeContext.Equals(input.CodeContext))) return false;

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
                if (this.Events != null) hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FixSuggestions != null) hashCode = hashCode * 59 + this.FixSuggestions.GetHashCode();
                if (this.Line != null) hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.EndLine != null) hashCode = hashCode * 59 + this.EndLine.GetHashCode();
                if (this.CodeContextStartLine != null) hashCode = hashCode * 59 + this.CodeContextStartLine.GetHashCode();
                if (this.Main != null) hashCode = hashCode * 59 + this.Main.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.MainBuggyCode != null) hashCode = hashCode * 59 + this.MainBuggyCode.GetHashCode();
                if (this.CodeContext != null) hashCode = hashCode * 59 + this.CodeContext.GetHashCode();
                return hashCode;
            }
        }
    }
}
