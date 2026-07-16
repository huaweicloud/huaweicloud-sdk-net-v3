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
    /// **参数解释**：自定义配置参数。 **约束限制**：不涉及。
    /// </summary>
    public class PoolResourceFlavorExtendParams 
    {

        /// <summary>
        /// **参数解释**：指定资源池节点的容器引擎空间大小。值为0时表示不限制大小。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public string DockerBaseSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolResourceFlavorExtendParams {\n");
            sb.Append("  dockerBaseSize: ").Append(DockerBaseSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolResourceFlavorExtendParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolResourceFlavorExtendParams input)
        {
            if (input == null) return false;
            if (this.DockerBaseSize != input.DockerBaseSize || (this.DockerBaseSize != null && !this.DockerBaseSize.Equals(input.DockerBaseSize))) return false;

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
                return hashCode;
            }
        }
    }
}
