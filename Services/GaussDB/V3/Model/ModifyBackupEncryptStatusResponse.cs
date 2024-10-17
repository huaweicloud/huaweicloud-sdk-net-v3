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
    /// Response Object
    /// </summary>
    public class ModifyBackupEncryptStatusResponse : SdkResponse
    {
        /// <summary>
        /// 备份加密状态。
        /// </summary>
        /// <value>备份加密状态。</value>
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
        /// 备份加密状态。
        /// </summary>
        [JsonProperty("encryption_status", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptionStatusEnum EncryptionStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyBackupEncryptStatusResponse {\n");
            sb.Append("  encryptionStatus: ").Append(EncryptionStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyBackupEncryptStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyBackupEncryptStatusResponse input)
        {
            if (input == null) return false;
            if (this.EncryptionStatus != input.EncryptionStatus) return false;

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
                hashCode = hashCode * 59 + this.EncryptionStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
