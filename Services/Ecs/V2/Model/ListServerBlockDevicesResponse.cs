using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListServerBlockDevicesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attachableQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public BlockDeviceAttachableQuantity AttachableQuantity { get; set; }

        /// <summary>
        /// 云服务器挂载信息列表。
        /// </summary>
        [JsonProperty("volumeAttachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServerBlockDevice> VolumeAttachments { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServerBlockDevicesResponse {\n");
            sb.Append("  attachableQuantity: ").Append(AttachableQuantity).Append("\n");
            sb.Append("  volumeAttachments: ").Append(VolumeAttachments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServerBlockDevicesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServerBlockDevicesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttachableQuantity == input.AttachableQuantity ||
                    (this.AttachableQuantity != null &&
                    this.AttachableQuantity.Equals(input.AttachableQuantity))
                ) && 
                (
                    this.VolumeAttachments == input.VolumeAttachments ||
                    this.VolumeAttachments != null &&
                    input.VolumeAttachments != null &&
                    this.VolumeAttachments.SequenceEqual(input.VolumeAttachments)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AttachableQuantity != null)
                    hashCode = hashCode * 59 + this.AttachableQuantity.GetHashCode();
                if (this.VolumeAttachments != null)
                    hashCode = hashCode * 59 + this.VolumeAttachments.GetHashCode();
                return hashCode;
            }
        }
    }
}
