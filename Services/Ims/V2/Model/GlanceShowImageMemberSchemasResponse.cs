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
    public class GlanceShowImageMemberSchemasResponse : SdkResponse
    {

        /// <summary>
        /// 视图名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像成员属性说明，主要是对基础属性的说明，包含每个属性的取值类型、用途等。
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Object Properties { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceShowImageMemberSchemasResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceShowImageMemberSchemasResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceShowImageMemberSchemasResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }
    }
}
