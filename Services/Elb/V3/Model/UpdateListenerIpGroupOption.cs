using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// listener对象中的ipgroup信息
    /// </summary>
    public class UpdateListenerIpGroupOption 
    {
        /// <summary>
        /// 参数解释：访问控制组的类型。  取值范围： - white:白名单，只允许指定ip访问。 - black:黑名单，不允许指定ip访问。
        /// </summary>
        /// <value>参数解释：访问控制组的类型。  取值范围： - white:白名单，只允许指定ip访问。 - black:黑名单，不允许指定ip访问。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum WHITE for value: white
            /// </summary>
            public static readonly TypeEnum WHITE = new TypeEnum("white");

            /// <summary>
            /// Enum BLACK for value: black
            /// </summary>
            public static readonly TypeEnum BLACK = new TypeEnum("black");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "white", WHITE },
                { "black", BLACK },
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
        /// 参数解释：监听器关联的访问控制组的id。 创建时必选，更新时非必选。  约束限制：指定的ipgroup必须已存在，不能指定为null，否则与enable_ipgroup冲突。
        /// </summary>
        [JsonProperty("ipgroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpgroupId { get; set; }

        /// <summary>
        /// 参数解释：访问控制组的状态。 开启访问控制的监听器，允许直接删除。  取值范围： - true:开启访问控制。 - false：关闭访问控制。
        /// </summary>
        [JsonProperty("enable_ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIpgroup { get; set; }

        /// <summary>
        /// 参数解释：访问控制组的类型。  取值范围： - white:白名单，只允许指定ip访问。 - black:黑名单，不允许指定ip访问。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateListenerIpGroupOption {\n");
            sb.Append("  ipgroupId: ").Append(IpgroupId).Append("\n");
            sb.Append("  enableIpgroup: ").Append(EnableIpgroup).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateListenerIpGroupOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateListenerIpGroupOption input)
        {
            if (input == null) return false;
            if (this.IpgroupId != input.IpgroupId || (this.IpgroupId != null && !this.IpgroupId.Equals(input.IpgroupId))) return false;
            if (this.EnableIpgroup != input.EnableIpgroup || (this.EnableIpgroup != null && !this.EnableIpgroup.Equals(input.EnableIpgroup))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.IpgroupId != null) hashCode = hashCode * 59 + this.IpgroupId.GetHashCode();
                if (this.EnableIpgroup != null) hashCode = hashCode * 59 + this.EnableIpgroup.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
