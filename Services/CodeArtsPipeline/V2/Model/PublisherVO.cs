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
    public class PublisherVO 
    {

        /// <summary>
        /// **参数解释**： 发布商ID。可通过[查询发布商详情](ShowPublisher.xml)查询。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("publisher_unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublisherUniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 用户ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释**： 发布商描述。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 发布商图标URL。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("logo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// **参数解释**： 创建发布商时填入的网页地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("website", NullValueHandling = NullValueHandling.Ignore)]
        public string Website { get; set; }

        /// <summary>
        /// **参数解释**： 创建发布商时填入的帮助地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("support_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportUrl { get; set; }

        /// <summary>
        /// **参数解释**： 创建发布商时填入的源地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("source_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// **参数解释**： 发布商英文名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("en_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnName { get; set; }

        /// <summary>
        /// **参数解释**： 发布商中文名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 授权状态。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("auth_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthStatus { get; set; }

        /// <summary>
        /// **参数解释**： 是否删除。 **取值范围**： - 0：未删除。 - 1：已删除。 
        /// </summary>
        [JsonProperty("is_delete", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsDelete { get; set; }

        /// <summary>
        /// **参数解释**： 最后更新人名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("last_update_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateUserName { get; set; }

        /// <summary>
        /// **参数解释**： 最后更新人用户ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("last_update_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateUserId { get; set; }

        /// <summary>
        /// **参数解释**： 最后更新时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublisherVO {\n");
            sb.Append("  publisherUniqueId: ").Append(PublisherUniqueId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  logoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  website: ").Append(Website).Append("\n");
            sb.Append("  supportUrl: ").Append(SupportUrl).Append("\n");
            sb.Append("  sourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  enName: ").Append(EnName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  authStatus: ").Append(AuthStatus).Append("\n");
            sb.Append("  isDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  lastUpdateUserName: ").Append(LastUpdateUserName).Append("\n");
            sb.Append("  lastUpdateUserId: ").Append(LastUpdateUserId).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublisherVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublisherVO input)
        {
            if (input == null) return false;
            if (this.PublisherUniqueId != input.PublisherUniqueId || (this.PublisherUniqueId != null && !this.PublisherUniqueId.Equals(input.PublisherUniqueId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.LogoUrl != input.LogoUrl || (this.LogoUrl != null && !this.LogoUrl.Equals(input.LogoUrl))) return false;
            if (this.Website != input.Website || (this.Website != null && !this.Website.Equals(input.Website))) return false;
            if (this.SupportUrl != input.SupportUrl || (this.SupportUrl != null && !this.SupportUrl.Equals(input.SupportUrl))) return false;
            if (this.SourceUrl != input.SourceUrl || (this.SourceUrl != null && !this.SourceUrl.Equals(input.SourceUrl))) return false;
            if (this.EnName != input.EnName || (this.EnName != null && !this.EnName.Equals(input.EnName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AuthStatus != input.AuthStatus || (this.AuthStatus != null && !this.AuthStatus.Equals(input.AuthStatus))) return false;
            if (this.IsDelete != input.IsDelete || (this.IsDelete != null && !this.IsDelete.Equals(input.IsDelete))) return false;
            if (this.LastUpdateUserName != input.LastUpdateUserName || (this.LastUpdateUserName != null && !this.LastUpdateUserName.Equals(input.LastUpdateUserName))) return false;
            if (this.LastUpdateUserId != input.LastUpdateUserId || (this.LastUpdateUserId != null && !this.LastUpdateUserId.Equals(input.LastUpdateUserId))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;

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
                if (this.PublisherUniqueId != null) hashCode = hashCode * 59 + this.PublisherUniqueId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LogoUrl != null) hashCode = hashCode * 59 + this.LogoUrl.GetHashCode();
                if (this.Website != null) hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.SupportUrl != null) hashCode = hashCode * 59 + this.SupportUrl.GetHashCode();
                if (this.SourceUrl != null) hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                if (this.EnName != null) hashCode = hashCode * 59 + this.EnName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AuthStatus != null) hashCode = hashCode * 59 + this.AuthStatus.GetHashCode();
                if (this.IsDelete != null) hashCode = hashCode * 59 + this.IsDelete.GetHashCode();
                if (this.LastUpdateUserName != null) hashCode = hashCode * 59 + this.LastUpdateUserName.GetHashCode();
                if (this.LastUpdateUserId != null) hashCode = hashCode * 59 + this.LastUpdateUserId.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
