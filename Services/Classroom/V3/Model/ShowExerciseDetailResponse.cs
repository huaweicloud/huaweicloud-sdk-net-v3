using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowExerciseDetailResponse : SdkResponse
    {

        /// <summary>
        /// 习题id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 习题名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 习题描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("difficult", NullValueHandling = NullValueHandling.Ignore)]
        public DifficultInfo Difficult { get; set; }

        /// <summary>
        /// 习题类型编号
        /// </summary>
        [JsonProperty("exercise_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExerciseType { get; set; }

        /// <summary>
        /// 习题类型名称
        /// </summary>
        [JsonProperty("exercise_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseTypeName { get; set; }

        /// <summary>
        /// 习题库里习题编号
        /// </summary>
        [JsonProperty("order_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderCount { get; set; }

        /// <summary>
        /// 测试用例描述
        /// </summary>
        [JsonProperty("test_case_description", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseDescription { get; set; }

        /// <summary>
        /// 相关知识点
        /// </summary>
        [JsonProperty("knowledge_point", NullValueHandling = NullValueHandling.Ignore)]
        public List<KnowledgePointInfo> KnowledgePoint { get; set; }

        /// <summary>
        /// 判题类型
        /// </summary>
        [JsonProperty("judge_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? JudgeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("exercise_data", NullValueHandling = NullValueHandling.Ignore)]
        public ExerciseDetailData ExerciseData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowExerciseDetailResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  difficult: ").Append(Difficult).Append("\n");
            sb.Append("  exerciseType: ").Append(ExerciseType).Append("\n");
            sb.Append("  exerciseTypeName: ").Append(ExerciseTypeName).Append("\n");
            sb.Append("  orderCount: ").Append(OrderCount).Append("\n");
            sb.Append("  testCaseDescription: ").Append(TestCaseDescription).Append("\n");
            sb.Append("  knowledgePoint: ").Append(KnowledgePoint).Append("\n");
            sb.Append("  judgeType: ").Append(JudgeType).Append("\n");
            sb.Append("  exerciseData: ").Append(ExerciseData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowExerciseDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowExerciseDetailResponse input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Difficult == input.Difficult ||
                    (this.Difficult != null &&
                    this.Difficult.Equals(input.Difficult))
                ) && 
                (
                    this.ExerciseType == input.ExerciseType ||
                    (this.ExerciseType != null &&
                    this.ExerciseType.Equals(input.ExerciseType))
                ) && 
                (
                    this.ExerciseTypeName == input.ExerciseTypeName ||
                    (this.ExerciseTypeName != null &&
                    this.ExerciseTypeName.Equals(input.ExerciseTypeName))
                ) && 
                (
                    this.OrderCount == input.OrderCount ||
                    (this.OrderCount != null &&
                    this.OrderCount.Equals(input.OrderCount))
                ) && 
                (
                    this.TestCaseDescription == input.TestCaseDescription ||
                    (this.TestCaseDescription != null &&
                    this.TestCaseDescription.Equals(input.TestCaseDescription))
                ) && 
                (
                    this.KnowledgePoint == input.KnowledgePoint ||
                    this.KnowledgePoint != null &&
                    input.KnowledgePoint != null &&
                    this.KnowledgePoint.SequenceEqual(input.KnowledgePoint)
                ) && 
                (
                    this.JudgeType == input.JudgeType ||
                    (this.JudgeType != null &&
                    this.JudgeType.Equals(input.JudgeType))
                ) && 
                (
                    this.ExerciseData == input.ExerciseData ||
                    (this.ExerciseData != null &&
                    this.ExerciseData.Equals(input.ExerciseData))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Difficult != null)
                    hashCode = hashCode * 59 + this.Difficult.GetHashCode();
                if (this.ExerciseType != null)
                    hashCode = hashCode * 59 + this.ExerciseType.GetHashCode();
                if (this.ExerciseTypeName != null)
                    hashCode = hashCode * 59 + this.ExerciseTypeName.GetHashCode();
                if (this.OrderCount != null)
                    hashCode = hashCode * 59 + this.OrderCount.GetHashCode();
                if (this.TestCaseDescription != null)
                    hashCode = hashCode * 59 + this.TestCaseDescription.GetHashCode();
                if (this.KnowledgePoint != null)
                    hashCode = hashCode * 59 + this.KnowledgePoint.GetHashCode();
                if (this.JudgeType != null)
                    hashCode = hashCode * 59 + this.JudgeType.GetHashCode();
                if (this.ExerciseData != null)
                    hashCode = hashCode * 59 + this.ExerciseData.GetHashCode();
                return hashCode;
            }
        }
    }
}
