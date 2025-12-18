using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 服务主体信息。
    /// </summary>
    public class ServicePrincipalMetadata 
    {

        /// <summary>
        /// 服务主体，由\&quot;service.\&quot;开头，后跟一个长度为1到56个字符，只包含字母、数字和\&quot;-\&quot;的字符串。
        /// </summary>
        [JsonProperty("service_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// 云服务名称。
        /// </summary>
        [JsonProperty("service_catalog", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceCatalog { get; set; }

        /// <summary>
        /// 用于显示的服务主体名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 服务主体的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePrincipalMetadata {\n");
            sb.Append("  servicePrincipal: ").Append(ServicePrincipal).Append("\n");
            sb.Append("  serviceCatalog: ").Append(ServiceCatalog).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServicePrincipalMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServicePrincipalMetadata input)
        {
            if (input == null) return false;
            if (this.ServicePrincipal != input.ServicePrincipal || (this.ServicePrincipal != null && !this.ServicePrincipal.Equals(input.ServicePrincipal))) return false;
            if (this.ServiceCatalog != input.ServiceCatalog || (this.ServiceCatalog != null && !this.ServiceCatalog.Equals(input.ServiceCatalog))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.ServiceCatalog != null) hashCode = hashCode * 59 + this.ServiceCatalog.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
