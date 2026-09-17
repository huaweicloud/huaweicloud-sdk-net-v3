using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 工作项详情响应
    /// </summary>
    public class IssueDetailsResponse 
    {

        /// <summary>
        /// **参数解释**： 工作项ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 工作项编号。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// **参数解释**： 工作项类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 停留天数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("stay_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? StayDays { get; set; }

        /// <summary>
        /// **参数解释**： 租户ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// **参数解释**： 工作项创建时间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// **参数解释**： 工作项标题。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_level", NullValueHandling = NullValueHandling.Ignore)]
        public SecurityLevelResult SecurityLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueDetailsResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  stayDays: ").Append(StayDays).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  securityLevel: ").Append(SecurityLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueDetailsResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.StayDays != input.StayDays || (this.StayDays != null && !this.StayDays.Equals(input.StayDays))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.SecurityLevel != input.SecurityLevel || (this.SecurityLevel != null && !this.SecurityLevel.Equals(input.SecurityLevel))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StayDays != null) hashCode = hashCode * 59 + this.StayDays.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.SecurityLevel != null) hashCode = hashCode * 59 + this.SecurityLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
