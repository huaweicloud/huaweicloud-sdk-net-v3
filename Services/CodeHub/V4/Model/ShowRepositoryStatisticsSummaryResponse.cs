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
    /// Response Object
    /// </summary>
    public class ShowRepositoryStatisticsSummaryResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 分支数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("branches_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BranchesCount { get; set; }

        /// <summary>
        /// **参数解释：** 提交数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("commits_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommitsCount { get; set; }

        /// <summary>
        /// **参数解释：** 成员数量。
        /// </summary>
        [JsonProperty("members_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MembersCount { get; set; }

        /// <summary>
        /// **参数解释：** Tag数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("tags_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TagsCount { get; set; }

        /// <summary>
        /// **参数解释：** 合并请求数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("merge_request_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? MergeRequestCount { get; set; }

        /// <summary>
        /// **参数解释：** 备注数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("note_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? NoteCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRepositoryStatisticsSummaryResponse {\n");
            sb.Append("  branchesCount: ").Append(BranchesCount).Append("\n");
            sb.Append("  commitsCount: ").Append(CommitsCount).Append("\n");
            sb.Append("  membersCount: ").Append(MembersCount).Append("\n");
            sb.Append("  tagsCount: ").Append(TagsCount).Append("\n");
            sb.Append("  mergeRequestCount: ").Append(MergeRequestCount).Append("\n");
            sb.Append("  noteCount: ").Append(NoteCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRepositoryStatisticsSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRepositoryStatisticsSummaryResponse input)
        {
            if (input == null) return false;
            if (this.BranchesCount != input.BranchesCount || (this.BranchesCount != null && !this.BranchesCount.Equals(input.BranchesCount))) return false;
            if (this.CommitsCount != input.CommitsCount || (this.CommitsCount != null && !this.CommitsCount.Equals(input.CommitsCount))) return false;
            if (this.MembersCount != input.MembersCount || (this.MembersCount != null && !this.MembersCount.Equals(input.MembersCount))) return false;
            if (this.TagsCount != input.TagsCount || (this.TagsCount != null && !this.TagsCount.Equals(input.TagsCount))) return false;
            if (this.MergeRequestCount != input.MergeRequestCount || (this.MergeRequestCount != null && !this.MergeRequestCount.Equals(input.MergeRequestCount))) return false;
            if (this.NoteCount != input.NoteCount || (this.NoteCount != null && !this.NoteCount.Equals(input.NoteCount))) return false;

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
                if (this.BranchesCount != null) hashCode = hashCode * 59 + this.BranchesCount.GetHashCode();
                if (this.CommitsCount != null) hashCode = hashCode * 59 + this.CommitsCount.GetHashCode();
                if (this.MembersCount != null) hashCode = hashCode * 59 + this.MembersCount.GetHashCode();
                if (this.TagsCount != null) hashCode = hashCode * 59 + this.TagsCount.GetHashCode();
                if (this.MergeRequestCount != null) hashCode = hashCode * 59 + this.MergeRequestCount.GetHashCode();
                if (this.NoteCount != null) hashCode = hashCode * 59 + this.NoteCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
