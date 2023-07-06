using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 任务实例规格信息体。
    /// </summary>
    public class JobNodeSpecInfo 
    {
        /// <summary>
        /// 实例规格编码。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。
        /// </summary>
        /// <value>实例规格编码。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。</value>
        [JsonConverter(typeof(EnumClassConverter<NodeTypeEnum>))]
        public class NodeTypeEnum
        {
            /// <summary>
            /// Enum MICRO for value: micro
            /// </summary>
            public static readonly NodeTypeEnum MICRO = new NodeTypeEnum("micro");

            /// <summary>
            /// Enum SMALL for value: small
            /// </summary>
            public static readonly NodeTypeEnum SMALL = new NodeTypeEnum("small");

            /// <summary>
            /// Enum MEDIUM for value: medium
            /// </summary>
            public static readonly NodeTypeEnum MEDIUM = new NodeTypeEnum("medium");

            /// <summary>
            /// Enum HIGH for value: high
            /// </summary>
            public static readonly NodeTypeEnum HIGH = new NodeTypeEnum("high");

            private static readonly Dictionary<string, NodeTypeEnum> StaticFields =
            new Dictionary<string, NodeTypeEnum>()
            {
                { "micro", MICRO },
                { "small", SMALL },
                { "medium", MEDIUM },
                { "high", HIGH },
            };

            private string _value;

            public NodeTypeEnum()
            {

            }

            public NodeTypeEnum(string value)
            {
                _value = value;
            }

            public static NodeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as NodeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NodeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NodeTypeEnum a, NodeTypeEnum b)
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

            public static bool operator !=(NodeTypeEnum a, NodeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例规格编码。取值： - micro：极小规格。 - small：小规格。 - medium：中规格。 - high：大规格。
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public NodeTypeEnum NodeType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobNodeSpecInfo {\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobNodeSpecInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobNodeSpecInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NodeType == input.NodeType ||
                    (this.NodeType != null &&
                    this.NodeType.Equals(input.NodeType))
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
                if (this.NodeType != null)
                    hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
