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
    /// 裸金属服务器挂载信息列表
    /// </summary>
    public class VolumeAttachments 
    {

        /// <summary>
        /// 挂载资源ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// 所属裸金属服务器ID
        /// </summary>
        [JsonProperty("serverId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServerId { get; set; }

        /// <summary>
        /// 挂载云磁盘ID
        /// </summary>
        [JsonProperty("volumeId", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? VolumeId { get; set; }

        /// <summary>
        /// 挂载目录，例如“/dev/sdd”。
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeAttachments {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeAttachments);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeAttachments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
                ) && 
                (
                    this.Device == input.Device ||
                    (this.Device != null &&
                    this.Device.Equals(input.Device))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                return hashCode;
            }
        }
    }
}
