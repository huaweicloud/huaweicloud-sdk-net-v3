using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MathInfo 
    {

        /// <summary>
        /// 数学试卷返回结果，表示题号。 
        /// </summary>
        [JsonProperty("question_number", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestionNumber { get; set; }

        /// <summary>
        /// 数学试卷答案的文字块数目。 
        /// </summary>
        [JsonProperty("answer_block_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AnswerBlockCount { get; set; }

        /// <summary>
        /// 数学试卷答案识别文字块列表，输出顺序从左到右，从上到下。 
        /// </summary>
        [JsonProperty("answer_block_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AnswerBlockList> AnswerBlockList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MathInfo {\n");
            sb.Append("  questionNumber: ").Append(QuestionNumber).Append("\n");
            sb.Append("  answerBlockCount: ").Append(AnswerBlockCount).Append("\n");
            sb.Append("  answerBlockList: ").Append(AnswerBlockList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MathInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MathInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuestionNumber == input.QuestionNumber ||
                    (this.QuestionNumber != null &&
                    this.QuestionNumber.Equals(input.QuestionNumber))
                ) && 
                (
                    this.AnswerBlockCount == input.AnswerBlockCount ||
                    (this.AnswerBlockCount != null &&
                    this.AnswerBlockCount.Equals(input.AnswerBlockCount))
                ) && 
                (
                    this.AnswerBlockList == input.AnswerBlockList ||
                    this.AnswerBlockList != null &&
                    input.AnswerBlockList != null &&
                    this.AnswerBlockList.SequenceEqual(input.AnswerBlockList)
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
                if (this.QuestionNumber != null)
                    hashCode = hashCode * 59 + this.QuestionNumber.GetHashCode();
                if (this.AnswerBlockCount != null)
                    hashCode = hashCode * 59 + this.AnswerBlockCount.GetHashCode();
                if (this.AnswerBlockList != null)
                    hashCode = hashCode * 59 + this.AnswerBlockList.GetHashCode();
                return hashCode;
            }
        }
    }
}
