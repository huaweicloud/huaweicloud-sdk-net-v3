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
    /// 弹性云服务器规格信息。
    /// </summary>
    public class ServerFlavor 
    {

        /// <summary>
        /// 弹性云服务器规格ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性云服务器规格名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 该云服务器规格对应要求系统盘大小，0为不限制。此字段在本系统中无效。
        /// </summary>
        [JsonProperty("disk", NullValueHandling = NullValueHandling.Ignore)]
        public string Disk { get; set; }

        /// <summary>
        /// 该云服务器规格对应的CPU核数。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        /// <summary>
        /// 该云服务器规格对应的内存大小，单位为MB。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public string Ram { get; set; }

        /// <summary>
        /// 该云服务器规格对应的GPU设备。
        /// </summary>
        [JsonProperty("gpus", NullValueHandling = NullValueHandling.Ignore)]
        public List<GpuInfo> Gpus { get; set; }

        /// <summary>
        /// 该云服务器规格对应的ASIC设备。
        /// </summary>
        [JsonProperty("asic_accelerators", NullValueHandling = NullValueHandling.Ignore)]
        public List<ASICAcceleratorInfo> AsicAccelerators { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerFlavor {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  disk: ").Append(Disk).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  gpus: ").Append(Gpus).Append("\n");
            sb.Append("  asicAccelerators: ").Append(AsicAccelerators).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerFlavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerFlavor input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Disk != input.Disk || (this.Disk != null && !this.Disk.Equals(input.Disk))) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;
            if (this.Ram != input.Ram || (this.Ram != null && !this.Ram.Equals(input.Ram))) return false;
            if (this.Gpus != input.Gpus || (this.Gpus != null && input.Gpus != null && !this.Gpus.SequenceEqual(input.Gpus))) return false;
            if (this.AsicAccelerators != input.AsicAccelerators || (this.AsicAccelerators != null && input.AsicAccelerators != null && !this.AsicAccelerators.SequenceEqual(input.AsicAccelerators))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Disk != null) hashCode = hashCode * 59 + this.Disk.GetHashCode();
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null) hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.Gpus != null) hashCode = hashCode * 59 + this.Gpus.GetHashCode();
                if (this.AsicAccelerators != null) hashCode = hashCode * 59 + this.AsicAccelerators.GetHashCode();
                return hashCode;
            }
        }
    }
}
