using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateSecretResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auths", NullValueHandling = NullValueHandling.Ignore)]
        public Certification Auths { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecretResponse {\n");
            sb.Append("  auths: ").Append(Auths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecretResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecretResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Auths == input.Auths ||
                    (this.Auths != null &&
                    this.Auths.Equals(input.Auths))
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
                if (this.Auths != null)
                    hashCode = hashCode * 59 + this.Auths.GetHashCode();
                return hashCode;
            }
        }
    }
}
