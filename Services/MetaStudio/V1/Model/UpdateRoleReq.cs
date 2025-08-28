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
    /// 修改角色请求。
    /// </summary>
    public class UpdateRoleReq 
    {

        /// <summary>
        /// 角色名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 角色描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 角色业务配置列表
        /// </summary>
        [JsonProperty("role_business_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RoleBusinessReq> RoleBusinessList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("llm_source", NullValueHandling = NullValueHandling.Ignore)]
        public LlmSourceEnum LlmSource { get; set; }
        /// <summary>
        /// 大语言模型配置ID。
        /// </summary>
        [JsonProperty("llm_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LlmConfigId { get; set; }

        /// <summary>
        /// 插件配置列表
        /// </summary>
        [JsonProperty("plugin_config_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RolePluginConfigInfo> PluginConfigList { get; set; }

        /// <summary>
        /// MCP服务端对接配置ID列表
        /// </summary>
        [JsonProperty("mcp_server_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> McpServerIdList { get; set; }

        /// <summary>
        /// 指令集ID。
        /// </summary>
        [JsonProperty("instruction_library_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstructionLibraryId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRoleReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  roleBusinessList: ").Append(RoleBusinessList).Append("\n");
            sb.Append("  llmSource: ").Append(LlmSource).Append("\n");
            sb.Append("  llmConfigId: ").Append(LlmConfigId).Append("\n");
            sb.Append("  pluginConfigList: ").Append(PluginConfigList).Append("\n");
            sb.Append("  mcpServerIdList: ").Append(McpServerIdList).Append("\n");
            sb.Append("  instructionLibraryId: ").Append(InstructionLibraryId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRoleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRoleReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RoleBusinessList != input.RoleBusinessList || (this.RoleBusinessList != null && input.RoleBusinessList != null && !this.RoleBusinessList.SequenceEqual(input.RoleBusinessList))) return false;
            if (this.LlmSource != input.LlmSource) return false;
            if (this.LlmConfigId != input.LlmConfigId || (this.LlmConfigId != null && !this.LlmConfigId.Equals(input.LlmConfigId))) return false;
            if (this.PluginConfigList != input.PluginConfigList || (this.PluginConfigList != null && input.PluginConfigList != null && !this.PluginConfigList.SequenceEqual(input.PluginConfigList))) return false;
            if (this.McpServerIdList != input.McpServerIdList || (this.McpServerIdList != null && input.McpServerIdList != null && !this.McpServerIdList.SequenceEqual(input.McpServerIdList))) return false;
            if (this.InstructionLibraryId != input.InstructionLibraryId || (this.InstructionLibraryId != null && !this.InstructionLibraryId.Equals(input.InstructionLibraryId))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RoleBusinessList != null) hashCode = hashCode * 59 + this.RoleBusinessList.GetHashCode();
                hashCode = hashCode * 59 + this.LlmSource.GetHashCode();
                if (this.LlmConfigId != null) hashCode = hashCode * 59 + this.LlmConfigId.GetHashCode();
                if (this.PluginConfigList != null) hashCode = hashCode * 59 + this.PluginConfigList.GetHashCode();
                if (this.McpServerIdList != null) hashCode = hashCode * 59 + this.McpServerIdList.GetHashCode();
                if (this.InstructionLibraryId != null) hashCode = hashCode * 59 + this.InstructionLibraryId.GetHashCode();
                return hashCode;
            }
        }
    }
}
