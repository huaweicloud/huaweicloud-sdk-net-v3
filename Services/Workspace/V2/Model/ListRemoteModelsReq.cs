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
    /// 查询供应商远程模型列表请求。
    /// </summary>
    public class ListRemoteModelsReq 
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
        /// 供应商id。
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 供应商API Key（SCC加密存储）。
        /// </summary>
        [JsonProperty("api_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiKey { get; set; }

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
        /// 每页数量，默认20，最大100。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量，从0开始。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRemoteModelsReq {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  providerType: ").Append(ProviderType).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  apiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  baseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  customConfig: ").Append(CustomConfig).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRemoteModelsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRemoteModelsReq input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProviderType != input.ProviderType || (this.ProviderType != null && !this.ProviderType.Equals(input.ProviderType))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.ApiKey != input.ApiKey || (this.ApiKey != null && !this.ApiKey.Equals(input.ApiKey))) return false;
            if (this.BaseUrl != input.BaseUrl || (this.BaseUrl != null && !this.BaseUrl.Equals(input.BaseUrl))) return false;
            if (this.CustomConfig != input.CustomConfig || (this.CustomConfig != null && !this.CustomConfig.Equals(input.CustomConfig))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.BaseUrl != null) hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.CustomConfig != null) hashCode = hashCode * 59 + this.CustomConfig.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
