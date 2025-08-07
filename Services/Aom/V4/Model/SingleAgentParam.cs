using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SingleAgentParam 
    {

        /// <summary>
        /// agent ID唯一值。
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// 主机ip。
        /// </summary>
        [JsonProperty("inner_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string InnerIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleAgentParam {\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  innerIp: ").Append(InnerIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SingleAgentParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SingleAgentParam input)
        {
            if (input == null) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.InnerIp != input.InnerIp || (this.InnerIp != null && !this.InnerIp.Equals(input.InnerIp))) return false;

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
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.InnerIp != null) hashCode = hashCode * 59 + this.InnerIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
