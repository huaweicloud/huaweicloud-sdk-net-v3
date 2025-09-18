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
    /// 加密信息
    /// </summary>
    public class Encryption 
    {
        /// <summary>
        /// 加密方式。  请注意：目前为保留字段，不支持配置。 
        /// </summary>
        /// <value>加密方式。  请注意：目前为保留字段，不支持配置。 </value>
        [JsonConverter(typeof(EnumClassConverter<EncryptionMethodEnum>))]
        public class EncryptionMethodEnum
        {
            /// <summary>
            /// Enum SAMPLE_AES for value: SAMPLE-AES
            /// </summary>
            public static readonly EncryptionMethodEnum SAMPLE_AES = new EncryptionMethodEnum("SAMPLE-AES");

            /// <summary>
            /// Enum AES_128 for value: AES-128
            /// </summary>
            public static readonly EncryptionMethodEnum AES_128 = new EncryptionMethodEnum("AES-128");

            private static readonly Dictionary<string, EncryptionMethodEnum> StaticFields =
            new Dictionary<string, EncryptionMethodEnum>()
            {
                { "SAMPLE-AES", SAMPLE_AES },
                { "AES-128", AES_128 },
            };

            private string _value;

            public EncryptionMethodEnum()
            {

            }

            public EncryptionMethodEnum(string value)
            {
                _value = value;
            }

            public static EncryptionMethodEnum FromValue(string value)
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

                if (this.Equals(obj as EncryptionMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EncryptionMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EncryptionMethodEnum a, EncryptionMethodEnum b)
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

            public static bool operator !=(EncryptionMethodEnum a, EncryptionMethodEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 取值如下： - content：一个频道对应一个密钥 - profile：一个码率对应一个密钥  默认值：content
        /// </summary>
        /// <value>取值如下： - content：一个频道对应一个密钥 - profile：一个码率对应一个密钥  默认值：content</value>
        [JsonConverter(typeof(EnumClassConverter<LevelEnum>))]
        public class LevelEnum
        {
            /// <summary>
            /// Enum CONTENT for value: content
            /// </summary>
            public static readonly LevelEnum CONTENT = new LevelEnum("content");

            /// <summary>
            /// Enum PROFILE for value: profile
            /// </summary>
            public static readonly LevelEnum PROFILE = new LevelEnum("profile");

            private static readonly Dictionary<string, LevelEnum> StaticFields =
            new Dictionary<string, LevelEnum>()
            {
                { "content", CONTENT },
                { "profile", PROFILE },
            };

            private string _value;

            public LevelEnum()
            {

            }

            public LevelEnum(string value)
            {
                _value = value;
            }

            public static LevelEnum FromValue(string value)
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

                if (this.Equals(obj as LevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LevelEnum a, LevelEnum b)
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

            public static bool operator !=(LevelEnum a, LevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines systemIds
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SystemIdsEnum>))]
        public class SystemIdsEnum
        {
            /// <summary>
            /// Enum WIDEVINE for value: Widevine
            /// </summary>
            public static readonly SystemIdsEnum WIDEVINE = new SystemIdsEnum("Widevine");

            /// <summary>
            /// Enum PLAYREADY for value: PlayReady
            /// </summary>
            public static readonly SystemIdsEnum PLAYREADY = new SystemIdsEnum("PlayReady");

            /// <summary>
            /// Enum FAIRPLAY for value: FairPlay
            /// </summary>
            public static readonly SystemIdsEnum FAIRPLAY = new SystemIdsEnum("FairPlay");

            private static readonly Dictionary<string, SystemIdsEnum> StaticFields =
            new Dictionary<string, SystemIdsEnum>()
            {
                { "Widevine", WIDEVINE },
                { "PlayReady", PLAYREADY },
                { "FairPlay", FAIRPLAY },
            };

            private string _value;

            public SystemIdsEnum()
            {

            }

            public SystemIdsEnum(string value)
            {
                _value = value;
            }

            public static SystemIdsEnum FromValue(string value)
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

                if (this.Equals(obj as SystemIdsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SystemIdsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SystemIdsEnum a, SystemIdsEnum b)
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

            public static bool operator !=(SystemIdsEnum a, SystemIdsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// drm speke 版本号 当前只支持1.0
        /// </summary>
        /// <value>drm speke 版本号 当前只支持1.0</value>
        [JsonConverter(typeof(EnumClassConverter<SpekeVersionEnum>))]
        public class SpekeVersionEnum
        {
            /// <summary>
            /// Enum _1_0 for value: 1.0
            /// </summary>
            public static readonly SpekeVersionEnum _1_0 = new SpekeVersionEnum("1.0");

            private static readonly Dictionary<string, SpekeVersionEnum> StaticFields =
            new Dictionary<string, SpekeVersionEnum>()
            {
                { "1.0", _1_0 },
            };

            private string _value;

            public SpekeVersionEnum()
            {

            }

            public SpekeVersionEnum(string value)
            {
                _value = value;
            }

            public static SpekeVersionEnum FromValue(string value)
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

                if (this.Equals(obj as SpekeVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SpekeVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SpekeVersionEnum a, SpekeVersionEnum b)
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

            public static bool operator !=(SpekeVersionEnum a, SpekeVersionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 请求模式。  取值如下： * direct_http：HTTP(S)直接访问DRM。 * functiongraph_proxy：FunctionGraph代理访问DRM。 
        /// </summary>
        /// <value>请求模式。  取值如下： * direct_http：HTTP(S)直接访问DRM。 * functiongraph_proxy：FunctionGraph代理访问DRM。 </value>
        [JsonConverter(typeof(EnumClassConverter<RequestModeEnum>))]
        public class RequestModeEnum
        {
            /// <summary>
            /// Enum DIRECT_HTTP for value: direct_http
            /// </summary>
            public static readonly RequestModeEnum DIRECT_HTTP = new RequestModeEnum("direct_http");

            /// <summary>
            /// Enum FUNCTIONGRAPH_PROXY for value: functiongraph_proxy
            /// </summary>
            public static readonly RequestModeEnum FUNCTIONGRAPH_PROXY = new RequestModeEnum("functiongraph_proxy");

            private static readonly Dictionary<string, RequestModeEnum> StaticFields =
            new Dictionary<string, RequestModeEnum>()
            {
                { "direct_http", DIRECT_HTTP },
                { "functiongraph_proxy", FUNCTIONGRAPH_PROXY },
            };

            private string _value;

            public RequestModeEnum()
            {

            }

            public RequestModeEnum(string value)
            {
                _value = value;
            }

            public static RequestModeEnum FromValue(string value)
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

                if (this.Equals(obj as RequestModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RequestModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RequestModeEnum a, RequestModeEnum b)
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

            public static bool operator !=(RequestModeEnum a, RequestModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 密钥缓存时间。如果密钥不变，默认缓存七天。  请注意：目前为保留字段，不支持配置。 
        /// </summary>
        [JsonProperty("key_rotation_interval_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeyRotationIntervalSeconds { get; set; }

        /// <summary>
        /// 加密方式。  请注意：目前为保留字段，不支持配置。 
        /// </summary>
        [JsonProperty("encryption_method", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptionMethodEnum EncryptionMethod { get; set; }
        /// <summary>
        /// 取值如下： - content：一个频道对应一个密钥 - profile：一个码率对应一个密钥  默认值：content
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public LevelEnum Level { get; set; }
        /// <summary>
        /// 客户生成的DRM内容ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// system_id枚举值。  取值如下： * HLS：FairPlay * DASH：Widevine、PlayReady * MSS：PlayReady 
        /// </summary>
        [JsonProperty("system_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemIdsEnum> SystemIds { get; set; }
        /// <summary>
        /// 获取密钥的DRM地址
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// drm speke 版本号 当前只支持1.0
        /// </summary>
        [JsonProperty("speke_version", NullValueHandling = NullValueHandling.Ignore)]
        public SpekeVersionEnum SpekeVersion { get; set; }
        /// <summary>
        /// 请求模式。  取值如下： * direct_http：HTTP(S)直接访问DRM。 * functiongraph_proxy：FunctionGraph代理访问DRM。 
        /// </summary>
        [JsonProperty("request_mode", NullValueHandling = NullValueHandling.Ignore)]
        public RequestModeEnum RequestMode { get; set; }
        /// <summary>
        /// 需要添加在drm请求头中的鉴权信息。最多支持配置5个。  仅direct_http请求模式支持配置http_headers。 
        /// </summary>
        [JsonProperty("http_headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<HttpHeader> HttpHeaders { get; set; }

        /// <summary>
        /// functiongraph_proxy请求模式需要提供functiongraph的urn。
        /// </summary>
        [JsonProperty("urn", NullValueHandling = NullValueHandling.Ignore)]
        public string Urn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Encryption {\n");
            sb.Append("  keyRotationIntervalSeconds: ").Append(KeyRotationIntervalSeconds).Append("\n");
            sb.Append("  encryptionMethod: ").Append(EncryptionMethod).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  systemIds: ").Append(SystemIds).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  spekeVersion: ").Append(SpekeVersion).Append("\n");
            sb.Append("  requestMode: ").Append(RequestMode).Append("\n");
            sb.Append("  httpHeaders: ").Append(HttpHeaders).Append("\n");
            sb.Append("  urn: ").Append(Urn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Encryption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Encryption input)
        {
            if (input == null) return false;
            if (this.KeyRotationIntervalSeconds != input.KeyRotationIntervalSeconds || (this.KeyRotationIntervalSeconds != null && !this.KeyRotationIntervalSeconds.Equals(input.KeyRotationIntervalSeconds))) return false;
            if (this.EncryptionMethod != input.EncryptionMethod) return false;
            if (this.Level != input.Level) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.SystemIds != input.SystemIds || (this.SystemIds != null && input.SystemIds != null && !this.SystemIds.SequenceEqual(input.SystemIds))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.SpekeVersion != input.SpekeVersion) return false;
            if (this.RequestMode != input.RequestMode) return false;
            if (this.HttpHeaders != input.HttpHeaders || (this.HttpHeaders != null && input.HttpHeaders != null && !this.HttpHeaders.SequenceEqual(input.HttpHeaders))) return false;
            if (this.Urn != input.Urn || (this.Urn != null && !this.Urn.Equals(input.Urn))) return false;

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
                if (this.KeyRotationIntervalSeconds != null) hashCode = hashCode * 59 + this.KeyRotationIntervalSeconds.GetHashCode();
                hashCode = hashCode * 59 + this.EncryptionMethod.GetHashCode();
                hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                hashCode = hashCode * 59 + this.SystemIds.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.SpekeVersion.GetHashCode();
                hashCode = hashCode * 59 + this.RequestMode.GetHashCode();
                if (this.HttpHeaders != null) hashCode = hashCode * 59 + this.HttpHeaders.GetHashCode();
                if (this.Urn != null) hashCode = hashCode * 59 + this.Urn.GetHashCode();
                return hashCode;
            }
        }
    }
}
