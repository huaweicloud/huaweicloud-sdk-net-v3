using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// MCP服务端对接配置基础信息。
    /// </summary>
    public class McpServerBaseInfo 
    {

        /// <summary>
        /// MCP服务端对接配置ID。
        /// </summary>
        [JsonProperty("mcp_server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string McpServerId { get; set; }

        /// <summary>
        /// MCP服务端对接配置名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class McpServerBaseInfo {\n");
            sb.Append("  mcpServerId: ").Append(McpServerId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as McpServerBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(McpServerBaseInfo input)
        {
            if (input == null) return false;
            if (this.McpServerId != input.McpServerId || (this.McpServerId != null && !this.McpServerId.Equals(input.McpServerId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.McpServerId != null) hashCode = hashCode * 59 + this.McpServerId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
