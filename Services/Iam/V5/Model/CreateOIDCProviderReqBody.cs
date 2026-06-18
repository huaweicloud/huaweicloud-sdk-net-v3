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
    public class CreateOIDCProviderReqBody 
    {

        /// <summary>
        /// **参数解释**： 身份提供商的 URL。该 URL 必须以 https:// 开头，并且应与提供商的 OpenID Connect ID 令牌中的 iss (issuer) 声明相对应。根据 OIDC 标准，URL 允许包含路径组件，但不允许包含查询参数。通常，该 URL 仅由一个主机名组成，不包含端口号，例如 https://www.oidc.com 或 https://oidc.com。  **约束限制**： 长度范围为[1,255]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释**： OIDC 提供商的名称。  **约束限制**： 字符串长度在 1 到 64 之间，并且只能包含：字母、数字、下划线（_）、中划线（-）。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 客户端 ID 列表，客户端 ID 也称为受众 (Audiences)。您可以使用同一个提供商注册多个客户端 ID。  **约束限制**： 列表元素数量取值范围为[1,100]个，每个元素字符串长度取值范围为[1,255]。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("client_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClientIds { get; set; }

        /// <summary>
        /// **参数解释**： OIDC 身份提供商的服务器证书指纹列表，列表中的指纹是 X.509 证书的十六进制编码的 SHA-1 哈希值，它始终是一个 64 个字符的字符串。通常，此列表只包含一个指纹，然而 IAM 允许您为一个 OIDC 提供商设置最多五个指纹，这使得您可以对身份提供商的证书进行安全轮转。此参数是可选的，如果未包含此参数，IAM 将检索并使用 OIDC 身份提供商服务器证书的顶层中间证书颁发机构 (CA) 指纹。有关获取 OIDC 提供商指纹的更多信息，请参阅 IAM 用户指南中的**获取 OIDC 提供商的指纹**。  **约束限制**： 列表元素数量取值范围为[0,5]个，每个元素字符串长度为64。  **取值范围**： 不涉及。  **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("thumbprints", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Thumbprints { get; set; }

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
            sb.Append("class CreateOIDCProviderReqBody {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  clientIds: ").Append(ClientIds).Append("\n");
            sb.Append("  thumbprints: ").Append(Thumbprints).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOIDCProviderReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOIDCProviderReqBody input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ClientIds != input.ClientIds || (this.ClientIds != null && input.ClientIds != null && !this.ClientIds.SequenceEqual(input.ClientIds))) return false;
            if (this.Thumbprints != input.Thumbprints || (this.Thumbprints != null && input.Thumbprints != null && !this.Thumbprints.SequenceEqual(input.Thumbprints))) return false;
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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ClientIds != null) hashCode = hashCode * 59 + this.ClientIds.GetHashCode();
                if (this.Thumbprints != null) hashCode = hashCode * 59 + this.Thumbprints.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
