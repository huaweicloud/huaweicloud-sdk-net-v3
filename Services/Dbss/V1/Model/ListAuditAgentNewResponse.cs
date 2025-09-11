using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAuditAgentNewResponse : SdkResponse
    {

        /// <summary>
        /// agent列表
        /// </summary>
        [JsonProperty("agents", NullValueHandling = NullValueHandling.Ignore)]
        public List<AuditAgentRespoonseAgents> Agents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditAgentNewResponse {\n");
            sb.Append("  agents: ").Append(Agents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuditAgentNewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuditAgentNewResponse input)
        {
            if (input == null) return false;
            if (this.Agents != input.Agents || (this.Agents != null && input.Agents != null && !this.Agents.SequenceEqual(input.Agents))) return false;

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
                if (this.Agents != null) hashCode = hashCode * 59 + this.Agents.GetHashCode();
                return hashCode;
            }
        }
    }
}
