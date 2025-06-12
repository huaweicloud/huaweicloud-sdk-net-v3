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
    /// 知识库问法信息。
    /// </summary>
    public class KnowledgeQuestionInfo 
    {

        /// <summary>
        /// 问法ID。
        /// </summary>
        [JsonProperty("question_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestionId { get; set; }

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
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeQuestionInfo {\n");
            sb.Append("  questionId: ").Append(QuestionId).Append("\n");
            sb.Append("  question: ").Append(Question).Append("\n");
            sb.Append("  intentId: ").Append(IntentId).Append("\n");
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
            return this.Equals(input as KnowledgeQuestionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KnowledgeQuestionInfo input)
        {
            if (input == null) return false;
            if (this.QuestionId != input.QuestionId || (this.QuestionId != null && !this.QuestionId.Equals(input.QuestionId))) return false;
            if (this.Question != input.Question || (this.Question != null && !this.Question.Equals(input.Question))) return false;
            if (this.IntentId != input.IntentId || (this.IntentId != null && !this.IntentId.Equals(input.IntentId))) return false;
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
                if (this.QuestionId != null) hashCode = hashCode * 59 + this.QuestionId.GetHashCode();
                if (this.Question != null) hashCode = hashCode * 59 + this.Question.GetHashCode();
                if (this.IntentId != null) hashCode = hashCode * 59 + this.IntentId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
