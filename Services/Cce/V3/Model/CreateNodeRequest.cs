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
    public class CreateNodeRequest 
    {
        /// <summary>
        /// 标明是否为nodepool下发的请求。若不为“NodepoolScaleUp”将自动更新对应节点池的实例数
        /// </summary>
        /// <value>标明是否为nodepool下发的请求。若不为“NodepoolScaleUp”将自动更新对应节点池的实例数</value>
        [JsonConverter(typeof(EnumClassConverter<NodepoolScaleUpEnum>))]
        public class NodepoolScaleUpEnum
        {
            /// <summary>
            /// Enum NODEPOOLSCALEUP for value: NodepoolScaleUp
            /// </summary>
            public static readonly NodepoolScaleUpEnum NODEPOOLSCALEUP = new NodepoolScaleUpEnum("NodepoolScaleUp");

            private static readonly Dictionary<string, NodepoolScaleUpEnum> StaticFields =
            new Dictionary<string, NodepoolScaleUpEnum>()
            {
                { "NodepoolScaleUp", NODEPOOLSCALEUP },
            };

            private string Value;

            public NodepoolScaleUpEnum(string value)
            {
                Value = value;
            }

            public static NodepoolScaleUpEnum FromValue(string value)
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

                if (this.Equals(obj as NodepoolScaleUpEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodepoolScaleUpEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NodepoolScaleUpEnum a, NodepoolScaleUpEnum b)
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

            public static bool operator !=(NodepoolScaleUpEnum a, NodepoolScaleUpEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 集群 ID，获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 标明是否为nodepool下发的请求。若不为“NodepoolScaleUp”将自动更新对应节点池的实例数
        /// </summary>
        [SDKProperty("nodepoolScaleUp", IsQuery = true)]
        [JsonProperty("nodepoolScaleUp", NullValueHandling = NullValueHandling.Ignore)]
        public NodepoolScaleUpEnum NodepoolScaleUp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public NodeCreateRequest Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNodeRequest {\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  nodepoolScaleUp: ").Append(NodepoolScaleUp).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNodeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.NodepoolScaleUp == input.NodepoolScaleUp ||
                    (this.NodepoolScaleUp != null &&
                    this.NodepoolScaleUp.Equals(input.NodepoolScaleUp))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.ClusterId != null)
                    hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.NodepoolScaleUp != null)
                    hashCode = hashCode * 59 + this.NodepoolScaleUp.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
