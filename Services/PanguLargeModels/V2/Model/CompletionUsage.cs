using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.PanguLargeModels.V2.Model
{
    /// <summary>
    /// tokens统计对象
    /// </summary>
    public class CompletionUsage 
    {

        /// <summary>
        /// 表示模型生成的答案中包含的tokens的数量。
        /// </summary>
        [JsonProperty("completion_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CompletionTokens { get; set; }

        /// <summary>
        /// 表示生成结果时使用的提示文本的tokens的数量。
        /// </summary>
        [JsonProperty("prompt_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PromptTokens { get; set; }

        /// <summary>
        /// 对话过程中使用的tokens总数。
        /// </summary>
        [JsonProperty("total_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TotalTokens { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletionUsage {\n");
            sb.Append("  completionTokens: ").Append(CompletionTokens).Append("\n");
            sb.Append("  promptTokens: ").Append(PromptTokens).Append("\n");
            sb.Append("  totalTokens: ").Append(TotalTokens).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompletionUsage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompletionUsage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompletionTokens == input.CompletionTokens ||
                    (this.CompletionTokens != null &&
                    this.CompletionTokens.Equals(input.CompletionTokens))
                ) && 
                (
                    this.PromptTokens == input.PromptTokens ||
                    (this.PromptTokens != null &&
                    this.PromptTokens.Equals(input.PromptTokens))
                ) && 
                (
                    this.TotalTokens == input.TotalTokens ||
                    (this.TotalTokens != null &&
                    this.TotalTokens.Equals(input.TotalTokens))
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
                if (this.CompletionTokens != null)
                    hashCode = hashCode * 59 + this.CompletionTokens.GetHashCode();
                if (this.PromptTokens != null)
                    hashCode = hashCode * 59 + this.PromptTokens.GetHashCode();
                if (this.TotalTokens != null)
                    hashCode = hashCode * 59 + this.TotalTokens.GetHashCode();
                return hashCode;
            }
        }
    }
}
