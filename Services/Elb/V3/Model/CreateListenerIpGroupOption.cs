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
    /// listener对象中的控制组（ipgroup）信息，可以不传或传null或{}，表示监听器不绑定访问控制组。若需要绑定访问控制组，则ipgroup_id是必须的。  [  不支持该字段，请勿使用。](tags:otc,otc_test)
    /// </summary>
    public class CreateListenerIpGroupOption 
    {
        /// <summary>
        /// 访问控制组的类型。 - white：白名单，只允许指定ip访问，默认值。 - black：黑名单，不允许指定ip访问。
        /// </summary>
        /// <value>访问控制组的类型。 - white：白名单，只允许指定ip访问，默认值。 - black：黑名单，不允许指定ip访问。</value>
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
        /// 监听器关联的访问控制组的id。  当关联的ipgroup中的ip_list为[]，且类型为白名单时，表示禁止所有ip的访问。  当关联的ipgroup中的ip_list为[]，且类型为黑名单时，表示允许所有ip的访问。 
        /// </summary>
        [JsonProperty("ipgroup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpgroupId { get; set; }

        /// <summary>
        /// 访问控制组的状态。取值： - true：开启访问控制，默认值。 - flase：关闭访问控制。
        /// </summary>
        [JsonProperty("enable_ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIpgroup { get; set; }

        /// <summary>
        /// 访问控制组的类型。 - white：白名单，只允许指定ip访问，默认值。 - black：黑名单，不允许指定ip访问。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListenerIpGroupOption {\n");
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
            return this.Equals(input as CreateListenerIpGroupOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateListenerIpGroupOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpgroupId == input.IpgroupId ||
                    (this.IpgroupId != null &&
                    this.IpgroupId.Equals(input.IpgroupId))
                ) && 
                (
                    this.EnableIpgroup == input.EnableIpgroup ||
                    (this.EnableIpgroup != null &&
                    this.EnableIpgroup.Equals(input.EnableIpgroup))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.IpgroupId != null)
                    hashCode = hashCode * 59 + this.IpgroupId.GetHashCode();
                if (this.EnableIpgroup != null)
                    hashCode = hashCode * 59 + this.EnableIpgroup.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
