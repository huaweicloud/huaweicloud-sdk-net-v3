using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.PanguLargeModels.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ExecuteChatCompletionResponse : SdkResponse
    {

        /// <summary>
        /// 响应ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public int? Created { get; set; }

        /// <summary>
        /// 模型回复
        /// </summary>
        [JsonProperty("choices", NullValueHandling = NullValueHandling.Ignore)]
        public List<ChatChoice> Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public CompletionUsage Usage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteChatCompletionResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  choices: ").Append(Choices).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteChatCompletionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteChatCompletionResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Choices == input.Choices ||
                    this.Choices != null &&
                    input.Choices != null &&
                    this.Choices.SequenceEqual(input.Choices)
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Choices != null)
                    hashCode = hashCode * 59 + this.Choices.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
                return hashCode;
            }
        }
    }
}
