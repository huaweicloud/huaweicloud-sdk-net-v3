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
    /// **参数解释**： OIDC 提供商。  **取值范围**： 不涉及。
    /// </summary>
    public class InlineResponse2011OidcProvider 
    {

        /// <summary>
        /// **参数解释**： OIDC 身份提供商的 ID。  **取值范围**： 字符串长度在 1 到 64 之间，并且只能包含：字母、数字、中划线（-）。
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// **参数解释**： OIDC 身份提供商的名称。  **取值范围**： 字符串长度在 1 到 64 之间，并且只能包含：字母、数字、下划线（_）、中划线（-）。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 身份提供商描述。  **取值范围**： 字符串长度不超过 255，并且不能包含特定字符\&quot;@\&quot;、\&quot;#\&quot;、\&quot;%\&quot;、\&quot;&amp;\&quot;、\&quot;&lt;\&quot;、\&quot;&gt;\&quot;、\&quot;\\\&quot;、\&quot;$\&quot;、\&quot;^\&quot;和\&quot;*\&quot;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： OIDC 身份提供商的 URL。  **取值范围**： 字符串长度在 1 到 255 之间。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释**： 统一资源名称。  **取值范围**： 字符串长度在 16 到 1500 之间，并且只能包含：字母、数字、字符\&quot;/\&quot;、\&quot;&#x3D;\&quot;、\&quot;_\&quot;、\&quot;:\&quot;、\&quot;-\&quot;。
        /// </summary>
        [JsonProperty("urn", NullValueHandling = NullValueHandling.Ignore)]
        public string Urn { get; set; }

        /// <summary>
        /// **参数解释**： 客户端 ID 列表。  **取值范围**： 数组长度在 1 到 100 之间；数组元素为字符串，长度在 1 到 255 之间。
        /// </summary>
        [JsonProperty("client_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClientIds { get; set; }

        /// <summary>
        /// **参数解释**： OIDC 身份提供商的服务器证书指纹列表。  **取值范围**： 数组长度在 1 到 5 之间；数组元素为长度为 64 的字符串，并且只能包含字母、数字。
        /// </summary>
        [JsonProperty("thumbprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Thumbprints { get; set; }

        /// <summary>
        /// **参数解释**： 提供商创建时间。  **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2011OidcProvider {\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  urn: ").Append(Urn).Append("\n");
            sb.Append("  clientIds: ").Append(ClientIds).Append("\n");
            sb.Append("  thumbprints: ").Append(Thumbprints).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse2011OidcProvider);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InlineResponse2011OidcProvider input)
        {
            if (input == null) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Urn != input.Urn || (this.Urn != null && !this.Urn.Equals(input.Urn))) return false;
            if (this.ClientIds != input.ClientIds || (this.ClientIds != null && input.ClientIds != null && !this.ClientIds.SequenceEqual(input.ClientIds))) return false;
            if (this.Thumbprints != input.Thumbprints || (this.Thumbprints != null && input.Thumbprints != null && !this.Thumbprints.SequenceEqual(input.Thumbprints))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Urn != null) hashCode = hashCode * 59 + this.Urn.GetHashCode();
                if (this.ClientIds != null) hashCode = hashCode * 59 + this.ClientIds.GetHashCode();
                if (this.Thumbprints != null) hashCode = hashCode * 59 + this.Thumbprints.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
