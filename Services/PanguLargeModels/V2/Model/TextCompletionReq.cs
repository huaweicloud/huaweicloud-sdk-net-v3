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
    /// 
    /// </summary>
    public class TextCompletionReq 
    {

        /// <summary>
        /// 向模型输入的文本信息，最小长度：1，最大长度：模型支持的max_tokens数量乘以系数，默认系数为1.5
        /// </summary>
        [JsonProperty("prompt", NullValueHandling = NullValueHandling.Ignore)]
        public string Prompt { get; set; }

        /// <summary>
        /// 用于代表客户的唯一标识符，最小长度：1，最大长度64
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// 流式调用的开启开关，true为开启流式调用，如果要开启流式调用，请使用流式SDK；false为关闭流式调用。默认为关闭状态（当前API Explorer不支持流式，在API Explorer调试时请使用非流式）。
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stream { get; set; }

        /// <summary>
        /// 用于控制生成文本的多样性和创造力。参数的取值范围是0到1，其中0表示最低的随机性。一般来说，temperature越低，适合完成确定性的任务。temperature越高，例如0.9，适合完成创造性的任务。temperature参数可以影响语言模型输出的质量和多样性，但也不是唯一的因素。还有其他一些参数，如top_p参数也可以用来调整语言模型的行为和偏好，但不建议同时更改这两个参数。
        /// </summary>
        [JsonProperty("temperature", NullValueHandling = NullValueHandling.Ignore)]
        public float? Temperature { get; set; }

        /// <summary>
        /// 一种替代温度采样的方法，称为nucleus sampling，其中模型考虑具有top_p 概率质量的标记的结果。因此 0.1 意味着只考虑构成前 10% 概率质量的标记。我们通常建议更改此值或温度，但不要同时更改两者。通常建议更改top_p或temperature来调整生成文本的倾向性，但不要同时更改这两个参数。
        /// </summary>
        [JsonProperty("top_p", NullValueHandling = NullValueHandling.Ignore)]
        public float? TopP { get; set; }

        /// <summary>
        /// 用于控制聊天回复的长度和质量。一般来说，较大的max_tokens值可以生成较长和较完整的回复，但也可能增加生成无关或重复内容的风险。较小的max_tokens值可以生成较短和较简洁的回复，但也可能导致生成不完整或不连贯的内容。因此，需要根据不同的场景和需求来选择合适的max_tokens值。最小值：1，最大值：根据模型不同最大值不同。
        /// </summary>
        [JsonProperty("max_tokens", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// 表示对每个问题生成多少条答案。n参数的默认值是1，表示只生成一个答案。如果想要生成多条答案，可以设置n参数为一个大于1的整数，例如n&#x3D;2。这样，API会返回一个包含2个答案的数组。流式调用时，n只能取1。最小值：1，最大值：2，默认值：1
        /// </summary>
        [JsonProperty("n", NullValueHandling = NullValueHandling.Ignore)]
        public int? N { get; set; }

        /// <summary>
        /// 用于控制生成文本中的重复程度。正值会根据它们到目前为止在文本中的现有频率来惩罚新tokens，从而降低模型逐字重复同一行的可能性。  presence_penalty 参数可以用来提高生成文本的多样性和创造性，避免生成单调或重复的内容。最小值：-2，最大值：2
        /// </summary>
        [JsonProperty("presence_penalty", NullValueHandling = NullValueHandling.Ignore)]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// 用于调整模型对频繁出现的Token的处理方式。即如果一个Token在训练集中出现的频率较高，那么模型在生成这个Token时会受到一定的惩罚。当frequency_penalty的值为正数时，模型会更倾向于生成出现频率较低的Token，即模型会更倾向于使用不常见的词汇。最小值：-2，最大值：2
        /// </summary>
        [JsonProperty("frequency_penalty", NullValueHandling = NullValueHandling.Ignore)]
        public float? FrequencyPenalty { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextCompletionReq {\n");
            sb.Append("  prompt: ").Append(Prompt).Append("\n");
            sb.Append("  user: ").Append(User).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  temperature: ").Append(Temperature).Append("\n");
            sb.Append("  topP: ").Append(TopP).Append("\n");
            sb.Append("  maxTokens: ").Append(MaxTokens).Append("\n");
            sb.Append("  n: ").Append(N).Append("\n");
            sb.Append("  presencePenalty: ").Append(PresencePenalty).Append("\n");
            sb.Append("  frequencyPenalty: ").Append(FrequencyPenalty).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TextCompletionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TextCompletionReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Prompt == input.Prompt ||
                    (this.Prompt != null &&
                    this.Prompt.Equals(input.Prompt))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
                ) && 
                (
                    this.TopP == input.TopP ||
                    (this.TopP != null &&
                    this.TopP.Equals(input.TopP))
                ) && 
                (
                    this.MaxTokens == input.MaxTokens ||
                    (this.MaxTokens != null &&
                    this.MaxTokens.Equals(input.MaxTokens))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.PresencePenalty == input.PresencePenalty ||
                    (this.PresencePenalty != null &&
                    this.PresencePenalty.Equals(input.PresencePenalty))
                ) && 
                (
                    this.FrequencyPenalty == input.FrequencyPenalty ||
                    (this.FrequencyPenalty != null &&
                    this.FrequencyPenalty.Equals(input.FrequencyPenalty))
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
                if (this.Prompt != null)
                    hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
                if (this.TopP != null)
                    hashCode = hashCode * 59 + this.TopP.GetHashCode();
                if (this.MaxTokens != null)
                    hashCode = hashCode * 59 + this.MaxTokens.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.PresencePenalty != null)
                    hashCode = hashCode * 59 + this.PresencePenalty.GetHashCode();
                if (this.FrequencyPenalty != null)
                    hashCode = hashCode * 59 + this.FrequencyPenalty.GetHashCode();
                return hashCode;
            }
        }
    }
}
