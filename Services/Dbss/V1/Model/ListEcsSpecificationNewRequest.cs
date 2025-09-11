using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEcsSpecificationNewRequest 
    {

        /// <summary>
        /// **参数解释**： 镜像类型。 **约束限制**： 以取值范围为准 **取值范围**： - 1：运维 - 2：加密 - 3：审计 **默认取值**：   不传则默认为审计 
        /// </summary>
        [SDKProperty("image_business_type", IsQuery = true)]
        [JsonProperty("image_business_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageBusinessType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEcsSpecificationNewRequest {\n");
            sb.Append("  imageBusinessType: ").Append(ImageBusinessType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEcsSpecificationNewRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEcsSpecificationNewRequest input)
        {
            if (input == null) return false;
            if (this.ImageBusinessType != input.ImageBusinessType || (this.ImageBusinessType != null && !this.ImageBusinessType.Equals(input.ImageBusinessType))) return false;

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
                if (this.ImageBusinessType != null) hashCode = hashCode * 59 + this.ImageBusinessType.GetHashCode();
                return hashCode;
            }
        }
    }
}
