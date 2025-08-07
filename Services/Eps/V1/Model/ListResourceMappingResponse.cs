using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListResourceMappingResponse : SdkResponse
    {

        /// <summary>
        /// 资源类型映射
        /// </summary>
        [JsonProperty("resource_mapping", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ResourceMapping { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceMappingResponse {\n");
            sb.Append("  resourceMapping: ").Append(ResourceMapping).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceMappingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceMappingResponse input)
        {
            if (input == null) return false;
            if (this.ResourceMapping != input.ResourceMapping || (this.ResourceMapping != null && input.ResourceMapping != null && !this.ResourceMapping.SequenceEqual(input.ResourceMapping))) return false;

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
                if (this.ResourceMapping != null) hashCode = hashCode * 59 + this.ResourceMapping.GetHashCode();
                return hashCode;
            }
        }
    }
}
