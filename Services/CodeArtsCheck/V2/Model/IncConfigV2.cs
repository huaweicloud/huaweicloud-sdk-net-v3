using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 增量检查相关的参数
    /// </summary>
    public class IncConfigV2 
    {

        /// <summary>
        /// 需要关联的父任务ID，流水线创建或MR创建任务需要该参数
        /// </summary>
        [JsonProperty("parent_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// 增量检查代码源分支
        /// </summary>
        [JsonProperty("git_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitSourceBranch { get; set; }

        /// <summary>
        /// 增量检查代码目标分支
        /// </summary>
        [JsonProperty("git_target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string GitTargetBranch { get; set; }

        /// <summary>
        /// MR唯一标示ID
        /// </summary>
        [JsonProperty("merge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeId { get; set; }

        /// <summary>
        /// webhook触发事件类型,merge_request/push_request
        /// </summary>
        [JsonProperty("event_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// webhook事件状态，open/close/update
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// MR标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncConfigV2 {\n");
            sb.Append("  parentTaskId: ").Append(ParentTaskId).Append("\n");
            sb.Append("  gitSourceBranch: ").Append(GitSourceBranch).Append("\n");
            sb.Append("  gitTargetBranch: ").Append(GitTargetBranch).Append("\n");
            sb.Append("  mergeId: ").Append(MergeId).Append("\n");
            sb.Append("  eventType: ").Append(EventType).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IncConfigV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IncConfigV2 input)
        {
            if (input == null) return false;
            if (this.ParentTaskId != input.ParentTaskId || (this.ParentTaskId != null && !this.ParentTaskId.Equals(input.ParentTaskId))) return false;
            if (this.GitSourceBranch != input.GitSourceBranch || (this.GitSourceBranch != null && !this.GitSourceBranch.Equals(input.GitSourceBranch))) return false;
            if (this.GitTargetBranch != input.GitTargetBranch || (this.GitTargetBranch != null && !this.GitTargetBranch.Equals(input.GitTargetBranch))) return false;
            if (this.MergeId != input.MergeId || (this.MergeId != null && !this.MergeId.Equals(input.MergeId))) return false;
            if (this.EventType != input.EventType || (this.EventType != null && !this.EventType.Equals(input.EventType))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;

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
                if (this.ParentTaskId != null) hashCode = hashCode * 59 + this.ParentTaskId.GetHashCode();
                if (this.GitSourceBranch != null) hashCode = hashCode * 59 + this.GitSourceBranch.GetHashCode();
                if (this.GitTargetBranch != null) hashCode = hashCode * 59 + this.GitTargetBranch.GetHashCode();
                if (this.MergeId != null) hashCode = hashCode * 59 + this.MergeId.GetHashCode();
                if (this.EventType != null) hashCode = hashCode * 59 + this.EventType.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }
    }
}
