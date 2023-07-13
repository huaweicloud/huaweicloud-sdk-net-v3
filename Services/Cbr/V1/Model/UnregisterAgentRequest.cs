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
    /// Request Object
    /// </summary>
    public class UnregisterAgentRequest 
    {

        /// <summary>
        /// 客户端ID
        /// </summary>
        [SDKProperty("agent_id", IsPath = true)]
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnregisterAgentRequest {\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnregisterAgentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnregisterAgentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
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
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
