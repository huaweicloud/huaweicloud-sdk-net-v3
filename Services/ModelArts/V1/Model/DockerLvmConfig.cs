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
    /// 节点容器磁盘配置项信息。
    /// </summary>
    public class DockerLvmConfig 
    {

        /// <summary>
        /// **参数解释**： 资源池节点Docker盘占数据盘的百分比。例如Docker盘大小占用数据盘20%，该参数值为20。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("dockerThinPool", NullValueHandling = NullValueHandling.Ignore)]
        public int? DockerThinPool { get; set; }

        /// <summary>
        /// **参数解释**： 资源池节点上kubelet占数据盘的百分比。例如Docker盘大小占用数据盘20%，该参数值为20。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("kubernetesLV", NullValueHandling = NullValueHandling.Ignore)]
        public int? KubernetesLV { get; set; }

        /// <summary>
        /// **参数解释**： 磁盘类型。 **取值范围**： 可选值如下： - evs：云硬盘 - ssd：本地SSD硬盘
        /// </summary>
        [JsonProperty("dockerDiskType", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerDiskType { get; set; }

        /// <summary>
        /// **参数解释**： LVM写入模式。 **取值范围**： 可选值如下： - striped：条带模式，使用多块磁盘组成条带模式，能够提升磁盘性能 - linear：线性模式
        /// </summary>
        [JsonProperty("lvType", NullValueHandling = NullValueHandling.Ignore)]
        public string LvType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DockerLvmConfig {\n");
            sb.Append("  dockerThinPool: ").Append(DockerThinPool).Append("\n");
            sb.Append("  kubernetesLV: ").Append(KubernetesLV).Append("\n");
            sb.Append("  dockerDiskType: ").Append(DockerDiskType).Append("\n");
            sb.Append("  lvType: ").Append(LvType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DockerLvmConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DockerLvmConfig input)
        {
            if (input == null) return false;
            if (this.DockerThinPool != input.DockerThinPool || (this.DockerThinPool != null && !this.DockerThinPool.Equals(input.DockerThinPool))) return false;
            if (this.KubernetesLV != input.KubernetesLV || (this.KubernetesLV != null && !this.KubernetesLV.Equals(input.KubernetesLV))) return false;
            if (this.DockerDiskType != input.DockerDiskType || (this.DockerDiskType != null && !this.DockerDiskType.Equals(input.DockerDiskType))) return false;
            if (this.LvType != input.LvType || (this.LvType != null && !this.LvType.Equals(input.LvType))) return false;

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
                if (this.DockerThinPool != null) hashCode = hashCode * 59 + this.DockerThinPool.GetHashCode();
                if (this.KubernetesLV != null) hashCode = hashCode * 59 + this.KubernetesLV.GetHashCode();
                if (this.DockerDiskType != null) hashCode = hashCode * 59 + this.DockerDiskType.GetHashCode();
                if (this.LvType != null) hashCode = hashCode * 59 + this.LvType.GetHashCode();
                return hashCode;
            }
        }
    }
}
