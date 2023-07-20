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
    /// 
    /// </summary>
    public class StructFieldInfo 
    {

        /// <summary>
        /// 结构化方式
        /// </summary>
        [JsonProperty("isAnalysis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAnalysis { get; set; }

        /// <summary>
        /// 字段内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("fieldName", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段数据类型,例：string，long，float
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 自定义别名(json方式中按需添加)
        /// </summary>
        [JsonProperty("userDefinedName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserDefinedName { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public int? Index { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructFieldInfo {\n");
            sb.Append("  isAnalysis: ").Append(IsAnalysis).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  userDefinedName: ").Append(UserDefinedName).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StructFieldInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StructFieldInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAnalysis == input.IsAnalysis ||
                    (this.IsAnalysis != null &&
                    this.IsAnalysis.Equals(input.IsAnalysis))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UserDefinedName == input.UserDefinedName ||
                    (this.UserDefinedName != null &&
                    this.UserDefinedName.Equals(input.UserDefinedName))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IsAnalysis != null)
                    hashCode = hashCode * 59 + this.IsAnalysis.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UserDefinedName != null)
                    hashCode = hashCode * 59 + this.UserDefinedName.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                return hashCode;
            }
        }
    }
}
