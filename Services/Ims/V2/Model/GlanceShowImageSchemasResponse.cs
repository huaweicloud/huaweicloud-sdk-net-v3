using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GlanceShowImageSchemasResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("additionalProperties", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalProperties AdditionalProperties { get; set; }

        /// <summary>
        /// 视图名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像属性说明，主要是对基础属性的说明，包含每个属性的取值类型、用途等。
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Object Properties { get; set; }

        /// <summary>
        /// 视图链接。
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Links> Links { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceShowImageSchemasResponse {\n");
            sb.Append("  additionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceShowImageSchemasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceShowImageSchemasResponse input)
        {
            if (input == null) return false;
            if (this.AdditionalProperties != input.AdditionalProperties || (this.AdditionalProperties != null && !this.AdditionalProperties.Equals(input.AdditionalProperties))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && !this.Properties.Equals(input.Properties))) return false;
            if (this.Links != input.Links || (this.Links != null && input.Links != null && !this.Links.SequenceEqual(input.Links))) return false;

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
                if (this.AdditionalProperties != null) hashCode = hashCode * 59 + this.AdditionalProperties.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }
}
