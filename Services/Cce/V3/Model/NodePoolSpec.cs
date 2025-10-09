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
    /// 
    /// </summary>
    public class NodePoolSpec 
    {
        /// <summary>
        /// 节点池类型。不填写时默认为vm。  - vm：弹性云服务器 - ElasticBMS：C6型弹性裸金属通用计算增强型云服务器，规格示例：c6.22xlarge.2.physical - pm: 裸金属服务器 
        /// </summary>
        /// <value>节点池类型。不填写时默认为vm。  - vm：弹性云服务器 - ElasticBMS：C6型弹性裸金属通用计算增强型云服务器，规格示例：c6.22xlarge.2.physical - pm: 裸金属服务器 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum VM for value: vm
            /// </summary>
            public static readonly TypeEnum VM = new TypeEnum("vm");

            /// <summary>
            /// Enum ELASTICBMS for value: ElasticBMS
            /// </summary>
            public static readonly TypeEnum ELASTICBMS = new TypeEnum("ElasticBMS");

            /// <summary>
            /// Enum PM for value: pm
            /// </summary>
            public static readonly TypeEnum PM = new TypeEnum("pm");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "vm", VM },
                { "ElasticBMS", ELASTICBMS },
                { "pm", PM },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 节点池类型。不填写时默认为vm。  - vm：弹性云服务器 - ElasticBMS：C6型弹性裸金属通用计算增强型云服务器，规格示例：c6.22xlarge.2.physical - pm: 裸金属服务器 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTemplate NodeTemplate { get; set; }

        /// <summary>
        /// 节点池初始化节点个数。查询时为节点池目标节点数量。
        /// </summary>
        [JsonProperty("initialNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? InitialNodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("autoscaling", NullValueHandling = NullValueHandling.Ignore)]
        public NodePoolNodeAutoscaling Autoscaling { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeManagement", NullValueHandling = NullValueHandling.Ignore)]
        public NodeManagement NodeManagement { get; set; }

        /// <summary>
        /// 1.21版本集群节点池支持绑定安全组，最多五个。
        /// </summary>
        [JsonProperty("podSecurityGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecurityID> PodSecurityGroups { get; set; }

        /// <summary>
        /// 节点池扩展伸缩组配置列表，详情参见ExtensionScaleGroup类型定义
        /// </summary>
        [JsonProperty("extensionScaleGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtensionScaleGroup> ExtensionScaleGroups { get; set; }

        /// <summary>
        /// 节点池自定义安全组相关配置。支持节点池新扩容节点绑定指定的安全组。  - 未指定安全组ID，新建节点将添加Node节点默认安全组。  - 指定有效安全组ID，新建节点将使用指定安全组。  - 指定安全组，应避免对CCE运行依赖的端口规则进行修改。[详细设置请参考[集群安全组规则配置](https://support.huaweicloud.com/cce_faq/cce_faq_00265.html)。](tag:hws)[详细设置请参考[集群安全组规则配置](https://support.huaweicloud.com/intl/zh-cn/cce_faq/cce_faq_00265.html)。](tag:hws_hk) 
        /// </summary>
        [JsonProperty("customSecurityGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomSecurityGroups { get; set; }

        /// <summary>
        /// **参数解释**： 存量节点污点同步策略 **约束限制**： 不涉及 **取值范围**： - ignore：配置为\&quot;ignore\&quot;后，节点池不再同步更新存量节点的污点。 - refresh：配置为\&quot;refresh\&quot;后，节点池将同步更新存量节点的污点。  **默认取值**： refresh
        /// </summary>
        [JsonProperty("taintPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string TaintPolicyOnExistingNodes { get; set; }

        /// <summary>
        /// **参数解释**： 存量节点标签同步策略 **约束限制**： 不涉及 **取值范围**： - ignore：配置为\&quot;ignore\&quot;后，节点池不再同步更新存量节点的标签。 - refresh：配置为\&quot;refresh\&quot;后，节点池将同步更新存量节点的标签。  **默认取值**： refresh
        /// </summary>
        [JsonProperty("labelPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelPolicyOnExistingNodes { get; set; }

        /// <summary>
        /// **参数解释**： 存量节点资源标签同步策略 **约束限制**： 不涉及 **取值范围**： - ignore：配置为\&quot;ignore\&quot;后，节点池不再同步更新存量节点的资源标签。 - refresh：配置为\&quot;refresh\&quot;后，节点池将同步更新存量节点的资源标签。  **默认取值**： ignore
        /// </summary>
        [JsonProperty("userTagsPolicyOnExistingNodes", NullValueHandling = NullValueHandling.Ignore)]
        public string UserTagsPolicyOnExistingNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodePoolSpec {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  nodeTemplate: ").Append(NodeTemplate).Append("\n");
            sb.Append("  initialNodeCount: ").Append(InitialNodeCount).Append("\n");
            sb.Append("  autoscaling: ").Append(Autoscaling).Append("\n");
            sb.Append("  nodeManagement: ").Append(NodeManagement).Append("\n");
            sb.Append("  podSecurityGroups: ").Append(PodSecurityGroups).Append("\n");
            sb.Append("  extensionScaleGroups: ").Append(ExtensionScaleGroups).Append("\n");
            sb.Append("  customSecurityGroups: ").Append(CustomSecurityGroups).Append("\n");
            sb.Append("  taintPolicyOnExistingNodes: ").Append(TaintPolicyOnExistingNodes).Append("\n");
            sb.Append("  labelPolicyOnExistingNodes: ").Append(LabelPolicyOnExistingNodes).Append("\n");
            sb.Append("  userTagsPolicyOnExistingNodes: ").Append(UserTagsPolicyOnExistingNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodePoolSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodePoolSpec input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.NodeTemplate != input.NodeTemplate || (this.NodeTemplate != null && !this.NodeTemplate.Equals(input.NodeTemplate))) return false;
            if (this.InitialNodeCount != input.InitialNodeCount || (this.InitialNodeCount != null && !this.InitialNodeCount.Equals(input.InitialNodeCount))) return false;
            if (this.Autoscaling != input.Autoscaling || (this.Autoscaling != null && !this.Autoscaling.Equals(input.Autoscaling))) return false;
            if (this.NodeManagement != input.NodeManagement || (this.NodeManagement != null && !this.NodeManagement.Equals(input.NodeManagement))) return false;
            if (this.PodSecurityGroups != input.PodSecurityGroups || (this.PodSecurityGroups != null && input.PodSecurityGroups != null && !this.PodSecurityGroups.SequenceEqual(input.PodSecurityGroups))) return false;
            if (this.ExtensionScaleGroups != input.ExtensionScaleGroups || (this.ExtensionScaleGroups != null && input.ExtensionScaleGroups != null && !this.ExtensionScaleGroups.SequenceEqual(input.ExtensionScaleGroups))) return false;
            if (this.CustomSecurityGroups != input.CustomSecurityGroups || (this.CustomSecurityGroups != null && input.CustomSecurityGroups != null && !this.CustomSecurityGroups.SequenceEqual(input.CustomSecurityGroups))) return false;
            if (this.TaintPolicyOnExistingNodes != input.TaintPolicyOnExistingNodes || (this.TaintPolicyOnExistingNodes != null && !this.TaintPolicyOnExistingNodes.Equals(input.TaintPolicyOnExistingNodes))) return false;
            if (this.LabelPolicyOnExistingNodes != input.LabelPolicyOnExistingNodes || (this.LabelPolicyOnExistingNodes != null && !this.LabelPolicyOnExistingNodes.Equals(input.LabelPolicyOnExistingNodes))) return false;
            if (this.UserTagsPolicyOnExistingNodes != input.UserTagsPolicyOnExistingNodes || (this.UserTagsPolicyOnExistingNodes != null && !this.UserTagsPolicyOnExistingNodes.Equals(input.UserTagsPolicyOnExistingNodes))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NodeTemplate != null) hashCode = hashCode * 59 + this.NodeTemplate.GetHashCode();
                if (this.InitialNodeCount != null) hashCode = hashCode * 59 + this.InitialNodeCount.GetHashCode();
                if (this.Autoscaling != null) hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.NodeManagement != null) hashCode = hashCode * 59 + this.NodeManagement.GetHashCode();
                if (this.PodSecurityGroups != null) hashCode = hashCode * 59 + this.PodSecurityGroups.GetHashCode();
                if (this.ExtensionScaleGroups != null) hashCode = hashCode * 59 + this.ExtensionScaleGroups.GetHashCode();
                if (this.CustomSecurityGroups != null) hashCode = hashCode * 59 + this.CustomSecurityGroups.GetHashCode();
                if (this.TaintPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.TaintPolicyOnExistingNodes.GetHashCode();
                if (this.LabelPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.LabelPolicyOnExistingNodes.GetHashCode();
                if (this.UserTagsPolicyOnExistingNodes != null) hashCode = hashCode * 59 + this.UserTagsPolicyOnExistingNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
