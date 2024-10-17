using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateSecretVersionResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("version_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public VersionMetadata VersionMetadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecretVersionResponse {\n");
            sb.Append("  versionMetadata: ").Append(VersionMetadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecretVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecretVersionResponse input)
        {
            if (input == null) return false;
            if (this.VersionMetadata != input.VersionMetadata || (this.VersionMetadata != null && !this.VersionMetadata.Equals(input.VersionMetadata))) return false;

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
                if (this.VersionMetadata != null) hashCode = hashCode * 59 + this.VersionMetadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
