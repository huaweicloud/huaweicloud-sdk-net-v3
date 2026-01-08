using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 云办公主机的属性。
    /// </summary>
    public class ListHostsRspHostProperties 
    {

        /// <summary>
        /// 云办公主机的vCPUs个数。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public int? Vcpus { get; set; }

        /// <summary>
        /// 云办公主机的物理核数。
        /// </summary>
        [JsonProperty("cores", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cores { get; set; }

        /// <summary>
        /// 云办公主机的物理套接字数量。
        /// </summary>
        [JsonProperty("sockets", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sockets { get; set; }

        /// <summary>
        /// 云办公主机的物理内存大小。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public int? Memory { get; set; }

        /// <summary>
        /// 云办公主机类型。
        /// </summary>
        [JsonProperty("host_type", NullValueHandling = NullValueHandling.Ignore)]
        public string HostType { get; set; }

        /// <summary>
        /// 云办公主机类型名称。
        /// </summary>
        [JsonProperty("host_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostTypeName { get; set; }

        /// <summary>
        /// 可以创建的规格。
        /// </summary>
        [JsonProperty("available_instance_capacities", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListHostsRspHostPropertiesAvailableInstanceCapacities> AvailableInstanceCapacities { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHostsRspHostProperties {\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  cores: ").Append(Cores).Append("\n");
            sb.Append("  sockets: ").Append(Sockets).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  hostType: ").Append(HostType).Append("\n");
            sb.Append("  hostTypeName: ").Append(HostTypeName).Append("\n");
            sb.Append("  availableInstanceCapacities: ").Append(AvailableInstanceCapacities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHostsRspHostProperties);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHostsRspHostProperties input)
        {
            if (input == null) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;
            if (this.Cores != input.Cores || (this.Cores != null && !this.Cores.Equals(input.Cores))) return false;
            if (this.Sockets != input.Sockets || (this.Sockets != null && !this.Sockets.Equals(input.Sockets))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.HostType != input.HostType || (this.HostType != null && !this.HostType.Equals(input.HostType))) return false;
            if (this.HostTypeName != input.HostTypeName || (this.HostTypeName != null && !this.HostTypeName.Equals(input.HostTypeName))) return false;
            if (this.AvailableInstanceCapacities != input.AvailableInstanceCapacities || (this.AvailableInstanceCapacities != null && input.AvailableInstanceCapacities != null && !this.AvailableInstanceCapacities.SequenceEqual(input.AvailableInstanceCapacities))) return false;

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
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Cores != null) hashCode = hashCode * 59 + this.Cores.GetHashCode();
                if (this.Sockets != null) hashCode = hashCode * 59 + this.Sockets.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.HostType != null) hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.HostTypeName != null) hashCode = hashCode * 59 + this.HostTypeName.GetHashCode();
                if (this.AvailableInstanceCapacities != null) hashCode = hashCode * 59 + this.AvailableInstanceCapacities.GetHashCode();
                return hashCode;
            }
        }
    }
}
