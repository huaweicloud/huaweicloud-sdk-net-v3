using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 服务器规格
    /// </summary>
    public class ServerSpec 
    {

        /// <summary>
        /// 服务器规格ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 服务器规格名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server_type", NullValueHandling = NullValueHandling.Ignore)]
        public ServerType? ServerType { get; set; }

        /// <summary>
        /// 服务器发放的资源规格类型
        /// </summary>
        [JsonProperty("flavor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorType { get; set; }

        /// <summary>
        /// 服务器规格分类。如通用计算型/云桌面型/网关型等。
        /// </summary>
        [JsonProperty("performance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PerformanceType { get; set; }

        /// <summary>
        /// 服务器功率（单位：w）
        /// </summary>
        [JsonProperty("power", NullValueHandling = NullValueHandling.Ignore)]
        public int? Power { get; set; }

        /// <summary>
        /// 设备高度。U位数
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Unit { get; set; }

        /// <summary>
        /// 可用虚拟CPU核数
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }

        /// <summary>
        /// 可用内存大小。单位：GB
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? Memory { get; set; }

        /// <summary>
        /// 可用存储容量。单位：TiB
        /// </summary>
        [JsonProperty("storage_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageCapacity { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("cpu_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuName { get; set; }

        /// <summary>
        /// CPU架构
        /// </summary>
        [JsonProperty("cpu_architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuArchitecture { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerSpec {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  flavorType: ").Append(FlavorType).Append("\n");
            sb.Append("  performanceType: ").Append(PerformanceType).Append("\n");
            sb.Append("  power: ").Append(Power).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  storageCapacity: ").Append(StorageCapacity).Append("\n");
            sb.Append("  cpuName: ").Append(CpuName).Append("\n");
            sb.Append("  cpuArchitecture: ").Append(CpuArchitecture).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerSpec input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ServerType != input.ServerType || (this.ServerType != null && !this.ServerType.Equals(input.ServerType))) return false;
            if (this.FlavorType != input.FlavorType || (this.FlavorType != null && !this.FlavorType.Equals(input.FlavorType))) return false;
            if (this.PerformanceType != input.PerformanceType || (this.PerformanceType != null && !this.PerformanceType.Equals(input.PerformanceType))) return false;
            if (this.Power != input.Power || (this.Power != null && !this.Power.Equals(input.Power))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.StorageCapacity != input.StorageCapacity || (this.StorageCapacity != null && !this.StorageCapacity.Equals(input.StorageCapacity))) return false;
            if (this.CpuName != input.CpuName || (this.CpuName != null && !this.CpuName.Equals(input.CpuName))) return false;
            if (this.CpuArchitecture != input.CpuArchitecture || (this.CpuArchitecture != null && !this.CpuArchitecture.Equals(input.CpuArchitecture))) return false;

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
                if (this.ServerType != null) hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.FlavorType != null) hashCode = hashCode * 59 + this.FlavorType.GetHashCode();
                if (this.PerformanceType != null) hashCode = hashCode * 59 + this.PerformanceType.GetHashCode();
                if (this.Power != null) hashCode = hashCode * 59 + this.Power.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.StorageCapacity != null) hashCode = hashCode * 59 + this.StorageCapacity.GetHashCode();
                if (this.CpuName != null) hashCode = hashCode * 59 + this.CpuName.GetHashCode();
                if (this.CpuArchitecture != null) hashCode = hashCode * 59 + this.CpuArchitecture.GetHashCode();
                return hashCode;
            }
        }
    }
}
