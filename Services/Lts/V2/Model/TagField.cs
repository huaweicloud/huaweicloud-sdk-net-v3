using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// tag信息。
    /// </summary>
    public class TagField 
    {

        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("fieldName", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段数据类型，例：string，long，float
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 是否开启快速分析
        /// </summary>
        [JsonProperty("isAnalysis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAnalysis { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagField {\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  isAnalysis: ").Append(IsAnalysis).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagField);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagField input)
        {
            if (input == null) return false;
            if (this.FieldName != input.FieldName || (this.FieldName != null && !this.FieldName.Equals(input.FieldName))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.IsAnalysis != input.IsAnalysis || (this.IsAnalysis != null && !this.IsAnalysis.Equals(input.IsAnalysis))) return false;

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
                if (this.FieldName != null) hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.IsAnalysis != null) hashCode = hashCode * 59 + this.IsAnalysis.GetHashCode();
                return hashCode;
            }
        }
    }
}
