using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAgencyPolicyRequestBody 
    {

        /// <summary>
        /// **参数解释**: 委托解绑的权限策略集合。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("unbind_role_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnbindRoleNames { get; set; }

        /// <summary>
        /// **参数解释**: 委托绑定的权限策略集合。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("bind_role_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BindRoleNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAgencyPolicyRequestBody {\n");
            sb.Append("  unbindRoleNames: ").Append(UnbindRoleNames).Append("\n");
            sb.Append("  bindRoleNames: ").Append(BindRoleNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAgencyPolicyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAgencyPolicyRequestBody input)
        {
            if (input == null) return false;
            if (this.UnbindRoleNames != input.UnbindRoleNames || (this.UnbindRoleNames != null && input.UnbindRoleNames != null && !this.UnbindRoleNames.SequenceEqual(input.UnbindRoleNames))) return false;
            if (this.BindRoleNames != input.BindRoleNames || (this.BindRoleNames != null && input.BindRoleNames != null && !this.BindRoleNames.SequenceEqual(input.BindRoleNames))) return false;

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
                if (this.UnbindRoleNames != null) hashCode = hashCode * 59 + this.UnbindRoleNames.GetHashCode();
                if (this.BindRoleNames != null) hashCode = hashCode * 59 + this.BindRoleNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
