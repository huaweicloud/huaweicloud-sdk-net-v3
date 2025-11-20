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
    /// Request Object
    /// </summary>
    public class DeleteNodeRequest 
    {
        /// <summary>
        /// **参数解释**： 标明是否为nodepool下发的请求。若不为“NoScaleDown”将自动更新对应节点池的实例数 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        /// <value>**参数解释**： 标明是否为nodepool下发的请求。若不为“NoScaleDown”将自动更新对应节点池的实例数 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<NodepoolScaleDownEnum>))]
        public class NodepoolScaleDownEnum
        {
            /// <summary>
            /// Enum NOSCALEDOWN for value: NoScaleDown
            /// </summary>
            public static readonly NodepoolScaleDownEnum NOSCALEDOWN = new NodepoolScaleDownEnum("NoScaleDown");

            private static readonly Dictionary<string, NodepoolScaleDownEnum> StaticFields =
            new Dictionary<string, NodepoolScaleDownEnum>()
            {
                { "NoScaleDown", NOSCALEDOWN },
            };

            private string _value;

            public NodepoolScaleDownEnum()
            {

            }

            public NodepoolScaleDownEnum(string value)
            {
                _value = value;
            }

            public static NodepoolScaleDownEnum FromValue(string value)
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

                if (this.Equals(obj as NodepoolScaleDownEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodepoolScaleDownEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NodepoolScaleDownEnum a, NodepoolScaleDownEnum b)
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

            public static bool operator !=(NodepoolScaleDownEnum a, NodepoolScaleDownEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 集群ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// **参数解释**： 节点ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [SDKProperty("node_id", IsPath = true)]
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**： 标明是否为nodepool下发的请求。若不为“NoScaleDown”将自动更新对应节点池的实例数 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及 
        /// </summary>
        [SDKProperty("nodepoolScaleDown", IsQuery = true)]
        [JsonProperty("nodepoolScaleDown", NullValueHandling = NullValueHandling.Ignore)]
        public NodepoolScaleDownEnum NodepoolScaleDown { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteNodeRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  nodepoolScaleDown: ").Append(NodepoolScaleDown).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteNodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteNodeRequest input)
        {
            if (input == null) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.NodepoolScaleDown != input.NodepoolScaleDown) return false;

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
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                hashCode = hashCode * 59 + this.NodepoolScaleDown.GetHashCode();
                return hashCode;
            }
        }
    }
}
