using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EncryptionConfig 
    {
        /// <summary>
        /// **参数解释**： 加密模式，取值为Default或KMS。默认为Default，即使用cce本地密钥加密。若使用KMS加密模式则使用用户自定义密钥或默认密钥加密secret资源。 若用户在创建时未填写，则集群查询接口中默认会返回Default。 **约束限制**： 不涉及 **取值范围**： 取值范围：[Default, KMS]; **默认取值**： Default
        /// </summary>
        /// <value>**参数解释**： 加密模式，取值为Default或KMS。默认为Default，即使用cce本地密钥加密。若使用KMS加密模式则使用用户自定义密钥或默认密钥加密secret资源。 若用户在创建时未填写，则集群查询接口中默认会返回Default。 **约束限制**： 不涉及 **取值范围**： 取值范围：[Default, KMS]; **默认取值**： Default</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: Default
            /// </summary>
            public static readonly ModeEnum DEFAULT = new ModeEnum("Default");

            /// <summary>
            /// Enum KMS for value: KMS
            /// </summary>
            public static readonly ModeEnum KMS = new ModeEnum("KMS");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "Default", DEFAULT },
                { "KMS", KMS },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 加密模式，取值为Default或KMS。默认为Default，即使用cce本地密钥加密。若使用KMS加密模式则使用用户自定义密钥或默认密钥加密secret资源。 若用户在创建时未填写，则集群查询接口中默认会返回Default。 **约束限制**： 不涉及 **取值范围**： 取值范围：[Default, KMS]; **默认取值**： Default
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// **参数解释**： kms密钥ID - 集群创建API中，如果mode字段设置为Default，无需填写该字段；如果mode字段设置为KMS，则支持填写该字段。若字段为空，则默认使用KMS默认密钥进行填充，默认密钥不存在时云服务将自动为用户创建cce/default默认密钥。 用户需使用真实存在的KMS密钥，并且在集群生命周期结束前，禁止删除、禁用密钥等操作，防止集群功能异常（集群设置该密钥后不允许修改）。  - 集群查询API中，如果mode字段设置为Default，则该字段返回为空；若mode字段设置为KMS，则该字段为具体的密钥ID。 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("kmsKeyID", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKeyID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptionConfig {\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  kmsKeyID: ").Append(KmsKeyID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncryptionConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncryptionConfig input)
        {
            if (input == null) return false;
            if (this.Mode != input.Mode) return false;
            if (this.KmsKeyID != input.KmsKeyID || (this.KmsKeyID != null && !this.KmsKeyID.Equals(input.KmsKeyID))) return false;

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
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.KmsKeyID != null) hashCode = hashCode * 59 + this.KmsKeyID.GetHashCode();
                return hashCode;
            }
        }
    }
}
