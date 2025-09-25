using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PipelineTrigger 
    {

        /// <summary>
        /// **参数解释**： 流水线ID，可以通过[查询流水线列表](ListPipelines.xml)接口，其中pipelines.pipelineId即为流水线ID。 **约束限制**： 不涉及。 **取值范围**： 32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// **参数解释**： 代码仓git链接。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释**： git代码仓类型。 **约束限制**： 不涉及。 **取值范围**： - codehub。 - gitee。 - github。 - gitcode。 - gitlab。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("git_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GitType { get; set; }

        /// <summary>
        /// **参数解释**： 是否自动提交。gitee仓库特有，webhook触发流水线后，自动添加评论。 **约束限制**： 不涉及。 **取值范围**： - true：是自动提交。 - false：不是自动提交。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("is_auto_commit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoCommit { get; set; }

        /// <summary>
        /// **参数解释**： 触发事件列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public List<CodeEvent> Events { get; set; }

        /// <summary>
        /// **参数解释**： 系统生成的回调ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("hook_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HookId { get; set; }

        /// <summary>
        /// **参数解释**： Repo仓库ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }

        /// <summary>
        /// **参数解释**： 代码源扩展点ID。 **约束限制**： 不涉及。 **取值范围**： 32位字符，由数字和字母组成。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("endpoint_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// **参数解释**： 回调链接，注册Webhook时生成。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// **参数解释**： 用户token，注册Webhook时生成。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("security_token", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityToken { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineTrigger {\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  gitType: ").Append(GitType).Append("\n");
            sb.Append("  isAutoCommit: ").Append(IsAutoCommit).Append("\n");
            sb.Append("  events: ").Append(Events).Append("\n");
            sb.Append("  hookId: ").Append(HookId).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  securityToken: ").Append(SecurityToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineTrigger);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineTrigger input)
        {
            if (input == null) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.GitType != input.GitType || (this.GitType != null && !this.GitType.Equals(input.GitType))) return false;
            if (this.IsAutoCommit != input.IsAutoCommit || (this.IsAutoCommit != null && !this.IsAutoCommit.Equals(input.IsAutoCommit))) return false;
            if (this.Events != input.Events || (this.Events != null && input.Events != null && !this.Events.SequenceEqual(input.Events))) return false;
            if (this.HookId != input.HookId || (this.HookId != null && !this.HookId.Equals(input.HookId))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;
            if (this.SecurityToken != input.SecurityToken || (this.SecurityToken != null && !this.SecurityToken.Equals(input.SecurityToken))) return false;

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
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.GitType != null) hashCode = hashCode * 59 + this.GitType.GetHashCode();
                if (this.IsAutoCommit != null) hashCode = hashCode * 59 + this.IsAutoCommit.GetHashCode();
                if (this.Events != null) hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.HookId != null) hashCode = hashCode * 59 + this.HookId.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.SecurityToken != null) hashCode = hashCode * 59 + this.SecurityToken.GetHashCode();
                return hashCode;
            }
        }
    }
}
