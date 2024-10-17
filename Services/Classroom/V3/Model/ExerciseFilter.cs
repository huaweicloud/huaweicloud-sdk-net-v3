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
    /// 获取习题库里习题过滤字段
    /// </summary>
    public class ExerciseFilter 
    {

        /// <summary>
        /// 需查询的习题名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 习题类型列表
        /// </summary>
        [JsonProperty("exercise_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ExerciseType { get; set; }

        /// <summary>
        /// 难度id列表
        /// </summary>
        [JsonProperty("difficult_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DifficultIds { get; set; }

        /// <summary>
        /// 知识点id列表
        /// </summary>
        [JsonProperty("knowledge_point_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KnowledgePointIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExerciseFilter {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  exerciseType: ").Append(ExerciseType).Append("\n");
            sb.Append("  difficultIds: ").Append(DifficultIds).Append("\n");
            sb.Append("  knowledgePointIds: ").Append(KnowledgePointIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExerciseFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExerciseFilter input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ExerciseType != input.ExerciseType || (this.ExerciseType != null && input.ExerciseType != null && !this.ExerciseType.SequenceEqual(input.ExerciseType))) return false;
            if (this.DifficultIds != input.DifficultIds || (this.DifficultIds != null && input.DifficultIds != null && !this.DifficultIds.SequenceEqual(input.DifficultIds))) return false;
            if (this.KnowledgePointIds != input.KnowledgePointIds || (this.KnowledgePointIds != null && input.KnowledgePointIds != null && !this.KnowledgePointIds.SequenceEqual(input.KnowledgePointIds))) return false;

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
                if (this.ExerciseType != null) hashCode = hashCode * 59 + this.ExerciseType.GetHashCode();
                if (this.DifficultIds != null) hashCode = hashCode * 59 + this.DifficultIds.GetHashCode();
                if (this.KnowledgePointIds != null) hashCode = hashCode * 59 + this.KnowledgePointIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
