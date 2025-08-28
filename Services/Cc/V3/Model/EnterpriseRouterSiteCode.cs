using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 中心网络企业路由器的站点编码。
    /// </summary>
    public class EnterpriseRouterSiteCode 
    {

        /// <summary>
        /// 中心网络企业路由器的站点编码。
        /// </summary>
        [JsonProperty("enterprise_router_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string _EnterpriseRouterSiteCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterpriseRouterSiteCode {\n");
            sb.Append("  _enterpriseRouterSiteCode: ").Append(_EnterpriseRouterSiteCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterpriseRouterSiteCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterpriseRouterSiteCode input)
        {
            if (input == null) return false;
            if (this._EnterpriseRouterSiteCode != input._EnterpriseRouterSiteCode || (this._EnterpriseRouterSiteCode != null && !this._EnterpriseRouterSiteCode.Equals(input._EnterpriseRouterSiteCode))) return false;

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
                if (this._EnterpriseRouterSiteCode != null) hashCode = hashCode * 59 + this._EnterpriseRouterSiteCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
