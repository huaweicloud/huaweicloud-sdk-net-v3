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
    public class ShowReviewSettingRequest 
    {

        /// <summary>
        /// **参数解释：** 仓库的ID，通过[[查询用户所有仓库](https://support.huaweicloud.com/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws)[[查询用户所有仓库](https://support.huaweicloud.com/intl/en-us/api-codeartsrepo/ListUserAllRepositories.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **约束限制：** 不涉及。
        /// </summary>
        [SDKProperty("repository_id", IsPath = true)]
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 额外返回可勾选检视意见分类和系统预置检视意见分类。 **取值范围：** - true, 返回可勾选检视意见分类和系统预置检视意见分类。 - false, 不返回可勾选检视意见分类和系统预置检视意见分类。
        /// </summary>
        [SDKProperty("with_default_review_categories", IsQuery = true)]
        [JsonProperty("with_default_review_categories", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithDefaultReviewCategories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReviewSettingRequest {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  withDefaultReviewCategories: ").Append(WithDefaultReviewCategories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReviewSettingRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReviewSettingRequest input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.WithDefaultReviewCategories != input.WithDefaultReviewCategories || (this.WithDefaultReviewCategories != null && !this.WithDefaultReviewCategories.Equals(input.WithDefaultReviewCategories))) return false;

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
                if (this.WithDefaultReviewCategories != null) hashCode = hashCode * 59 + this.WithDefaultReviewCategories.GetHashCode();
                return hashCode;
            }
        }
    }
}
