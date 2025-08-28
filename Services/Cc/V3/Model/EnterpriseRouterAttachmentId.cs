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
    /// 企业路由器的连接ID。
    /// </summary>
    public class EnterpriseRouterAttachmentId 
    {

        /// <summary>
        /// 企业路由器的连接ID。
        /// </summary>
        [JsonProperty("enterprise_router_attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _EnterpriseRouterAttachmentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnterpriseRouterAttachmentId {\n");
            sb.Append("  _enterpriseRouterAttachmentId: ").Append(_EnterpriseRouterAttachmentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnterpriseRouterAttachmentId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnterpriseRouterAttachmentId input)
        {
            if (input == null) return false;
            if (this._EnterpriseRouterAttachmentId != input._EnterpriseRouterAttachmentId || (this._EnterpriseRouterAttachmentId != null && !this._EnterpriseRouterAttachmentId.Equals(input._EnterpriseRouterAttachmentId))) return false;

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
                if (this._EnterpriseRouterAttachmentId != null) hashCode = hashCode * 59 + this._EnterpriseRouterAttachmentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
