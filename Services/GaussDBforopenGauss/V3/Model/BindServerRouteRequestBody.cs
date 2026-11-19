using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BindServerRouteRequestBody 
    {
        /// <summary>
        /// **参数解释**: 操作类型。 **约束限制**: 不涉及。 **取值范围**: - add：绑定服务端IP路由 - delete：解绑服务端IP路由  **默认取值**: 不涉及。
        /// </summary>
        /// <value>**参数解释**: 操作类型。 **约束限制**: 不涉及。 **取值范围**: - add：绑定服务端IP路由 - delete：解绑服务端IP路由  **默认取值**: 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<OperateEnum>))]
        public class OperateEnum
        {
            /// <summary>
            /// Enum ADD for value: add
            /// </summary>
            public static readonly OperateEnum ADD = new OperateEnum("add");

            /// <summary>
            /// Enum DELETE for value: delete
            /// </summary>
            public static readonly OperateEnum DELETE = new OperateEnum("delete");

            private static readonly Dictionary<string, OperateEnum> StaticFields =
            new Dictionary<string, OperateEnum>()
            {
                { "add", ADD },
                { "delete", DELETE },
            };

            private string _value;

            public OperateEnum()
            {

            }

            public OperateEnum(string value)
            {
                _value = value;
            }

            public static OperateEnum FromValue(string value)
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

                if (this.Equals(obj as OperateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperateEnum a, OperateEnum b)
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

            public static bool operator !=(OperateEnum a, OperateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 操作类型。 **约束限制**: 不涉及。 **取值范围**: - add：绑定服务端IP路由 - delete：解绑服务端IP路由  **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("operate", NullValueHandling = NullValueHandling.Ignore)]
        public OperateEnum Operate { get; set; }
        /// <summary>
        /// **参数解释**: 服务端IP列表。 **约束限制**: 列表元素需要满足IPv4格式要求。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("target_server_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TargetServerIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BindServerRouteRequestBody {\n");
            sb.Append("  operate: ").Append(Operate).Append("\n");
            sb.Append("  targetServerIps: ").Append(TargetServerIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BindServerRouteRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BindServerRouteRequestBody input)
        {
            if (input == null) return false;
            if (this.Operate != input.Operate) return false;
            if (this.TargetServerIps != input.TargetServerIps || (this.TargetServerIps != null && input.TargetServerIps != null && !this.TargetServerIps.SequenceEqual(input.TargetServerIps))) return false;

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
                hashCode = hashCode * 59 + this.Operate.GetHashCode();
                if (this.TargetServerIps != null) hashCode = hashCode * 59 + this.TargetServerIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
