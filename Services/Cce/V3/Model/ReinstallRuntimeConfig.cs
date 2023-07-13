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
        /// 节点上单容器的可用磁盘空间大小，单位G。  不配置该值或值为0时将使用默认值，Devicemapper模式下默认值为10；OverlayFS模式默认不限制单容器可用空间大小，且dockerBaseSize设置仅在新版本集群的EulerOS节点上生效。  CCE节点容器运行时空间配置请参考[数据盘空间分配说明](cce_01_0341.xml)。  Devicemapper模式下建议dockerBaseSize配置不超过80G，设置过大时可能会导致容器运行时初始化时间过长而启动失败，若对容器磁盘大小有特殊要求，可考虑使用挂载外部或本地存储方式代替。 
        /// </summary>
        [JsonProperty("dockerBaseSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? DockerBaseSize { get; set; }

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
            if (input == null)
                return false;

            return 
                (
                    this.DockerBaseSize == input.DockerBaseSize ||
                    (this.DockerBaseSize != null &&
                    this.DockerBaseSize.Equals(input.DockerBaseSize))
                ) && 
                (
                    this.Runtime == input.Runtime ||
                    (this.Runtime != null &&
                    this.Runtime.Equals(input.Runtime))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DockerBaseSize != null)
                    hashCode = hashCode * 59 + this.DockerBaseSize.GetHashCode();
                if (this.Runtime != null)
                    hashCode = hashCode * 59 + this.Runtime.GetHashCode();
                return hashCode;
            }
        }
    }
}
