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
    /// 客户自定义DNS服务。
    /// </summary>
    public class CustomizedDns 
    {
        /// <summary>
        /// 设置客户自定义DNS的行为。 - add：新增客户自定义DNS IP。 - keep：保持客户自定义DNS IP。 - update：更新客户自定义DNS IP（当DNS IP变化时更新生效）。 - recover：还原系统默认DNS IP（还原时可能会导致域名解析失败，请谨慎操作）。
        /// </summary>
        /// <value>设置客户自定义DNS的行为。 - add：新增客户自定义DNS IP。 - keep：保持客户自定义DNS IP。 - update：更新客户自定义DNS IP（当DNS IP变化时更新生效）。 - recover：还原系统默认DNS IP（还原时可能会导致域名解析失败，请谨慎操作）。</value>
        [JsonConverter(typeof(EnumClassConverter<SetDnsActionEnum>))]
        public class SetDnsActionEnum
        {
            /// <summary>
            /// Enum ADD for value: add
            /// </summary>
            public static readonly SetDnsActionEnum ADD = new SetDnsActionEnum("add");

            /// <summary>
            /// Enum KEEP for value: keep
            /// </summary>
            public static readonly SetDnsActionEnum KEEP = new SetDnsActionEnum("keep");

            /// <summary>
            /// Enum UPDATE for value: update
            /// </summary>
            public static readonly SetDnsActionEnum UPDATE = new SetDnsActionEnum("update");

            /// <summary>
            /// Enum RECOVER for value: recover
            /// </summary>
            public static readonly SetDnsActionEnum RECOVER = new SetDnsActionEnum("recover");

            private static readonly Dictionary<string, SetDnsActionEnum> StaticFields =
            new Dictionary<string, SetDnsActionEnum>()
            {
                { "add", ADD },
                { "keep", KEEP },
                { "update", UPDATE },
                { "recover", RECOVER },
            };

            private string _value;

            public SetDnsActionEnum()
            {

            }

            public SetDnsActionEnum(string value)
            {
                _value = value;
            }

            public static SetDnsActionEnum FromValue(string value)
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

                if (this.Equals(obj as SetDnsActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SetDnsActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SetDnsActionEnum a, SetDnsActionEnum b)
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

            public static bool operator !=(SetDnsActionEnum a, SetDnsActionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否设置客户自定义DNS。
        /// </summary>
        [JsonProperty("is_set_dns", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSetDns { get; set; }

        /// <summary>
        /// 设置客户自定义DNS的行为。 - add：新增客户自定义DNS IP。 - keep：保持客户自定义DNS IP。 - update：更新客户自定义DNS IP（当DNS IP变化时更新生效）。 - recover：还原系统默认DNS IP（还原时可能会导致域名解析失败，请谨慎操作）。
        /// </summary>
        [JsonProperty("set_dns_action", NullValueHandling = NullValueHandling.Ignore)]
        public SetDnsActionEnum SetDnsAction { get; set; }
        /// <summary>
        /// 设置客户自定义DNS IP。
        /// </summary>
        [JsonProperty("dns_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomizedDns {\n");
            sb.Append("  isSetDns: ").Append(IsSetDns).Append("\n");
            sb.Append("  setDnsAction: ").Append(SetDnsAction).Append("\n");
            sb.Append("  dnsIp: ").Append(DnsIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomizedDns);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomizedDns input)
        {
            if (input == null) return false;
            if (this.IsSetDns != input.IsSetDns || (this.IsSetDns != null && !this.IsSetDns.Equals(input.IsSetDns))) return false;
            if (this.SetDnsAction != input.SetDnsAction) return false;
            if (this.DnsIp != input.DnsIp || (this.DnsIp != null && !this.DnsIp.Equals(input.DnsIp))) return false;

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
                if (this.IsSetDns != null) hashCode = hashCode * 59 + this.IsSetDns.GetHashCode();
                hashCode = hashCode * 59 + this.SetDnsAction.GetHashCode();
                if (this.DnsIp != null) hashCode = hashCode * 59 + this.DnsIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
