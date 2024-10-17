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
    /// 
    /// </summary>
    public class ShowGroupsRespGroupMembers 
    {

        /// <summary>
        /// 消费组consumer地址。
        /// </summary>
        [JsonProperty("host", NullValueHandling = NullValueHandling.Ignore)]
        public string Host { get; set; }

        /// <summary>
        /// consumer分配到的分区信息。
        /// </summary>
        [JsonProperty("assignment", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowGroupsRespGroupAssignment> Assignment { get; set; }

        /// <summary>
        /// 消费组consumer的ID。
        /// </summary>
        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberId { get; set; }

        /// <summary>
        /// 客户端ID。
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGroupsRespGroupMembers {\n");
            sb.Append("  host: ").Append(Host).Append("\n");
            sb.Append("  assignment: ").Append(Assignment).Append("\n");
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
            return this.Equals(input as ShowGroupsRespGroupMembers);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGroupsRespGroupMembers input)
        {
            if (input == null) return false;
            if (this.Host != input.Host || (this.Host != null && !this.Host.Equals(input.Host))) return false;
            if (this.Assignment != input.Assignment || (this.Assignment != null && input.Assignment != null && !this.Assignment.SequenceEqual(input.Assignment))) return false;
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
                if (this.Host != null) hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Assignment != null) hashCode = hashCode * 59 + this.Assignment.GetHashCode();
                if (this.MemberId != null) hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.ClientId != null) hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                return hashCode;
            }
        }
    }
}
