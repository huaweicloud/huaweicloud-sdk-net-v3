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
    /// **参数解释**： SAML 提供商。  **取值范围**： 不涉及。
    /// </summary>
    public class InlineResponse2001SamlProvider 
    {
        /// <summary>
        /// **参数解释**： 指定 SAML 身份提供商的加密设置。  **取值范围**： 取值范围为[Required,Allowed]。
        /// </summary>
        /// <value>**参数解释**： 指定 SAML 身份提供商的加密设置。  **取值范围**： 取值范围为[Required,Allowed]。</value>
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
        /// **参数解释**： SAML 身份提供商的ID。  **取值范围**： 字符串长度在 1 到 64 之间，并且只能包含：字母、数字、中划线（-）。
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// **参数解释**： SAML 身份提供商的名称。  **取值范围**： 字符串长度在 1 到 64 之间，并且只能包含：字母、数字、下划线（_）、中划线（-）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 身份提供商描述。  **取值范围**： 字符串长度在 0 到 255 之间，不能包含特定字符\&quot;@\&quot;、\&quot;#\&quot;、\&quot;%\&quot;、\&quot;&amp;\&quot;、\&quot;&lt;\&quot;、\&quot;&gt;\&quot;、\&quot;\\\&quot;、\&quot;$\&quot;、\&quot;^\&quot;和\&quot;*\&quot;的字符串。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 统一资源名称。  **取值范围**： 字符串长度在 16 到 1500 之间，可以包含：字母、数字、斜杠（/）、等号（&#x3D;）、下划线（_）、冒号（:）、中划线（-）
        /// </summary>
        [JsonProperty("urn", NullValueHandling = NullValueHandling.Ignore)]
        public string Urn { get; set; }

        /// <summary>
        /// **参数解释**： 支持 SAML 2.0 的身份提供商 (IdP) 的 XML 文档。  **取值范围**： 长度范围为[1000,512000]。
        /// </summary>
        [JsonProperty("saml_metadata_document", NullValueHandling = NullValueHandling.Ignore)]
        public string SamlMetadataDocument { get; set; }

        /// <summary>
        /// **参数解释**： 指定 SAML 身份提供商的加密设置。  **取值范围**： 取值范围为[Required,Allowed]。
        /// </summary>
        [JsonProperty("assertion_encryption_mode", NullValueHandling = NullValueHandling.Ignore)]
        public AssertionEncryptionModeEnum AssertionEncryptionMode { get; set; }
        /// <summary>
        /// **参数解释**： 解密 SAML 断言的私钥。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("private_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<InlineResponse200PrivateKeys> PrivateKeys { get; set; }

        /// <summary>
        /// **参数解释**： 自定义标签列表。  **取值范围**： 数组长度不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<InlineResponse2001SamlProviderTags> Tags { get; set; }

        /// <summary>
        /// **参数解释**： SAML 身份提供商创建时间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**： SAML 身份提供商过期时间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExpiresAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001SamlProvider {\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  urn: ").Append(Urn).Append("\n");
            sb.Append("  samlMetadataDocument: ").Append(SamlMetadataDocument).Append("\n");
            sb.Append("  assertionEncryptionMode: ").Append(AssertionEncryptionMode).Append("\n");
            sb.Append("  privateKeys: ").Append(PrivateKeys).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  expiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse2001SamlProvider);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InlineResponse2001SamlProvider input)
        {
            if (input == null) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Urn != input.Urn || (this.Urn != null && !this.Urn.Equals(input.Urn))) return false;
            if (this.SamlMetadataDocument != input.SamlMetadataDocument || (this.SamlMetadataDocument != null && !this.SamlMetadataDocument.Equals(input.SamlMetadataDocument))) return false;
            if (this.AssertionEncryptionMode != input.AssertionEncryptionMode) return false;
            if (this.PrivateKeys != input.PrivateKeys || (this.PrivateKeys != null && input.PrivateKeys != null && !this.PrivateKeys.SequenceEqual(input.PrivateKeys))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.ExpiresAt != input.ExpiresAt || (this.ExpiresAt != null && !this.ExpiresAt.Equals(input.ExpiresAt))) return false;

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
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Urn != null) hashCode = hashCode * 59 + this.Urn.GetHashCode();
                if (this.SamlMetadataDocument != null) hashCode = hashCode * 59 + this.SamlMetadataDocument.GetHashCode();
                hashCode = hashCode * 59 + this.AssertionEncryptionMode.GetHashCode();
                if (this.PrivateKeys != null) hashCode = hashCode * 59 + this.PrivateKeys.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ExpiresAt != null) hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
