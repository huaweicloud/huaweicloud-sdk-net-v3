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
        [JsonProperty("specification", NullValueHandling = NullValueHandling.Ignore)]
        public List<EcsSpecificationBean> Specification { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEcsSpecificationNewResponse {\n");
            sb.Append("  specification: ").Append(Specification).Append("\n");
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
            if (this.Specification != input.Specification || (this.Specification != null && input.Specification != null && !this.Specification.SequenceEqual(input.Specification))) return false;

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
                if (this.Specification != null) hashCode = hashCode * 59 + this.Specification.GetHashCode();
                return hashCode;
            }
        }
    }
}
