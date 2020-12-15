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
        /// Defines nodepoolScaleDown
        /// </summary>
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

            private string Value;

            public NodepoolScaleDownEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NodepoolScaleDownEnum a, NodepoolScaleDownEnum b)
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

            public static bool operator !=(NodepoolScaleDownEnum a, NodepoolScaleDownEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("cluster_id", IsPath = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("node_id", IsPath = true)]
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("errorStatus", IsQuery = true)]
        [JsonProperty("errorStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorStatus { get; set; }

        /// <summary>
        /// 
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
            sb.Append("  errorStatus: ").Append(ErrorStatus).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.ClusterId == input.ClusterId ||
                    (this.ClusterId != null &&
                    this.ClusterId.Equals(input.ClusterId))
                ) && 
                (
                    this.NodeId == input.NodeId ||
                    (this.NodeId != null &&
                    this.NodeId.Equals(input.NodeId))
                ) && 
                (
                    this.ErrorStatus == input.ErrorStatus ||
                    (this.ErrorStatus != null &&
                    this.ErrorStatus.Equals(input.ErrorStatus))
                ) && 
                (
                    this.NodepoolScaleDown == input.NodepoolScaleDown ||
                    (this.NodepoolScaleDown != null &&
                    this.NodepoolScaleDown.Equals(input.NodepoolScaleDown))
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
                if (this.NodeId != null)
                    hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.ErrorStatus != null)
                    hashCode = hashCode * 59 + this.ErrorStatus.GetHashCode();
                if (this.NodepoolScaleDown != null)
                    hashCode = hashCode * 59 + this.NodepoolScaleDown.GetHashCode();
                return hashCode;
            }
        }
    }
}
