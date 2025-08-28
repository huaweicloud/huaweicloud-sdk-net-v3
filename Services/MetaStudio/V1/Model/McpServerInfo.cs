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
    /// MCP服务端对接配置基本信息。
    /// </summary>
    public class McpServerInfo 
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
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class McpServerInfo {\n");
            sb.Append("  mcpServerId: ").Append(McpServerId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  mcpServerUrl: ").Append(McpServerUrl).Append("\n");
            sb.Append("  authHeaderName: ").Append(AuthHeaderName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as McpServerInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(McpServerInfo input)
        {
            if (input == null) return false;
            if (this.McpServerId != input.McpServerId || (this.McpServerId != null && !this.McpServerId.Equals(input.McpServerId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.McpServerUrl != input.McpServerUrl || (this.McpServerUrl != null && !this.McpServerUrl.Equals(input.McpServerUrl))) return false;
            if (this.AuthHeaderName != input.AuthHeaderName || (this.AuthHeaderName != null && !this.AuthHeaderName.Equals(input.AuthHeaderName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.McpServerUrl != null) hashCode = hashCode * 59 + this.McpServerUrl.GetHashCode();
                if (this.AuthHeaderName != null) hashCode = hashCode * 59 + this.AuthHeaderName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
