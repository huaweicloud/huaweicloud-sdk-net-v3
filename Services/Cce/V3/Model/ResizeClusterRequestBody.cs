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
    /// 变更集群规格的请求体
    /// </summary>
    public class ResizeClusterRequestBody 
    {

        /// <summary>
        /// 要变更的目标规格  - cce.s1.small: 小规模单控制节点CCE集群（最大50节点） - cce.s1.medium: 中等规模单控制节点CCE集群（最大200节点） - cce.s2.small: 小规模多控制节点CCE集群（最大50节点） - cce.s2.medium: 中等规模多控制节点CCE集群（最大200节点） - cce.s2.large: 大规模多控制节点CCE集群（最大1000节点） - cce.s2.xlarge: 超大规模多控制节点CCE集群（最大2000节点）  &gt;    - s1：单控制节点CCE集群。 &gt;    - s2：多控制节点CCE集群。 &gt;    - dec：专属CCE集群规格。如cce.dec.s1.small为小规模单控制节点专属CCE集群（最大50节点）。 &gt;    - 最大节点数：当前集群支持管理的最大节点规模，请根据业务需求选择。 &gt;    - 单控制节点集群：普通集群是单控制节点，控制节点故障后，集群将不可用，但已运行工作负载不受影响。 &gt;    - 多控制节点集群：即高可用集群，当某个控制节点故障时，集群仍然可用。 
        /// </summary>
        [JsonProperty("flavorResize", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorResize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public ResizeClusterRequestExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeClusterRequestBody {\n");
            sb.Append("  flavorResize: ").Append(FlavorResize).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeClusterRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeClusterRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlavorResize == input.FlavorResize ||
                    (this.FlavorResize != null &&
                    this.FlavorResize.Equals(input.FlavorResize))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
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
                if (this.FlavorResize != null)
                    hashCode = hashCode * 59 + this.FlavorResize.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
