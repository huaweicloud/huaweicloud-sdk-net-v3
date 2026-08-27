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
    /// 模型详情信息。
    /// </summary>
    public class ModelInfoForResp 
    {

        /// <summary>
        /// 模型id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 模型名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 输入类型数组。
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Input { get; set; }

        /// <summary>
        /// 最大上下文窗口。
        /// </summary>
        [JsonProperty("context_window", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContextWindow { get; set; }

        /// <summary>
        /// 最大输出Token数。
        /// </summary>
        [JsonProperty("max_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 是否支持推理。
        /// </summary>
        [JsonProperty("reasoning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reasoning { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cost", NullValueHandling = NullValueHandling.Ignore)]
        public ModelCost Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compat", NullValueHandling = NullValueHandling.Ignore)]
        public ModelCompat Compat { get; set; }

        /// <summary>
        /// 是否内置模型。
        /// </summary>
        [JsonProperty("is_builtin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBuiltin { get; set; }

        /// <summary>
        /// 供应商侧模型标识。
        /// </summary>
        [JsonProperty("provider_model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderModelId { get; set; }

        /// <summary>
        /// 供应商id。
        /// </summary>
        [JsonProperty("provider_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderId { get; set; }

        /// <summary>
        /// 供应商名称。
        /// </summary>
        [JsonProperty("provider_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderName { get; set; }

        /// <summary>
        /// 模型描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 组内排序优先级。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelInfoForResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  contextWindow: ").Append(ContextWindow).Append("\n");
            sb.Append("  maxTokens: ").Append(MaxTokens).Append("\n");
            sb.Append("  reasoning: ").Append(Reasoning).Append("\n");
            sb.Append("  cost: ").Append(Cost).Append("\n");
            sb.Append("  compat: ").Append(Compat).Append("\n");
            sb.Append("  isBuiltin: ").Append(IsBuiltin).Append("\n");
            sb.Append("  providerModelId: ").Append(ProviderModelId).Append("\n");
            sb.Append("  providerId: ").Append(ProviderId).Append("\n");
            sb.Append("  providerName: ").Append(ProviderName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelInfoForResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelInfoForResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Input != input.Input || (this.Input != null && input.Input != null && !this.Input.SequenceEqual(input.Input))) return false;
            if (this.ContextWindow != input.ContextWindow || (this.ContextWindow != null && !this.ContextWindow.Equals(input.ContextWindow))) return false;
            if (this.MaxTokens != input.MaxTokens || (this.MaxTokens != null && !this.MaxTokens.Equals(input.MaxTokens))) return false;
            if (this.Reasoning != input.Reasoning || (this.Reasoning != null && !this.Reasoning.Equals(input.Reasoning))) return false;
            if (this.Cost != input.Cost || (this.Cost != null && !this.Cost.Equals(input.Cost))) return false;
            if (this.Compat != input.Compat || (this.Compat != null && !this.Compat.Equals(input.Compat))) return false;
            if (this.IsBuiltin != input.IsBuiltin || (this.IsBuiltin != null && !this.IsBuiltin.Equals(input.IsBuiltin))) return false;
            if (this.ProviderModelId != input.ProviderModelId || (this.ProviderModelId != null && !this.ProviderModelId.Equals(input.ProviderModelId))) return false;
            if (this.ProviderId != input.ProviderId || (this.ProviderId != null && !this.ProviderId.Equals(input.ProviderId))) return false;
            if (this.ProviderName != input.ProviderName || (this.ProviderName != null && !this.ProviderName.Equals(input.ProviderName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.ContextWindow != null) hashCode = hashCode * 59 + this.ContextWindow.GetHashCode();
                if (this.MaxTokens != null) hashCode = hashCode * 59 + this.MaxTokens.GetHashCode();
                if (this.Reasoning != null) hashCode = hashCode * 59 + this.Reasoning.GetHashCode();
                if (this.Cost != null) hashCode = hashCode * 59 + this.Cost.GetHashCode();
                if (this.Compat != null) hashCode = hashCode * 59 + this.Compat.GetHashCode();
                if (this.IsBuiltin != null) hashCode = hashCode * 59 + this.IsBuiltin.GetHashCode();
                if (this.ProviderModelId != null) hashCode = hashCode * 59 + this.ProviderModelId.GetHashCode();
                if (this.ProviderId != null) hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.ProviderName != null) hashCode = hashCode * 59 + this.ProviderName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
