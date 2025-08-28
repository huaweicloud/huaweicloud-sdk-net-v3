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
    /// 中心网络附件对端实例的连接ID，企业路由器的连接ID或者GDGW的连接ID。
    /// </summary>
    public class AttachmentId 
    {

        /// <summary>
        /// 中心网络附件对端实例的连接ID，企业路由器的连接ID或者GDGW的连接ID。
        /// </summary>
        [JsonProperty("attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _AttachmentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentId {\n");
            sb.Append("  _attachmentId: ").Append(_AttachmentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentId input)
        {
            if (input == null) return false;
            if (this._AttachmentId != input._AttachmentId || (this._AttachmentId != null && !this._AttachmentId.Equals(input._AttachmentId))) return false;

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
                if (this._AttachmentId != null) hashCode = hashCode * 59 + this._AttachmentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
