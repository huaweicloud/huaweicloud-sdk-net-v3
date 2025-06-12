using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetAgencyCredentialsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("agency_credentials", NullValueHandling = NullValueHandling.Ignore)]
        public AgencyCredentials AgencyCredentials { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAgencyCredentialsResponse {\n");
            sb.Append("  agencyCredentials: ").Append(AgencyCredentials).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetAgencyCredentialsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetAgencyCredentialsResponse input)
        {
            if (input == null) return false;
            if (this.AgencyCredentials != input.AgencyCredentials || (this.AgencyCredentials != null && !this.AgencyCredentials.Equals(input.AgencyCredentials))) return false;

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
                if (this.AgencyCredentials != null) hashCode = hashCode * 59 + this.AgencyCredentials.GetHashCode();
                return hashCode;
            }
        }
    }
}
