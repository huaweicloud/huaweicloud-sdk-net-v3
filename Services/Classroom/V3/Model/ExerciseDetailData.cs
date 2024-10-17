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
    /// 习题详细内容及测试用例信息
    /// </summary>
    public class ExerciseDetailData 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("exercise_code_resource", NullValueHandling = NullValueHandling.Ignore)]
        public ExerciseCodeResource ExerciseCodeResource { get; set; }

        /// <summary>
        /// 测试用例信息
        /// </summary>
        [JsonProperty("exercise_case_resource", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExerciseCaseResource> ExerciseCaseResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExerciseDetailData {\n");
            sb.Append("  exerciseCodeResource: ").Append(ExerciseCodeResource).Append("\n");
            sb.Append("  exerciseCaseResource: ").Append(ExerciseCaseResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExerciseDetailData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExerciseDetailData input)
        {
            if (input == null) return false;
            if (this.ExerciseCodeResource != input.ExerciseCodeResource || (this.ExerciseCodeResource != null && !this.ExerciseCodeResource.Equals(input.ExerciseCodeResource))) return false;
            if (this.ExerciseCaseResource != input.ExerciseCaseResource || (this.ExerciseCaseResource != null && input.ExerciseCaseResource != null && !this.ExerciseCaseResource.SequenceEqual(input.ExerciseCaseResource))) return false;

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
                if (this.ExerciseCodeResource != null) hashCode = hashCode * 59 + this.ExerciseCodeResource.GetHashCode();
                if (this.ExerciseCaseResource != null) hashCode = hashCode * 59 + this.ExerciseCaseResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
