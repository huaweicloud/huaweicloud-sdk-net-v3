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
    /// 模型信息，下发和查询共用。
    /// </summary>
    public class ModelInfo 
    {

        /// <summary>
        /// 模型 ID（业务主键）。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 模型名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 供应商侧模型 ID。
        /// </summary>
        [JsonProperty("provider_model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderModelId { get; set; }

        /// <summary>
        /// 输入类型数组。
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Input { get; set; }

        /// <summary>
        /// 是否支持推理。
        /// </summary>
        [JsonProperty("reasoning", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reasoning { get; set; }

        /// <summary>
        /// 模型更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 上下文窗口。
        /// </summary>
        [JsonProperty("context_window", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContextWindow { get; set; }

        /// <summary>
        /// 最大输出 token 数。
        /// </summary>
        [JsonProperty("max_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 纳管类型（BACKEND_MANAGE后台管理/CUSTOM自定义）,业务下发的都是BACKEND_MANAGE。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  providerModelId: ").Append(ProviderModelId).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  reasoning: ").Append(Reasoning).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  contextWindow: ").Append(ContextWindow).Append("\n");
            sb.Append("  maxTokens: ").Append(MaxTokens).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProviderModelId != input.ProviderModelId || (this.ProviderModelId != null && !this.ProviderModelId.Equals(input.ProviderModelId))) return false;
            if (this.Input != input.Input || (this.Input != null && input.Input != null && !this.Input.SequenceEqual(input.Input))) return false;
            if (this.Reasoning != input.Reasoning || (this.Reasoning != null && !this.Reasoning.Equals(input.Reasoning))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.ContextWindow != input.ContextWindow || (this.ContextWindow != null && !this.ContextWindow.Equals(input.ContextWindow))) return false;
            if (this.MaxTokens != input.MaxTokens || (this.MaxTokens != null && !this.MaxTokens.Equals(input.MaxTokens))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.ProviderModelId != null) hashCode = hashCode * 59 + this.ProviderModelId.GetHashCode();
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Reasoning != null) hashCode = hashCode * 59 + this.Reasoning.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.ContextWindow != null) hashCode = hashCode * 59 + this.ContextWindow.GetHashCode();
                if (this.MaxTokens != null) hashCode = hashCode * 59 + this.MaxTokens.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
