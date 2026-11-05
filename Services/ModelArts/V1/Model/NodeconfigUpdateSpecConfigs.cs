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
    /// **参数解释**：待更新的节点配置。支持镜像预热（image_warm_up）、CPU管理策略（cpu_manager）、缓存清理（drop_cache）、透明大页（transparent_hugepage）等配置项。 **约束限制**：仅Dedicate（专属）资源池支持修改节点配置，非专属资源池调用将返回403。镜像预热配置仅在资源池机型为支持镜像预热的裸金属规格（Ascend 910B/910C）时可用。 **取值范围**：不涉及。 **默认取值**：不涉及。
    /// </summary>
    public class NodeconfigUpdateSpecConfigs 
    {

        /// <summary>
        /// **参数解释**：镜像预热配置。用于创建或删除镜像预热任务，镜像会被提前拉取到资源池节点，缩短训练任务启动时间。 **约束限制**：镜像预热任务数量上限为10；同一请求内任务名称不可重复、镜像地址不可重复；仅标准池支持，Lite资源池不支持该配置。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("image_warm_up", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeconfigUpdateSpecConfigsImageWarmUp> ImageWarmUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu_manager", NullValueHandling = NullValueHandling.Ignore)]
        public NodeconfigUpdateSpecConfigsCpuManager CpuManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("drop_cache", NullValueHandling = NullValueHandling.Ignore)]
        public NodeconfigUpdateSpecConfigsDropCache DropCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transparent_hugepage", NullValueHandling = NullValueHandling.Ignore)]
        public NodeconfigUpdateSpecConfigsTransparentHugepage TransparentHugepage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeconfigUpdateSpecConfigs {\n");
            sb.Append("  imageWarmUp: ").Append(ImageWarmUp).Append("\n");
            sb.Append("  cpuManager: ").Append(CpuManager).Append("\n");
            sb.Append("  dropCache: ").Append(DropCache).Append("\n");
            sb.Append("  transparentHugepage: ").Append(TransparentHugepage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeconfigUpdateSpecConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeconfigUpdateSpecConfigs input)
        {
            if (input == null) return false;
            if (this.ImageWarmUp != input.ImageWarmUp || (this.ImageWarmUp != null && input.ImageWarmUp != null && !this.ImageWarmUp.SequenceEqual(input.ImageWarmUp))) return false;
            if (this.CpuManager != input.CpuManager || (this.CpuManager != null && !this.CpuManager.Equals(input.CpuManager))) return false;
            if (this.DropCache != input.DropCache || (this.DropCache != null && !this.DropCache.Equals(input.DropCache))) return false;
            if (this.TransparentHugepage != input.TransparentHugepage || (this.TransparentHugepage != null && !this.TransparentHugepage.Equals(input.TransparentHugepage))) return false;

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
                if (this.ImageWarmUp != null) hashCode = hashCode * 59 + this.ImageWarmUp.GetHashCode();
                if (this.CpuManager != null) hashCode = hashCode * 59 + this.CpuManager.GetHashCode();
                if (this.DropCache != null) hashCode = hashCode * 59 + this.DropCache.GetHashCode();
                if (this.TransparentHugepage != null) hashCode = hashCode * 59 + this.TransparentHugepage.GetHashCode();
                return hashCode;
            }
        }
    }
}
