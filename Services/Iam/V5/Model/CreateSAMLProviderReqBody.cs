using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateSAMLProviderReqBody 
    {
        /// <summary>
        /// **参数解释**： 指定 SAML 提供商的加密设置。  **约束限制**： 不涉及。  **取值范围**： 取值范围为[Required,Allowed]。  **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 指定 SAML 提供商的加密设置。  **约束限制**： 不涉及。  **取值范围**： 取值范围为[Required,Allowed]。  **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<AssertionEncryptionModeEnum>))]
        public class AssertionEncryptionModeEnum
        {
            /// <summary>
            /// Enum REQUIRED for value: Required
            /// </summary>
            public static readonly AssertionEncryptionModeEnum REQUIRED = new AssertionEncryptionModeEnum("Required");

            /// <summary>
            /// Enum ALLOWED for value: Allowed
            /// </summary>
            public static readonly AssertionEncryptionModeEnum ALLOWED = new AssertionEncryptionModeEnum("Allowed");

            private static readonly Dictionary<string, AssertionEncryptionModeEnum> StaticFields =
            new Dictionary<string, AssertionEncryptionModeEnum>()
            {
                { "Required", REQUIRED },
                { "Allowed", ALLOWED },
            };

            private string _value;

            public AssertionEncryptionModeEnum()
            {

            }

            public AssertionEncryptionModeEnum(string value)
            {
                _value = value;
            }

            public static AssertionEncryptionModeEnum FromValue(string value)
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

                if (this.Equals(obj as AssertionEncryptionModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssertionEncryptionModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssertionEncryptionModeEnum a, AssertionEncryptionModeEnum b)
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

            public static bool operator !=(AssertionEncryptionModeEnum a, AssertionEncryptionModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： SAML 提供商的名称。  **约束限制**： 字符串长度在 1 到 64 之间，并且只能包含：字母、数字、下划线（_）、中划线（-）。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 由支持 SAML 2.0 的身份提供商 (IdP) 生成的 XML 文档。该文档包含颁发者的名称、过期信息，以及可用于验证从 IdP 接收到的 SAML 身份验证响应（断言）的密钥。  **约束限制**： 长度范围为[1000,512000]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("saml_metadata_document", NullValueHandling = NullValueHandling.Ignore)]
        public string SamlMetadataDocument { get; set; }

        /// <summary>
        /// **参数解释**： 指定 SAML 提供商的加密设置。  **约束限制**： 不涉及。  **取值范围**： 取值范围为[Required,Allowed]。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("assertion_encryption_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AssertionEncryptionModeEnum AssertionEncryptionMode { get; set; }
        /// <summary>
        /// **参数解释**： 添加解密 SAML 断言的私钥，必须是一个 PEM 格式的 RSA 私钥。在接收到加密的 SAML 断言时，IAM 会基于 RSA-OAEP 算法使用该私钥解密得到用于加密 SAML 断言的对称密钥，然后再基于 AES-GCM 或 AES-CBC 加密算法使用对称密钥解密出 SAML 断言明文。  **约束限制**： 长度范围为[1,16384]。  **取值范围**： 字符串必须由 1 个或多个字符组成，这些字符可以是：空格、可见 ASCII 字符、Latin-1 扩展字符、Tab、换行、回车  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("add_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AddPrivateKey { get; set; }

        /// <summary>
        /// **参数解释**： 身份提供商描述。  **约束限制**： 长度范围为[0,255]。  **取值范围**： 不能包含特定字符\&quot;@\&quot;、\&quot;#\&quot;、\&quot;%\&quot;、\&quot;&amp;\&quot;、\&quot;&lt;\&quot;、\&quot;&gt;\&quot;、\&quot;\\\&quot;、\&quot;$\&quot;、\&quot;^\&quot;和\&quot;*\&quot;的字符串。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSAMLProviderReqBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  samlMetadataDocument: ").Append(SamlMetadataDocument).Append("\n");
            sb.Append("  assertionEncryptionMode: ").Append(AssertionEncryptionMode).Append("\n");
            sb.Append("  addPrivateKey: ").Append(AddPrivateKey).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSAMLProviderReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSAMLProviderReqBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SamlMetadataDocument != input.SamlMetadataDocument || (this.SamlMetadataDocument != null && !this.SamlMetadataDocument.Equals(input.SamlMetadataDocument))) return false;
            if (this.AssertionEncryptionMode != input.AssertionEncryptionMode) return false;
            if (this.AddPrivateKey != input.AddPrivateKey || (this.AddPrivateKey != null && !this.AddPrivateKey.Equals(input.AddPrivateKey))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SamlMetadataDocument != null) hashCode = hashCode * 59 + this.SamlMetadataDocument.GetHashCode();
                hashCode = hashCode * 59 + this.AssertionEncryptionMode.GetHashCode();
                if (this.AddPrivateKey != null) hashCode = hashCode * 59 + this.AddPrivateKey.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
