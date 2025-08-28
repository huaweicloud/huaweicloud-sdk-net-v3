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
    /// **参数解释**：后端服务器检测任务各检查项的检测结果。
    /// </summary>
    public class MemberCheckJobResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public MemberCheckJobResultGroup Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("acl", NullValueHandling = NullValueHandling.Ignore)]
        public MemberCheckJobResultGroup Acl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_group", NullValueHandling = NullValueHandling.Ignore)]
        public MemberCheckJobResultGroup SecurityGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberCheckJobResult {\n");
            sb.Append("  config: ").Append(Config).Append("\n");
            sb.Append("  acl: ").Append(Acl).Append("\n");
            sb.Append("  securityGroup: ").Append(SecurityGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberCheckJobResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MemberCheckJobResult input)
        {
            if (input == null) return false;
            if (this.Config != input.Config || (this.Config != null && !this.Config.Equals(input.Config))) return false;
            if (this.Acl != input.Acl || (this.Acl != null && !this.Acl.Equals(input.Acl))) return false;
            if (this.SecurityGroup != input.SecurityGroup || (this.SecurityGroup != null && !this.SecurityGroup.Equals(input.SecurityGroup))) return false;

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
                if (this.Config != null) hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.Acl != null) hashCode = hashCode * 59 + this.Acl.GetHashCode();
                if (this.SecurityGroup != null) hashCode = hashCode * 59 + this.SecurityGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
