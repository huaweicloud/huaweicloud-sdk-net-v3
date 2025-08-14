using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListProfilesResponse : SdkResponse
    {

        /// <summary>
        /// 应用程序Profile
        /// </summary>
        [JsonProperty("applicationProfiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationProfileDto> ApplicationProfiles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProfilesResponse {\n");
            sb.Append("  applicationProfiles: ").Append(ApplicationProfiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProfilesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProfilesResponse input)
        {
            if (input == null) return false;
            if (this.ApplicationProfiles != input.ApplicationProfiles || (this.ApplicationProfiles != null && input.ApplicationProfiles != null && !this.ApplicationProfiles.SequenceEqual(input.ApplicationProfiles))) return false;

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
                if (this.ApplicationProfiles != null) hashCode = hashCode * 59 + this.ApplicationProfiles.GetHashCode();
                return hashCode;
            }
        }
    }
}
