using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkloadNodeVO 
    {

        /// <summary>
        /// **参数解释**：作业运行节点的IP地址。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("hostIp", NullValueHandling = NullValueHandling.Ignore)]
        public string HostIp { get; set; }

        /// <summary>
        /// **参数解释**：NPU卡的资源使用拓扑信息，长度为16的二进制编码，右起第一位编码代表卡1。其中，1表示占用，0表示空闲。例如，16卡的机型中卡1和卡15被占用，值为0100000000000001；8卡的机型中卡1和卡7被占用，返回值为0000000001000001。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("npuTopologyPlacement", NullValueHandling = NullValueHandling.Ignore)]
        public string NpuTopologyPlacement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resourceRequirement", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceRequirementVO ResourceRequirement { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkloadNodeVO {\n");
            sb.Append("  hostIp: ").Append(HostIp).Append("\n");
            sb.Append("  npuTopologyPlacement: ").Append(NpuTopologyPlacement).Append("\n");
            sb.Append("  resourceRequirement: ").Append(ResourceRequirement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkloadNodeVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkloadNodeVO input)
        {
            if (input == null) return false;
            if (this.HostIp != input.HostIp || (this.HostIp != null && !this.HostIp.Equals(input.HostIp))) return false;
            if (this.NpuTopologyPlacement != input.NpuTopologyPlacement || (this.NpuTopologyPlacement != null && !this.NpuTopologyPlacement.Equals(input.NpuTopologyPlacement))) return false;
            if (this.ResourceRequirement != input.ResourceRequirement || (this.ResourceRequirement != null && !this.ResourceRequirement.Equals(input.ResourceRequirement))) return false;

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
                if (this.HostIp != null) hashCode = hashCode * 59 + this.HostIp.GetHashCode();
                if (this.NpuTopologyPlacement != null) hashCode = hashCode * 59 + this.NpuTopologyPlacement.GetHashCode();
                if (this.ResourceRequirement != null) hashCode = hashCode * 59 + this.ResourceRequirement.GetHashCode();
                return hashCode;
            }
        }
    }
}
