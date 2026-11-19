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
    /// 转移密钥请求体
    /// </summary>
    public class TransferKeyRequestBody 
    {
        /// <summary>
        /// **参数解释：** 转移模式 **约束限制：** ASSIGN模式仅支持对称密钥，且密钥必须未属于任何密钥空间，目标密钥空间类型需与密钥所属keystore类型匹配； **取值范围：** - ASSIGN：将密钥分配给目标密钥空间 **默认取值：** ASSIGN
        /// </summary>
        /// <value>**参数解释：** 转移模式 **约束限制：** ASSIGN模式仅支持对称密钥，且密钥必须未属于任何密钥空间，目标密钥空间类型需与密钥所属keystore类型匹配； **取值范围：** - ASSIGN：将密钥分配给目标密钥空间 **默认取值：** ASSIGN</value>
        [JsonConverter(typeof(EnumClassConverter<TransferModeEnum>))]
        public class TransferModeEnum
        {
            /// <summary>
            /// Enum ASSIGN for value: ASSIGN
            /// </summary>
            public static readonly TransferModeEnum ASSIGN = new TransferModeEnum("ASSIGN");

            private static readonly Dictionary<string, TransferModeEnum> StaticFields =
            new Dictionary<string, TransferModeEnum>()
            {
                { "ASSIGN", ASSIGN },
            };

            private string _value;

            public TransferModeEnum()
            {

            }

            public TransferModeEnum(string value)
            {
                _value = value;
            }

            public static TransferModeEnum FromValue(string value)
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

                if (this.Equals(obj as TransferModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TransferModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TransferModeEnum a, TransferModeEnum b)
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

            public static bool operator !=(TransferModeEnum a, TransferModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 待转移的密钥ID **约束限制：** 满足正则表达式^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$ **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// **参数解释：** 目标密钥空间ID **约束限制：** 满足正则表达式^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$ **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("target_keyspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetKeyspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 转移模式 **约束限制：** ASSIGN模式仅支持对称密钥，且密钥必须未属于任何密钥空间，目标密钥空间类型需与密钥所属keystore类型匹配； **取值范围：** - ASSIGN：将密钥分配给目标密钥空间 **默认取值：** ASSIGN
        /// </summary>
        [JsonProperty("transfer_mode", NullValueHandling = NullValueHandling.Ignore)]
        public TransferModeEnum TransferMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferKeyRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  targetKeyspaceId: ").Append(TargetKeyspaceId).Append("\n");
            sb.Append("  transferMode: ").Append(TransferMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferKeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferKeyRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.TargetKeyspaceId != input.TargetKeyspaceId || (this.TargetKeyspaceId != null && !this.TargetKeyspaceId.Equals(input.TargetKeyspaceId))) return false;
            if (this.TransferMode != input.TransferMode) return false;

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
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.TargetKeyspaceId != null) hashCode = hashCode * 59 + this.TargetKeyspaceId.GetHashCode();
                hashCode = hashCode * 59 + this.TransferMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
