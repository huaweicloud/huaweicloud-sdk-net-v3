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
    /// StreamConnect flow解密信息
    /// </summary>
    public class FlowSourceDecryption 
    {
        /// <summary>
        /// 加密算法，aes128: 加密算法为aes-128，aes192:加密算法为aes-192，aes256: 加密算法为AES-256
        /// </summary>
        /// <value>加密算法，aes128: 加密算法为aes-128，aes192:加密算法为aes-192，aes256: 加密算法为AES-256</value>
        [JsonConverter(typeof(EnumClassConverter<AlgorithmEnum>))]
        public class AlgorithmEnum
        {
            /// <summary>
            /// Enum AES128 for value: aes128
            /// </summary>
            public static readonly AlgorithmEnum AES128 = new AlgorithmEnum("aes128");

            /// <summary>
            /// Enum AES192 for value: aes192
            /// </summary>
            public static readonly AlgorithmEnum AES192 = new AlgorithmEnum("aes192");

            /// <summary>
            /// Enum AES256 for value: aes256
            /// </summary>
            public static readonly AlgorithmEnum AES256 = new AlgorithmEnum("aes256");

            private static readonly Dictionary<string, AlgorithmEnum> StaticFields =
            new Dictionary<string, AlgorithmEnum>()
            {
                { "aes128", AES128 },
                { "aes192", AES192 },
                { "aes256", AES256 },
            };

            private string _value;

            public AlgorithmEnum()
            {

            }

            public AlgorithmEnum(string value)
            {
                _value = value;
            }

            public static AlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as AlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AlgorithmEnum a, AlgorithmEnum b)
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

            public static bool operator !=(AlgorithmEnum a, AlgorithmEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 秘钥类型,speke:使用speke协议获取秘钥,static-key:静态秘钥,srt-password:SRT协议秘钥 目前仅支持srt-password类型，其他类型暂不支持
        /// </summary>
        /// <value>秘钥类型,speke:使用speke协议获取秘钥,static-key:静态秘钥,srt-password:SRT协议秘钥 目前仅支持srt-password类型，其他类型暂不支持</value>
        [JsonConverter(typeof(EnumClassConverter<KeyTypeEnum>))]
        public class KeyTypeEnum
        {
            /// <summary>
            /// Enum SPEKE for value: speke
            /// </summary>
            public static readonly KeyTypeEnum SPEKE = new KeyTypeEnum("speke");

            /// <summary>
            /// Enum STATIC_KEY for value: static-key
            /// </summary>
            public static readonly KeyTypeEnum STATIC_KEY = new KeyTypeEnum("static-key");

            /// <summary>
            /// Enum SRT_PASSWORD for value: srt-password
            /// </summary>
            public static readonly KeyTypeEnum SRT_PASSWORD = new KeyTypeEnum("srt-password");

            private static readonly Dictionary<string, KeyTypeEnum> StaticFields =
            new Dictionary<string, KeyTypeEnum>()
            {
                { "speke", SPEKE },
                { "static-key", STATIC_KEY },
                { "srt-password", SRT_PASSWORD },
            };

            private string _value;

            public KeyTypeEnum()
            {

            }

            public KeyTypeEnum(string value)
            {
                _value = value;
            }

            public static KeyTypeEnum FromValue(string value)
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

                if (this.Equals(obj as KeyTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeyTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeyTypeEnum a, KeyTypeEnum b)
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

            public static bool operator !=(KeyTypeEnum a, KeyTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 加密算法，aes128: 加密算法为aes-128，aes192:加密算法为aes-192，aes256: 加密算法为AES-256
        /// </summary>
        [JsonProperty("algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public AlgorithmEnum Algorithm { get; set; }
        /// <summary>
        /// 秘钥类型,speke:使用speke协议获取秘钥,static-key:静态秘钥,srt-password:SRT协议秘钥 目前仅支持srt-password类型，其他类型暂不支持
        /// </summary>
        [JsonProperty("key_type", NullValueHandling = NullValueHandling.Ignore)]
        public KeyTypeEnum KeyType { get; set; }
        /// <summary>
        /// srt解密秘钥，用于flow对srt流进行解密
        /// </summary>
        [JsonProperty("passphrase", NullValueHandling = NullValueHandling.Ignore)]
        public string Passphrase { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowSourceDecryption {\n");
            sb.Append("  algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  keyType: ").Append(KeyType).Append("\n");
            sb.Append("  passphrase: ").Append(Passphrase).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowSourceDecryption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowSourceDecryption input)
        {
            if (input == null) return false;
            if (this.Algorithm != input.Algorithm) return false;
            if (this.KeyType != input.KeyType) return false;
            if (this.Passphrase != input.Passphrase || (this.Passphrase != null && !this.Passphrase.Equals(input.Passphrase))) return false;

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
                hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                hashCode = hashCode * 59 + this.KeyType.GetHashCode();
                if (this.Passphrase != null) hashCode = hashCode * 59 + this.Passphrase.GetHashCode();
                return hashCode;
            }
        }
    }
}
