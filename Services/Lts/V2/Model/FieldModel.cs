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
    /// 创建结构化模板中的字段模型
    /// </summary>
    public class FieldModel 
    {

        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 是否开启快速分析。
        /// </summary>
        [JsonProperty("is_analysis", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAnalysis { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldModel {\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  isAnalysis: ").Append(IsAnalysis).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FieldModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FieldModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.IsAnalysis == input.IsAnalysis ||
                    (this.IsAnalysis != null &&
                    this.IsAnalysis.Equals(input.IsAnalysis))
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
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.IsAnalysis != null)
                    hashCode = hashCode * 59 + this.IsAnalysis.GetHashCode();
                return hashCode;
            }
        }
    }
}
