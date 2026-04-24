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
    /// 更新域控的配置信息请求。
    /// </summary>
    public class UpdateDomainNewReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uos_domain_info", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateUosDomainInfo UosDomainInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ad_domain_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdDomain AdDomainInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public DomainType AuthType { get; set; }
        /// <summary>
        /// 认证配置id。
        /// </summary>
        [JsonProperty("auth_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthConfigId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainNewReq {\n");
            sb.Append("  uosDomainInfo: ").Append(UosDomainInfo).Append("\n");
            sb.Append("  adDomainInfo: ").Append(AdDomainInfo).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  authConfigId: ").Append(AuthConfigId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainNewReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainNewReq input)
        {
            if (input == null) return false;
            if (this.UosDomainInfo != input.UosDomainInfo || (this.UosDomainInfo != null && !this.UosDomainInfo.Equals(input.UosDomainInfo))) return false;
            if (this.AdDomainInfo != input.AdDomainInfo || (this.AdDomainInfo != null && !this.AdDomainInfo.Equals(input.AdDomainInfo))) return false;
            if (this.AuthType != input.AuthType) return false;
            if (this.AuthConfigId != input.AuthConfigId || (this.AuthConfigId != null && !this.AuthConfigId.Equals(input.AuthConfigId))) return false;

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
                hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.AuthConfigId != null) hashCode = hashCode * 59 + this.AuthConfigId.GetHashCode();
                return hashCode;
            }
        }
    }
}
