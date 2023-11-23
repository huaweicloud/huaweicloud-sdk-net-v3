using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAccessCodeResponse : SdkResponse
    {

        /// <summary>
        /// accessCodes
        /// </summary>
        [JsonProperty("access_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessCodeModel> AccessCodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccessCodeResponse {\n");
            sb.Append("  accessCodes: ").Append(AccessCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccessCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccessCodeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessCodes == input.AccessCodes ||
                    this.AccessCodes != null &&
                    input.AccessCodes != null &&
                    this.AccessCodes.SequenceEqual(input.AccessCodes)
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
                if (this.AccessCodes != null)
                    hashCode = hashCode * 59 + this.AccessCodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
