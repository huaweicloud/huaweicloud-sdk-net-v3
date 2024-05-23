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
    /// 包含可信服务详细信息的结构，可信服务表示已启用与组织集成的服务。
    /// </summary>
    public class TrustedServiceDto 
    {

        /// <summary>
        /// 可信服务的名称。
        /// </summary>
        [JsonProperty("service_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// 可信服务与组织集成的日期。
        /// </summary>
        [JsonProperty("enabled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EnabledAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustedServiceDto {\n");
            sb.Append("  servicePrincipal: ").Append(ServicePrincipal).Append("\n");
            sb.Append("  enabledAt: ").Append(EnabledAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrustedServiceDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrustedServiceDto input)
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
                    this.EnabledAt == input.EnabledAt ||
                    (this.EnabledAt != null &&
                    this.EnabledAt.Equals(input.EnabledAt))
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
                if (this.EnabledAt != null)
                    hashCode = hashCode * 59 + this.EnabledAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
