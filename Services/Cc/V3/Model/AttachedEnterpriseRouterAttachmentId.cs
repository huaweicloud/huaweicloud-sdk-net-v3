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
    /// 被挂载的企业路由器的连接ID。
    /// </summary>
    public class AttachedEnterpriseRouterAttachmentId 
    {

        /// <summary>
        /// 被挂载的企业路由器的连接ID。
        /// </summary>
        [JsonProperty("attached_er_attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachedErAttachmentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachedEnterpriseRouterAttachmentId {\n");
            sb.Append("  attachedErAttachmentId: ").Append(AttachedErAttachmentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachedEnterpriseRouterAttachmentId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachedEnterpriseRouterAttachmentId input)
        {
            if (input == null) return false;
            if (this.AttachedErAttachmentId != input.AttachedErAttachmentId || (this.AttachedErAttachmentId != null && !this.AttachedErAttachmentId.Equals(input.AttachedErAttachmentId))) return false;

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
                if (this.AttachedErAttachmentId != null) hashCode = hashCode * 59 + this.AttachedErAttachmentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
