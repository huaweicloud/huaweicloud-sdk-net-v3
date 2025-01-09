using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 终端类型登录管控。
    /// </summary>
    public class PoliciesClientClientType 
    {

        /// <summary>
        /// 是否开启终端类型登录管控。 false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("client_type_limit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClientTypeLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public PoliciesClientClientTypeOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesClientClientType {\n");
            sb.Append("  clientTypeLimit: ").Append(ClientTypeLimit).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesClientClientType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesClientClientType input)
        {
            if (input == null) return false;
            if (this.ClientTypeLimit != input.ClientTypeLimit || (this.ClientTypeLimit != null && !this.ClientTypeLimit.Equals(input.ClientTypeLimit))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.ClientTypeLimit != null) hashCode = hashCode * 59 + this.ClientTypeLimit.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
