using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PutMergeRequestParamsDto 
    {
        /// <summary>
        /// 合并请求状态
        /// </summary>
        /// <value>合并请求状态</value>
        [JsonConverter(typeof(EnumClassConverter<StateEventEnum>))]
        public class StateEventEnum
        {
            /// <summary>
            /// Enum REOPEN for value: reopen
            /// </summary>
            public static readonly StateEventEnum REOPEN = new StateEventEnum("reopen");

            /// <summary>
            /// Enum CLOSE for value: close
            /// </summary>
            public static readonly StateEventEnum CLOSE = new StateEventEnum("close");

            private static readonly Dictionary<string, StateEventEnum> StaticFields =
            new Dictionary<string, StateEventEnum>()
            {
                { "reopen", REOPEN },
                { "close", CLOSE },
            };

            private string _value;

            public StateEventEnum()
            {

            }

            public StateEventEnum(string value)
            {
                _value = value;
            }

            public static StateEventEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as StateEventEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEventEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEventEnum a, StateEventEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StateEventEnum a, StateEventEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 合并请求标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 合并请求状态
        /// </summary>
        [JsonProperty("state_event", NullValueHandling = NullValueHandling.Ignore)]
        public StateEventEnum StateEvent { get; set; }
        /// <summary>
        /// 合并人id列表
        /// </summary>
        [JsonProperty("assignee_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string AssigneeIds { get; set; }

        /// <summary>
        /// 评审人id列表
        /// </summary>
        [JsonProperty("reviewer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewerIds { get; set; }

        /// <summary>
        /// 合并请求描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 里程碑id
        /// </summary>
        [JsonProperty("milestone_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MilestoneId { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Object Labels { get; set; }

        /// <summary>
        /// 合入后删除源分支
        /// </summary>
        [JsonProperty("force_remove_source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceRemoveSourceBranch { get; set; }

        /// <summary>
        /// squash合入
        /// </summary>
        [JsonProperty("squash", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Squash { get; set; }

        /// <summary>
        /// squash提交信息
        /// </summary>
        [JsonProperty("squash_commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string SquashCommitMessage { get; set; }

        /// <summary>
        /// e2e单号
        /// </summary>
        [JsonProperty("work_item_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WorkItemIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutMergeRequestParamsDto {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  stateEvent: ").Append(StateEvent).Append("\n");
            sb.Append("  assigneeIds: ").Append(AssigneeIds).Append("\n");
            sb.Append("  reviewerIds: ").Append(ReviewerIds).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  milestoneId: ").Append(MilestoneId).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  forceRemoveSourceBranch: ").Append(ForceRemoveSourceBranch).Append("\n");
            sb.Append("  squash: ").Append(Squash).Append("\n");
            sb.Append("  squashCommitMessage: ").Append(SquashCommitMessage).Append("\n");
            sb.Append("  workItemIds: ").Append(WorkItemIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PutMergeRequestParamsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PutMergeRequestParamsDto input)
        {
            if (input == null) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.StateEvent != input.StateEvent) return false;
            if (this.AssigneeIds != input.AssigneeIds || (this.AssigneeIds != null && !this.AssigneeIds.Equals(input.AssigneeIds))) return false;
            if (this.ReviewerIds != input.ReviewerIds || (this.ReviewerIds != null && !this.ReviewerIds.Equals(input.ReviewerIds))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.MilestoneId != input.MilestoneId || (this.MilestoneId != null && !this.MilestoneId.Equals(input.MilestoneId))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && !this.Labels.Equals(input.Labels))) return false;
            if (this.ForceRemoveSourceBranch != input.ForceRemoveSourceBranch || (this.ForceRemoveSourceBranch != null && !this.ForceRemoveSourceBranch.Equals(input.ForceRemoveSourceBranch))) return false;
            if (this.Squash != input.Squash || (this.Squash != null && !this.Squash.Equals(input.Squash))) return false;
            if (this.SquashCommitMessage != input.SquashCommitMessage || (this.SquashCommitMessage != null && !this.SquashCommitMessage.Equals(input.SquashCommitMessage))) return false;
            if (this.WorkItemIds != input.WorkItemIds || (this.WorkItemIds != null && input.WorkItemIds != null && !this.WorkItemIds.SequenceEqual(input.WorkItemIds))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                hashCode = hashCode * 59 + this.StateEvent.GetHashCode();
                if (this.AssigneeIds != null) hashCode = hashCode * 59 + this.AssigneeIds.GetHashCode();
                if (this.ReviewerIds != null) hashCode = hashCode * 59 + this.ReviewerIds.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MilestoneId != null) hashCode = hashCode * 59 + this.MilestoneId.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.ForceRemoveSourceBranch != null) hashCode = hashCode * 59 + this.ForceRemoveSourceBranch.GetHashCode();
                if (this.Squash != null) hashCode = hashCode * 59 + this.Squash.GetHashCode();
                if (this.SquashCommitMessage != null) hashCode = hashCode * 59 + this.SquashCommitMessage.GetHashCode();
                if (this.WorkItemIds != null) hashCode = hashCode * 59 + this.WorkItemIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
