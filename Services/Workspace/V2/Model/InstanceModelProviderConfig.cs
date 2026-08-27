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
    /// 供应商配置（不含 API Key）
    /// </summary>
    public class InstanceModelProviderConfig 
    {

        /// <summary>
        /// 供应商配置主键 ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 供应商标识
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 供应商类型
        /// </summary>
        [JsonProperty("provider_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderType { get; set; }

        /// <summary>
        /// 供应商更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 供应商 API 地址
        /// </summary>
        [JsonProperty("api_base_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiBaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_config", NullValueHandling = NullValueHandling.Ignore)]
        public ProviderCustomConfig CustomConfig { get; set; }

        /// <summary>
        /// 模型列表
        /// </summary>
        [JsonProperty("models", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModelInfo> Models { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceModelProviderConfig {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  providerType: ").Append(ProviderType).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  apiBaseUrl: ").Append(ApiBaseUrl).Append("\n");
            sb.Append("  customConfig: ").Append(CustomConfig).Append("\n");
            sb.Append("  models: ").Append(Models).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceModelProviderConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceModelProviderConfig input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProviderType != input.ProviderType || (this.ProviderType != null && !this.ProviderType.Equals(input.ProviderType))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ApiBaseUrl != input.ApiBaseUrl || (this.ApiBaseUrl != null && !this.ApiBaseUrl.Equals(input.ApiBaseUrl))) return false;
            if (this.CustomConfig != input.CustomConfig || (this.CustomConfig != null && !this.CustomConfig.Equals(input.CustomConfig))) return false;
            if (this.Models != input.Models || (this.Models != null && input.Models != null && !this.Models.SequenceEqual(input.Models))) return false;

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
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProviderType != null) hashCode = hashCode * 59 + this.ProviderType.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ApiBaseUrl != null) hashCode = hashCode * 59 + this.ApiBaseUrl.GetHashCode();
                if (this.CustomConfig != null) hashCode = hashCode * 59 + this.CustomConfig.GetHashCode();
                if (this.Models != null) hashCode = hashCode * 59 + this.Models.GetHashCode();
                return hashCode;
            }
        }
    }
}
