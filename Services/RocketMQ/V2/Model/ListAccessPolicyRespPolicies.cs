using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListAccessPolicyRespPolicies 
    {

        /// <summary>
        /// **参数解释**： 用户名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// **参数解释**： IP白名单。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("white_remote_address", NullValueHandling = NullValueHandling.Ignore)]
        public string WhiteRemoteAddress { get; set; }

        /// <summary>
        /// **参数解释**： 是否为管理员。 **约束限制**： 不涉及。 **取值范围**： - true：是管理员。 - false：不是管理员。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin { get; set; }

        /// <summary>
        /// **参数解释**： 用户权限。 **约束限制**： 不涉及。 **取值范围**： - PUB：拥有发布权限。 - SUB：拥有订阅权限。 - PUB|SUB：拥有发布订阅权限。 - DENY：无权限。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("perm", NullValueHandling = NullValueHandling.Ignore)]
        public string Perm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccessPolicyRespPolicies {\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  whiteRemoteAddress: ").Append(WhiteRemoteAddress).Append("\n");
            sb.Append("  admin: ").Append(Admin).Append("\n");
            sb.Append("  perm: ").Append(Perm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccessPolicyRespPolicies);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccessPolicyRespPolicies input)
        {
            if (input == null) return false;
            if (this.AccessKey != input.AccessKey || (this.AccessKey != null && !this.AccessKey.Equals(input.AccessKey))) return false;
            if (this.WhiteRemoteAddress != input.WhiteRemoteAddress || (this.WhiteRemoteAddress != null && !this.WhiteRemoteAddress.Equals(input.WhiteRemoteAddress))) return false;
            if (this.Admin != input.Admin || (this.Admin != null && !this.Admin.Equals(input.Admin))) return false;
            if (this.Perm != input.Perm || (this.Perm != null && !this.Perm.Equals(input.Perm))) return false;

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
                if (this.AccessKey != null) hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.WhiteRemoteAddress != null) hashCode = hashCode * 59 + this.WhiteRemoteAddress.GetHashCode();
                if (this.Admin != null) hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.Perm != null) hashCode = hashCode * 59 + this.Perm.GetHashCode();
                return hashCode;
            }
        }
    }
}
