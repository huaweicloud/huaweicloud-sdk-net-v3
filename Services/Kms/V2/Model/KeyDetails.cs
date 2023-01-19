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
    /// 密钥详情。
    /// </summary>
    public class KeyDetails 
    {
        /// <summary>
        /// 密钥生成算法。  - AES_256  - SM4  - RSA_2048  - RSA_3072  - RSA_4096  - EC_P256  - EC_P384  - SM2
        /// </summary>
        /// <value>密钥生成算法。  - AES_256  - SM4  - RSA_2048  - RSA_3072  - RSA_4096  - EC_P256  - EC_P384  - SM2</value>
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
        /// 密钥用途。 - ENCRYPT_DECRYPT - SIGN_VERIFY
        /// </summary>
        /// <value>密钥用途。 - ENCRYPT_DECRYPT - SIGN_VERIFY</value>
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
        /// 密钥来源，默认为“kms”，枚举如下：  - kms表示密钥材料由kms生成kms表示密钥材料由kms生成  - external表示密钥材料由外部导入
        /// </summary>
        /// <value>密钥来源，默认为“kms”，枚举如下：  - kms表示密钥材料由kms生成kms表示密钥材料由kms生成  - external表示密钥材料由外部导入</value>
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
        /// 密钥ID。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 用户域ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 密钥别名。
        /// </summary>
        [JsonProperty("key_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlias { get; set; }

        /// <summary>
        /// 密钥区域。
        /// </summary>
        [JsonProperty("realm", NullValueHandling = NullValueHandling.Ignore)]
        public string Realm { get; set; }

        /// <summary>
        /// 密钥生成算法。  - AES_256  - SM4  - RSA_2048  - RSA_3072  - RSA_4096  - EC_P256  - EC_P384  - SM2
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public KeySpecEnum KeySpec { get; set; }
        /// <summary>
        /// 密钥用途。 - ENCRYPT_DECRYPT - SIGN_VERIFY
        /// </summary>
        [JsonProperty("key_usage", NullValueHandling = NullValueHandling.Ignore)]
        public KeyUsageEnum KeyUsage { get; set; }
        /// <summary>
        /// 密钥描述。
        /// </summary>
        [JsonProperty("key_description", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyDescription { get; set; }

        /// <summary>
        /// 密钥创建时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationDate { get; set; }

        /// <summary>
        /// 密钥计划删除时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("scheduled_deletion_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledDeletionDate { get; set; }

        /// <summary>
        /// 密钥状态，满足正则匹配“^[1-5]{1}$”，枚举如下：  - “1”表示待激活状态  - “2”表示启用状态  - “3”表示禁用状态  - “4”表示计划删除状态  - “5”表示等待导入状态
        /// </summary>
        [JsonProperty("key_state", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyState { get; set; }

        /// <summary>
        /// 默认主密钥标识，默认主密钥标识为1，非默认标识为0。
        /// </summary>
        [JsonProperty("default_key_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultKeyFlag { get; set; }

        /// <summary>
        /// 密钥类型。
        /// </summary>
        [JsonProperty("key_type", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyType { get; set; }

        /// <summary>
        /// 密钥材料失效时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// 密钥来源，默认为“kms”，枚举如下：  - kms表示密钥材料由kms生成kms表示密钥材料由kms生成  - external表示密钥材料由外部导入
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// 密钥轮换状态，默认为“false”，表示关闭密钥轮换功能。
        /// </summary>
        [JsonProperty("key_rotation_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyRotationEnabled { get; set; }

        /// <summary>
        /// 企业项目ID，默认为“0”。  - 对于开通企业项目的用户，表示资源处于默认企业项目下。  - 对于未开通企业项目的用户，表示资源未处于企业项目下。
        /// </summary>
        [JsonProperty("sys_enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SysEnterpriseProjectId { get; set; }

        /// <summary>
        /// 密钥库ID
        /// </summary>
        [JsonProperty("keystore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreId { get; set; }

        /// <summary>
        /// 密钥在加密机中的标签
        /// </summary>
        [JsonProperty("key_label", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyLabel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KeyDetails {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  keyAlias: ").Append(KeyAlias).Append("\n");
            sb.Append("  realm: ").Append(Realm).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("  keyUsage: ").Append(KeyUsage).Append("\n");
            sb.Append("  keyDescription: ").Append(KeyDescription).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  scheduledDeletionDate: ").Append(ScheduledDeletionDate).Append("\n");
            sb.Append("  keyState: ").Append(KeyState).Append("\n");
            sb.Append("  defaultKeyFlag: ").Append(DefaultKeyFlag).Append("\n");
            sb.Append("  keyType: ").Append(KeyType).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  origin: ").Append(Origin).Append("\n");
            sb.Append("  keyRotationEnabled: ").Append(KeyRotationEnabled).Append("\n");
            sb.Append("  sysEnterpriseProjectId: ").Append(SysEnterpriseProjectId).Append("\n");
            sb.Append("  keystoreId: ").Append(KeystoreId).Append("\n");
            sb.Append("  keyLabel: ").Append(KeyLabel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KeyDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KeyDetails input)
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
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.KeyAlias == input.KeyAlias ||
                    (this.KeyAlias != null &&
                    this.KeyAlias.Equals(input.KeyAlias))
                ) && 
                (
                    this.Realm == input.Realm ||
                    (this.Realm != null &&
                    this.Realm.Equals(input.Realm))
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
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.ScheduledDeletionDate == input.ScheduledDeletionDate ||
                    (this.ScheduledDeletionDate != null &&
                    this.ScheduledDeletionDate.Equals(input.ScheduledDeletionDate))
                ) && 
                (
                    this.KeyState == input.KeyState ||
                    (this.KeyState != null &&
                    this.KeyState.Equals(input.KeyState))
                ) && 
                (
                    this.DefaultKeyFlag == input.DefaultKeyFlag ||
                    (this.DefaultKeyFlag != null &&
                    this.DefaultKeyFlag.Equals(input.DefaultKeyFlag))
                ) && 
                (
                    this.KeyType == input.KeyType ||
                    (this.KeyType != null &&
                    this.KeyType.Equals(input.KeyType))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
                ) && 
                (
                    this.KeyRotationEnabled == input.KeyRotationEnabled ||
                    (this.KeyRotationEnabled != null &&
                    this.KeyRotationEnabled.Equals(input.KeyRotationEnabled))
                ) && 
                (
                    this.SysEnterpriseProjectId == input.SysEnterpriseProjectId ||
                    (this.SysEnterpriseProjectId != null &&
                    this.SysEnterpriseProjectId.Equals(input.SysEnterpriseProjectId))
                ) && 
                (
                    this.KeystoreId == input.KeystoreId ||
                    (this.KeystoreId != null &&
                    this.KeystoreId.Equals(input.KeystoreId))
                ) && 
                (
                    this.KeyLabel == input.KeyLabel ||
                    (this.KeyLabel != null &&
                    this.KeyLabel.Equals(input.KeyLabel))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.KeyAlias != null)
                    hashCode = hashCode * 59 + this.KeyAlias.GetHashCode();
                if (this.Realm != null)
                    hashCode = hashCode * 59 + this.Realm.GetHashCode();
                if (this.KeySpec != null)
                    hashCode = hashCode * 59 + this.KeySpec.GetHashCode();
                if (this.KeyUsage != null)
                    hashCode = hashCode * 59 + this.KeyUsage.GetHashCode();
                if (this.KeyDescription != null)
                    hashCode = hashCode * 59 + this.KeyDescription.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.ScheduledDeletionDate != null)
                    hashCode = hashCode * 59 + this.ScheduledDeletionDate.GetHashCode();
                if (this.KeyState != null)
                    hashCode = hashCode * 59 + this.KeyState.GetHashCode();
                if (this.DefaultKeyFlag != null)
                    hashCode = hashCode * 59 + this.DefaultKeyFlag.GetHashCode();
                if (this.KeyType != null)
                    hashCode = hashCode * 59 + this.KeyType.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.KeyRotationEnabled != null)
                    hashCode = hashCode * 59 + this.KeyRotationEnabled.GetHashCode();
                if (this.SysEnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.SysEnterpriseProjectId.GetHashCode();
                if (this.KeystoreId != null)
                    hashCode = hashCode * 59 + this.KeystoreId.GetHashCode();
                if (this.KeyLabel != null)
                    hashCode = hashCode * 59 + this.KeyLabel.GetHashCode();
                return hashCode;
            }
        }
    }
}
