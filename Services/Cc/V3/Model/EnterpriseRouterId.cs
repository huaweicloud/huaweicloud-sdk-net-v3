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
    /// 企业路由器的ID。
    /// </summary>
    public class EnterpriseRouterId 
    {

        /// <summary>
        /// 企业路由器的ID。
        /// </summary>
        [JsonProperty("enterprise_router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _EnterpriseRouterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterpriseRouterId {\n");
            sb.Append("  _enterpriseRouterId: ").Append(_EnterpriseRouterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterpriseRouterId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterpriseRouterId input)
        {
            if (input == null) return false;
            if (this._EnterpriseRouterId != input._EnterpriseRouterId || (this._EnterpriseRouterId != null && !this._EnterpriseRouterId.Equals(input._EnterpriseRouterId))) return false;

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
                if (this._EnterpriseRouterId != null) hashCode = hashCode * 59 + this._EnterpriseRouterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
