using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AssumeAgencyResponse : SdkResponse
    {

        /// <summary>
        /// 调用链里最初调用者所声明的身份。
        /// </summary>
        [JsonProperty("source_identity", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIdentity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assumed_agency", NullValueHandling = NullValueHandling.Ignore)]
        public AssumedAgencyDto AssumedAgency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public CredentialsDto Credentials { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssumeAgencyResponse {\n");
            sb.Append("  sourceIdentity: ").Append(SourceIdentity).Append("\n");
            sb.Append("  assumedAgency: ").Append(AssumedAgency).Append("\n");
            sb.Append("  credentials: ").Append(Credentials).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssumeAgencyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssumeAgencyResponse input)
        {
            if (input == null) return false;
            if (this.SourceIdentity != input.SourceIdentity || (this.SourceIdentity != null && !this.SourceIdentity.Equals(input.SourceIdentity))) return false;
            if (this.AssumedAgency != input.AssumedAgency || (this.AssumedAgency != null && !this.AssumedAgency.Equals(input.AssumedAgency))) return false;
            if (this.Credentials != input.Credentials || (this.Credentials != null && !this.Credentials.Equals(input.Credentials))) return false;

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
                if (this.SourceIdentity != null) hashCode = hashCode * 59 + this.SourceIdentity.GetHashCode();
                if (this.AssumedAgency != null) hashCode = hashCode * 59 + this.AssumedAgency.GetHashCode();
                if (this.Credentials != null) hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                return hashCode;
            }
        }
    }
}
