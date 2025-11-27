using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 复制域名请求体 **约束限制：** 不涉及
    /// </summary>
    public class DuplicateDomainRequestBody 
    {

        /// <summary>
        /// **参数解释：** 存量加速域名，将该域名的配置复制给新添加的域名。  **约束限制：** 已经在CDN添加成功的域名。 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("reference_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ReferenceDomainName { get; set; }

        /// <summary>
        /// **参数解释：** 需要添加到CDN控制台加速的域名 &gt; 添加泛域名后，该泛域名所有次级域名均默认接入CDN加速。  **约束限制：** 加速域名不允许重复添加 **取值范围：** - 域名长度不能超过200个字符 - 支持大小写字母、数字、\&quot;-\&quot;、\&quot;.\&quot;，首尾字符不能是\&quot;-\&quot;或\&quot;.\&quot; - 泛域名场景下支持\&quot;*\&quot;，且\&quot;*必须为首字符 - 域名单节点长度不超过63个字符，即：***.***.com中，***的字符数不超过63个字符  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DuplicateDomainRequestBody {\n");
            sb.Append("  referenceDomainName: ").Append(ReferenceDomainName).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DuplicateDomainRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DuplicateDomainRequestBody input)
        {
            if (input == null) return false;
            if (this.ReferenceDomainName != input.ReferenceDomainName || (this.ReferenceDomainName != null && !this.ReferenceDomainName.Equals(input.ReferenceDomainName))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;

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
                if (this.ReferenceDomainName != null) hashCode = hashCode * 59 + this.ReferenceDomainName.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                return hashCode;
            }
        }
    }
}
