using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class RegisterOrganizationalUnitRequest 
    {

        /// <summary>
        /// 注册OU ID。
        /// </summary>
        [SDKProperty("organizational_unit_id", IsPath = true)]
        [JsonProperty("organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationalUnitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterOrganizationalUnitRequest {\n");
            sb.Append("  organizationalUnitId: ").Append(OrganizationalUnitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterOrganizationalUnitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterOrganizationalUnitRequest input)
        {
            if (input == null) return false;
            if (this.OrganizationalUnitId != input.OrganizationalUnitId || (this.OrganizationalUnitId != null && !this.OrganizationalUnitId.Equals(input.OrganizationalUnitId))) return false;

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
                if (this.OrganizationalUnitId != null) hashCode = hashCode * 59 + this.OrganizationalUnitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
