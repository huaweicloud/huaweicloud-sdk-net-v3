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
    /// Request Object
    /// </summary>
    public class ListMergeRequestChangesTreesRequest 
    {

        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：**  合并请求 iid。
        /// </summary>
        [SDKProperty("merge_request_iid", IsPath = true)]
        [JsonProperty("merge_request_iid", NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeRequestIid { get; set; }

        /// <summary>
        /// **参数解释：** 审核人ID。
        /// </summary>
        [SDKProperty("approval_user_id", IsQuery = true)]
        [JsonProperty("approval_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ApprovalUserId { get; set; }

        /// <summary>
        /// **参数解释：** commit ID。 **取值范围：** 字符串长度不少于1，不超过40。
        /// </summary>
        [SDKProperty("commit_id", IsQuery = true)]
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// **参数解释：** 文件变更对比源版本id
        /// </summary>
        [SDKProperty("from_diff_id", IsQuery = true)]
        [JsonProperty("from_diff_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? FromDiffId { get; set; }

        /// <summary>
        /// **参数解释：** 文件变更对比目标版本id
        /// </summary>
        [SDKProperty("to_diff_id", IsQuery = true)]
        [JsonProperty("to_diff_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ToDiffId { get; set; }

        /// <summary>
        /// **参数解释：** 偏移量，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 返回数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMergeRequestChangesTreesRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  mergeRequestIid: ").Append(MergeRequestIid).Append("\n");
            sb.Append("  approvalUserId: ").Append(ApprovalUserId).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  fromDiffId: ").Append(FromDiffId).Append("\n");
            sb.Append("  toDiffId: ").Append(ToDiffId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMergeRequestChangesTreesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMergeRequestChangesTreesRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.MergeRequestIid != input.MergeRequestIid || (this.MergeRequestIid != null && !this.MergeRequestIid.Equals(input.MergeRequestIid))) return false;
            if (this.ApprovalUserId != input.ApprovalUserId || (this.ApprovalUserId != null && !this.ApprovalUserId.Equals(input.ApprovalUserId))) return false;
            if (this.CommitId != input.CommitId || (this.CommitId != null && !this.CommitId.Equals(input.CommitId))) return false;
            if (this.FromDiffId != input.FromDiffId || (this.FromDiffId != null && !this.FromDiffId.Equals(input.FromDiffId))) return false;
            if (this.ToDiffId != input.ToDiffId || (this.ToDiffId != null && !this.ToDiffId.Equals(input.ToDiffId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.MergeRequestIid != null) hashCode = hashCode * 59 + this.MergeRequestIid.GetHashCode();
                if (this.ApprovalUserId != null) hashCode = hashCode * 59 + this.ApprovalUserId.GetHashCode();
                if (this.CommitId != null) hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.FromDiffId != null) hashCode = hashCode * 59 + this.FromDiffId.GetHashCode();
                if (this.ToDiffId != null) hashCode = hashCode * 59 + this.ToDiffId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
