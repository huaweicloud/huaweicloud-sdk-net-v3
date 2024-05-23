using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// 包含有关账号是可信服务委托管理员的信息。
    /// </summary>
    public class DelegatedServiceDto 
    {

        /// <summary>
        /// 服务主体的名称。
        /// </summary>
        [JsonProperty("service_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// 账号成为此服务的委托管理员的日期。
        /// </summary>
        [JsonProperty("delegation_enabled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DelegationEnabledAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelegatedServiceDto {\n");
            sb.Append("  servicePrincipal: ").Append(ServicePrincipal).Append("\n");
            sb.Append("  delegationEnabledAt: ").Append(DelegationEnabledAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DelegatedServiceDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DelegatedServiceDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServicePrincipal == input.ServicePrincipal ||
                    (this.ServicePrincipal != null &&
                    this.ServicePrincipal.Equals(input.ServicePrincipal))
                ) && 
                (
                    this.DelegationEnabledAt == input.DelegationEnabledAt ||
                    (this.DelegationEnabledAt != null &&
                    this.DelegationEnabledAt.Equals(input.DelegationEnabledAt))
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
                if (this.ServicePrincipal != null)
                    hashCode = hashCode * 59 + this.ServicePrincipal.GetHashCode();
                if (this.DelegationEnabledAt != null)
                    hashCode = hashCode * 59 + this.DelegationEnabledAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
