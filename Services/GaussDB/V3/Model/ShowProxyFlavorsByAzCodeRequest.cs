using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowProxyFlavorsByAzCodeRequest 
    {

        /// <summary>
        /// **参数解释**：              请求语言类型。  **约束限制**：  不涉及。  **取值范围**： - en-us - zh-cn  **默认取值**：  en-us。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// **参数解释**：  可用区。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("az_codes", IsQuery = true)]
        [JsonProperty("az_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCodes { get; set; }

        /// <summary>
        /// **参数解释**：  代理引擎名称。  **约束限制**：  不涉及。  **取值范围**：  taurusproxy。  **默认取值**：  不涉及。
        /// </summary>
        [SDKProperty("proxy_engine_name", IsQuery = true)]
        [JsonProperty("proxy_engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyEngineName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProxyFlavorsByAzCodeRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  azCodes: ").Append(AzCodes).Append("\n");
            sb.Append("  proxyEngineName: ").Append(ProxyEngineName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProxyFlavorsByAzCodeRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProxyFlavorsByAzCodeRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.AzCodes != input.AzCodes || (this.AzCodes != null && !this.AzCodes.Equals(input.AzCodes))) return false;
            if (this.ProxyEngineName != input.ProxyEngineName || (this.ProxyEngineName != null && !this.ProxyEngineName.Equals(input.ProxyEngineName))) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.AzCodes != null) hashCode = hashCode * 59 + this.AzCodes.GetHashCode();
                if (this.ProxyEngineName != null) hashCode = hashCode * 59 + this.ProxyEngineName.GetHashCode();
                return hashCode;
            }
        }
    }
}
