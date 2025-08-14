using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// Indicates whether a resource is a member of a group in the identity store.
    /// </summary>
    public class GroupMembershipExistenceResultDto 
    {

        /// <summary>
        /// 身份源中IdentityCenter用户组的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public MemberIdDto MemberId { get; set; }

        /// <summary>
        /// 一个布尔值，表示用户是否在组中
        /// </summary>
        [JsonProperty("membership_exists", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MembershipExists { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMembershipExistenceResultDto {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  memberId: ").Append(MemberId).Append("\n");
            sb.Append("  membershipExists: ").Append(MembershipExists).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMembershipExistenceResultDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupMembershipExistenceResultDto input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.MemberId != input.MemberId || (this.MemberId != null && !this.MemberId.Equals(input.MemberId))) return false;
            if (this.MembershipExists != input.MembershipExists || (this.MembershipExists != null && !this.MembershipExists.Equals(input.MembershipExists))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.MemberId != null) hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.MembershipExists != null) hashCode = hashCode * 59 + this.MembershipExists.GetHashCode();
                return hashCode;
            }
        }
    }
}
