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
    public class ShowJobExercisesResponse : SdkResponse
    {

        /// <summary>
        /// 作业下习题列表
        /// </summary>
        [JsonProperty("group_exercises", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExerciseGroup> GroupExercises { get; set; }

        /// <summary>
        /// 作业下习题总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobExercisesResponse {\n");
            sb.Append("  groupExercises: ").Append(GroupExercises).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobExercisesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobExercisesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupExercises == input.GroupExercises ||
                    this.GroupExercises != null &&
                    input.GroupExercises != null &&
                    this.GroupExercises.SequenceEqual(input.GroupExercises)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.GroupExercises != null)
                    hashCode = hashCode * 59 + this.GroupExercises.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
