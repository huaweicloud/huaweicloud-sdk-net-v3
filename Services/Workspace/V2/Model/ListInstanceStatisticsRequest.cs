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
    /// Request Object
    /// </summary>
    public class ListInstanceStatisticsRequest 
    {

        /// <summary>
        /// Agent 类型
        /// </summary>
        [SDKProperty("ai_agent_type", IsQuery = true)]
        [JsonProperty("ai_agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AiAgentType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceStatisticsRequest {\n");
            sb.Append("  aiAgentType: ").Append(AiAgentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceStatisticsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceStatisticsRequest input)
        {
            if (input == null) return false;
            if (this.AiAgentType != input.AiAgentType || (this.AiAgentType != null && !this.AiAgentType.Equals(input.AiAgentType))) return false;

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
                if (this.AiAgentType != null) hashCode = hashCode * 59 + this.AiAgentType.GetHashCode();
                return hashCode;
            }
        }
    }
}
