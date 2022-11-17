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
    /// 
    /// </summary>
    public class CreateTemporaryAccessKeyByAgencyRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public AgencyAuth Auth { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTemporaryAccessKeyByAgencyRequestBody {\n");
            sb.Append("  auth: ").Append(Auth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTemporaryAccessKeyByAgencyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTemporaryAccessKeyByAgencyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Auth == input.Auth ||
                    (this.Auth != null &&
                    this.Auth.Equals(input.Auth))
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
                if (this.Auth != null)
                    hashCode = hashCode * 59 + this.Auth.GetHashCode();
                return hashCode;
            }
        }
    }
}
