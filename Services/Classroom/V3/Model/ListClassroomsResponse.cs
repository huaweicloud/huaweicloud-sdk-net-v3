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
    public class ListClassroomsResponse : SdkResponse
    {

        /// <summary>
        /// 课堂列表
        /// </summary>
        [JsonProperty("classrooms", NullValueHandling = NullValueHandling.Ignore)]
        public List<ClassroomCard> Classrooms { get; set; }

        /// <summary>
        /// 课堂总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListClassroomsResponse {\n");
            sb.Append("  classrooms: ").Append(Classrooms).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListClassroomsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListClassroomsResponse input)
        {
            if (input == null) return false;
            if (this.Classrooms != input.Classrooms || (this.Classrooms != null && input.Classrooms != null && !this.Classrooms.SequenceEqual(input.Classrooms))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Classrooms != null) hashCode = hashCode * 59 + this.Classrooms.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
