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
    public class ListMergeRequestDiscussionsRequest 
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
        /// **参数解释：** 是否筛选解决的检视意见 - true 筛选所有未解决的检视意见 - false 筛选所有已解决的检视意见 - &#39;&#39; 不传此值时默认查询所有检视意见
        /// </summary>
        [SDKProperty("unresolved", IsQuery = true)]
        [JsonProperty("unresolved", NullValueHandling = NullValueHandling.Ignore)]
        public string Unresolved { get; set; }

        /// <summary>
        /// **参数解释：** 操作者id。
        /// </summary>
        [SDKProperty("author_id", IsQuery = true)]
        [JsonProperty("author_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthorId { get; set; }

        /// <summary>
        /// **参数解释：** 检视意见返回排序 - asc 按创建时间正序返回 - desc 按创建时间倒序返回
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

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
            sb.Append("class ListMergeRequestDiscussionsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  mergeRequestIid: ").Append(MergeRequestIid).Append("\n");
            sb.Append("  unresolved: ").Append(Unresolved).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
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
            return this.Equals(input as ListMergeRequestDiscussionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMergeRequestDiscussionsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.MergeRequestIid != input.MergeRequestIid || (this.MergeRequestIid != null && !this.MergeRequestIid.Equals(input.MergeRequestIid))) return false;
            if (this.Unresolved != input.Unresolved || (this.Unresolved != null && !this.Unresolved.Equals(input.Unresolved))) return false;
            if (this.AuthorId != input.AuthorId || (this.AuthorId != null && !this.AuthorId.Equals(input.AuthorId))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
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
                if (this.Unresolved != null) hashCode = hashCode * 59 + this.Unresolved.GetHashCode();
                if (this.AuthorId != null) hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
