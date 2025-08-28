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
    /// 中心网络附件对端实例的项目ID。
    /// </summary>
    public class AttachmentInstanceProjectId 
    {

        /// <summary>
        /// 中心网络附件对端实例的项目ID。
        /// </summary>
        [JsonProperty("attachment_instance_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _AttachmentInstanceProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentInstanceProjectId {\n");
            sb.Append("  _attachmentInstanceProjectId: ").Append(_AttachmentInstanceProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentInstanceProjectId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentInstanceProjectId input)
        {
            if (input == null) return false;
            if (this._AttachmentInstanceProjectId != input._AttachmentInstanceProjectId || (this._AttachmentInstanceProjectId != null && !this._AttachmentInstanceProjectId.Equals(input._AttachmentInstanceProjectId))) return false;

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
                if (this._AttachmentInstanceProjectId != null) hashCode = hashCode * 59 + this._AttachmentInstanceProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
