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
    /// **参数解释**：资源池自定义配置参数。
    /// </summary>
    public class PoolSpecModelExtendParams 
    {

        /// <summary>
        /// **参数解释**：资源池创建的节点的容器引擎空间大小。值为0时表示不限制大小。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerBaseSize { get; set; }

        /// <summary>
        /// **参数描述**：磁盘分组名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("volumeGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeGroup { get; set; }

        /// <summary>
        /// **参数描述**：模型运行时环境。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public string Runtime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolSpecModelExtendParams {\n");
            sb.Append("  dockerBaseSize: ").Append(DockerBaseSize).Append("\n");
            sb.Append("  volumeGroup: ").Append(VolumeGroup).Append("\n");
            sb.Append("  runtime: ").Append(Runtime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolSpecModelExtendParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolSpecModelExtendParams input)
        {
            if (input == null) return false;
            if (this.DockerBaseSize != input.DockerBaseSize || (this.DockerBaseSize != null && !this.DockerBaseSize.Equals(input.DockerBaseSize))) return false;
            if (this.VolumeGroup != input.VolumeGroup || (this.VolumeGroup != null && !this.VolumeGroup.Equals(input.VolumeGroup))) return false;
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
                if (this.VolumeGroup != null) hashCode = hashCode * 59 + this.VolumeGroup.GetHashCode();
                if (this.Runtime != null) hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                return hashCode;
            }
        }
    }
}
