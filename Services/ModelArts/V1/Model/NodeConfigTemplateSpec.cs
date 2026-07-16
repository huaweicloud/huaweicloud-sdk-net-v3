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
    /// 节点配置模板信息。
    /// </summary>
    public class NodeConfigTemplateSpec 
    {

        /// <summary>
        /// **参数解释**： 资源池节点上单容器的可用磁盘空间大小，单位G。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? DockerBaseSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dockerLvmConfig", NullValueHandling = NullValueHandling.Ignore)]
        public DockerLvmConfig DockerLvmConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeConfigTemplateSpec {\n");
            sb.Append("  dockerBaseSize: ").Append(DockerBaseSize).Append("\n");
            sb.Append("  dockerLvmConfig: ").Append(DockerLvmConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeConfigTemplateSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeConfigTemplateSpec input)
        {
            if (input == null) return false;
            if (this.DockerBaseSize != input.DockerBaseSize || (this.DockerBaseSize != null && !this.DockerBaseSize.Equals(input.DockerBaseSize))) return false;
            if (this.DockerLvmConfig != input.DockerLvmConfig || (this.DockerLvmConfig != null && !this.DockerLvmConfig.Equals(input.DockerLvmConfig))) return false;

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
                if (this.DockerLvmConfig != null) hashCode = hashCode * 59 + this.DockerLvmConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
