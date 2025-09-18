using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SwitchKmsTdeRequestBody 
    {
        /// <summary>
        /// **参数解释**: 需要切换的状态：on表示开启。 **约束限制**: 不涉及。 **取值范围**: on: 开启。 **默认取值**: on
        /// </summary>
        /// <value>**参数解释**: 需要切换的状态：on表示开启。 **约束限制**: 不涉及。 **取值范围**: on: 开启。 **默认取值**: on</value>
        [JsonConverter(typeof(EnumClassConverter<KmsTdeStatusEnum>))]
        public class KmsTdeStatusEnum
        {
            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly KmsTdeStatusEnum ON = new KmsTdeStatusEnum("on");

            private static readonly Dictionary<string, KmsTdeStatusEnum> StaticFields =
            new Dictionary<string, KmsTdeStatusEnum>()
            {
                { "on", ON },
            };

            private string _value;

            public KmsTdeStatusEnum()
            {

            }

            public KmsTdeStatusEnum(string value)
            {
                _value = value;
            }

            public static KmsTdeStatusEnum FromValue(string value)
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

                if (this.Equals(obj as KmsTdeStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KmsTdeStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KmsTdeStatusEnum a, KmsTdeStatusEnum b)
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

            public static bool operator !=(KmsTdeStatusEnum a, KmsTdeStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: kms主密钥ID。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("kms_tde_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsTdeKeyId { get; set; }

        /// <summary>
        /// **参数解释**: GaussDB使用透明加密的KMS主密钥ID所在资源空间名称。 获取方法请参见[获取项目名称](https://support.huaweicloud.com/api-gaussdb/gaussdb_api_196.html)。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("kms_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsProjectName { get; set; }

        /// <summary>
        /// **参数解释**: 需要切换的状态：on表示开启。 **约束限制**: 不涉及。 **取值范围**: on: 开启。 **默认取值**: on
        /// </summary>
        [JsonProperty("kms_tde_status", NullValueHandling = NullValueHandling.Ignore)]
        public KmsTdeStatusEnum KmsTdeStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchKmsTdeRequestBody {\n");
            sb.Append("  kmsTdeKeyId: ").Append(KmsTdeKeyId).Append("\n");
            sb.Append("  kmsProjectName: ").Append(KmsProjectName).Append("\n");
            sb.Append("  kmsTdeStatus: ").Append(KmsTdeStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchKmsTdeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchKmsTdeRequestBody input)
        {
            if (input == null) return false;
            if (this.KmsTdeKeyId != input.KmsTdeKeyId || (this.KmsTdeKeyId != null && !this.KmsTdeKeyId.Equals(input.KmsTdeKeyId))) return false;
            if (this.KmsProjectName != input.KmsProjectName || (this.KmsProjectName != null && !this.KmsProjectName.Equals(input.KmsProjectName))) return false;
            if (this.KmsTdeStatus != input.KmsTdeStatus) return false;

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
                if (this.KmsTdeKeyId != null) hashCode = hashCode * 59 + this.KmsTdeKeyId.GetHashCode();
                if (this.KmsProjectName != null) hashCode = hashCode * 59 + this.KmsProjectName.GetHashCode();
                hashCode = hashCode * 59 + this.KmsTdeStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
