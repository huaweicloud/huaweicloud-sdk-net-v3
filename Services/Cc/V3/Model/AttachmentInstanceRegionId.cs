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
    /// 中心网络附件对端实例的regionID。
    /// </summary>
    public class AttachmentInstanceRegionId 
    {

        /// <summary>
        /// 中心网络附件对端实例的regionID。
        /// </summary>
        [JsonProperty("attachment_instance_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string _AttachmentInstanceRegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentInstanceRegionId {\n");
            sb.Append("  _attachmentInstanceRegionId: ").Append(_AttachmentInstanceRegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentInstanceRegionId);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentInstanceRegionId input)
        {
            if (input == null) return false;
            if (this._AttachmentInstanceRegionId != input._AttachmentInstanceRegionId || (this._AttachmentInstanceRegionId != null && !this._AttachmentInstanceRegionId.Equals(input._AttachmentInstanceRegionId))) return false;

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
                if (this._AttachmentInstanceRegionId != null) hashCode = hashCode * 59 + this._AttachmentInstanceRegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
