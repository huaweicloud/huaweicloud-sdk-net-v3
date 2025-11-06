using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TemplateRepository 
    {

        /// <summary>
        /// 模板唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 模板关联仓库名称
        /// </summary>
        [JsonProperty("template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 模板标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 模板描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模板简介
        /// </summary>
        [JsonProperty("brief_introduction", NullValueHandling = NullValueHandling.Ignore)]
        public string BriefIntroduction { get; set; }

        /// <summary>
        /// 是否自动创建流水线
        /// </summary>
        [JsonProperty("auto_pending_pipelines", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoPendingPipelines { get; set; }

        /// <summary>
        /// 模板语言分类
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 模板创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 模板引用次数
        /// </summary>
        [JsonProperty("used_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedTimes { get; set; }

        /// <summary>
        /// 模板被点赞次数
        /// </summary>
        [JsonProperty("liked_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? LikedTimes { get; set; }

        /// <summary>
        /// 模板创建人
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 模板https链接
        /// </summary>
        [JsonProperty("https_url", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateRepository {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  briefIntroduction: ").Append(BriefIntroduction).Append("\n");
            sb.Append("  autoPendingPipelines: ").Append(AutoPendingPipelines).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
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
            return this.Equals(input as TemplateRepository);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateRepository input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.BriefIntroduction != input.BriefIntroduction || (this.BriefIntroduction != null && !this.BriefIntroduction.Equals(input.BriefIntroduction))) return false;
            if (this.AutoPendingPipelines != input.AutoPendingPipelines || (this.AutoPendingPipelines != null && !this.AutoPendingPipelines.Equals(input.AutoPendingPipelines))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.BriefIntroduction != null) hashCode = hashCode * 59 + this.BriefIntroduction.GetHashCode();
                if (this.AutoPendingPipelines != null) hashCode = hashCode * 59 + this.AutoPendingPipelines.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
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
