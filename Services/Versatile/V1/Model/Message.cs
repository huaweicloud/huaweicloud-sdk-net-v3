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
    /// 
    /// </summary>
    public class Message 
    {

        /// <summary>
        /// 角色
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 工具名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Object Name { get; set; }

        /// <summary>
        /// 工具调用信息
        /// </summary>
        [JsonProperty("function_call", NullValueHandling = NullValueHandling.Ignore)]
        public Object FunctionCall { get; set; }

        /// <summary>
        /// 工具调用信息
        /// </summary>
        [JsonProperty("tool_calls", NullValueHandling = NullValueHandling.Ignore)]
        public Object ToolCalls { get; set; }

        /// <summary>
        /// 工具调用ID信息
        /// </summary>
        [JsonProperty("tool_call_id", NullValueHandling = NullValueHandling.Ignore)]
        public Object ToolCallId { get; set; }

        /// <summary>
        /// 是否开启会话历史
        /// </summary>
        [JsonProperty("enable_history", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Intent { get; set; }

        /// <summary>
        /// 对话ID
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// agent id
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// 评分，-1（点赞）、1（点踩）
        /// </summary>
        [JsonProperty("rating", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rating { get; set; }

        /// <summary>
        /// 多模态文件列表
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public FeedbackReason Reason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  functionCall: ").Append(FunctionCall).Append("\n");
            sb.Append("  toolCalls: ").Append(ToolCalls).Append("\n");
            sb.Append("  toolCallId: ").Append(ToolCallId).Append("\n");
            sb.Append("  enableHistory: ").Append(EnableHistory).Append("\n");
            sb.Append("  intent: ").Append(Intent).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  rating: ").Append(Rating).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Message input)
        {
            if (input == null) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.FunctionCall != input.FunctionCall || (this.FunctionCall != null && !this.FunctionCall.Equals(input.FunctionCall))) return false;
            if (this.ToolCalls != input.ToolCalls || (this.ToolCalls != null && !this.ToolCalls.Equals(input.ToolCalls))) return false;
            if (this.ToolCallId != input.ToolCallId || (this.ToolCallId != null && !this.ToolCallId.Equals(input.ToolCallId))) return false;
            if (this.EnableHistory != input.EnableHistory || (this.EnableHistory != null && !this.EnableHistory.Equals(input.EnableHistory))) return false;
            if (this.Intent != input.Intent || (this.Intent != null && input.Intent != null && !this.Intent.SequenceEqual(input.Intent))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.Rating != input.Rating || (this.Rating != null && !this.Rating.Equals(input.Rating))) return false;
            if (this.Files != input.Files || (this.Files != null && input.Files != null && !this.Files.SequenceEqual(input.Files))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;

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
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FunctionCall != null) hashCode = hashCode * 59 + this.FunctionCall.GetHashCode();
                if (this.ToolCalls != null) hashCode = hashCode * 59 + this.ToolCalls.GetHashCode();
                if (this.ToolCallId != null) hashCode = hashCode * 59 + this.ToolCallId.GetHashCode();
                if (this.EnableHistory != null) hashCode = hashCode * 59 + this.EnableHistory.GetHashCode();
                if (this.Intent != null) hashCode = hashCode * 59 + this.Intent.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.Rating != null) hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.Files != null) hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                return hashCode;
            }
        }
    }
}
