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
    public class CreateKeyRequestBody 
    {
        /// <summary>
        /// 密钥生成算法，默认为“AES_256”，枚举如下： - AES_256 - SM4 - RSA_2048 - RSA_3072 - RSA_4096 - EC_P256 - EC_P384 - SM2
        /// </summary>
        /// <value>密钥生成算法，默认为“AES_256”，枚举如下： - AES_256 - SM4 - RSA_2048 - RSA_3072 - RSA_4096 - EC_P256 - EC_P384 - SM2</value>
        [JsonConverter(typeof(EnumClassConverter<KeySpecEnum>))]
        public class KeySpecEnum
        {
            /// <summary>
            /// Enum AES_256 for value: AES_256
            /// </summary>
            public static readonly KeySpecEnum AES_256 = new KeySpecEnum("AES_256");

            /// <summary>
            /// Enum SM4 for value: SM4
            /// </summary>
            public static readonly KeySpecEnum SM4 = new KeySpecEnum("SM4");

            /// <summary>
            /// Enum RSA_2048 for value: RSA_2048
            /// </summary>
            public static readonly KeySpecEnum RSA_2048 = new KeySpecEnum("RSA_2048");

            /// <summary>
            /// Enum RSA_3072 for value: RSA_3072
            /// </summary>
            public static readonly KeySpecEnum RSA_3072 = new KeySpecEnum("RSA_3072");

            /// <summary>
            /// Enum RSA_4096 for value: RSA_4096
            /// </summary>
            public static readonly KeySpecEnum RSA_4096 = new KeySpecEnum("RSA_4096");

            /// <summary>
            /// Enum EC_P256 for value: EC_P256
            /// </summary>
            public static readonly KeySpecEnum EC_P256 = new KeySpecEnum("EC_P256");

            /// <summary>
            /// Enum EC_P384 for value: EC_P384
            /// </summary>
            public static readonly KeySpecEnum EC_P384 = new KeySpecEnum("EC_P384");

            /// <summary>
            /// Enum SM2 for value: SM2
            /// </summary>
            public static readonly KeySpecEnum SM2 = new KeySpecEnum("SM2");

            private static readonly Dictionary<string, KeySpecEnum> StaticFields =
            new Dictionary<string, KeySpecEnum>()
            {
                { "AES_256", AES_256 },
                { "SM4", SM4 },
                { "RSA_2048", RSA_2048 },
                { "RSA_3072", RSA_3072 },
                { "RSA_4096", RSA_4096 },
                { "EC_P256", EC_P256 },
                { "EC_P384", EC_P384 },
                { "SM2", SM2 },
            };

            private string _value;

            public KeySpecEnum()
            {

            }

            public KeySpecEnum(string value)
            {
                _value = value;
            }

            public static KeySpecEnum FromValue(string value)
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

                if (this.Equals(obj as KeySpecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeySpecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeySpecEnum a, KeySpecEnum b)
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

            public static bool operator !=(KeySpecEnum a, KeySpecEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 密钥用途，对称密钥默认为“ENCRYPT_DECRYPT”，非对称密钥默认为“SIGN_VERIFY”，枚举如下： - ENCRYPT_DECRYPT - SIGN_VERIFY
        /// </summary>
        /// <value>密钥用途，对称密钥默认为“ENCRYPT_DECRYPT”，非对称密钥默认为“SIGN_VERIFY”，枚举如下： - ENCRYPT_DECRYPT - SIGN_VERIFY</value>
        [JsonConverter(typeof(EnumClassConverter<KeyUsageEnum>))]
        public class KeyUsageEnum
        {
            /// <summary>
            /// Enum ENCRYPT_DECRYPT for value: ENCRYPT_DECRYPT
            /// </summary>
            public static readonly KeyUsageEnum ENCRYPT_DECRYPT = new KeyUsageEnum("ENCRYPT_DECRYPT");

            /// <summary>
            /// Enum SIGN_VERIFY for value: SIGN_VERIFY
            /// </summary>
            public static readonly KeyUsageEnum SIGN_VERIFY = new KeyUsageEnum("SIGN_VERIFY");

            private static readonly Dictionary<string, KeyUsageEnum> StaticFields =
            new Dictionary<string, KeyUsageEnum>()
            {
                { "ENCRYPT_DECRYPT", ENCRYPT_DECRYPT },
                { "SIGN_VERIFY", SIGN_VERIFY },
            };

            private string _value;

            public KeyUsageEnum()
            {

            }

            public KeyUsageEnum(string value)
            {
                _value = value;
            }

            public static KeyUsageEnum FromValue(string value)
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

                if (this.Equals(obj as KeyUsageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeyUsageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeyUsageEnum a, KeyUsageEnum b)
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

            public static bool operator !=(KeyUsageEnum a, KeyUsageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 密钥来源，默认为“kms”，枚举如下： - kms：表示密钥材料由kms生成。 - external：表示密钥材料由外部导入。
        /// </summary>
        /// <value>密钥来源，默认为“kms”，枚举如下： - kms：表示密钥材料由kms生成。 - external：表示密钥材料由外部导入。</value>
        [JsonConverter(typeof(EnumClassConverter<OriginEnum>))]
        public class OriginEnum
        {
            /// <summary>
            /// Enum KMS for value: kms
            /// </summary>
            public static readonly OriginEnum KMS = new OriginEnum("kms");

            /// <summary>
            /// Enum EXTERNAL for value: external
            /// </summary>
            public static readonly OriginEnum EXTERNAL = new OriginEnum("external");

            private static readonly Dictionary<string, OriginEnum> StaticFields =
            new Dictionary<string, OriginEnum>()
            {
                { "kms", KMS },
                { "external", EXTERNAL },
            };

            private string _value;

            public OriginEnum()
            {

            }

            public OriginEnum(string value)
            {
                _value = value;
            }

            public static OriginEnum FromValue(string value)
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

                if (this.Equals(obj as OriginEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OriginEnum a, OriginEnum b)
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

            public static bool operator !=(OriginEnum a, OriginEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 非默认主密钥别名，取值范围为1到255个字符，满足正则匹配“^[a-zA-Z0-9:/_-]{1,255}$”，且不与系统服务创建的默认主密钥别名重名。
        /// </summary>
        [JsonProperty("key_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlias { get; set; }

        /// <summary>
        /// 密钥生成算法，默认为“AES_256”，枚举如下： - AES_256 - SM4 - RSA_2048 - RSA_3072 - RSA_4096 - EC_P256 - EC_P384 - SM2
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }
        /// <summary>
        /// 密钥用途，对称密钥默认为“ENCRYPT_DECRYPT”，非对称密钥默认为“SIGN_VERIFY”，枚举如下： - ENCRYPT_DECRYPT - SIGN_VERIFY
        /// </summary>
        [JsonProperty("key_usage", NullValueHandling = NullValueHandling.Ignore)]
        public KeyUsageEnum KeyUsage { get; set; }
        /// <summary>
        /// 密钥描述，取值0到255字符。
        /// </summary>
        [JsonProperty("key_description", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyDescription { get; set; }

        /// <summary>
        /// 密钥来源，默认为“kms”，枚举如下： - kms：表示密钥材料由kms生成。 - external：表示密钥材料由外部导入。
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// 企业多项目ID。 - 用户未开通企业多项目时，不需要输入该字段。 - 用户开通企业多项目时，创建资源可以输入该字段。若用户户不输入该字段，默认创建属于默认企业多项目ID（ID为“0”）的资源。 注意：若用户没有默认企业多项目ID（ID为“0”）下的创建权限，则接口报错。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 请求消息序列号，36字节序列号。 例如：919c82d4-8046-4722-9094-35c3c6524cff
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }

        /// <summary>
        /// 密钥库ID，默认使用KMS默认密钥库
        /// </summary>
        [JsonProperty("keystore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKeyRequestBody {\n");
            sb.Append("  keyAlias: ").Append(KeyAlias).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("  keyUsage: ").Append(KeyUsage).Append("\n");
            sb.Append("  keyDescription: ").Append(KeyDescription).Append("\n");
            sb.Append("  origin: ").Append(Origin).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  keystoreId: ").Append(KeystoreId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKeyRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyAlias == input.KeyAlias ||
                    (this.KeyAlias != null &&
                    this.KeyAlias.Equals(input.KeyAlias))
                ) && 
                (
                    this.KeySpec == input.KeySpec ||
                    (this.KeySpec != null &&
                    this.KeySpec.Equals(input.KeySpec))
                ) && 
                (
                    this.KeyUsage == input.KeyUsage ||
                    (this.KeyUsage != null &&
                    this.KeyUsage.Equals(input.KeyUsage))
                ) && 
                (
                    this.KeyDescription == input.KeyDescription ||
                    (this.KeyDescription != null &&
                    this.KeyDescription.Equals(input.KeyDescription))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.KeystoreId == input.KeystoreId ||
                    (this.KeystoreId != null &&
                    this.KeystoreId.Equals(input.KeystoreId))
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
                if (this.KeyAlias != null)
                    hashCode = hashCode * 59 + this.KeyAlias.GetHashCode();
                if (this.KeySpec != null)
                    hashCode = hashCode * 59 + this.KeySpec.GetHashCode();
                if (this.KeyUsage != null)
                    hashCode = hashCode * 59 + this.KeyUsage.GetHashCode();
                if (this.KeyDescription != null)
                    hashCode = hashCode * 59 + this.KeyDescription.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.KeystoreId != null)
                    hashCode = hashCode * 59 + this.KeystoreId.GetHashCode();
                return hashCode;
            }
        }
    }
}
