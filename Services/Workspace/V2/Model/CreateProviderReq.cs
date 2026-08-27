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
    /// 新增供应商配置请求。
    /// </summary>
    public class CreateProviderReq 
    {

        /// <summary>
        /// 供应商类型（模板创建时与模板保持一致，自定义时为custom）。
        /// </summary>
        [JsonProperty("provider_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderType { get; set; }

        /// <summary>
        /// 供应商标识（模板创建时与模板保持一致，自定义时可指定）。
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 供应商API Key（SCC加密存储）。
        /// </summary>
        [JsonProperty("api_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiKey { get; set; }

        /// <summary>
        /// 供应商名称（租户自定义）。
        /// </summary>
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        /// 自定义Base URL。
        /// </summary>
        [JsonProperty("base_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_config", NullValueHandling = NullValueHandling.Ignore)]
        public ProviderCustomConfig CustomConfig { get; set; }

        /// <summary>
        /// 批量创建关联的模型列表。
        /// </summary>
        [JsonProperty("models", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateModelReq> Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("api_type", NullValueHandling = NullValueHandling.Ignore)]
        public ApiType ApiType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProviderReq {\n");
            sb.Append("  providerType: ").Append(ProviderType).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  apiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  baseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  customConfig: ").Append(CustomConfig).Append("\n");
            sb.Append("  models: ").Append(Models).Append("\n");
            sb.Append("  apiType: ").Append(ApiType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateProviderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateProviderReq input)
        {
            if (input == null) return false;
            if (this.ProviderType != input.ProviderType || (this.ProviderType != null && !this.ProviderType.Equals(input.ProviderType))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.ApiKey != input.ApiKey || (this.ApiKey != null && !this.ApiKey.Equals(input.ApiKey))) return false;
            if (this.ProviderName != input.ProviderName || (this.ProviderName != null && !this.ProviderName.Equals(input.ProviderName))) return false;
            if (this.BaseUrl != input.BaseUrl || (this.BaseUrl != null && !this.BaseUrl.Equals(input.BaseUrl))) return false;
            if (this.CustomConfig != input.CustomConfig || (this.CustomConfig != null && !this.CustomConfig.Equals(input.CustomConfig))) return false;
            if (this.Models != input.Models || (this.Models != null && input.Models != null && !this.Models.SequenceEqual(input.Models))) return false;
            if (this.ApiType != input.ApiType) return false;

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
                if (this.ApiKey != null) hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.ProviderName != null) hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.BaseUrl != null) hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.CustomConfig != null) hashCode = hashCode * 59 + this.CustomConfig.GetHashCode();
                if (this.Models != null) hashCode = hashCode * 59 + this.Models.GetHashCode();
                hashCode = hashCode * 59 + this.ApiType.GetHashCode();
                return hashCode;
            }
        }
    }
}
