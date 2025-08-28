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
    /// 连接的父资源ID，这里表示企业路由器ID。
    /// </summary>
    public class AttachmentParentInstanceId 
    {

        /// <summary>
        /// 连接的父资源ID，这里表示企业路由器ID。
        /// </summary>
        [JsonProperty("attachment_parent_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _AttachmentParentInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentParentInstanceId {\n");
            sb.Append("  _attachmentParentInstanceId: ").Append(_AttachmentParentInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentParentInstanceId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentParentInstanceId input)
        {
            if (input == null) return false;
            if (this._AttachmentParentInstanceId != input._AttachmentParentInstanceId || (this._AttachmentParentInstanceId != null && !this._AttachmentParentInstanceId.Equals(input._AttachmentParentInstanceId))) return false;

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
                if (this._AttachmentParentInstanceId != null) hashCode = hashCode * 59 + this._AttachmentParentInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
