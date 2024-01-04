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
    /// 获取指定集群配置项列表返回体
    /// </summary>
    public class ClusterConfigDetailRespBody 
    {

        /// <summary>
        /// 配置参数，由key/value组成。
        /// </summary>
        [JsonProperty("kube-apiserver", NullValueHandling = NullValueHandling.Ignore)]
        public List<PackageOptions> KubeApiserver { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterConfigDetailRespBody {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  kubeApiserver: ").Append(KubeApiserver).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterConfigDetailRespBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterConfigDetailRespBody input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.KubeApiserver == input.KubeApiserver ||
                    this.KubeApiserver != null &&
                    input.KubeApiserver != null &&
                    this.KubeApiserver.SequenceEqual(input.KubeApiserver)
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
                if (this.KubeApiserver != null)
                    hashCode = hashCode * 59 + this.KubeApiserver.GetHashCode();
                return hashCode;
            }
        }
    }
}
