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
    /// 
    /// </summary>
    public class BaseModeInfo 
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseModeInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  contextWindow: ").Append(ContextWindow).Append("\n");
            sb.Append("  maxTokens: ").Append(MaxTokens).Append("\n");
            sb.Append("  reasoning: ").Append(Reasoning).Append("\n");
            sb.Append("  cost: ").Append(Cost).Append("\n");
            sb.Append("  compat: ").Append(Compat).Append("\n");
            sb.Append("  isBuiltin: ").Append(IsBuiltin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseModeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseModeInfo input)
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
                return hashCode;
            }
        }
    }
}
