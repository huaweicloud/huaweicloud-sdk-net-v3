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
    public class ClassroomCard 
    {

        /// <summary>
        /// 课堂ID
        /// </summary>
        [JsonProperty("classroom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassroomId { get; set; }

        /// <summary>
        /// 课堂名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 课堂描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 课堂学分
        /// </summary>
        [JsonProperty("credit", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Credit { get; set; }

        /// <summary>
        /// 课堂当前的状态，normal：课堂处于正常状态，archive：课堂已归档
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClassroomCard {\n");
            sb.Append("  classroomId: ").Append(ClassroomId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  credit: ").Append(Credit).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClassroomCard);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClassroomCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClassroomId == input.ClassroomId ||
                    (this.ClassroomId != null &&
                    this.ClassroomId.Equals(input.ClassroomId))
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
                    this.Credit == input.Credit ||
                    (this.Credit != null &&
                    this.Credit.Equals(input.Credit))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ClassroomId != null)
                    hashCode = hashCode * 59 + this.ClassroomId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Credit != null)
                    hashCode = hashCode * 59 + this.Credit.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
