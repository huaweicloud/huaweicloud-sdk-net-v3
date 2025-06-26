using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 租户信息配置。
    /// </summary>
    public class InitializeTenantReq 
    {

        /// <summary>
        /// 服务状态 * &#x60;active&#x60; - 激活 * &#x60;inactive&#x60; - 未激活
        /// </summary>
        [JsonProperty("service_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitializeTenantReq {\n");
            sb.Append("  serviceStatus: ").Append(ServiceStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InitializeTenantReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InitializeTenantReq input)
        {
            if (input == null) return false;
            if (this.ServiceStatus != input.ServiceStatus || (this.ServiceStatus != null && !this.ServiceStatus.Equals(input.ServiceStatus))) return false;

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
                if (this.ServiceStatus != null) hashCode = hashCode * 59 + this.ServiceStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
