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
    /// 查询云服务器指定磁盘挂载信息响应信息
    /// </summary>
    public class ServerBlockDevice 
    {

        /// <summary>
        /// 云硬盘启动顺序。  - 0为系统盘。  - 非0为数据盘
        /// </summary>
        [JsonProperty("bootIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? BootIndex { get; set; }

        /// <summary>
        /// pci地址。
        /// </summary>
        [JsonProperty("pciAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string PciAddress { get; set; }

        /// <summary>
        /// 云硬盘ID，UUID格式。
        /// </summary>
        [JsonProperty("volumeId", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }

        /// <summary>
        /// 云硬盘挂载盘符，即磁盘挂载点。
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// 弹性云服务器ID，UUID格式。
        /// </summary>
        [JsonProperty("serverId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 挂载ID，与云硬盘ID相同。UUID格式。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云硬盘大小，单位GB。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 磁盘总线类型 。  取值范围：virtio、scsi
        /// </summary>
        [JsonProperty("bus", NullValueHandling = NullValueHandling.Ignore)]
        public string Bus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerBlockDevice {\n");
            sb.Append("  bootIndex: ").Append(BootIndex).Append("\n");
            sb.Append("  pciAddress: ").Append(PciAddress).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  bus: ").Append(Bus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerBlockDevice);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerBlockDevice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BootIndex == input.BootIndex ||
                    (this.BootIndex != null &&
                    this.BootIndex.Equals(input.BootIndex))
                ) && 
                (
                    this.PciAddress == input.PciAddress ||
                    (this.PciAddress != null &&
                    this.PciAddress.Equals(input.PciAddress))
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
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Bus == input.Bus ||
                    (this.Bus != null &&
                    this.Bus.Equals(input.Bus))
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
                if (this.BootIndex != null)
                    hashCode = hashCode * 59 + this.BootIndex.GetHashCode();
                if (this.PciAddress != null)
                    hashCode = hashCode * 59 + this.PciAddress.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Bus != null)
                    hashCode = hashCode * 59 + this.Bus.GetHashCode();
                return hashCode;
            }
        }
    }
}
