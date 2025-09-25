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
    /// 
    /// </summary>
    public class ConflictSectionLineDto 
    {

        /// <summary>
        /// 行
        /// </summary>
        [JsonProperty("line_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LineCode { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 旧行
        /// </summary>
        [JsonProperty("old_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? OldLine { get; set; }

        /// <summary>
        /// 新行
        /// </summary>
        [JsonProperty("new_line", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewLine { get; set; }

        /// <summary>
        /// 文本
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public ConflictSectionLineMetaDataDto MetaData { get; set; }

        /// <summary>
        /// 富文本
        /// </summary>
        [JsonProperty("rich_text", NullValueHandling = NullValueHandling.Ignore)]
        public string RichText { get; set; }

        /// <summary>
        /// 可接受建议
        /// </summary>
        [JsonProperty("can_receive_suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanReceiveSuggestion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConflictSectionLineDto {\n");
            sb.Append("  lineCode: ").Append(LineCode).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  oldLine: ").Append(OldLine).Append("\n");
            sb.Append("  newLine: ").Append(NewLine).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("  richText: ").Append(RichText).Append("\n");
            sb.Append("  canReceiveSuggestion: ").Append(CanReceiveSuggestion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConflictSectionLineDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConflictSectionLineDto input)
        {
            if (input == null) return false;
            if (this.LineCode != input.LineCode || (this.LineCode != null && !this.LineCode.Equals(input.LineCode))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.OldLine != input.OldLine || (this.OldLine != null && !this.OldLine.Equals(input.OldLine))) return false;
            if (this.NewLine != input.NewLine || (this.NewLine != null && !this.NewLine.Equals(input.NewLine))) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
            if (this.MetaData != input.MetaData || (this.MetaData != null && !this.MetaData.Equals(input.MetaData))) return false;
            if (this.RichText != input.RichText || (this.RichText != null && !this.RichText.Equals(input.RichText))) return false;
            if (this.CanReceiveSuggestion != input.CanReceiveSuggestion || (this.CanReceiveSuggestion != null && !this.CanReceiveSuggestion.Equals(input.CanReceiveSuggestion))) return false;

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
                if (this.LineCode != null) hashCode = hashCode * 59 + this.LineCode.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.OldLine != null) hashCode = hashCode * 59 + this.OldLine.GetHashCode();
                if (this.NewLine != null) hashCode = hashCode * 59 + this.NewLine.GetHashCode();
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.MetaData != null) hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.RichText != null) hashCode = hashCode * 59 + this.RichText.GetHashCode();
                if (this.CanReceiveSuggestion != null) hashCode = hashCode * 59 + this.CanReceiveSuggestion.GetHashCode();
                return hashCode;
            }
        }
    }
}
