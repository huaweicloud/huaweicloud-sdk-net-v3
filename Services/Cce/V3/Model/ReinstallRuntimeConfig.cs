using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点重装场景容器运行时配置
    /// </summary>
    public class ReinstallRuntimeConfig 
    {

        /// <summary>
        /// **参数解释**: 节点上单容器的可用磁盘空间大小（已废弃，请优先使用containerBaseSize参数），单位G。  不配置该值或值为0时将使用默认值，Devicemapper模式下默认值为10；OverlayFS模式默认不限制单容器可用空间大小，且dockerBaseSize设置仅在新版本集群的EulerOS[/HCEOS2.0](tag:hws,hws_hk,ctc,cmcc)节点上生效。  CCE节点容器运行时空间配置请参考[数据盘空间分配说明](cce_01_0341.xml)。  Devicemapper模式下建议dockerBaseSize配置不超过80G，设置过大时可能会导致容器运行时初始化时间过长而启动失败，若对容器磁盘大小有特殊要求，可考虑使用挂载外部或本地存储方式代替。 **约束限制**: 不涉及 **取值范围**: 不涉及 **默认取值**: 不涉及
        /// </summary>
        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? DockerBaseSize { get; set; }

        /// <summary>
        /// **参数解释**： 节点上单容器的可用磁盘空间大小，单位G。 &gt; - 更新节点池时，不支持更新此参数 &gt; - 不配置该值或值为0时将使用默认值，OverlayFS模式默认不限制单容器可用空间大小；Devicemapper模式下默认值为10，且containerBaseSize设置仅在新版本集群（v1.23.14-r0/v1.25.9-r0/v1.27.6-r0/v1.28.4-r0及以上）的EulerOS[/HCEOS2.0](tag:hws,hws_hk,ctc,cmcc)节点上生效。           &gt; - CCE节点容器运行时空间配置请参考[数据盘空间分配说明](cce_01_0341.xml)。        &gt; - Devicemapper模式下建议containerBaseSize配置不超过80G，设置过大时可能会导致容器运行时初始化时间过长而启动失败，若对容器磁盘大小有特殊要求，可考虑使用挂载外部或本地存储方式代替；Devicemapper模式在新版中仅有共池裸机使用，已逐步废弃。  **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [JsonProperty("containerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContainerBaseSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public Runtime Runtime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReinstallRuntimeConfig {\n");
            sb.Append("  dockerBaseSize: ").Append(DockerBaseSize).Append("\n");
            sb.Append("  containerBaseSize: ").Append(ContainerBaseSize).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallRuntimeConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallRuntimeConfig input)
        {
            if (input == null) return false;
            if (this.DockerBaseSize != input.DockerBaseSize || (this.DockerBaseSize != null && !this.DockerBaseSize.Equals(input.DockerBaseSize))) return false;
            if (this.ContainerBaseSize != input.ContainerBaseSize || (this.ContainerBaseSize != null && !this.ContainerBaseSize.Equals(input.ContainerBaseSize))) return false;
            if (this.Runtime != input.Runtime || (this.Runtime != null && !this.Runtime.Equals(input.Runtime))) return false;

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
                if (this.DockerBaseSize != null) hashCode = hashCode * 59 + this.DockerBaseSize.GetHashCode();
                if (this.ContainerBaseSize != null) hashCode = hashCode * 59 + this.ContainerBaseSize.GetHashCode();
                if (this.Runtime != null) hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                return hashCode;
            }
        }
    }
}
