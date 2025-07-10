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
    /// 
    /// </summary>
    public class AgentInfo 
    {

        /// <summary>
        /// 插件名称。
        /// </summary>
        [JsonProperty("agent_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentName { get; set; }

        /// <summary>
        /// 插件版本。
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 是否安装插件（是否）。
        /// </summary>
        [JsonProperty("is_installed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInstalled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentInfo {\n");
            sb.Append("  agentName: ").Append(AgentName).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  isInstalled: ").Append(IsInstalled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentInfo input)
        {
            if (input == null) return false;
            if (this.AgentName != input.AgentName || (this.AgentName != null && !this.AgentName.Equals(input.AgentName))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.IsInstalled != input.IsInstalled || (this.IsInstalled != null && !this.IsInstalled.Equals(input.IsInstalled))) return false;

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
                if (this.AgentName != null) hashCode = hashCode * 59 + this.AgentName.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.IsInstalled != null) hashCode = hashCode * 59 + this.IsInstalled.GetHashCode();
                return hashCode;
            }
        }
    }
}
