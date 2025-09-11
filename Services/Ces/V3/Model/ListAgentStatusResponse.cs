using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAgentStatusResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: agent插件状态列表 **取值范围**: 数组长度为[1,2000] 
        /// </summary>
        [JsonProperty("agent_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgentStatusInfo> AgentStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgentStatusResponse {\n");
            sb.Append("  agentStatus: ").Append(AgentStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgentStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgentStatusResponse input)
        {
            if (input == null) return false;
            if (this.AgentStatus != input.AgentStatus || (this.AgentStatus != null && input.AgentStatus != null && !this.AgentStatus.SequenceEqual(input.AgentStatus))) return false;

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
                if (this.AgentStatus != null) hashCode = hashCode * 59 + this.AgentStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
