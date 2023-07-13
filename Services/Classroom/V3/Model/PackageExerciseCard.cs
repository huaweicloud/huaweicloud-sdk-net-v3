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
    /// 习题简单信息返回体，用于列表返回
    /// </summary>
    public class PackageExerciseCard 
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
        /// 相关知识点
        /// </summary>
        [JsonProperty("knowledge_point", NullValueHandling = NullValueHandling.Ignore)]
        public List<KnowledgePointInfo> KnowledgePoint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageExerciseCard {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  difficult: ").Append(Difficult).Append("\n");
            sb.Append("  exerciseType: ").Append(ExerciseType).Append("\n");
            sb.Append("  exerciseTypeName: ").Append(ExerciseTypeName).Append("\n");
            sb.Append("  orderCount: ").Append(OrderCount).Append("\n");
            sb.Append("  knowledgePoint: ").Append(KnowledgePoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageExerciseCard);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageExerciseCard input)
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
                    this.KnowledgePoint == input.KnowledgePoint ||
                    this.KnowledgePoint != null &&
                    input.KnowledgePoint != null &&
                    this.KnowledgePoint.SequenceEqual(input.KnowledgePoint)
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
                if (this.Difficult != null)
                    hashCode = hashCode * 59 + this.Difficult.GetHashCode();
                if (this.ExerciseType != null)
                    hashCode = hashCode * 59 + this.ExerciseType.GetHashCode();
                if (this.ExerciseTypeName != null)
                    hashCode = hashCode * 59 + this.ExerciseTypeName.GetHashCode();
                if (this.OrderCount != null)
                    hashCode = hashCode * 59 + this.OrderCount.GetHashCode();
                if (this.KnowledgePoint != null)
                    hashCode = hashCode * 59 + this.KnowledgePoint.GetHashCode();
                return hashCode;
            }
        }
    }
}
