using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PublisherRequest 
    {

        /// <summary>
        /// **参数解释**： 发布商名称。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 用户ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释**： 发布商描述。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 发布商图标URL。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("logo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// **参数解释**： 发布商网页地址。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        /// <summary>
        /// **参数解释**： 发布商帮助地址。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("support_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportUrl { get; set; }

        /// <summary>
        /// **参数解释**： 发布商源码地址。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("source_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// **参数解释**： 发布商英文名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("en_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnName { get; set; }

        /// <summary>
        /// **参数解释**： 发布商ID。可通过[查询发布商详情](ShowPublisher.xml)查询。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("publisher_unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublisherUniqueId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublisherRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  logoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  website: ").Append(Website).Append("\n");
            sb.Append("  supportUrl: ").Append(SupportUrl).Append("\n");
            sb.Append("  sourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  enName: ").Append(EnName).Append("\n");
            sb.Append("  publisherUniqueId: ").Append(PublisherUniqueId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublisherRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublisherRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LogoUrl != input.LogoUrl || (this.LogoUrl != null && !this.LogoUrl.Equals(input.LogoUrl))) return false;
            if (this.Website != input.Website || (this.Website != null && !this.Website.Equals(input.Website))) return false;
            if (this.SupportUrl != input.SupportUrl || (this.SupportUrl != null && !this.SupportUrl.Equals(input.SupportUrl))) return false;
            if (this.SourceUrl != input.SourceUrl || (this.SourceUrl != null && !this.SourceUrl.Equals(input.SourceUrl))) return false;
            if (this.EnName != input.EnName || (this.EnName != null && !this.EnName.Equals(input.EnName))) return false;
            if (this.PublisherUniqueId != input.PublisherUniqueId || (this.PublisherUniqueId != null && !this.PublisherUniqueId.Equals(input.PublisherUniqueId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LogoUrl != null) hashCode = hashCode * 59 + this.LogoUrl.GetHashCode();
                if (this.Website != null) hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.SupportUrl != null) hashCode = hashCode * 59 + this.SupportUrl.GetHashCode();
                if (this.SourceUrl != null) hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                if (this.EnName != null) hashCode = hashCode * 59 + this.EnName.GetHashCode();
                if (this.PublisherUniqueId != null) hashCode = hashCode * 59 + this.PublisherUniqueId.GetHashCode();
                return hashCode;
            }
        }
    }
}
