using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 成员详情
    /// </summary>
    public class GroupMemberEntity 
    {

        /// <summary>
        /// 成员Id
        /// </summary>
        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberId { get; set; }

        /// <summary>
        /// 客户端Id
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMemberEntity {\n");
            sb.Append("  memberId: ").Append(MemberId).Append("\n");
            sb.Append("  clientId: ").Append(ClientId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMemberEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupMemberEntity input)
        {
            if (input == null) return false;
            if (this.MemberId != input.MemberId || (this.MemberId != null && !this.MemberId.Equals(input.MemberId))) return false;
            if (this.ClientId != input.ClientId || (this.ClientId != null && !this.ClientId.Equals(input.ClientId))) return false;

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
                if (this.MemberId != null) hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                return hashCode;
            }
        }
    }
}
