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
    public class ExerciseGroup 
    {

        /// <summary>
        /// 习题列表
        /// </summary>
        [JsonProperty("exercises", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExerciseCard> Exercises { get; set; }

        /// <summary>
        /// 习题分类
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExerciseGroup {\n");
            sb.Append("  exercises: ").Append(Exercises).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExerciseGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExerciseGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Exercises == input.Exercises ||
                    this.Exercises != null &&
                    input.Exercises != null &&
                    this.Exercises.SequenceEqual(input.Exercises)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Exercises != null)
                    hashCode = hashCode * 59 + this.Exercises.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
