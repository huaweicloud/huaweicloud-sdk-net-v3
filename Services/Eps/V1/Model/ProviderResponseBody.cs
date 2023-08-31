using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eps.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProviderResponseBody 
    {

        /// <summary>
        /// 云服务名称
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 云服务显示名称，可以通过参数中的&#39;locale&#39;设置语言
        /// </summary>
        [JsonProperty("provider_i18n_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderI18nDisplayName { get; set; }

        /// <summary>
        /// 资源类型列表
        /// </summary>
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTypeBody> ResourceTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProviderResponseBody {\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  providerI18nDisplayName: ").Append(ProviderI18nDisplayName).Append("\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProviderResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProviderResponseBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.ProviderI18nDisplayName == input.ProviderI18nDisplayName ||
                    (this.ProviderI18nDisplayName != null &&
                    this.ProviderI18nDisplayName.Equals(input.ProviderI18nDisplayName))
                ) && 
                (
                    this.ResourceTypes == input.ResourceTypes ||
                    this.ResourceTypes != null &&
                    input.ResourceTypes != null &&
                    this.ResourceTypes.SequenceEqual(input.ResourceTypes)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.ProviderI18nDisplayName != null)
                    hashCode = hashCode * 59 + this.ProviderI18nDisplayName.GetHashCode();
                if (this.ResourceTypes != null)
                    hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
