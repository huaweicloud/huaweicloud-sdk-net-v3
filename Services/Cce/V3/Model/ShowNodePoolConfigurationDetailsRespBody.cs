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
    /// 获取指定节点池配置参数列表返回体
    /// </summary>
    public class ShowNodePoolConfigurationDetailsRespBody 
    {

        /// <summary>
        /// 配置参数，由key/value组成。
        /// </summary>
        [JsonProperty("kubelet", NullValueHandling = NullValueHandling.Ignore)]
        public List<PackageOptions> Kubelet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNodePoolConfigurationDetailsRespBody {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  kubelet: ").Append(Kubelet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNodePoolConfigurationDetailsRespBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNodePoolConfigurationDetailsRespBody input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Kubelet == input.Kubelet ||
                    this.Kubelet != null &&
                    input.Kubelet != null &&
                    this.Kubelet.SequenceEqual(input.Kubelet)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Kubelet != null)
                    hashCode = hashCode * 59 + this.Kubelet.GetHashCode();
                return hashCode;
            }
        }
    }
}
