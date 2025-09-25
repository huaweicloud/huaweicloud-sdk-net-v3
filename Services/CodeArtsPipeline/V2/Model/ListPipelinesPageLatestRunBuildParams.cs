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
    /// **参数解释**： 构建参数。 **取值范围**： 不涉及。 
    /// </summary>
    public class ListPipelinesPageLatestRunBuildParams 
    {

        /// <summary>
        /// **参数解释**： 合并请求事件类型。 **取值范围**： - open：打开。 - reopen：重开。 - update：更新。 - merge：合并。 
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**： 基于分支还是标签触发。 **取值范围**： - branch：分支触发。 - tag：标签触发。 
        /// </summary>
        [JsonProperty("build_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildType { get; set; }

        /// <summary>
        /// **参数解释**： 代码仓提交ID。 **取值范围**： 40位字符。 
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// **参数解释**： 运行事件类型。 **取值范围**： - Manual：手动触发。 - Scheduler：定时任务。 - MR：MR触发。 - Push：Push事件触发。 - CreateTag：Tag事件触发。 - Issue：Issue触发。 - Note：评论触发。 
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// **参数解释**： 合并请求ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("merge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeId { get; set; }

        /// <summary>
        /// **参数解释**： 代码仓提交信息。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// **参数解释**： 源分支。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// **参数解释**： 标签。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// **参数解释**： 目标分支。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// **参数解释**： Repo代码仓ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("codehub_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodehubId { get; set; }

        /// <summary>
        /// **参数解释**： 代码仓https地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// **参数解释**： 源Repo代码仓ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("source_codehub_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCodehubId { get; set; }

        /// <summary>
        /// **参数解释**： 源Repo代码仓地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("source_codehub_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCodehubUrl { get; set; }

        /// <summary>
        /// **参数解释**： 源Repo代码仓http地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("source_codehub_http_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceCodehubHttpUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPipelinesPageLatestRunBuildParams {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  buildType: ").Append(BuildType).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  mergeId: ").Append(MergeId).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  codehubId: ").Append(CodehubId).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  sourceCodehubId: ").Append(SourceCodehubId).Append("\n");
            sb.Append("  sourceCodehubUrl: ").Append(SourceCodehubUrl).Append("\n");
            sb.Append("  sourceCodehubHttpUrl: ").Append(SourceCodehubHttpUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPipelinesPageLatestRunBuildParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPipelinesPageLatestRunBuildParams input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.BuildType != input.BuildType || (this.BuildType != null && !this.BuildType.Equals(input.BuildType))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.MergeId != input.MergeId || (this.MergeId != null && !this.MergeId.Equals(input.MergeId))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.CodehubId != input.CodehubId || (this.CodehubId != null && !this.CodehubId.Equals(input.CodehubId))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.SourceCodehubId != input.SourceCodehubId || (this.SourceCodehubId != null && !this.SourceCodehubId.Equals(input.SourceCodehubId))) return false;
            if (this.SourceCodehubUrl != input.SourceCodehubUrl || (this.SourceCodehubUrl != null && !this.SourceCodehubUrl.Equals(input.SourceCodehubUrl))) return false;
            if (this.SourceCodehubHttpUrl != input.SourceCodehubHttpUrl || (this.SourceCodehubHttpUrl != null && !this.SourceCodehubHttpUrl.Equals(input.SourceCodehubHttpUrl))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.BuildType != null) hashCode = hashCode * 59 + this.BuildType.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.MergeId != null) hashCode = hashCode * 59 + this.MergeId.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.CodehubId != null) hashCode = hashCode * 59 + this.CodehubId.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.SourceCodehubId != null) hashCode = hashCode * 59 + this.SourceCodehubId.GetHashCode();
                if (this.SourceCodehubUrl != null) hashCode = hashCode * 59 + this.SourceCodehubUrl.GetHashCode();
                if (this.SourceCodehubHttpUrl != null) hashCode = hashCode * 59 + this.SourceCodehubHttpUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
