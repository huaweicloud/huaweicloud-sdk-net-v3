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
    public class UpdatePermanentAccessKeyResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("credential", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCredentialResult Credential { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePermanentAccessKeyResponse {\n");
            sb.Append("  credential: ").Append(Credential).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePermanentAccessKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePermanentAccessKeyResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Credential == input.Credential ||
                    (this.Credential != null &&
                    this.Credential.Equals(input.Credential))
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
                if (this.Credential != null)
                    hashCode = hashCode * 59 + this.Credential.GetHashCode();
                return hashCode;
            }
        }
    }
}
