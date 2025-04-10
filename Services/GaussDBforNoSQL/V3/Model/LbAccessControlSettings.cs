using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 负载均衡访问控制配置。
    /// </summary>
    public class LbAccessControlSettings 
    {
        /// <summary>
        /// 黑白名单类型，blackList黑名单，whiteList白名单，仅支持设置黑名单或白名单中的一种，当配置切换时，原配置会失效。
        /// </summary>
        /// <value>黑白名单类型，blackList黑名单，whiteList白名单，仅支持设置黑名单或白名单中的一种，当配置切换时，原配置会失效。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum BLACKLIST for value: blackList
            /// </summary>
            public static readonly TypeEnum BLACKLIST = new TypeEnum("blackList");

            /// <summary>
            /// Enum WHITELIST for value: whiteList
            /// </summary>
            public static readonly TypeEnum WHITELIST = new TypeEnum("whiteList");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "blackList", BLACKLIST },
                { "whiteList", WHITELIST },
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
        /// true 开启，false 关闭。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 黑白名单类型，blackList黑名单，whiteList白名单，仅支持设置黑名单或白名单中的一种，当配置切换时，原配置会失效。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// IP地址组中包含的IP或网段列表。
        /// </summary>
        [JsonProperty("ip_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpGroupsDetail> IpGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LbAccessControlSettings {\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  ipGroups: ").Append(IpGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LbAccessControlSettings);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LbAccessControlSettings input)
        {
            if (input == null) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.Type != input.Type) return false;
            if (this.IpGroups != input.IpGroups || (this.IpGroups != null && input.IpGroups != null && !this.IpGroups.SequenceEqual(input.IpGroups))) return false;

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
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IpGroups != null) hashCode = hashCode * 59 + this.IpGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
