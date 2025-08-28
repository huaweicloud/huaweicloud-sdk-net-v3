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
    /// 被挂载的企业路由器ID。
    /// </summary>
    public class AttachedEnterpriseRouterId 
    {

        /// <summary>
        /// 被挂载的企业路由器ID。
        /// </summary>
        [JsonProperty("attached_er_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachedEnterpriseRouterId {\n");
            sb.Append("  attachedErId: ").Append(AttachedErId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachedEnterpriseRouterId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachedEnterpriseRouterId input)
        {
            if (input == null) return false;
            if (this.AttachedErId != input.AttachedErId || (this.AttachedErId != null && !this.AttachedErId.Equals(input.AttachedErId))) return false;

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
                if (this.AttachedErId != null) hashCode = hashCode * 59 + this.AttachedErId.GetHashCode();
                return hashCode;
            }
        }
    }
}
