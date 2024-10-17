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
    /// 可信服务相关操作的请求体。
    /// </summary>
    public class TrustedServiceReqBody 
    {

        /// <summary>
        /// 服务主体名称。
        /// </summary>
        [JsonProperty("service_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePrincipal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrustedServiceReqBody {\n");
            sb.Append("  servicePrincipal: ").Append(ServicePrincipal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrustedServiceReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrustedServiceReqBody input)
        {
            if (input == null) return false;
            if (this.ServicePrincipal != input.ServicePrincipal || (this.ServicePrincipal != null && !this.ServicePrincipal.Equals(input.ServicePrincipal))) return false;

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
                if (this.ServicePrincipal != null) hashCode = hashCode * 59 + this.ServicePrincipal.GetHashCode();
                return hashCode;
            }
        }
    }
}
