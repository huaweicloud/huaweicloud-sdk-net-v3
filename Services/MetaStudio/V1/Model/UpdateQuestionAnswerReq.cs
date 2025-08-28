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
    /// 修改问答对请求。
    /// </summary>
    public class UpdateQuestionAnswerReq 
    {

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateQuestionAnswerReq {\n");
            sb.Append("  question: ").Append(Question).Append("\n");
            sb.Append("  answer: ").Append(Answer).Append("\n");
            sb.Append("  similarQuestions: ").Append(SimilarQuestions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateQuestionAnswerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateQuestionAnswerReq input)
        {
            if (input == null) return false;
            if (this.Question != input.Question || (this.Question != null && !this.Question.Equals(input.Question))) return false;
            if (this.Answer != input.Answer || (this.Answer != null && !this.Answer.Equals(input.Answer))) return false;
            if (this.SimilarQuestions != input.SimilarQuestions || (this.SimilarQuestions != null && !this.SimilarQuestions.Equals(input.SimilarQuestions))) return false;

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
                if (this.Answer != null) hashCode = hashCode * 59 + this.Answer.GetHashCode();
                if (this.SimilarQuestions != null) hashCode = hashCode * 59 + this.SimilarQuestions.GetHashCode();
                return hashCode;
            }
        }
    }
}
