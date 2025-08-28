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
    /// **参数解释**：创建后端服务器检测任务请求body体。
    /// </summary>
    public class CreateMemberHealthCheckJobRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("member_check", NullValueHandling = NullValueHandling.Ignore)]
        public CreateMemberHealthCheckJobOption MemberCheck { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMemberHealthCheckJobRequestBody {\n");
            sb.Append("  memberCheck: ").Append(MemberCheck).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMemberHealthCheckJobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMemberHealthCheckJobRequestBody input)
        {
            if (input == null) return false;
            if (this.MemberCheck != input.MemberCheck || (this.MemberCheck != null && !this.MemberCheck.Equals(input.MemberCheck))) return false;

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
                return hashCode;
            }
        }
    }
}
