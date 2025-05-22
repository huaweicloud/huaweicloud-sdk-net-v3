using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateMemberHealthCheckJobResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("member_check", NullValueHandling = NullValueHandling.Ignore)]
        public MemberCheckJob MemberCheck { get; set; }

        /// <summary>
        /// 参数解释：请求ID。  注：自动生成 。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMemberHealthCheckJobResponse {\n");
            sb.Append("  memberCheck: ").Append(MemberCheck).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMemberHealthCheckJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMemberHealthCheckJobResponse input)
        {
            if (input == null) return false;
            if (this.MemberCheck != input.MemberCheck || (this.MemberCheck != null && !this.MemberCheck.Equals(input.MemberCheck))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;

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
                if (this.MemberCheck != null) hashCode = hashCode * 59 + this.MemberCheck.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
