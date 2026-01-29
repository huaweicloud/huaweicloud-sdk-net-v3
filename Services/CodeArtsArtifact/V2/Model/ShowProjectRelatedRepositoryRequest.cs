using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowProjectRelatedRepositoryRequest 
    {

        /// <summary>
        /// **参数解释**： 项目名称，支持模糊查询。 **约束限制**： 不涉及。 **取值范围**： 最大200个字符。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("search_name", IsQuery = true)]
        [JsonProperty("search_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchName { get; set; }

        /// <summary>
        /// **参数解释**： 分页查询的起始位置。 **约束限制**： 不涉及。 **取值范围**： 0-2147483647 **默认取值**： 0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释**： 分页查询每页的数据量。 **约束限制**： 不涉及。 **取值范围**： 1-2147483647 **默认取值**： 10
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 仓库ID，格式为{region}\\_{domainId}\\_{format}_{sequence}。可以从“私有依赖库首页 &gt; 仓库概览 &gt; 仓库地址url”中获取，最后两个“/”中间的字符串即为仓库ID。如仓库地址：https://devrepo.devcloud.abcde.abc.xyz.com/artgalaxy/abcde_09d2ca2f5080d5b60f51c00ae5bad0a0_maven_2_50/，其中abcde_09d2ca2f5080d5b60f51c00ae5bad0a0_maven_2_50即为仓库ID。 **约束限制**： 不涉及。 **取值范围**： 仓库ID格式中的format支持以下值： - npm - go - pypi - rpm - composer - maven - debian - conan - nuget - docker2 - cocoapods **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("repo_id", IsQuery = true)]
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectRelatedRepositoryRequest {\n");
            sb.Append("  searchName: ").Append(SearchName).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectRelatedRepositoryRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectRelatedRepositoryRequest input)
        {
            if (input == null) return false;
            if (this.SearchName != input.SearchName || (this.SearchName != null && !this.SearchName.Equals(input.SearchName))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;

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
                if (this.SearchName != null) hashCode = hashCode * 59 + this.SearchName.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                return hashCode;
            }
        }
    }
}
