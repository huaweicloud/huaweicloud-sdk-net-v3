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
    public class DeregisterOrganizationalUnitRequest 
    {

        /// <summary>
        /// 注册OU ID。
        /// </summary>
        [SDKProperty("managed_organizational_unit_id", IsPath = true)]
        [JsonProperty("managed_organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedOrganizationalUnitId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeregisterOrganizationalUnitRequest {\n");
            sb.Append("  managedOrganizationalUnitId: ").Append(ManagedOrganizationalUnitId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeregisterOrganizationalUnitRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeregisterOrganizationalUnitRequest input)
        {
            if (input == null) return false;
            if (this.ManagedOrganizationalUnitId != input.ManagedOrganizationalUnitId || (this.ManagedOrganizationalUnitId != null && !this.ManagedOrganizationalUnitId.Equals(input.ManagedOrganizationalUnitId))) return false;

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
                if (this.ManagedOrganizationalUnitId != null) hashCode = hashCode * 59 + this.ManagedOrganizationalUnitId.GetHashCode();
                return hashCode;
            }
        }
    }
}
