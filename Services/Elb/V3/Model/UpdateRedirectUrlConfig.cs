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
    /// 转发到的url配置。  当监听器的高级转发策略功能（enhance_l7policy_enable）开启后才会生效，未开启传入该字段会报错。  当action为REDIRECT_TO_URL时生效，且为必选字段，其他action不可指定，否则报错。  格式：protocol://host:port/path?query  protocol、host、port、path不允许同时不传或同时传${xxx} （${xxx}表示原值，如${host}表示被转发的请求URL的host部分）。 protocol和port传入的值不能与l7policy关联的监听器一致且host、path同时不传或同时传${xxx}。   [共享型负载均衡器下的转发策略不支持该字段，传入会报错。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt)  [不支持该字段，请勿使用。](tag:hcso_dt) [荷兰region不支持该字段，请勿使用。](tag:dt)
    /// </summary>
    public class UpdateRedirectUrlConfig 
    {
        /// <summary>
        /// 重定向的协议。默认值${protocol}表示继承原值（即与被转发请求保持一致）。  取值范围： - HTTP - HTTPS - ${protocol}
        /// </summary>
        /// <value>重定向的协议。默认值${protocol}表示继承原值（即与被转发请求保持一致）。  取值范围： - HTTP - HTTPS - ${protocol}</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            public static readonly ProtocolEnum HTTP = new ProtocolEnum("HTTP");

            /// <summary>
            /// Enum HTTPS for value: HTTPS
            /// </summary>
            public static readonly ProtocolEnum HTTPS = new ProtocolEnum("HTTPS");

            /// <summary>
            /// Enum _PROTOCOL_ for value: ${protocol}
            /// </summary>
            public static readonly ProtocolEnum _PROTOCOL_ = new ProtocolEnum("${protocol}");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "HTTP", HTTP },
                { "HTTPS", HTTPS },
                { "${protocol}", _PROTOCOL_ },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 重定向后的返回码。  取值范围： - 301 - 302 - 303 - 307 - 308
        /// </summary>
        /// <value>重定向后的返回码。  取值范围： - 301 - 302 - 303 - 307 - 308</value>
        [JsonConverter(typeof(EnumClassConverter<StatusCodeEnum>))]
        public class StatusCodeEnum
        {
            /// <summary>
            /// Enum _301 for value: 301
            /// </summary>
            public static readonly StatusCodeEnum _301 = new StatusCodeEnum("301");

            /// <summary>
            /// Enum _302 for value: 302
            /// </summary>
            public static readonly StatusCodeEnum _302 = new StatusCodeEnum("302");

            /// <summary>
            /// Enum _303 for value: 303
            /// </summary>
            public static readonly StatusCodeEnum _303 = new StatusCodeEnum("303");

            /// <summary>
            /// Enum _307 for value: 307
            /// </summary>
            public static readonly StatusCodeEnum _307 = new StatusCodeEnum("307");

            /// <summary>
            /// Enum _308 for value: 308
            /// </summary>
            public static readonly StatusCodeEnum _308 = new StatusCodeEnum("308");

            private static readonly Dictionary<string, StatusCodeEnum> StaticFields =
            new Dictionary<string, StatusCodeEnum>()
            {
                { "301", _301 },
                { "302", _302 },
                { "303", _303 },
                { "307", _307 },
                { "308", _308 },
            };

            private string _value;

            public StatusCodeEnum()
            {

            }

            public StatusCodeEnum(string value)
            {
                _value = value;
            }

            public static StatusCodeEnum FromValue(string value)
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

                if (this.Equals(obj as StatusCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusCodeEnum a, StatusCodeEnum b)
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

            public static bool operator !=(StatusCodeEnum a, StatusCodeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 重定向的协议。默认值${protocol}表示继承原值（即与被转发请求保持一致）。  取值范围： - HTTP - HTTPS - ${protocol}
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 重定向的主机名。字符串只能包含英文字母、数字、“-”、“.”，必须以字母、数字开头。 默认值${host}表示继承原值（即与被转发请求保持一致）。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// 重定向到的端口。默认值${port}表示继承原值（即与被转发请求保持一致）。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 重定向的路径。默认值${path}表示继承原值（即与被转发请求保持一致）。  只能包含英文字母、数字、_~&#39;;@^-%#&amp;$.*+?,&#x3D;!:|\\/()\\[\\]{}，且必须以\&quot;/\&quot;开头
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 重定向的查询字符串。默认${query}表示继承原值（即与被转发请求保持一致）。举例如下：  若该字段被设置为：${query}&amp;name&#x3D;my_name，则在转发符合条件的URL （如https://www.xxx.com:8080/elb?type&#x3D;loadbalancer， 此时${query}表示type&#x3D;loadbalancer）时，将会重定向到 https://www.xxx.com:8080/elb?type&#x3D;loadbalancer&amp;name&#x3D;my_name。其中$1，$2会匹配请求url通配符星号（*）。  只能包含英文字母、数字和特殊字符：!$&amp;&#39;()*+,-./:;&#x3D;?@^_&#x60;。字母区分大小写。
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// 重定向后的返回码。  取值范围： - 301 - 302 - 303 - 307 - 308
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public StatusCodeEnum StatusCode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRedirectUrlConfig {\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRedirectUrlConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRedirectUrlConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
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
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
