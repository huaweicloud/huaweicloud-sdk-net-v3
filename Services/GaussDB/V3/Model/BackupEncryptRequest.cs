using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// taurus支持备份加密的请求体。
    /// </summary>
    public class BackupEncryptRequest 
    {
        /// <summary>
        /// 加密类型。当前只支持kms。 开启加密时必传，关闭加密时不传。 不区分大小写。
        /// </summary>
        /// <value>加密类型。当前只支持kms。 开启加密时必传，关闭加密时不传。 不区分大小写。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum KMS for value: kms
            /// </summary>
            public static readonly TypeEnum KMS = new TypeEnum("kms");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "kms", KMS },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 开启或关闭加密。不区分大小写。
        /// </summary>
        /// <value>开启或关闭加密。不区分大小写。</value>
        [JsonConverter(typeof(EnumClassConverter<EncryptionStatusEnum>))]
        public class EncryptionStatusEnum
        {
            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly EncryptionStatusEnum ON = new EncryptionStatusEnum("on");

            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly EncryptionStatusEnum OFF = new EncryptionStatusEnum("off");

            private static readonly Dictionary<string, EncryptionStatusEnum> StaticFields =
            new Dictionary<string, EncryptionStatusEnum>()
            {
                { "on", ON },
                { "off", OFF },
            };

            private string _value;

            public EncryptionStatusEnum()
            {

            }

            public EncryptionStatusEnum(string value)
            {
                _value = value;
            }

            public static EncryptionStatusEnum FromValue(string value)
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

                if (this.Equals(obj as EncryptionStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EncryptionStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EncryptionStatusEnum a, EncryptionStatusEnum b)
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

            public static bool operator !=(EncryptionStatusEnum a, EncryptionStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 加密类型。当前只支持kms。 开启加密时必传，关闭加密时不传。 不区分大小写。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// kms加密ID。加密时必传，关闭加密时候不传。
        /// </summary>
        [JsonProperty("kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// 开启或关闭加密。不区分大小写。
        /// </summary>
        [JsonProperty("encryption_status", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptionStatusEnum EncryptionStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupEncryptRequest {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  kmsKeyId: ").Append(KmsKeyId).Append("\n");
            sb.Append("  encryptionStatus: ").Append(EncryptionStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupEncryptRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupEncryptRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.KmsKeyId == input.KmsKeyId ||
                    (this.KmsKeyId != null &&
                    this.KmsKeyId.Equals(input.KmsKeyId))
                ) && 
                (
                    this.EncryptionStatus == input.EncryptionStatus ||
                    (this.EncryptionStatus != null &&
                    this.EncryptionStatus.Equals(input.EncryptionStatus))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.KmsKeyId != null)
                    hashCode = hashCode * 59 + this.KmsKeyId.GetHashCode();
                if (this.EncryptionStatus != null)
                    hashCode = hashCode * 59 + this.EncryptionStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
