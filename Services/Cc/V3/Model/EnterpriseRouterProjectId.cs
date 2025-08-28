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
    /// 企业路由器的项目ID。
    /// </summary>
    public class EnterpriseRouterProjectId 
    {

        /// <summary>
        /// 企业路由器的项目ID。
        /// </summary>
        [JsonProperty("enterprise_router_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _EnterpriseRouterProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterpriseRouterProjectId {\n");
            sb.Append("  _enterpriseRouterProjectId: ").Append(_EnterpriseRouterProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterpriseRouterProjectId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterpriseRouterProjectId input)
        {
            if (input == null) return false;
            if (this._EnterpriseRouterProjectId != input._EnterpriseRouterProjectId || (this._EnterpriseRouterProjectId != null && !this._EnterpriseRouterProjectId.Equals(input._EnterpriseRouterProjectId))) return false;

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
                if (this._EnterpriseRouterProjectId != null) hashCode = hashCode * 59 + this._EnterpriseRouterProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
