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
    /// 资源规格描述信息。
    /// </summary>
    public class ResourceFlavorSpec 
    {

        /// <summary>
        /// **参数解释**：资源规格类型。 **取值范围**：可选值如下： - Dedicate：物理资源规格。物理资源规格可以创建节点资源。 [- Logical：逻辑资源规格。](tag:hcso)
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：资源规格实例的计算架构。 **取值范围**：可选值如下： - x86：x86架构。 - arm64：ARM架构。
        /// </summary>
        [JsonProperty("cpuArch", NullValueHandling = NullValueHandling.Ignore)]
        public string CpuArch { get; set; }

        /// <summary>
        /// **参数解释**：资源规格实例的CPU核心数量。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// **参数解释**：资源规格实例的内存大小。以Gi为单位。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gpu", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceFlavorSpecGpu Gpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("npu", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceFlavorSpecNpu Npu { get; set; }

        /// <summary>
        /// **参数解释**：资源规格实例的存储资源信息。
        /// </summary>
        [JsonProperty("dataVolume", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceFlavorSpecDataVolume> DataVolume { get; set; }

        /// <summary>
        /// **参数解释**：资源规格支持的计费模式。
        /// </summary>
        [JsonProperty("billingModes", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> BillingModes { get; set; }

        /// <summary>
        /// **参数解释**：资源规格计费码。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("billingCode", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingCode { get; set; }

        /// <summary>
        /// **参数解释**：资源规格支持的作业类型列表。
        /// </summary>
        [JsonProperty("jobFlavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobFlavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceFlavorSpec {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cpuArch: ").Append(CpuArch).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  gpu: ").Append(Gpu).Append("\n");
            sb.Append("  npu: ").Append(Npu).Append("\n");
            sb.Append("  dataVolume: ").Append(DataVolume).Append("\n");
            sb.Append("  billingModes: ").Append(BillingModes).Append("\n");
            sb.Append("  billingCode: ").Append(BillingCode).Append("\n");
            sb.Append("  jobFlavors: ").Append(JobFlavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceFlavorSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceFlavorSpec input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.CpuArch != input.CpuArch || (this.CpuArch != null && !this.CpuArch.Equals(input.CpuArch))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Gpu != input.Gpu || (this.Gpu != null && !this.Gpu.Equals(input.Gpu))) return false;
            if (this.Npu != input.Npu || (this.Npu != null && !this.Npu.Equals(input.Npu))) return false;
            if (this.DataVolume != input.DataVolume || (this.DataVolume != null && input.DataVolume != null && !this.DataVolume.SequenceEqual(input.DataVolume))) return false;
            if (this.BillingModes != input.BillingModes || (this.BillingModes != null && input.BillingModes != null && !this.BillingModes.SequenceEqual(input.BillingModes))) return false;
            if (this.BillingCode != input.BillingCode || (this.BillingCode != null && !this.BillingCode.Equals(input.BillingCode))) return false;
            if (this.JobFlavors != input.JobFlavors || (this.JobFlavors != null && input.JobFlavors != null && !this.JobFlavors.SequenceEqual(input.JobFlavors))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CpuArch != null) hashCode = hashCode * 59 + this.CpuArch.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Gpu != null) hashCode = hashCode * 59 + this.Gpu.GetHashCode();
                if (this.Npu != null) hashCode = hashCode * 59 + this.Npu.GetHashCode();
                if (this.DataVolume != null) hashCode = hashCode * 59 + this.DataVolume.GetHashCode();
                if (this.BillingModes != null) hashCode = hashCode * 59 + this.BillingModes.GetHashCode();
                if (this.BillingCode != null) hashCode = hashCode * 59 + this.BillingCode.GetHashCode();
                if (this.JobFlavors != null) hashCode = hashCode * 59 + this.JobFlavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
