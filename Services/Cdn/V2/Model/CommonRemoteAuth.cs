using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 远程鉴权配置。
    /// </summary>
    public class CommonRemoteAuth 
    {

        /// <summary>
        /// 是否开启远程鉴权(on：开启，off：关闭)。
        /// </summary>
        [JsonProperty("remote_authentication", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteAuthentication { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("remote_auth_rules", NullValueHandling = NullValueHandling.Ignore)]
        public RemoteAuthRule RemoteAuthRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonRemoteAuth {\n");
            sb.Append("  remoteAuthentication: ").Append(RemoteAuthentication).Append("\n");
            sb.Append("  remoteAuthRules: ").Append(RemoteAuthRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommonRemoteAuth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommonRemoteAuth input)
        {
            if (input == null) return false;
            if (this.RemoteAuthentication != input.RemoteAuthentication || (this.RemoteAuthentication != null && !this.RemoteAuthentication.Equals(input.RemoteAuthentication))) return false;
            if (this.RemoteAuthRules != input.RemoteAuthRules || (this.RemoteAuthRules != null && !this.RemoteAuthRules.Equals(input.RemoteAuthRules))) return false;

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
                if (this.RemoteAuthentication != null) hashCode = hashCode * 59 + this.RemoteAuthentication.GetHashCode();
                if (this.RemoteAuthRules != null) hashCode = hashCode * 59 + this.RemoteAuthRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
