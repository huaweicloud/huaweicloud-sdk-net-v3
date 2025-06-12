using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 创建知识库问法请求。
    /// </summary>
    public class CreateKnowledgeQuestionReq 
    {

        /// <summary>
        /// 问法。
        /// </summary>
        [JsonProperty("question", NullValueHandling = NullValueHandling.Ignore)]
        public string Question { get; set; }

        /// <summary>
        /// 意图ID。
        /// </summary>
        [JsonProperty("intent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKnowledgeQuestionReq {\n");
            sb.Append("  question: ").Append(Question).Append("\n");
            sb.Append("  intentId: ").Append(IntentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKnowledgeQuestionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKnowledgeQuestionReq input)
        {
            if (input == null) return false;
            if (this.Question != input.Question || (this.Question != null && !this.Question.Equals(input.Question))) return false;
            if (this.IntentId != input.IntentId || (this.IntentId != null && !this.IntentId.Equals(input.IntentId))) return false;

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
                if (this.Question != null) hashCode = hashCode * 59 + this.Question.GetHashCode();
                if (this.IntentId != null) hashCode = hashCode * 59 + this.IntentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
