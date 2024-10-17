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
    public class AgentRegisterReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("agent", NullValueHandling = NullValueHandling.Ignore)]
        public AgentRegister Agent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentRegisterReq {\n");
            sb.Append("  agent: ").Append(Agent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentRegisterReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentRegisterReq input)
        {
            if (input == null) return false;
            if (this.Agent != input.Agent || (this.Agent != null && !this.Agent.Equals(input.Agent))) return false;

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
                if (this.Agent != null) hashCode = hashCode * 59 + this.Agent.GetHashCode();
                return hashCode;
            }
        }
    }
}
