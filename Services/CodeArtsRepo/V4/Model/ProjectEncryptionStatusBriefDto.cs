using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectEncryptionStatusBriefDto 
    {
        /// <summary>
        /// **参数解释：** 仓库加密状态 **取值范围：** - encrypting，加密中。 - encrypted，已加密。 - decrypting，解密中。 - decrypted，已解密。 **默认取值：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 仓库加密状态 **取值范围：** - encrypting，加密中。 - encrypted，已加密。 - decrypting，解密中。 - decrypted，已解密。 **默认取值：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ENCRYPTING for value: encrypting
            /// </summary>
            public static readonly StatusEnum ENCRYPTING = new StatusEnum("encrypting");

            /// <summary>
            /// Enum ENCRYPTED for value: encrypted
            /// </summary>
            public static readonly StatusEnum ENCRYPTED = new StatusEnum("encrypted");

            /// <summary>
            /// Enum DECRYPTING for value: decrypting
            /// </summary>
            public static readonly StatusEnum DECRYPTING = new StatusEnum("decrypting");

            /// <summary>
            /// Enum DECRYPTED for value: decrypted
            /// </summary>
            public static readonly StatusEnum DECRYPTED = new StatusEnum("decrypted");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "encrypting", ENCRYPTING },
                { "encrypted", ENCRYPTED },
                { "decrypting", DECRYPTING },
                { "decrypted", DECRYPTED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 仓库加密状态ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 仓库加密状态 **取值范围：** - encrypting，加密中。 - encrypted，已加密。 - decrypting，解密中。 - decrypted，已解密。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释：** 最近加密时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_encryption_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastEncryptionAt { get; set; }

        /// <summary>
        /// **参数解释：** 最近解密时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("last_decryption_at", NullValueHandling = NullValueHandling.Ignore)]
        public string LastDecryptionAt { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启仓库加密。 **约束限制：** 不涉及。 **取值范围：** - true，开启仓库加密。 - false，关闭仓库加密。
        /// </summary>
        [JsonProperty("is_consistent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsConsistent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectEncryptionStatusBriefDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  lastEncryptionAt: ").Append(LastEncryptionAt).Append("\n");
            sb.Append("  lastDecryptionAt: ").Append(LastDecryptionAt).Append("\n");
            sb.Append("  isConsistent: ").Append(IsConsistent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectEncryptionStatusBriefDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectEncryptionStatusBriefDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status) return false;
            if (this.LastEncryptionAt != input.LastEncryptionAt || (this.LastEncryptionAt != null && !this.LastEncryptionAt.Equals(input.LastEncryptionAt))) return false;
            if (this.LastDecryptionAt != input.LastDecryptionAt || (this.LastDecryptionAt != null && !this.LastDecryptionAt.Equals(input.LastDecryptionAt))) return false;
            if (this.IsConsistent != input.IsConsistent || (this.IsConsistent != null && !this.IsConsistent.Equals(input.IsConsistent))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastEncryptionAt != null) hashCode = hashCode * 59 + this.LastEncryptionAt.GetHashCode();
                if (this.LastDecryptionAt != null) hashCode = hashCode * 59 + this.LastDecryptionAt.GetHashCode();
                if (this.IsConsistent != null) hashCode = hashCode * 59 + this.IsConsistent.GetHashCode();
                return hashCode;
            }
        }
    }
}
