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
    /// 创建知识库意图和问法请求。
    /// </summary>
    public class CreateIntentAndQuestionReq 
    {

        /// <summary>
        /// 主题。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 问题答案。
        /// </summary>
        [JsonProperty("answer", NullValueHandling = NullValueHandling.Ignore)]
        public string Answer { get; set; }

        /// <summary>
        /// 技能ID。
        /// </summary>
        [JsonProperty("skill_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SkillId { get; set; }

        /// <summary>
        /// 问法列表
        /// </summary>
        [JsonProperty("question_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<KnowledgeQuestionCreateInfo> QuestionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateIntentAndQuestionReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  answer: ").Append(Answer).Append("\n");
            sb.Append("  skillId: ").Append(SkillId).Append("\n");
            sb.Append("  questionList: ").Append(QuestionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateIntentAndQuestionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateIntentAndQuestionReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Answer != input.Answer || (this.Answer != null && !this.Answer.Equals(input.Answer))) return false;
            if (this.SkillId != input.SkillId || (this.SkillId != null && !this.SkillId.Equals(input.SkillId))) return false;
            if (this.QuestionList != input.QuestionList || (this.QuestionList != null && input.QuestionList != null && !this.QuestionList.SequenceEqual(input.QuestionList))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Answer != null) hashCode = hashCode * 59 + this.Answer.GetHashCode();
                if (this.SkillId != null) hashCode = hashCode * 59 + this.SkillId.GetHashCode();
                if (this.QuestionList != null) hashCode = hashCode * 59 + this.QuestionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
