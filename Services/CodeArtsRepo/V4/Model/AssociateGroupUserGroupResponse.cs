using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AssociateGroupUserGroupResponse : SdkResponse
    {

        /// <summary>
        /// 关联成功成员列表
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public List<MemberBaseDto> Success { get; set; }

        /// <summary>
        /// 关联失败成员列表
        /// </summary>
        [JsonProperty("failure", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailureForBatchCreateGroupMembersDto> Failure { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateGroupUserGroupResponse {\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  failure: ").Append(Failure).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateGroupUserGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateGroupUserGroupResponse input)
        {
            if (input == null) return false;
            if (this.Success != input.Success || (this.Success != null && input.Success != null && !this.Success.SequenceEqual(input.Success))) return false;
            if (this.Failure != input.Failure || (this.Failure != null && input.Failure != null && !this.Failure.SequenceEqual(input.Failure))) return false;

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
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Failure != null) hashCode = hashCode * 59 + this.Failure.GetHashCode();
                return hashCode;
            }
        }
    }
}
