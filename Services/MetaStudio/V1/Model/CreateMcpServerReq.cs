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
    /// 创建MCP服务端对接配置请求。
    /// </summary>
    public class CreateMcpServerReq 
    {

        /// <summary>
        /// MCP服务端对接配置名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// MCP服务端地址。
        /// </summary>
        [JsonProperty("mcp_server_url", NullValueHandling = NullValueHandling.Ignore)]
        public string McpServerUrl { get; set; }

        /// <summary>
        /// 鉴权头域名称。
        /// </summary>
        [JsonProperty("auth_header_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthHeaderName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMcpServerReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  mcpServerUrl: ").Append(McpServerUrl).Append("\n");
            sb.Append("  authHeaderName: ").Append(AuthHeaderName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMcpServerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMcpServerReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.McpServerUrl != input.McpServerUrl || (this.McpServerUrl != null && !this.McpServerUrl.Equals(input.McpServerUrl))) return false;
            if (this.AuthHeaderName != input.AuthHeaderName || (this.AuthHeaderName != null && !this.AuthHeaderName.Equals(input.AuthHeaderName))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.McpServerUrl != null) hashCode = hashCode * 59 + this.McpServerUrl.GetHashCode();
                if (this.AuthHeaderName != null) hashCode = hashCode * 59 + this.AuthHeaderName.GetHashCode();
                return hashCode;
            }
        }
    }
}
