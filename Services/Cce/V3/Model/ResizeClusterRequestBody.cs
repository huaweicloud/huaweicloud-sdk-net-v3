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
        /// Defines skippedTasks
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SkippedTasksEnum>))]
        public class SkippedTasksEnum
        {
            /// <summary>
            /// Enum INGRESSCHECKER for value: IngressChecker
            /// </summary>
            public static readonly SkippedTasksEnum INGRESSCHECKER = new SkippedTasksEnum("IngressChecker");

            private static readonly Dictionary<string, SkippedTasksEnum> StaticFields =
            new Dictionary<string, SkippedTasksEnum>()
            {
                { "IngressChecker", INGRESSCHECKER },
            };

            private string _value;

            public SkippedTasksEnum()
            {

            }

            public SkippedTasksEnum(string value)
            {
                _value = value;
            }

            public static SkippedTasksEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as SkippedTasksEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SkippedTasksEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SkippedTasksEnum a, SkippedTasksEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SkippedTasksEnum a, SkippedTasksEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// **参数解释**： 要变更的目标规格。仅支持变更集群最大节点规模，不支持变更控制节点数，且不支持降低集群规格。例如原集群规格为cce.s2.medium，仅支持变更至cce.s2.large及以上规格，不支持变更至cce.s2.small或cce.s1.medium。 **约束限制**： VPC 网络模型建议集群规模为 1000 节点及以下。集群本身规模受 VPC 路由表配额上限限制，若扩容规格至cce.s2.xlarge，可能出现实际节点规模无法达到目标规模的情况。 **取值范围**： - cce.s1.small: 小规模单控制节点CCE集群（最大50节点） - cce.s1.medium: 中等规模单控制节点CCE集群（最大200节点） - cce.s2.small: 小规模三控制节点CCE集群（最大50节点） - cce.s2.medium: 中等规模三控制节点CCE集群（最大200节点） - cce.s2.large: 大规模三控制节点CCE集群（最大1000节点） - cce.s2.xlarge: 超大规模三控制节点CCE集群（最大2000节点） - [cce.s3.small: 小规模五控制节点CCE集群（最大50节点）](tag:hcs,hcs_sm) - [cce.s3.medium: 中等规模五控制节点CCE集群（最大200节点）](tag:hcs,hcs_sm) - [cce.s3.large: 大规模五控制节点CCE集群（最大1000节点）](tag:hcs,hcs_sm) - [cce.s3.xlarge: 超大规模五控制节点CCE集群（最大2000节点）](tag:hcs,hcs_sm) **默认取值**： 不涉及  &gt;    关于规格参数中的字段说明如下： &gt;    - s1：单控制节点的集群，控制节点数为1。单控制节点故障后，集群将不可用，但已运行工作负载不受影响。 &gt;    - s2：三控制节点的集群，即高可用集群，控制节点数为3。当某个控制节点故障时，集群仍然可用。 &gt;    [- s3：五控制节点的集群，即超高可用集群，控制节点数为5。当某2个控制节点故障时，集群仍然可用。](tag:hcs,hcs_sm) &gt;    [- dec：表示专属云的CCE集群规格。例如cce.dec.s1.small表示小规模单控制节点的专属云CCE集群（最大50节点）。](tag:hws,hws_hk) &gt;    - small：表示集群支持管理的最大节点规模为50节点。 &gt;    - medium：表示集群支持管理的最大节点规模为200节点。 &gt;    - large：表示集群支持管理的最大节点规模为1000节点。 &gt;    - xlarge：表示集群支持管理的最大节点规模为2000节点。 
        /// </summary>
        [JsonProperty("flavorResize", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorResize { get; set; }

        /// <summary>
        /// **参数解释**： 该参数用于控制集群规格变更时跳过部分任务。 **约束限制**： 无 **取值范围**： - IngressChecker: 集群规格变更时跳过Ingress与ELB配置一致性检查  &gt; - 跳过Ingress与ELB配置一致性检查可能导致业务中断，请谨慎操作！ &gt; - 集群不可用或者过载时，必须跳过Ingress与ELB配置一致性检查，否则会导致集群规格变更失败。[请确保变更集群规格前已按 [ELB Ingress与ELB配置不一致如何处理？](https://support.huaweicloud.com/cce_faq/cce_faq_00493.html) 指南解决一致性问题。](tag:hws)[请确保变更集群规格前已按 [ELB Ingress与ELB配置不一致如何处理？](https://support.huaweicloud.com/intl/zh-cn/cce_faq/cce_faq_00493.html) 指南解决一致性问题。](tag:hws_hk)  **默认取值**： 集群不可用时默认包含IngressChecker
        /// </summary>
        [JsonProperty("skippedTasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<SkippedTasksEnum> SkippedTasks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public ResizeClusterRequestBodyExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeClusterRequestBody {\n");
            sb.Append("  flavorResize: ").Append(FlavorResize).Append("\n");
            sb.Append("  skippedTasks: ").Append(SkippedTasks).Append("\n");
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
            if (input == null) return false;
            if (this.FlavorResize != input.FlavorResize || (this.FlavorResize != null && !this.FlavorResize.Equals(input.FlavorResize))) return false;
            if (this.SkippedTasks != input.SkippedTasks || (this.SkippedTasks != null && input.SkippedTasks != null && !this.SkippedTasks.SequenceEqual(input.SkippedTasks))) return false;
            if (this.ExtendParam != input.ExtendParam || (this.ExtendParam != null && !this.ExtendParam.Equals(input.ExtendParam))) return false;

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
                if (this.FlavorResize != null) hashCode = hashCode * 59 + this.FlavorResize.GetHashCode();
                hashCode = hashCode * 59 + this.SkippedTasks.GetHashCode();
                if (this.ExtendParam != null) hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
