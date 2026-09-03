using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 更新企业自研技能请求。
    /// </summary>
    public class UpdateSkillReq 
    {

        /// <summary>
        /// 技能名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 别名（业务界面可修改的名称）。
        /// </summary>
        [JsonProperty("alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasName { get; set; }

        /// <summary>
        /// 技能描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public SkillCategoryEnum? Category { get; set; }

        /// <summary>
        /// 技能标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 封面图 base64 编码。
        /// </summary>
        [JsonProperty("cover", NullValueHandling = NullValueHandling.Ignore)]
        public string Cover { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public SkillStatusEnum? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public SkillSourceEnum? Source { get; set; }

        /// <summary>
        /// 支持的操作系统类型列表。
        /// </summary>
        [JsonProperty("support_os_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportOsTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSkillReq {\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  aliasName: ").Append(AliasName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  cover: ").Append(Cover).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  supportOsTypes: ").Append(SupportOsTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSkillReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSkillReq input)
        {
            if (input == null) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.AliasName != input.AliasName || (this.AliasName != null && !this.AliasName.Equals(input.AliasName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Cover != input.Cover || (this.Cover != null && !this.Cover.Equals(input.Cover))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.SupportOsTypes != input.SupportOsTypes || (this.SupportOsTypes != null && input.SupportOsTypes != null && !this.SupportOsTypes.SequenceEqual(input.SupportOsTypes))) return false;

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
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.AliasName != null) hashCode = hashCode * 59 + this.AliasName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Cover != null) hashCode = hashCode * 59 + this.Cover.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SupportOsTypes != null) hashCode = hashCode * 59 + this.SupportOsTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
