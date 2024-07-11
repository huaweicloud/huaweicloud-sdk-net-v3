using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPullSourcesConfigResponse : SdkResponse
    {
        /// <summary>
        /// 回源方式。 - domain: 回源客户源站，源站地址是域名格式。回源域名，可配置多个，如果回源失败，将按照配置顺序进行轮循。 - ipaddr: 回源客户源站，源站地址是IP格式。回源IP，可配置多个，如果回源失败，将按照配置顺序进行轮循。同时，最多可以配置一个回源域名，如果配置，回源时httpflv HOST头填该域名，RTMP tcurl字段填该域名，否则按当前IP作为HOST。 - huawei: 回源华为源站，域名创建后的默认值。
        /// </summary>
        /// <value>回源方式。 - domain: 回源客户源站，源站地址是域名格式。回源域名，可配置多个，如果回源失败，将按照配置顺序进行轮循。 - ipaddr: 回源客户源站，源站地址是IP格式。回源IP，可配置多个，如果回源失败，将按照配置顺序进行轮循。同时，最多可以配置一个回源域名，如果配置，回源时httpflv HOST头填该域名，RTMP tcurl字段填该域名，否则按当前IP作为HOST。 - huawei: 回源华为源站，域名创建后的默认值。</value>
        [JsonConverter(typeof(EnumClassConverter<SourceTypeEnum>))]
        public class SourceTypeEnum
        {
            /// <summary>
            /// Enum DOMAIN for value: domain
            /// </summary>
            public static readonly SourceTypeEnum DOMAIN = new SourceTypeEnum("domain");

            /// <summary>
            /// Enum IPADDR for value: ipaddr
            /// </summary>
            public static readonly SourceTypeEnum IPADDR = new SourceTypeEnum("ipaddr");

            /// <summary>
            /// Enum HUAWEI for value: huawei
            /// </summary>
            public static readonly SourceTypeEnum HUAWEI = new SourceTypeEnum("huawei");

            private static readonly Dictionary<string, SourceTypeEnum> StaticFields =
            new Dictionary<string, SourceTypeEnum>()
            {
                { "domain", DOMAIN },
                { "ipaddr", IPADDR },
                { "huawei", HUAWEI },
            };

            private string _value;

            public SourceTypeEnum()
            {

            }

            public SourceTypeEnum(string value)
            {
                _value = value;
            }

            public static SourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceTypeEnum a, SourceTypeEnum b)
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

            public static bool operator !=(SourceTypeEnum a, SourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 回源协议，回源方式非“huawei”时必选。
        /// </summary>
        /// <value>回源协议，回源方式非“huawei”时必选。</value>
        [JsonConverter(typeof(EnumClassConverter<SchemeEnum>))]
        public class SchemeEnum
        {
            /// <summary>
            /// Enum HTTP for value: http
            /// </summary>
            public static readonly SchemeEnum HTTP = new SchemeEnum("http");

            /// <summary>
            /// Enum RTMP for value: rtmp
            /// </summary>
            public static readonly SchemeEnum RTMP = new SchemeEnum("rtmp");

            private static readonly Dictionary<string, SchemeEnum> StaticFields =
            new Dictionary<string, SchemeEnum>()
            {
                { "http", HTTP },
                { "rtmp", RTMP },
            };

            private string _value;

            public SchemeEnum()
            {

            }

            public SchemeEnum(string value)
            {
                _value = value;
            }

            public static SchemeEnum FromValue(string value)
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

                if (this.Equals(obj as SchemeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SchemeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SchemeEnum a, SchemeEnum b)
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

            public static bool operator !=(SchemeEnum a, SchemeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 播放域名
        /// </summary>
        [JsonProperty("play_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// 回源方式。 - domain: 回源客户源站，源站地址是域名格式。回源域名，可配置多个，如果回源失败，将按照配置顺序进行轮循。 - ipaddr: 回源客户源站，源站地址是IP格式。回源IP，可配置多个，如果回源失败，将按照配置顺序进行轮循。同时，最多可以配置一个回源域名，如果配置，回源时httpflv HOST头填该域名，RTMP tcurl字段填该域名，否则按当前IP作为HOST。 - huawei: 回源华为源站，域名创建后的默认值。
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// 回源域名列表，最多可配置10个。 - 当回源方式是“domain”时，此参数必选，域名配置多个时，如果回源失败，将按照配置顺序进行轮循。 - 当回源方式是“ipaddr”时，最多可以配置一个回源域名，如果配置，回源时httpflv HOST头填该域名，RTMP tcurl 字段填该域名，否则按当前IP作为HOST。
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sources { get; set; }

        /// <summary>
        /// 回源IP地址列表，最多可配置10个。当回源方式是“ipaddr”时，此参数必选，IP配置多个时，如果回源失败，将按照配置顺序进行轮循。
        /// </summary>
        [JsonProperty("sources_ip", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourcesIp { get; set; }

        /// <summary>
        /// 回源端口。 
        /// </summary>
        [JsonProperty("source_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourcePort { get; set; }

        /// <summary>
        /// 回源协议，回源方式非“huawei”时必选。
        /// </summary>
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public SchemeEnum Scheme { get; set; }
        /// <summary>
        /// 回源客户源站时在URL携带的参数。
        /// </summary>
        [JsonProperty("additional_args", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AdditionalArgs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPullSourcesConfigResponse {\n");
            sb.Append("  playDomain: ").Append(PlayDomain).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  sourcesIp: ").Append(SourcesIp).Append("\n");
            sb.Append("  sourcePort: ").Append(SourcePort).Append("\n");
            sb.Append("  scheme: ").Append(Scheme).Append("\n");
            sb.Append("  additionalArgs: ").Append(AdditionalArgs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPullSourcesConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPullSourcesConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlayDomain == input.PlayDomain ||
                    (this.PlayDomain != null &&
                    this.PlayDomain.Equals(input.PlayDomain))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.Sources == input.Sources ||
                    this.Sources != null &&
                    input.Sources != null &&
                    this.Sources.SequenceEqual(input.Sources)
                ) && 
                (
                    this.SourcesIp == input.SourcesIp ||
                    this.SourcesIp != null &&
                    input.SourcesIp != null &&
                    this.SourcesIp.SequenceEqual(input.SourcesIp)
                ) && 
                (
                    this.SourcePort == input.SourcePort ||
                    (this.SourcePort != null &&
                    this.SourcePort.Equals(input.SourcePort))
                ) && 
                (
                    this.Scheme == input.Scheme ||
                    (this.Scheme != null &&
                    this.Scheme.Equals(input.Scheme))
                ) && 
                (
                    this.AdditionalArgs == input.AdditionalArgs ||
                    this.AdditionalArgs != null &&
                    input.AdditionalArgs != null &&
                    this.AdditionalArgs.SequenceEqual(input.AdditionalArgs)
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
                if (this.PlayDomain != null)
                    hashCode = hashCode * 59 + this.PlayDomain.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.Sources != null)
                    hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.SourcesIp != null)
                    hashCode = hashCode * 59 + this.SourcesIp.GetHashCode();
                if (this.SourcePort != null)
                    hashCode = hashCode * 59 + this.SourcePort.GetHashCode();
                if (this.Scheme != null)
                    hashCode = hashCode * 59 + this.Scheme.GetHashCode();
                if (this.AdditionalArgs != null)
                    hashCode = hashCode * 59 + this.AdditionalArgs.GetHashCode();
                return hashCode;
            }
        }
    }
}
