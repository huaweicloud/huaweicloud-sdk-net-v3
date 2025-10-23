using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRestartPolicyResponse : SdkResponse
    {

        /// <summary>
        /// 是否重启虚拟机。
        /// </summary>
        [JsonProperty("restart_server", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartServer { get; set; }

        /// <summary>
        /// 重启策略。
        /// </summary>
        [JsonProperty("restart_policy", NullValueHandling = NullValueHandling.Ignore)]
        public Object RestartPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRestartPolicyResponse {\n");
            sb.Append("  restartServer: ").Append(RestartServer).Append("\n");
            sb.Append("  restartPolicy: ").Append(RestartPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRestartPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRestartPolicyResponse input)
        {
            if (input == null) return false;
            if (this.RestartServer != input.RestartServer || (this.RestartServer != null && !this.RestartServer.Equals(input.RestartServer))) return false;
            if (this.RestartPolicy != input.RestartPolicy || (this.RestartPolicy != null && !this.RestartPolicy.Equals(input.RestartPolicy))) return false;

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
                if (this.RestartServer != null) hashCode = hashCode * 59 + this.RestartServer.GetHashCode();
                if (this.RestartPolicy != null) hashCode = hashCode * 59 + this.RestartPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
