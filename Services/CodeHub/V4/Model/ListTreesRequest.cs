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
    public class ListTreesRequest 
    {

        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 引用，可以是分支名称、标签名称或者commitid，如果不传则为默认分支。 **取值范围：** 字符串长度不少于1，不超过2000。
        /// </summary>
        [SDKProperty("ref", IsQuery = true)]
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Ref { get; set; }

        /// <summary>
        /// **参数解释：** 文件路径。 **取值范围：** 字符串长度不少于1，不超过100000。
        /// </summary>
        [SDKProperty("path", IsQuery = true)]
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 是否递归查询
        /// </summary>
        [SDKProperty("recursive", IsQuery = true)]
        [JsonProperty("recursive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recursive { get; set; }

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
            sb.Append("class ListTreesRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  recursive: ").Append(Recursive).Append("\n");
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
            return this.Equals(input as ListTreesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTreesRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Ref != input.Ref || (this.Ref != null && !this.Ref.Equals(input.Ref))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Recursive != input.Recursive || (this.Recursive != null && !this.Recursive.Equals(input.Recursive))) return false;
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
                if (this.Ref != null) hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Recursive != null) hashCode = hashCode * 59 + this.Recursive.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
