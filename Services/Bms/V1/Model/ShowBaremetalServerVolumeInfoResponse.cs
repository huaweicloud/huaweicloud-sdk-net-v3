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
    /// Response Object
    /// </summary>
    public class ShowBaremetalServerVolumeInfoResponse : SdkResponse
    {

        /// <summary>
        /// 裸金属服务器挂载信息列表，详情请参见表2 volumeAttachments字段数据结构说明。
        /// </summary>
        [JsonProperty("volumeAttachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeAttachments> VolumeAttachments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBaremetalServerVolumeInfoResponse {\n");
            sb.Append("  volumeAttachments: ").Append(VolumeAttachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBaremetalServerVolumeInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBaremetalServerVolumeInfoResponse input)
        {
            if (input == null) return false;
            if (this.VolumeAttachments != input.VolumeAttachments || (this.VolumeAttachments != null && input.VolumeAttachments != null && !this.VolumeAttachments.SequenceEqual(input.VolumeAttachments))) return false;

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
                if (this.VolumeAttachments != null) hashCode = hashCode * 59 + this.VolumeAttachments.GetHashCode();
                return hashCode;
            }
        }
    }
}
