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
    /// 
    /// </summary>
    public class ExerciseCard 
    {

        /// <summary>
        /// 习题名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 习题ID
        /// </summary>
        [JsonProperty("exercise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseId { get; set; }

        /// <summary>
        /// 习题描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 习题子类型 1：函数c 2：函数c++ 3：函数Java 4：函数Python 5：单人项目java 6：单人项目Hadoop 7：通用 8：企业级软件项目 10：web习题 11：AI习题 12：单选题 13：多选题 14：填空题 15：单人项目C 16：单人项目C++
        /// </summary>
        [JsonProperty("resource_sub_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSubType { get; set; }

        /// <summary>
        /// 习题分值
        /// </summary>
        [JsonProperty("target_score", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetScore { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExerciseCard {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  exerciseId: ").Append(ExerciseId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  resourceSubType: ").Append(ResourceSubType).Append("\n");
            sb.Append("  targetScore: ").Append(TargetScore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExerciseCard);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExerciseCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ExerciseId == input.ExerciseId ||
                    (this.ExerciseId != null &&
                    this.ExerciseId.Equals(input.ExerciseId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ResourceSubType == input.ResourceSubType ||
                    (this.ResourceSubType != null &&
                    this.ResourceSubType.Equals(input.ResourceSubType))
                ) && 
                (
                    this.TargetScore == input.TargetScore ||
                    (this.TargetScore != null &&
                    this.TargetScore.Equals(input.TargetScore))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExerciseId != null)
                    hashCode = hashCode * 59 + this.ExerciseId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ResourceSubType != null)
                    hashCode = hashCode * 59 + this.ResourceSubType.GetHashCode();
                if (this.TargetScore != null)
                    hashCode = hashCode * 59 + this.TargetScore.GetHashCode();
                return hashCode;
            }
        }
    }
}
