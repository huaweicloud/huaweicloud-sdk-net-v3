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
        /// 节点池类型。不填写时默认为vm。  - vm：弹性云服务器 - ElasticBMS：C6型弹性裸金属通用计算增强型云服务器，规格示例：c6.22xlarge.2.physical 
        /// </summary>
        /// <value>节点池类型。不填写时默认为vm。  - vm：弹性云服务器 - ElasticBMS：C6型弹性裸金属通用计算增强型云服务器，规格示例：c6.22xlarge.2.physical </value>
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

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "vm", VM },
                { "ElasticBMS", ELASTICBMS },
            };

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
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
        /// 节点池类型。不填写时默认为vm。  - vm：弹性云服务器 - ElasticBMS：C6型弹性裸金属通用计算增强型云服务器，规格示例：c6.22xlarge.2.physical 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nodeTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public V3NodeSpec NodeTemplate { get; set; }

        /// <summary>
        /// 节点池初始化节点个数。
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
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.NodeTemplate == input.NodeTemplate ||
                    (this.NodeTemplate != null &&
                    this.NodeTemplate.Equals(input.NodeTemplate))
                ) && 
                (
                    this.InitialNodeCount == input.InitialNodeCount ||
                    (this.InitialNodeCount != null &&
                    this.InitialNodeCount.Equals(input.InitialNodeCount))
                ) && 
                (
                    this.Autoscaling == input.Autoscaling ||
                    (this.Autoscaling != null &&
                    this.Autoscaling.Equals(input.Autoscaling))
                ) && 
                (
                    this.NodeManagement == input.NodeManagement ||
                    (this.NodeManagement != null &&
                    this.NodeManagement.Equals(input.NodeManagement))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.NodeTemplate != null)
                    hashCode = hashCode * 59 + this.NodeTemplate.GetHashCode();
                if (this.InitialNodeCount != null)
                    hashCode = hashCode * 59 + this.InitialNodeCount.GetHashCode();
                if (this.Autoscaling != null)
                    hashCode = hashCode * 59 + this.Autoscaling.GetHashCode();
                if (this.NodeManagement != null)
                    hashCode = hashCode * 59 + this.NodeManagement.GetHashCode();
                return hashCode;
            }
        }
    }
}
