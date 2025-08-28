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
    /// 被挂载的企业路由器的站点编码。
    /// </summary>
    public class AttachedEnterpriseRouterSiteCode 
    {

        /// <summary>
        /// 被挂载的企业路由器的站点编码。
        /// </summary>
        [JsonProperty("attached_er_table_site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableSiteCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachedEnterpriseRouterSiteCode {\n");
            sb.Append("  attachedErTableSiteCode: ").Append(AttachedErTableSiteCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachedEnterpriseRouterSiteCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachedEnterpriseRouterSiteCode input)
        {
            if (input == null) return false;
            if (this.AttachedErTableSiteCode != input.AttachedErTableSiteCode || (this.AttachedErTableSiteCode != null && !this.AttachedErTableSiteCode.Equals(input.AttachedErTableSiteCode))) return false;

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
                if (this.AttachedErTableSiteCode != null) hashCode = hashCode * 59 + this.AttachedErTableSiteCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
