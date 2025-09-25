using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleMergeRequestDetailDto 
    {

        /// <summary>
        /// **参数解释：** 合并请求id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求iid。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iid { get; set; }

        /// <summary>
        /// **参数解释：** 标题。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释：** 描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 源分支。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("source_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// **参数解释：** 目标分支。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("target_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// **参数解释：** 状态。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 审核模式。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("review_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public UserBasicDto Author { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求类型。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("merge_request_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeRequestType { get; set; }

        /// <summary>
        /// **参数解释：** 送审结果。 **取值范围：** - true，成功。 - false，失败
        /// </summary>
        [JsonProperty("moderation_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ModerationResult { get; set; }

        /// <summary>
        /// **参数解释：** 送审时间时间戳。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("moderation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModerationTime { get; set; }

        /// <summary>
        /// **参数解释：** 送审状态码。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("moderation_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModerationStatus { get; set; }

        /// <summary>
        /// **参数解释：** 是否使用临时分支。 **取值范围：** - true，使用。 - false，不使用
        /// </summary>
        [JsonProperty("is_use_temp_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUseTempBranch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleMergeRequestDetailDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iid: ").Append(Iid).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  sourceBranch: ").Append(SourceBranch).Append("\n");
            sb.Append("  targetBranch: ").Append(TargetBranch).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  reviewMode: ").Append(ReviewMode).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  mergeRequestType: ").Append(MergeRequestType).Append("\n");
            sb.Append("  moderationResult: ").Append(ModerationResult).Append("\n");
            sb.Append("  moderationTime: ").Append(ModerationTime).Append("\n");
            sb.Append("  moderationStatus: ").Append(ModerationStatus).Append("\n");
            sb.Append("  isUseTempBranch: ").Append(IsUseTempBranch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleMergeRequestDetailDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SimpleMergeRequestDetailDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Iid != input.Iid || (this.Iid != null && !this.Iid.Equals(input.Iid))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SourceBranch != input.SourceBranch || (this.SourceBranch != null && !this.SourceBranch.Equals(input.SourceBranch))) return false;
            if (this.TargetBranch != input.TargetBranch || (this.TargetBranch != null && !this.TargetBranch.Equals(input.TargetBranch))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.ReviewMode != input.ReviewMode || (this.ReviewMode != null && !this.ReviewMode.Equals(input.ReviewMode))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.MergeRequestType != input.MergeRequestType || (this.MergeRequestType != null && !this.MergeRequestType.Equals(input.MergeRequestType))) return false;
            if (this.ModerationResult != input.ModerationResult || (this.ModerationResult != null && !this.ModerationResult.Equals(input.ModerationResult))) return false;
            if (this.ModerationTime != input.ModerationTime || (this.ModerationTime != null && !this.ModerationTime.Equals(input.ModerationTime))) return false;
            if (this.ModerationStatus != input.ModerationStatus || (this.ModerationStatus != null && !this.ModerationStatus.Equals(input.ModerationStatus))) return false;
            if (this.IsUseTempBranch != input.IsUseTempBranch || (this.IsUseTempBranch != null && !this.IsUseTempBranch.Equals(input.IsUseTempBranch))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Iid != null) hashCode = hashCode * 59 + this.Iid.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SourceBranch != null) hashCode = hashCode * 59 + this.SourceBranch.GetHashCode();
                if (this.TargetBranch != null) hashCode = hashCode * 59 + this.TargetBranch.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ReviewMode != null) hashCode = hashCode * 59 + this.ReviewMode.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.MergeRequestType != null) hashCode = hashCode * 59 + this.MergeRequestType.GetHashCode();
                if (this.ModerationResult != null) hashCode = hashCode * 59 + this.ModerationResult.GetHashCode();
                if (this.ModerationTime != null) hashCode = hashCode * 59 + this.ModerationTime.GetHashCode();
                if (this.ModerationStatus != null) hashCode = hashCode * 59 + this.ModerationStatus.GetHashCode();
                if (this.IsUseTempBranch != null) hashCode = hashCode * 59 + this.IsUseTempBranch.GetHashCode();
                return hashCode;
            }
        }
    }
}
