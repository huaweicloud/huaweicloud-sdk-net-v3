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
    public class ListClassroomMemberJobsRequest 
    {

        /// <summary>
        /// 课堂ID
        /// </summary>
        [SDKProperty("classroom_id", IsPath = true)]
        [JsonProperty("classroom_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassroomId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [SDKProperty("member_id", IsQuery = true)]
        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberId { get; set; }

        /// <summary>
        /// 信息记录的起始编号
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页包含的信息记录数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListClassroomMemberJobsRequest {\n");
            sb.Append("  classroomId: ").Append(ClassroomId).Append("\n");
            sb.Append("  memberId: ").Append(MemberId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListClassroomMemberJobsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListClassroomMemberJobsRequest input)
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
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.MemberId != null)
                    hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
