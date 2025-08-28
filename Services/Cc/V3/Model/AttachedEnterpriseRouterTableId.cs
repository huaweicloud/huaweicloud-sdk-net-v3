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
    /// 被挂载的企业路由器的路由表ID。
    /// </summary>
    public class AttachedEnterpriseRouterTableId 
    {

        /// <summary>
        /// 被挂载的企业路由器的路由表ID。
        /// </summary>
        [JsonProperty("attached_er_table_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachedEnterpriseRouterTableId {\n");
            sb.Append("  attachedErTableId: ").Append(AttachedErTableId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachedEnterpriseRouterTableId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachedEnterpriseRouterTableId input)
        {
            if (input == null) return false;
            if (this.AttachedErTableId != input.AttachedErTableId || (this.AttachedErTableId != null && !this.AttachedErTableId.Equals(input.AttachedErTableId))) return false;

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
                if (this.AttachedErTableId != null) hashCode = hashCode * 59 + this.AttachedErTableId.GetHashCode();
                return hashCode;
            }
        }
    }
}
