using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ErrorInfo 
    {

        /// <summary>
        /// 错误内容的描述
        /// </summary>
        [JsonProperty("error_content", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 错误索引的描述
        /// </summary>
        [JsonProperty("error_index", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorIndex { get; set; }

        /// <summary>
        /// 错误点的描述
        /// </summary>
        [JsonProperty("error_point", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorPoint { get; set; }

        /// <summary>
        /// 是否高亮标识
        /// </summary>
        [JsonProperty("high_light", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HighLight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorInfo {\n");
            sb.Append("  errorContent: ").Append(ErrorContent).Append("\n");
            sb.Append("  errorIndex: ").Append(ErrorIndex).Append("\n");
            sb.Append("  errorPoint: ").Append(ErrorPoint).Append("\n");
            sb.Append("  highLight: ").Append(HighLight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ErrorInfo input)
        {
            if (input == null) return false;
            if (this.ErrorContent != input.ErrorContent || (this.ErrorContent != null && !this.ErrorContent.Equals(input.ErrorContent))) return false;
            if (this.ErrorIndex != input.ErrorIndex || (this.ErrorIndex != null && !this.ErrorIndex.Equals(input.ErrorIndex))) return false;
            if (this.ErrorPoint != input.ErrorPoint || (this.ErrorPoint != null && !this.ErrorPoint.Equals(input.ErrorPoint))) return false;
            if (this.HighLight != input.HighLight || (this.HighLight != null && !this.HighLight.Equals(input.HighLight))) return false;

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
                if (this.ErrorContent != null) hashCode = hashCode * 59 + this.ErrorContent.GetHashCode();
                if (this.ErrorIndex != null) hashCode = hashCode * 59 + this.ErrorIndex.GetHashCode();
                if (this.ErrorPoint != null) hashCode = hashCode * 59 + this.ErrorPoint.GetHashCode();
                if (this.HighLight != null) hashCode = hashCode * 59 + this.HighLight.GetHashCode();
                return hashCode;
            }
        }
    }
}
