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
    /// 中心网络附件对端实例ID，企业路由器的路由表ID或者GDGW的ID。
    /// </summary>
    public class AttachmentInstanceId 
    {

        /// <summary>
        /// 中心网络附件对端实例ID，企业路由器的路由表ID或者GDGW的ID。
        /// </summary>
        [JsonProperty("attachment_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _AttachmentInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentInstanceId {\n");
            sb.Append("  _attachmentInstanceId: ").Append(_AttachmentInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentInstanceId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentInstanceId input)
        {
            if (input == null) return false;
            if (this._AttachmentInstanceId != input._AttachmentInstanceId || (this._AttachmentInstanceId != null && !this._AttachmentInstanceId.Equals(input._AttachmentInstanceId))) return false;

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
                if (this._AttachmentInstanceId != null) hashCode = hashCode * 59 + this._AttachmentInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
