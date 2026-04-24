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
    /// 配置域控的配置信息请求。
    /// </summary>
    public class CreateDomainNewReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uos_domain_info", NullValueHandling = NullValueHandling.Ignore)]
        public CreateUosDomainInfo UosDomainInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ad_domain_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdDomain AdDomainInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public DomainType? AuthType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDomainNewReq {\n");
            sb.Append("  uosDomainInfo: ").Append(UosDomainInfo).Append("\n");
            sb.Append("  adDomainInfo: ").Append(AdDomainInfo).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDomainNewReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDomainNewReq input)
        {
            if (input == null) return false;
            if (this.UosDomainInfo != input.UosDomainInfo || (this.UosDomainInfo != null && !this.UosDomainInfo.Equals(input.UosDomainInfo))) return false;
            if (this.AdDomainInfo != input.AdDomainInfo || (this.AdDomainInfo != null && !this.AdDomainInfo.Equals(input.AdDomainInfo))) return false;
            if (this.AuthType != input.AuthType || (this.AuthType != null && !this.AuthType.Equals(input.AuthType))) return false;

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
                if (this.UosDomainInfo != null) hashCode = hashCode * 59 + this.UosDomainInfo.GetHashCode();
                if (this.AdDomainInfo != null) hashCode = hashCode * 59 + this.AdDomainInfo.GetHashCode();
                if (this.AuthType != null) hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                return hashCode;
            }
        }
    }
}
