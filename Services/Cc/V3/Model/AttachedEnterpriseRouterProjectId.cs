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
    /// 被挂载的企业路由器的项目ID。
    /// </summary>
    public class AttachedEnterpriseRouterProjectId 
    {

        /// <summary>
        /// 被挂载的企业路由器的项目ID。
        /// </summary>
        [JsonProperty("attached_er_table_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErTableProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachedEnterpriseRouterProjectId {\n");
            sb.Append("  attachedErTableProjectId: ").Append(AttachedErTableProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachedEnterpriseRouterProjectId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachedEnterpriseRouterProjectId input)
        {
            if (input == null) return false;
            if (this.AttachedErTableProjectId != input.AttachedErTableProjectId || (this.AttachedErTableProjectId != null && !this.AttachedErTableProjectId.Equals(input.AttachedErTableProjectId))) return false;

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
                if (this.AttachedErTableProjectId != null) hashCode = hashCode * 59 + this.AttachedErTableProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
