using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMetadataOptionsResponse : SdkResponse
    {
        /// <summary>
        /// 是否禁用IMDS服务。
        /// </summary>
        /// <value>是否禁用IMDS服务。</value>
        [JsonConverter(typeof(EnumClassConverter<HttpEndpointEnum>))]
        public class HttpEndpointEnum
        {
            /// <summary>
            /// Enum ENABLED for value: enabled
            /// </summary>
            public static readonly HttpEndpointEnum ENABLED = new HttpEndpointEnum("enabled");

            /// <summary>
            /// Enum DISABLED for value: disabled
            /// </summary>
            public static readonly HttpEndpointEnum DISABLED = new HttpEndpointEnum("disabled");

            private static readonly Dictionary<string, HttpEndpointEnum> StaticFields =
            new Dictionary<string, HttpEndpointEnum>()
            {
                { "enabled", ENABLED },
                { "disabled", DISABLED },
            };

            private string _value;

            public HttpEndpointEnum()
            {

            }

            public HttpEndpointEnum(string value)
            {
                _value = value;
            }

            public static HttpEndpointEnum FromValue(string value)
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

                if (this.Equals(obj as HttpEndpointEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HttpEndpointEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HttpEndpointEnum a, HttpEndpointEnum b)
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

            public static bool operator !=(HttpEndpointEnum a, HttpEndpointEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否要求携带token。
        /// </summary>
        /// <value>是否要求携带token。</value>
        [JsonConverter(typeof(EnumClassConverter<HttpTokensEnum>))]
        public class HttpTokensEnum
        {
            /// <summary>
            /// Enum OPTIONAL for value: optional
            /// </summary>
            public static readonly HttpTokensEnum OPTIONAL = new HttpTokensEnum("optional");

            /// <summary>
            /// Enum REQUIRED for value: required
            /// </summary>
            public static readonly HttpTokensEnum REQUIRED = new HttpTokensEnum("required");

            private static readonly Dictionary<string, HttpTokensEnum> StaticFields =
            new Dictionary<string, HttpTokensEnum>()
            {
                { "optional", OPTIONAL },
                { "required", REQUIRED },
            };

            private string _value;

            public HttpTokensEnum()
            {

            }

            public HttpTokensEnum(string value)
            {
                _value = value;
            }

            public static HttpTokensEnum FromValue(string value)
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

                if (this.Equals(obj as HttpTokensEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HttpTokensEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HttpTokensEnum a, HttpTokensEnum b)
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

            public static bool operator !=(HttpTokensEnum a, HttpTokensEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否禁用IMDS服务。
        /// </summary>
        [JsonProperty("http_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public HttpEndpointEnum HttpEndpoint { get; set; }
        /// <summary>
        /// 是否要求携带token。
        /// </summary>
        [JsonProperty("http_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public HttpTokensEnum HttpTokens { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetadataOptionsResponse {\n");
            sb.Append("  httpEndpoint: ").Append(HttpEndpoint).Append("\n");
            sb.Append("  httpTokens: ").Append(HttpTokens).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetadataOptionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetadataOptionsResponse input)
        {
            if (input == null) return false;
            if (this.HttpEndpoint != input.HttpEndpoint) return false;
            if (this.HttpTokens != input.HttpTokens) return false;

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
                hashCode = hashCode * 59 + this.HttpEndpoint.GetHashCode();
                hashCode = hashCode * 59 + this.HttpTokens.GetHashCode();
                return hashCode;
            }
        }
    }
}
