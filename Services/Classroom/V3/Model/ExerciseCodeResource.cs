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
    /// 习题详细内容
    /// </summary>
    public class ExerciseCodeResource 
    {

        /// <summary>
        /// 习题内容存储id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 资源聚合id
        /// </summary>
        [JsonProperty("polymeric_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolymericResourceId { get; set; }

        /// <summary>
        /// 习题内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 参考答案
        /// </summary>
        [JsonProperty("code_answer", NullValueHandling = NullValueHandling.Ignore)]
        public string CodeAnswer { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExerciseCodeResource {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  polymericResourceId: ").Append(PolymericResourceId).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  codeAnswer: ").Append(CodeAnswer).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExerciseCodeResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExerciseCodeResource input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PolymericResourceId != input.PolymericResourceId || (this.PolymericResourceId != null && !this.PolymericResourceId.Equals(input.PolymericResourceId))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.CodeAnswer != input.CodeAnswer || (this.CodeAnswer != null && !this.CodeAnswer.Equals(input.CodeAnswer))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PolymericResourceId != null) hashCode = hashCode * 59 + this.PolymericResourceId.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CodeAnswer != null) hashCode = hashCode * 59 + this.CodeAnswer.GetHashCode();
                return hashCode;
            }
        }
    }
}
