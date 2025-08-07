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
    public class AgentUpgradeParam 
    {

        /// <summary>
        /// UniAgent升级的版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// UniAgent主机列表信息。
        /// </summary>
        [JsonProperty("agent_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SingleAgentParam> AgentList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentUpgradeParam {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  agentList: ").Append(AgentList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentUpgradeParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentUpgradeParam input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.AgentList != input.AgentList || (this.AgentList != null && input.AgentList != null && !this.AgentList.SequenceEqual(input.AgentList))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.AgentList != null) hashCode = hashCode * 59 + this.AgentList.GetHashCode();
                return hashCode;
            }
        }
    }
}
