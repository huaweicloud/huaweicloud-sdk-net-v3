using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// 应用程序Schema属性映射配置
    /// </summary>
    public class ResponseSchemaConfigDto 
    {

        /// <summary>
        /// 额外添加的属性映射Schema配置
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ResponseSchemaPropertiesDetailsDto> Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseSchemaSubjectDetailsDto Subject { get; set; }

        /// <summary>
        /// 应用程序支持的Subject NameID格式
        /// </summary>
        [JsonProperty("supported_name_id_formats", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportedNameIdFormats { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseSchemaConfigDto {\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  supportedNameIdFormats: ").Append(SupportedNameIdFormats).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseSchemaConfigDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResponseSchemaConfigDto input)
        {
            if (input == null) return false;
            if (this.Properties != input.Properties || (this.Properties != null && input.Properties != null && !this.Properties.SequenceEqual(input.Properties))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.SupportedNameIdFormats != input.SupportedNameIdFormats || (this.SupportedNameIdFormats != null && input.SupportedNameIdFormats != null && !this.SupportedNameIdFormats.SequenceEqual(input.SupportedNameIdFormats))) return false;

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
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.SupportedNameIdFormats != null) hashCode = hashCode * 59 + this.SupportedNameIdFormats.GetHashCode();
                return hashCode;
            }
        }
    }
}
