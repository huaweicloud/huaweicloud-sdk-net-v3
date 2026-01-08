using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 证书DN。
    /// </summary>
    public class DistinguishedName 
    {

        /// <summary>
        /// ca名称。
        /// </summary>
        [JsonProperty("common_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommonName { get; set; }

        /// <summary>
        /// 国家/地区。
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 省份/州。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 城市。
        /// </summary>
        [JsonProperty("locality", NullValueHandling = NullValueHandling.Ignore)]
        public string Locality { get; set; }

        /// <summary>
        /// 公司名称。
        /// </summary>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("organizational_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationalUnit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DistinguishedName {\n");
            sb.Append("  commonName: ").Append(CommonName).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  locality: ").Append(Locality).Append("\n");
            sb.Append("  organization: ").Append(Organization).Append("\n");
            sb.Append("  organizationalUnit: ").Append(OrganizationalUnit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DistinguishedName);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DistinguishedName input)
        {
            if (input == null) return false;
            if (this.CommonName != input.CommonName || (this.CommonName != null && !this.CommonName.Equals(input.CommonName))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Locality != input.Locality || (this.Locality != null && !this.Locality.Equals(input.Locality))) return false;
            if (this.Organization != input.Organization || (this.Organization != null && !this.Organization.Equals(input.Organization))) return false;
            if (this.OrganizationalUnit != input.OrganizationalUnit || (this.OrganizationalUnit != null && !this.OrganizationalUnit.Equals(input.OrganizationalUnit))) return false;

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
                if (this.CommonName != null) hashCode = hashCode * 59 + this.CommonName.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Locality != null) hashCode = hashCode * 59 + this.Locality.GetHashCode();
                if (this.Organization != null) hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.OrganizationalUnit != null) hashCode = hashCode * 59 + this.OrganizationalUnit.GetHashCode();
                return hashCode;
            }
        }
    }
}
