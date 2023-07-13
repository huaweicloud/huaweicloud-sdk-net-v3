using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VerifyRequestBody 
    {
        /// <summary>
        /// 签名算法，枚举如下：  - RSASSA_PSS_SHA_256  - RSASSA_PSS_SHA_384  - RSASSA_PSS_SHA_512  - RSASSA_PKCS1_V1_5_SHA_256  - RSASSA_PKCS1_V1_5_SHA_384  - RSASSA_PKCS1_V1_5_SHA_512  - ECDSA_SHA_256  - ECDSA_SHA_384  - ECDSA_SHA_512  - SM2DSA_SM3
        /// </summary>
        /// <value>签名算法，枚举如下：  - RSASSA_PSS_SHA_256  - RSASSA_PSS_SHA_384  - RSASSA_PSS_SHA_512  - RSASSA_PKCS1_V1_5_SHA_256  - RSASSA_PKCS1_V1_5_SHA_384  - RSASSA_PKCS1_V1_5_SHA_512  - ECDSA_SHA_256  - ECDSA_SHA_384  - ECDSA_SHA_512  - SM2DSA_SM3</value>
        [JsonConverter(typeof(EnumClassConverter<SigningAlgorithmEnum>))]
        public class SigningAlgorithmEnum
        {
            /// <summary>
            /// Enum RSASSA_PSS_SHA_256 for value: RSASSA_PSS_SHA_256
            /// </summary>
            public static readonly SigningAlgorithmEnum RSASSA_PSS_SHA_256 = new SigningAlgorithmEnum("RSASSA_PSS_SHA_256");

            /// <summary>
            /// Enum RSASSA_PSS_SHA_384 for value: RSASSA_PSS_SHA_384
            /// </summary>
            public static readonly SigningAlgorithmEnum RSASSA_PSS_SHA_384 = new SigningAlgorithmEnum("RSASSA_PSS_SHA_384");

            /// <summary>
            /// Enum RSASSA_PSS_SHA_512 for value: RSASSA_PSS_SHA_512
            /// </summary>
            public static readonly SigningAlgorithmEnum RSASSA_PSS_SHA_512 = new SigningAlgorithmEnum("RSASSA_PSS_SHA_512");

            /// <summary>
            /// Enum RSASSA_PKCS1_V1_5_SHA_256 for value: RSASSA_PKCS1_V1_5_SHA_256
            /// </summary>
            public static readonly SigningAlgorithmEnum RSASSA_PKCS1_V1_5_SHA_256 = new SigningAlgorithmEnum("RSASSA_PKCS1_V1_5_SHA_256");

            /// <summary>
            /// Enum RSASSA_PKCS1_V1_5_SHA_384 for value: RSASSA_PKCS1_V1_5_SHA_384
            /// </summary>
            public static readonly SigningAlgorithmEnum RSASSA_PKCS1_V1_5_SHA_384 = new SigningAlgorithmEnum("RSASSA_PKCS1_V1_5_SHA_384");

            /// <summary>
            /// Enum RSASSA_PKCS1_V1_5_SHA_512 for value: RSASSA_PKCS1_V1_5_SHA_512
            /// </summary>
            public static readonly SigningAlgorithmEnum RSASSA_PKCS1_V1_5_SHA_512 = new SigningAlgorithmEnum("RSASSA_PKCS1_V1_5_SHA_512");

            /// <summary>
            /// Enum ECDSA_SHA_256 for value: ECDSA_SHA_256
            /// </summary>
            public static readonly SigningAlgorithmEnum ECDSA_SHA_256 = new SigningAlgorithmEnum("ECDSA_SHA_256");

            /// <summary>
            /// Enum ECDSA_SHA_384 for value: ECDSA_SHA_384
            /// </summary>
            public static readonly SigningAlgorithmEnum ECDSA_SHA_384 = new SigningAlgorithmEnum("ECDSA_SHA_384");

            /// <summary>
            /// Enum ECDSA_SHA_512 for value: ECDSA_SHA_512
            /// </summary>
            public static readonly SigningAlgorithmEnum ECDSA_SHA_512 = new SigningAlgorithmEnum("ECDSA_SHA_512");

            /// <summary>
            /// Enum SM2DSA_SM3 for value: SM2DSA_SM3
            /// </summary>
            public static readonly SigningAlgorithmEnum SM2DSA_SM3 = new SigningAlgorithmEnum("SM2DSA_SM3");

            private static readonly Dictionary<string, SigningAlgorithmEnum> StaticFields =
            new Dictionary<string, SigningAlgorithmEnum>()
            {
                { "RSASSA_PSS_SHA_256", RSASSA_PSS_SHA_256 },
                { "RSASSA_PSS_SHA_384", RSASSA_PSS_SHA_384 },
                { "RSASSA_PSS_SHA_512", RSASSA_PSS_SHA_512 },
                { "RSASSA_PKCS1_V1_5_SHA_256", RSASSA_PKCS1_V1_5_SHA_256 },
                { "RSASSA_PKCS1_V1_5_SHA_384", RSASSA_PKCS1_V1_5_SHA_384 },
                { "RSASSA_PKCS1_V1_5_SHA_512", RSASSA_PKCS1_V1_5_SHA_512 },
                { "ECDSA_SHA_256", ECDSA_SHA_256 },
                { "ECDSA_SHA_384", ECDSA_SHA_384 },
                { "ECDSA_SHA_512", ECDSA_SHA_512 },
                { "SM2DSA_SM3", SM2DSA_SM3 },
            };

            private string _value;

            public SigningAlgorithmEnum()
            {

            }

            public SigningAlgorithmEnum(string value)
            {
                _value = value;
            }

            public static SigningAlgorithmEnum FromValue(string value)
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

                if (this.Equals(obj as SigningAlgorithmEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SigningAlgorithmEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SigningAlgorithmEnum a, SigningAlgorithmEnum b)
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

            public static bool operator !=(SigningAlgorithmEnum a, SigningAlgorithmEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 消息类型，默认为“DIGEST”，枚举如下：  - DIGEST 表示消息摘要  - RAW 表示消息原文
        /// </summary>
        /// <value>消息类型，默认为“DIGEST”，枚举如下：  - DIGEST 表示消息摘要  - RAW 表示消息原文</value>
        [JsonConverter(typeof(EnumClassConverter<MessageTypeEnum>))]
        public class MessageTypeEnum
        {
            /// <summary>
            /// Enum DIGEST for value: DIGEST
            /// </summary>
            public static readonly MessageTypeEnum DIGEST = new MessageTypeEnum("DIGEST");

            /// <summary>
            /// Enum RAW for value: RAW
            /// </summary>
            public static readonly MessageTypeEnum RAW = new MessageTypeEnum("RAW");

            private static readonly Dictionary<string, MessageTypeEnum> StaticFields =
            new Dictionary<string, MessageTypeEnum>()
            {
                { "DIGEST", DIGEST },
                { "RAW", RAW },
            };

            private string _value;

            public MessageTypeEnum()
            {

            }

            public MessageTypeEnum(string value)
            {
                _value = value;
            }

            public static MessageTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MessageTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MessageTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MessageTypeEnum a, MessageTypeEnum b)
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

            public static bool operator !=(MessageTypeEnum a, MessageTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 密钥ID，36字节，满足正则匹配“^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$”。 例如：0d0466b0-e727-4d9c-b35d-f84bb474a37f。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 待签名的消息摘要或者消息，消息长度要求小于4096字节，使用Base64编码。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 待验证的签名值，使用Base64编码。
        /// </summary>
        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string Signature { get; set; }

        /// <summary>
        /// 签名算法，枚举如下：  - RSASSA_PSS_SHA_256  - RSASSA_PSS_SHA_384  - RSASSA_PSS_SHA_512  - RSASSA_PKCS1_V1_5_SHA_256  - RSASSA_PKCS1_V1_5_SHA_384  - RSASSA_PKCS1_V1_5_SHA_512  - ECDSA_SHA_256  - ECDSA_SHA_384  - ECDSA_SHA_512  - SM2DSA_SM3
        /// </summary>
        [JsonProperty("signing_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public SigningAlgorithmEnum SigningAlgorithm { get; set; }
        /// <summary>
        /// 消息类型，默认为“DIGEST”，枚举如下：  - DIGEST 表示消息摘要  - RAW 表示消息原文
        /// </summary>
        [JsonProperty("message_type", NullValueHandling = NullValueHandling.Ignore)]
        public MessageTypeEnum MessageType { get; set; }
        /// <summary>
        /// 请求消息序列号，36字节序列号。 例如：919c82d4-8046-4722-9094-35c3c6524cff。
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  signature: ").Append(Signature).Append("\n");
            sb.Append("  signingAlgorithm: ").Append(SigningAlgorithm).Append("\n");
            sb.Append("  messageType: ").Append(MessageType).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.SigningAlgorithm == input.SigningAlgorithm ||
                    (this.SigningAlgorithm != null &&
                    this.SigningAlgorithm.Equals(input.SigningAlgorithm))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
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
                if (this.KeyId != null)
                    hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                if (this.SigningAlgorithm != null)
                    hashCode = hashCode * 59 + this.SigningAlgorithm.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
