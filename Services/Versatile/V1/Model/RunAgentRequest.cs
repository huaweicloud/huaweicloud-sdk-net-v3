using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class RunAgentRequest 
    {

        /// <summary>
        /// **参数解释**： 智能体ID  **取值范围**： 由英文，数字，“-”，“_”组成，不超过64位字符。
        /// </summary>
        [SDKProperty("agent_id", IsPath = true)]
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// **参数解释**： 会话ID，历史对话记忆功能基于同一个会话  **取值范围**： 由英文，数字，“-”，“_”组成，不超过64位字符。
        /// </summary>
        [SDKProperty("conversation_id", IsPath = true)]
        [JsonProperty("conversation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConversationId { get; set; }

        /// <summary>
        /// **参数解释**： 空间ID，当前资源所属工作空间  **取值范围**： 由英文，数字，“-”，“_”组成，不超过64位字符。
        /// </summary>
        [SDKProperty("workspace_id", IsQuery = true)]
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**： 运行的智能体/工作流的发布版本号，默认运行最新发布版本  **取值范围**： 不涉及
        /// </summary>
        [SDKProperty("version", IsQuery = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 指定运行的智能体是单智能体还是多智能体，默认 agent  **取值范围**： agent, controller
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 是否流式响应  **取值范围**： true,false（不传默认 true，支持流式）
        /// </summary>
        [SDKProperty("stream", IsHeader = true)]
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public AgentRunReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunAgentRequest {\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  conversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunAgentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunAgentRequest input)
        {
            if (input == null) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.ConversationId != input.ConversationId || (this.ConversationId != null && !this.ConversationId.Equals(input.ConversationId))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Stream != input.Stream || (this.Stream != null && !this.Stream.Equals(input.Stream))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.ConversationId != null) hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Stream != null) hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
