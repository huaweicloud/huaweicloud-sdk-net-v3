using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMemberGroupAndStreamRequest 
    {

        /// <summary>
        /// 成员账号ID
        /// </summary>
        [SDKProperty("member_account_id", IsPath = true)]
        [JsonProperty("member_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberAccountId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMemberGroupAndStreamRequest {\n");
            sb.Append("  memberAccountId: ").Append(MemberAccountId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMemberGroupAndStreamRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMemberGroupAndStreamRequest input)
        {
            if (input == null) return false;
            if (this.MemberAccountId != input.MemberAccountId || (this.MemberAccountId != null && !this.MemberAccountId.Equals(input.MemberAccountId))) return false;

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
                if (this.MemberAccountId != null) hashCode = hashCode * 59 + this.MemberAccountId.GetHashCode();
                return hashCode;
            }
        }
    }
}
