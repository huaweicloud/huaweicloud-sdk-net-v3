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
    public class ListCommitsRequest 
    {

        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

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
        /// 分支/tag名
        /// </summary>
        [SDKProperty("ref_name", IsQuery = true)]
        [JsonProperty("ref_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RefName { get; set; }

        /// <summary>
        /// 起始时间（不包含）
        /// </summary>
        [SDKProperty("since", IsQuery = true)]
        [JsonProperty("since", NullValueHandling = NullValueHandling.Ignore)]
        public string Since { get; set; }

        /// <summary>
        /// 结束时间（不包含）
        /// </summary>
        [SDKProperty("until", IsQuery = true)]
        [JsonProperty("until", NullValueHandling = NullValueHandling.Ignore)]
        public string Until { get; set; }

        /// <summary>
        /// The file path
        /// </summary>
        [SDKProperty("path", IsQuery = true)]
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 提交信息或者commit id
        /// </summary>
        [SDKProperty("message", IsQuery = true)]
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 代码作者名称
        /// </summary>
        [SDKProperty("author", IsQuery = true)]
        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public string Author { get; set; }

        /// <summary>
        /// 是否按照时间降序排序
        /// </summary>
        [SDKProperty("order_by_date", IsQuery = true)]
        [JsonProperty("order_by_date", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrderByDate { get; set; }

        /// <summary>
        /// 为true时可以追踪文件移动、改名前后的提交记录
        /// </summary>
        [SDKProperty("follow", IsQuery = true)]
        [JsonProperty("follow", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Follow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCommitsRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  refName: ").Append(RefName).Append("\n");
            sb.Append("  since: ").Append(Since).Append("\n");
            sb.Append("  until: ").Append(Until).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  author: ").Append(Author).Append("\n");
            sb.Append("  orderByDate: ").Append(OrderByDate).Append("\n");
            sb.Append("  follow: ").Append(Follow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCommitsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCommitsRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.RefName != input.RefName || (this.RefName != null && !this.RefName.Equals(input.RefName))) return false;
            if (this.Since != input.Since || (this.Since != null && !this.Since.Equals(input.Since))) return false;
            if (this.Until != input.Until || (this.Until != null && !this.Until.Equals(input.Until))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Author != input.Author || (this.Author != null && !this.Author.Equals(input.Author))) return false;
            if (this.OrderByDate != input.OrderByDate || (this.OrderByDate != null && !this.OrderByDate.Equals(input.OrderByDate))) return false;
            if (this.Follow != input.Follow || (this.Follow != null && !this.Follow.Equals(input.Follow))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.RefName != null) hashCode = hashCode * 59 + this.RefName.GetHashCode();
                if (this.Since != null) hashCode = hashCode * 59 + this.Since.GetHashCode();
                if (this.Until != null) hashCode = hashCode * 59 + this.Until.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Author != null) hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.OrderByDate != null) hashCode = hashCode * 59 + this.OrderByDate.GetHashCode();
                if (this.Follow != null) hashCode = hashCode * 59 + this.Follow.GetHashCode();
                return hashCode;
            }
        }
    }
}
