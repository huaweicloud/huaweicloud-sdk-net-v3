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
    /// Request Object
    /// </summary>
    public class ExecuteExerciseRequest 
    {

        /// <summary>
        /// 具体调用者的用户token
        /// </summary>
        [SDKProperty("user-token", IsHeader = true)]
        [JsonProperty("user-token", NullValueHandling = NullValueHandling.Ignore)]
        public string UserToken { get; set; }

        /// <summary>
        /// 需判题的习题id
        /// </summary>
        [SDKProperty("exercise_id", IsPath = true)]
        [JsonProperty("exercise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExerciseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public PackageExerciseJudgeRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteExerciseRequest {\n");
            sb.Append("  userToken: ").Append(UserToken).Append("\n");
            sb.Append("  exerciseId: ").Append(ExerciseId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteExerciseRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteExerciseRequest input)
        {
            if (input == null) return false;
            if (this.UserToken != input.UserToken || (this.UserToken != null && !this.UserToken.Equals(input.UserToken))) return false;
            if (this.ExerciseId != input.ExerciseId || (this.ExerciseId != null && !this.ExerciseId.Equals(input.ExerciseId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.UserToken != null) hashCode = hashCode * 59 + this.UserToken.GetHashCode();
                if (this.ExerciseId != null) hashCode = hashCode * 59 + this.ExerciseId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
