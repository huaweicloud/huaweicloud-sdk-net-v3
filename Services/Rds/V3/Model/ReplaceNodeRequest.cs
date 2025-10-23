using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReplaceNodeRequest 
    {
        /// <summary>
        /// 替换动作，取值范围： REPLACE: 节点顶替 REPLACE_ROLLBACK: 节点顶替回切
        /// </summary>
        /// <value>替换动作，取值范围： REPLACE: 节点顶替 REPLACE_ROLLBACK: 节点顶替回切</value>
        [JsonConverter(typeof(EnumClassConverter<ReplaceActionEnum>))]
        public class ReplaceActionEnum
        {
            /// <summary>
            /// Enum REPLACE for value: REPLACE
            /// </summary>
            public static readonly ReplaceActionEnum REPLACE = new ReplaceActionEnum("REPLACE");

            /// <summary>
            /// Enum REPLACE_ROLLBACK for value: REPLACE_ROLLBACK
            /// </summary>
            public static readonly ReplaceActionEnum REPLACE_ROLLBACK = new ReplaceActionEnum("REPLACE_ROLLBACK");

            private static readonly Dictionary<string, ReplaceActionEnum> StaticFields =
            new Dictionary<string, ReplaceActionEnum>()
            {
                { "REPLACE", REPLACE },
                { "REPLACE_ROLLBACK", REPLACE_ROLLBACK },
            };

            private string _value;

            public ReplaceActionEnum()
            {

            }

            public ReplaceActionEnum(string value)
            {
                _value = value;
            }

            public static ReplaceActionEnum FromValue(string value)
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

                if (this.Equals(obj as ReplaceActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReplaceActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReplaceActionEnum a, ReplaceActionEnum b)
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

            public static bool operator !=(ReplaceActionEnum a, ReplaceActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 只读实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 只读实例的节点ID。
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 替换动作，取值范围： REPLACE: 节点顶替 REPLACE_ROLLBACK: 节点顶替回切
        /// </summary>
        [JsonProperty("replace_action", NullValueHandling = NullValueHandling.Ignore)]
        public ReplaceActionEnum ReplaceAction { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaceNodeRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  replaceAction: ").Append(ReplaceAction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplaceNodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplaceNodeRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.ReplaceAction != input.ReplaceAction) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                hashCode = hashCode * 59 + this.ReplaceAction.GetHashCode();
                return hashCode;
            }
        }
    }
}
