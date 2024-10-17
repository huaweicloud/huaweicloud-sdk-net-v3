using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DetachBaremetalServerVolumeRequest 
    {

        /// <summary>
        /// 裸金属服务器ID
        /// </summary>
        [SDKProperty("server_id", IsPath = true)]
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 裸金属服务器的云磁盘ID
        /// </summary>
        [SDKProperty("attachment_id", IsPath = true)]
        [JsonProperty("attachment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachmentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetachBaremetalServerVolumeRequest {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  attachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetachBaremetalServerVolumeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetachBaremetalServerVolumeRequest input)
        {
            if (input == null) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;
            if (this.AttachmentId != input.AttachmentId || (this.AttachmentId != null && !this.AttachmentId.Equals(input.AttachmentId))) return false;

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
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.AttachmentId != null) hashCode = hashCode * 59 + this.AttachmentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
