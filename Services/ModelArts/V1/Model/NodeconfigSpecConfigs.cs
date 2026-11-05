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
    /// **参数解释**： 节点自定义配置；当前支持节点绑核（cpu_manager）、缓存清理（drop_cache）、透明大页（transparent_hugepage）和镜像预热（image_warm_up）。 **约束限制**：仅Dedicate（专属）资源池支持修改节点配置，非专属资源池调用将返回403。 **取值范围**：不涉及。 **默认取值**：不涉及。
    /// </summary>
    public class NodeconfigSpecConfigs 
    {

        /// <summary>
        /// **参数解释**：镜像预热任务配置列表。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("image_warm_up", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodeconfigSpecConfigsImageWarmUp> ImageWarmUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cpu_manager", NullValueHandling = NullValueHandling.Ignore)]
        public NodeconfigSpecConfigsCpuManager CpuManager { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("drop_cache", NullValueHandling = NullValueHandling.Ignore)]
        public NodeconfigSpecConfigsDropCache DropCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("transparent_hugepage", NullValueHandling = NullValueHandling.Ignore)]
        public NodeconfigSpecConfigsTransparentHugepage TransparentHugepage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeconfigSpecConfigs {\n");
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
            return this.Equals(input as NodeconfigSpecConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeconfigSpecConfigs input)
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
