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
    /// 资源标签选择器，匹配Kubernetes中node资源
    /// </summary>
    public class ResourceSelector 
    {
        /// <summary>
        /// 标签键值，取值如下 - node.uid：节点UID。
        /// </summary>
        /// <value>标签键值，取值如下 - node.uid：节点UID。</value>
        [JsonConverter(typeof(EnumClassConverter<KeyEnum>))]
        public class KeyEnum
        {
            /// <summary>
            /// Enum NODE_UID for value: node.uid
            /// </summary>
            public static readonly KeyEnum NODE_UID = new KeyEnum("node.uid");

            private static readonly Dictionary<string, KeyEnum> StaticFields =
            new Dictionary<string, KeyEnum>()
            {
                { "node.uid", NODE_UID },
            };

            private string _value;

            public KeyEnum()
            {

            }

            public KeyEnum(string value)
            {
                _value = value;
            }

            public static KeyEnum FromValue(string value)
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

                if (this.Equals(obj as KeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeyEnum a, KeyEnum b)
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

            public static bool operator !=(KeyEnum a, KeyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 标签逻辑运算符，当前支持如下取值 - In
        /// </summary>
        /// <value>标签逻辑运算符，当前支持如下取值 - In</value>
        [JsonConverter(typeof(EnumClassConverter<OperatorEnum>))]
        public class OperatorEnum
        {
            /// <summary>
            /// Enum IN for value: In
            /// </summary>
            public static readonly OperatorEnum IN = new OperatorEnum("In");

            private static readonly Dictionary<string, OperatorEnum> StaticFields =
            new Dictionary<string, OperatorEnum>()
            {
                { "In", IN },
            };

            private string _value;

            public OperatorEnum()
            {

            }

            public OperatorEnum(string value)
            {
                _value = value;
            }

            public static OperatorEnum FromValue(string value)
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

                if (this.Equals(obj as OperatorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperatorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperatorEnum a, OperatorEnum b)
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

            public static bool operator !=(OperatorEnum a, OperatorEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标签键值，取值如下 - node.uid：节点UID。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public KeyEnum Key { get; set; }
        /// <summary>
        /// 标签值列表
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }

        /// <summary>
        /// 标签逻辑运算符，当前支持如下取值 - In
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public OperatorEnum Operator { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceSelector {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceSelector);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceSelector input)
        {
            if (input == null) return false;
            if (this.Key != input.Key) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;
            if (this.Operator != input.Operator) return false;

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
                hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                return hashCode;
            }
        }
    }
}
