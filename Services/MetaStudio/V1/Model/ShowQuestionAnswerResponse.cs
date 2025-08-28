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
    /// Response Object
    /// </summary>
    public class ShowQuestionAnswerResponse : SdkResponse
    {

        /// <summary>
        /// 问答对ID。
        /// </summary>
        [JsonProperty("question_answer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestionAnswerId { get; set; }

        /// <summary>
        /// 标准问题。
        /// </summary>
        [JsonProperty("question", NullValueHandling = NullValueHandling.Ignore)]
        public string Question { get; set; }

        /// <summary>
        /// 问题答案。
        /// </summary>
        [JsonProperty("answer", NullValueHandling = NullValueHandling.Ignore)]
        public string Answer { get; set; }

        /// <summary>
        /// 所有相似问题，多个相似问题间用换行符\\n分隔。
        /// </summary>
        [JsonProperty("similar_questions", NullValueHandling = NullValueHandling.Ignore)]
        public string SimilarQuestions { get; set; }

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
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQuestionAnswerResponse {\n");
            sb.Append("  questionAnswerId: ").Append(QuestionAnswerId).Append("\n");
            sb.Append("  question: ").Append(Question).Append("\n");
            sb.Append("  answer: ").Append(Answer).Append("\n");
            sb.Append("  similarQuestions: ").Append(SimilarQuestions).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuestionAnswerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuestionAnswerResponse input)
        {
            if (input == null) return false;
            if (this.QuestionAnswerId != input.QuestionAnswerId || (this.QuestionAnswerId != null && !this.QuestionAnswerId.Equals(input.QuestionAnswerId))) return false;
            if (this.Question != input.Question || (this.Question != null && !this.Question.Equals(input.Question))) return false;
            if (this.Answer != input.Answer || (this.Answer != null && !this.Answer.Equals(input.Answer))) return false;
            if (this.SimilarQuestions != input.SimilarQuestions || (this.SimilarQuestions != null && !this.SimilarQuestions.Equals(input.SimilarQuestions))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.QuestionAnswerId != null) hashCode = hashCode * 59 + this.QuestionAnswerId.GetHashCode();
                if (this.Question != null) hashCode = hashCode * 59 + this.Question.GetHashCode();
                if (this.Answer != null) hashCode = hashCode * 59 + this.Answer.GetHashCode();
                if (this.SimilarQuestions != null) hashCode = hashCode * 59 + this.SimilarQuestions.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
