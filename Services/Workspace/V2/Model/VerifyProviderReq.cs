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
    /// 验证供应商配置请求。
    /// </summary>
    public class VerifyProviderReq 
    {

        /// <summary>
        /// 供应商主键ID。传入时，其他空字段从数据库已保存的供应商记录中补充。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 供应商类型。
        /// </summary>
        [JsonProperty("provider_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderType { get; set; }

        /// <summary>
        /// 供应商id（从模板实例化后的ID）。
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 供应商API Key（SCC加密存储）。
        /// </summary>
        [JsonProperty("api_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("api_type", NullValueHandling = NullValueHandling.Ignore)]
        public ApiType? ApiType { get; set; }

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
        /// 用于验证连接的模型ID。调用Chat Completion接口时作为model参数传入。
        /// </summary>
        [JsonProperty("model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyProviderReq {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  providerType: ").Append(ProviderType).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  apiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  apiType: ").Append(ApiType).Append("\n");
            sb.Append("  baseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  customConfig: ").Append(CustomConfig).Append("\n");
            sb.Append("  modelId: ").Append(ModelId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyProviderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyProviderReq input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProviderType != input.ProviderType || (this.ProviderType != null && !this.ProviderType.Equals(input.ProviderType))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.ApiKey != input.ApiKey || (this.ApiKey != null && !this.ApiKey.Equals(input.ApiKey))) return false;
            if (this.ApiType != input.ApiType || (this.ApiType != null && !this.ApiType.Equals(input.ApiType))) return false;
            if (this.BaseUrl != input.BaseUrl || (this.BaseUrl != null && !this.BaseUrl.Equals(input.BaseUrl))) return false;
            if (this.CustomConfig != input.CustomConfig || (this.CustomConfig != null && !this.CustomConfig.Equals(input.CustomConfig))) return false;
            if (this.ModelId != input.ModelId || (this.ModelId != null && !this.ModelId.Equals(input.ModelId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProviderType != null) hashCode = hashCode * 59 + this.ProviderType.GetHashCode();
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.ApiKey != null) hashCode = hashCode * 59 + this.ApiKey.GetHashCode();
                if (this.ApiType != null) hashCode = hashCode * 59 + this.ApiType.GetHashCode();
                if (this.BaseUrl != null) hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.CustomConfig != null) hashCode = hashCode * 59 + this.CustomConfig.GetHashCode();
                if (this.ModelId != null) hashCode = hashCode * 59 + this.ModelId.GetHashCode();
                return hashCode;
            }
        }
    }
}
