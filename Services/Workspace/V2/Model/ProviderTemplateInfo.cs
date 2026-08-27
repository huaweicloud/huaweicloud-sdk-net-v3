using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 供应商模板信息。
    /// </summary>
    public class ProviderTemplateInfo 
    {

        /// <summary>
        /// 模板唯一标识（供应商类型）。
        /// </summary>
        [JsonProperty("provider_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderType { get; set; }

        /// <summary>
        /// 供应商id。
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 供应商base_url。
        /// </summary>
        [JsonProperty("base_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_config", NullValueHandling = NullValueHandling.Ignore)]
        public ProviderCustomConfig CustomConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("api_type", NullValueHandling = NullValueHandling.Ignore)]
        public ApiType? ApiType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProviderTemplateInfo {\n");
            sb.Append("  providerType: ").Append(ProviderType).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  baseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  customConfig: ").Append(CustomConfig).Append("\n");
            sb.Append("  apiType: ").Append(ApiType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProviderTemplateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProviderTemplateInfo input)
        {
            if (input == null) return false;
            if (this.ProviderType != input.ProviderType || (this.ProviderType != null && !this.ProviderType.Equals(input.ProviderType))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.BaseUrl != input.BaseUrl || (this.BaseUrl != null && !this.BaseUrl.Equals(input.BaseUrl))) return false;
            if (this.CustomConfig != input.CustomConfig || (this.CustomConfig != null && !this.CustomConfig.Equals(input.CustomConfig))) return false;
            if (this.ApiType != input.ApiType || (this.ApiType != null && !this.ApiType.Equals(input.ApiType))) return false;

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
                if (this.ProviderType != null) hashCode = hashCode * 59 + this.ProviderType.GetHashCode();
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.BaseUrl != null) hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.CustomConfig != null) hashCode = hashCode * 59 + this.CustomConfig.GetHashCode();
                if (this.ApiType != null) hashCode = hashCode * 59 + this.ApiType.GetHashCode();
                return hashCode;
            }
        }
    }
}
