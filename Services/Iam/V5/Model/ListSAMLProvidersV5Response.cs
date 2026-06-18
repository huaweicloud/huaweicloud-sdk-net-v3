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
    /// Response Object
    /// </summary>
    public class ListSAMLProvidersV5Response : SdkResponse
    {

        /// <summary>
        /// **参数解释**： SAML 提供商。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("saml_providers", NullValueHandling = NullValueHandling.Ignore)]
        public List<InlineResponse200SamlProviders> SamlProviders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public InlineResponse200PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSAMLProvidersV5Response {\n");
            sb.Append("  samlProviders: ").Append(SamlProviders).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSAMLProvidersV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSAMLProvidersV5Response input)
        {
            if (input == null) return false;
            if (this.SamlProviders != input.SamlProviders || (this.SamlProviders != null && input.SamlProviders != null && !this.SamlProviders.SequenceEqual(input.SamlProviders))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.SamlProviders != null) hashCode = hashCode * 59 + this.SamlProviders.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
