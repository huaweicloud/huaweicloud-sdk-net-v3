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
    /// **参数解释：** 模板仓列表
    /// </summary>
    public class RepositoryTemplateDto 
    {

        /// <summary>
        /// **参数解释：** 仓库Id。
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepositoryId { get; set; }

        /// <summary>
        /// **参数解释：** 模板仓标题。 **取值范围：** 字符串长度1-50。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 是否是系统模板。 **取值范围：** - true，系统模板。 - false，个人模板。
        /// </summary>
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public bool? System { get; set; }

        /// <summary>
        /// **参数解释：** 标签列表。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// **参数解释：** 仓库描述信息。 **取值范围：** 字符串长度0-2000。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 编程语言。 **取值范围：** 字符串长度0-32。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// **参数解释：** 模板仓的仓库名称。 **取值范围：** 字符串长度0-255。
        /// </summary>
        [JsonProperty("repository_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryName { get; set; }

        /// <summary>
        /// **参数解释：** 模板仓的简介。 **取值范围：** 字符串长度0-32。
        /// </summary>
        [JsonProperty("brief_introduction", NullValueHandling = NullValueHandling.Ignore)]
        public string BriefIntroduction { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 模板仓被使用的次数。
        /// </summary>
        [JsonProperty("used_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedTimes { get; set; }

        /// <summary>
        /// **参数解释：** 模板仓被点赞的次数。
        /// </summary>
        [JsonProperty("liked_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? LikedTimes { get; set; }

        /// <summary>
        /// **参数解释：** 作者。 **取值范围：** 字符串长度0-128。
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// **参数解释：** 代码仓https协议的git地址。 **取值范围：** 字符串最大长度512。
        /// </summary>
        [JsonProperty("https_url", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryTemplateDto {\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  system: ").Append(System).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  repositoryName: ").Append(RepositoryName).Append("\n");
            sb.Append("  briefIntroduction: ").Append(BriefIntroduction).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  usedTimes: ").Append(UsedTimes).Append("\n");
            sb.Append("  likedTimes: ").Append(LikedTimes).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  httpsUrl: ").Append(HttpsUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryTemplateDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryTemplateDto input)
        {
            if (input == null) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.System != input.System || (this.System != null && !this.System.Equals(input.System))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.RepositoryName != input.RepositoryName || (this.RepositoryName != null && !this.RepositoryName.Equals(input.RepositoryName))) return false;
            if (this.BriefIntroduction != input.BriefIntroduction || (this.BriefIntroduction != null && !this.BriefIntroduction.Equals(input.BriefIntroduction))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UsedTimes != input.UsedTimes || (this.UsedTimes != null && !this.UsedTimes.Equals(input.UsedTimes))) return false;
            if (this.LikedTimes != input.LikedTimes || (this.LikedTimes != null && !this.LikedTimes.Equals(input.LikedTimes))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.HttpsUrl != input.HttpsUrl || (this.HttpsUrl != null && !this.HttpsUrl.Equals(input.HttpsUrl))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.System != null) hashCode = hashCode * 59 + this.System.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.RepositoryName != null) hashCode = hashCode * 59 + this.RepositoryName.GetHashCode();
                if (this.BriefIntroduction != null) hashCode = hashCode * 59 + this.BriefIntroduction.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UsedTimes != null) hashCode = hashCode * 59 + this.UsedTimes.GetHashCode();
                if (this.LikedTimes != null) hashCode = hashCode * 59 + this.LikedTimes.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.HttpsUrl != null) hashCode = hashCode * 59 + this.HttpsUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
