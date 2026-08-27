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
    /// 供应商配置信息（含last_verify_time）。
    /// </summary>
    public class ProviderInfoVO 
    {

        /// <summary>
        /// 供应商id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 供应商名称。
        /// </summary>
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

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
        /// 供应商base_url。
        /// </summary>
        [JsonProperty("base_url", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// 连接状态（connected/disconnected/unverified）。
        /// </summary>
        [JsonProperty("connection_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// 下属模型数量。
        /// </summary>
        [JsonProperty("model_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModelCount { get; set; }

        /// <summary>
        /// 关联的模型分组数量。
        /// </summary>
        [JsonProperty("group_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupCount { get; set; }

        /// <summary>
        /// 最后一次验证时间。
        /// </summary>
        [JsonProperty("last_verify_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastVerifyTime { get; set; }

        /// <summary>
        /// 创建时间（ISO8601格式，UTC时区）。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间（ISO8601格式，UTC时区）。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 是否为内置供应商。
        /// </summary>
        [JsonProperty("is_builtin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBuiltin { get; set; }

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
            sb.Append("class ProviderInfoVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  providerType: ").Append(ProviderType).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  baseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  connectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  modelCount: ").Append(ModelCount).Append("\n");
            sb.Append("  groupCount: ").Append(GroupCount).Append("\n");
            sb.Append("  lastVerifyTime: ").Append(LastVerifyTime).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  isBuiltin: ").Append(IsBuiltin).Append("\n");
            sb.Append("  apiType: ").Append(ApiType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProviderInfoVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProviderInfoVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProviderName != input.ProviderName || (this.ProviderName != null && !this.ProviderName.Equals(input.ProviderName))) return false;
            if (this.ProviderType != input.ProviderType || (this.ProviderType != null && !this.ProviderType.Equals(input.ProviderType))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.BaseUrl != input.BaseUrl || (this.BaseUrl != null && !this.BaseUrl.Equals(input.BaseUrl))) return false;
            if (this.ConnectionStatus != input.ConnectionStatus || (this.ConnectionStatus != null && !this.ConnectionStatus.Equals(input.ConnectionStatus))) return false;
            if (this.ModelCount != input.ModelCount || (this.ModelCount != null && !this.ModelCount.Equals(input.ModelCount))) return false;
            if (this.GroupCount != input.GroupCount || (this.GroupCount != null && !this.GroupCount.Equals(input.GroupCount))) return false;
            if (this.LastVerifyTime != input.LastVerifyTime || (this.LastVerifyTime != null && !this.LastVerifyTime.Equals(input.LastVerifyTime))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.IsBuiltin != input.IsBuiltin || (this.IsBuiltin != null && !this.IsBuiltin.Equals(input.IsBuiltin))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProviderName != null) hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.ProviderType != null) hashCode = hashCode * 59 + this.ProviderType.GetHashCode();
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.BaseUrl != null) hashCode = hashCode * 59 + this.BaseUrl.GetHashCode();
                if (this.ConnectionStatus != null) hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.ModelCount != null) hashCode = hashCode * 59 + this.ModelCount.GetHashCode();
                if (this.GroupCount != null) hashCode = hashCode * 59 + this.GroupCount.GetHashCode();
                if (this.LastVerifyTime != null) hashCode = hashCode * 59 + this.LastVerifyTime.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.IsBuiltin != null) hashCode = hashCode * 59 + this.IsBuiltin.GetHashCode();
                if (this.ApiType != null) hashCode = hashCode * 59 + this.ApiType.GetHashCode();
                return hashCode;
            }
        }
    }
}
