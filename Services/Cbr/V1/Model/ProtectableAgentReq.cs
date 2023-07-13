using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProtectableAgentReq 
    {

        /// <summary>
        /// 查询参数列表
        /// </summary>
        [JsonProperty("agent_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProtectableAgentStatusResource> AgentStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtectableAgentReq {\n");
            sb.Append("  agentStatus: ").Append(AgentStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtectableAgentReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtectableAgentReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentStatus == input.AgentStatus ||
                    this.AgentStatus != null &&
                    input.AgentStatus != null &&
                    this.AgentStatus.SequenceEqual(input.AgentStatus)
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
                if (this.AgentStatus != null)
                    hashCode = hashCode * 59 + this.AgentStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
