using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class KeystoneCreateMappingResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mapping", NullValueHandling = NullValueHandling.Ignore)]
        public MappingResult Mapping { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeystoneCreateMappingResponse {\n");
            sb.Append("  mapping: ").Append(Mapping).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeystoneCreateMappingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeystoneCreateMappingResponse input)
        {
            if (input == null) return false;
            if (this.Mapping != input.Mapping || (this.Mapping != null && !this.Mapping.Equals(input.Mapping))) return false;

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
                if (this.Mapping != null) hashCode = hashCode * 59 + this.Mapping.GetHashCode();
                return hashCode;
            }
        }
    }
}
