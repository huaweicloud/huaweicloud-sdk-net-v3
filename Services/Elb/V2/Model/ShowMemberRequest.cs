using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMemberRequest 
    {

        /// <summary>
        /// 后端云服务器组id
        /// </summary>
        [SDKProperty("pool_id", IsPath = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 后端云服务器id
        /// </summary>
        [SDKProperty("member_id", IsPath = true)]
        [JsonProperty("member_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMemberRequest {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  memberId: ").Append(MemberId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMemberRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMemberRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
                ) && 
                (
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
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
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.MemberId != null)
                    hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                return hashCode;
            }
        }
    }
}
