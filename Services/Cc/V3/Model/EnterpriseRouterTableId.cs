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
    /// 企业路由器的路由表ID。
    /// </summary>
    public class EnterpriseRouterTableId 
    {

        /// <summary>
        /// 企业路由器的路由表ID。
        /// </summary>
        [JsonProperty("enterprise_router_table_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _EnterpriseRouterTableId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterpriseRouterTableId {\n");
            sb.Append("  _enterpriseRouterTableId: ").Append(_EnterpriseRouterTableId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterpriseRouterTableId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterpriseRouterTableId input)
        {
            if (input == null) return false;
            if (this._EnterpriseRouterTableId != input._EnterpriseRouterTableId || (this._EnterpriseRouterTableId != null && !this._EnterpriseRouterTableId.Equals(input._EnterpriseRouterTableId))) return false;

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
                if (this._EnterpriseRouterTableId != null) hashCode = hashCode * 59 + this._EnterpriseRouterTableId.GetHashCode();
                return hashCode;
            }
        }
    }
}
