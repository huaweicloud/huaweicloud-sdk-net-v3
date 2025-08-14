using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListProvisioningTenantsResponse : SdkResponse
    {

        /// <summary>
        /// SCIM自动预配配置信息
        /// </summary>
        [JsonProperty("provisioning_tenants", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProvisioningTenant> ProvisioningTenants { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProvisioningTenantsResponse {\n");
            sb.Append("  provisioningTenants: ").Append(ProvisioningTenants).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProvisioningTenantsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProvisioningTenantsResponse input)
        {
            if (input == null) return false;
            if (this.ProvisioningTenants != input.ProvisioningTenants || (this.ProvisioningTenants != null && input.ProvisioningTenants != null && !this.ProvisioningTenants.SequenceEqual(input.ProvisioningTenants))) return false;

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
                if (this.ProvisioningTenants != null) hashCode = hashCode * 59 + this.ProvisioningTenants.GetHashCode();
                return hashCode;
            }
        }
    }
}
