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
    /// Response Object
    /// </summary>
    public class ListEcsSpecificationNewResponse : SdkResponse
    {

        /// <summary>
        /// ecs规格集合
        /// </summary>
        [JsonProperty("specifications", NullValueHandling = NullValueHandling.Ignore)]
        public List<EcsSpecificationBean> Specifications { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEcsSpecificationNewResponse {\n");
            sb.Append("  specifications: ").Append(Specifications).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEcsSpecificationNewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEcsSpecificationNewResponse input)
        {
            if (input == null) return false;
            if (this.Specifications != input.Specifications || (this.Specifications != null && input.Specifications != null && !this.Specifications.SequenceEqual(input.Specifications))) return false;

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
                if (this.Specifications != null) hashCode = hashCode * 59 + this.Specifications.GetHashCode();
                return hashCode;
            }
        }
    }
}
