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
    /// 知识型Agent执行请求体
    /// </summary>
    public class AgentRunReq 
    {

        /// <summary>
        /// 请求问题
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_profile", NullValueHandling = NullValueHandling.Ignore)]
        public UserProfile UserProfile { get; set; }

        /// <summary>
        /// 插件是否开启
        /// </summary>
        [JsonProperty("tool_switch_dict", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool?> ToolSwitchDict { get; set; }

        /// <summary>
        /// 模型ID
        /// </summary>
        [JsonProperty("model_deployment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelDeploymentId { get; set; }

        /// <summary>
        /// 是否记录会话历史
        /// </summary>
        [JsonProperty("enable_history", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHistory { get; set; }

        /// <summary>
        /// 传入的会话历史
        /// </summary>
        [JsonProperty("histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<Message> Histories { get; set; }

        /// <summary>
        /// 上传文件列表
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Files { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentRunReq {\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  userProfile: ").Append(UserProfile).Append("\n");
            sb.Append("  toolSwitchDict: ").Append(ToolSwitchDict).Append("\n");
            sb.Append("  modelDeploymentId: ").Append(ModelDeploymentId).Append("\n");
            sb.Append("  enableHistory: ").Append(EnableHistory).Append("\n");
            sb.Append("  histories: ").Append(Histories).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentRunReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentRunReq input)
        {
            if (input == null) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && input.Inputs != null && !this.Inputs.SequenceEqual(input.Inputs))) return false;
            if (this.UserProfile != input.UserProfile || (this.UserProfile != null && !this.UserProfile.Equals(input.UserProfile))) return false;
            if (this.ToolSwitchDict != input.ToolSwitchDict || (this.ToolSwitchDict != null && input.ToolSwitchDict != null && !this.ToolSwitchDict.SequenceEqual(input.ToolSwitchDict))) return false;
            if (this.ModelDeploymentId != input.ModelDeploymentId || (this.ModelDeploymentId != null && !this.ModelDeploymentId.Equals(input.ModelDeploymentId))) return false;
            if (this.EnableHistory != input.EnableHistory || (this.EnableHistory != null && !this.EnableHistory.Equals(input.EnableHistory))) return false;
            if (this.Histories != input.Histories || (this.Histories != null && input.Histories != null && !this.Histories.SequenceEqual(input.Histories))) return false;
            if (this.Files != input.Files || (this.Files != null && input.Files != null && !this.Files.SequenceEqual(input.Files))) return false;

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
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.UserProfile != null) hashCode = hashCode * 59 + this.UserProfile.GetHashCode();
                if (this.ToolSwitchDict != null) hashCode = hashCode * 59 + this.ToolSwitchDict.GetHashCode();
                if (this.ModelDeploymentId != null) hashCode = hashCode * 59 + this.ModelDeploymentId.GetHashCode();
                if (this.EnableHistory != null) hashCode = hashCode * 59 + this.EnableHistory.GetHashCode();
                if (this.Histories != null) hashCode = hashCode * 59 + this.Histories.GetHashCode();
                if (this.Files != null) hashCode = hashCode * 59 + this.Files.GetHashCode();
                return hashCode;
            }
        }
    }
}
