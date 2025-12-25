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
    public class WorkflowRunReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("memory_inputs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> MemoryInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("globals", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Globals { get; set; }

        /// <summary>
        /// user消息
        /// </summary>
        [JsonProperty("messages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Message> Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_profile", NullValueHandling = NullValueHandling.Ignore)]
        public UserProfile UserProfile { get; set; }

        /// <summary>
        /// 插件参数数组
        /// </summary>
        [JsonProperty("plugin_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<PluginConfig> PluginConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("userId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("conversation", NullValueHandling = NullValueHandling.Ignore)]
        public Conversation Conversation { get; set; }

        /// <summary>
        /// 会话历史写入
        /// </summary>
        [JsonProperty("enable_history", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHistory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowRunReq {\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  memoryInputs: ").Append(MemoryInputs).Append("\n");
            sb.Append("  globals: ").Append(Globals).Append("\n");
            sb.Append("  messages: ").Append(Messages).Append("\n");
            sb.Append("  userProfile: ").Append(UserProfile).Append("\n");
            sb.Append("  pluginConfigs: ").Append(PluginConfigs).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  conversation: ").Append(Conversation).Append("\n");
            sb.Append("  enableHistory: ").Append(EnableHistory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowRunReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowRunReq input)
        {
            if (input == null) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.MemoryInputs != input.MemoryInputs || (this.MemoryInputs != null && input.MemoryInputs != null && !this.MemoryInputs.SequenceEqual(input.MemoryInputs))) return false;
            if (this.Globals != input.Globals || (this.Globals != null && input.Globals != null && !this.Globals.SequenceEqual(input.Globals))) return false;
            if (this.Messages != input.Messages || (this.Messages != null && input.Messages != null && !this.Messages.SequenceEqual(input.Messages))) return false;
            if (this.UserProfile != input.UserProfile || (this.UserProfile != null && !this.UserProfile.Equals(input.UserProfile))) return false;
            if (this.PluginConfigs != input.PluginConfigs || (this.PluginConfigs != null && input.PluginConfigs != null && !this.PluginConfigs.SequenceEqual(input.PluginConfigs))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.Conversation != input.Conversation || (this.Conversation != null && !this.Conversation.Equals(input.Conversation))) return false;
            if (this.EnableHistory != input.EnableHistory || (this.EnableHistory != null && !this.EnableHistory.Equals(input.EnableHistory))) return false;

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
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.MemoryInputs != null) hashCode = hashCode * 59 + this.MemoryInputs.GetHashCode();
                if (this.Globals != null) hashCode = hashCode * 59 + this.Globals.GetHashCode();
                if (this.Messages != null) hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.UserProfile != null) hashCode = hashCode * 59 + this.UserProfile.GetHashCode();
                if (this.PluginConfigs != null) hashCode = hashCode * 59 + this.PluginConfigs.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Conversation != null) hashCode = hashCode * 59 + this.Conversation.GetHashCode();
                if (this.EnableHistory != null) hashCode = hashCode * 59 + this.EnableHistory.GetHashCode();
                return hashCode;
            }
        }
    }
}
