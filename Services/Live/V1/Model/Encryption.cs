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
        /// 加密方式
        /// </summary>
        /// <value>加密方式</value>
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

            public static bool operator !=(SystemIdsEnum a, SystemIdsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 密钥缓存时间。如果密钥不变，默认缓存七天
        /// </summary>
        [JsonProperty("key_rotation_interval_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeyRotationIntervalSeconds { get; set; }

        /// <summary>
        /// 加密方式
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
        [JsonProperty("drm_content_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DrmContentId { get; set; }

        /// <summary>
        /// system_id枚举值
        /// </summary>
        [JsonProperty("system_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemIdsEnum> SystemIds { get; set; }
        /// <summary>
        /// 增加到请求消息体header中的鉴权信息
        /// </summary>
        [JsonProperty("auth_info", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthInfo { get; set; }

        /// <summary>
        /// 获取密钥的DRM地址
        /// </summary>
        [JsonProperty("km_url", NullValueHandling = NullValueHandling.Ignore)]
        public string KmUrl { get; set; }



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
            sb.Append("  drmContentId: ").Append(DrmContentId).Append("\n");
            sb.Append("  systemIds: ").Append(SystemIds).Append("\n");
            sb.Append("  authInfo: ").Append(AuthInfo).Append("\n");
            sb.Append("  kmUrl: ").Append(KmUrl).Append("\n");
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
            if (this.DrmContentId != input.DrmContentId || (this.DrmContentId != null && !this.DrmContentId.Equals(input.DrmContentId))) return false;
            if (this.SystemIds != input.SystemIds || (this.SystemIds != null && input.SystemIds != null && !this.SystemIds.SequenceEqual(input.SystemIds))) return false;
            if (this.AuthInfo != input.AuthInfo || (this.AuthInfo != null && !this.AuthInfo.Equals(input.AuthInfo))) return false;
            if (this.KmUrl != input.KmUrl || (this.KmUrl != null && !this.KmUrl.Equals(input.KmUrl))) return false;

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
                if (this.DrmContentId != null) hashCode = hashCode * 59 + this.DrmContentId.GetHashCode();
                hashCode = hashCode * 59 + this.SystemIds.GetHashCode();
                if (this.AuthInfo != null) hashCode = hashCode * 59 + this.AuthInfo.GetHashCode();
                if (this.KmUrl != null) hashCode = hashCode * 59 + this.KmUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
