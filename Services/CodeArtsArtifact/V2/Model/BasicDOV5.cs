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
    /// 
    /// </summary>
    public class BasicDOV5 
    {

        /// <summary>
        /// **参数解释**: 仓库状态。 **取值范围**: active：正常。 delete：删除。 disabled：无效。 view：私有库浏览者。 trash：废弃。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**: 租户id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**: 区域。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// **参数解释**: 创建时间，时间格式：yyyy-MM-dd HH:mm:ss。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("created_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// **参数解释**: 修改时间，时间格式：yyyy-MM-dd HH:mm:ss。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// **参数解释**: 创建人id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("created_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedUserId { get; set; }

        /// <summary>
        /// **参数解释**: 创建人。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("created_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedUserName { get; set; }

        /// <summary>
        /// **参数解释**: 修改人id。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("modified_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedUserId { get; set; }

        /// <summary>
        /// **参数解释**: 修改人。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("modified_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedUserName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicDOV5 {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  createdTime: ").Append(CreatedTime).Append("\n");
            sb.Append("  modifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  createdUserId: ").Append(CreatedUserId).Append("\n");
            sb.Append("  createdUserName: ").Append(CreatedUserName).Append("\n");
            sb.Append("  modifiedUserId: ").Append(ModifiedUserId).Append("\n");
            sb.Append("  modifiedUserName: ").Append(ModifiedUserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BasicDOV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BasicDOV5 input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CreatedTime != input.CreatedTime || (this.CreatedTime != null && !this.CreatedTime.Equals(input.CreatedTime))) return false;
            if (this.ModifiedTime != input.ModifiedTime || (this.ModifiedTime != null && !this.ModifiedTime.Equals(input.ModifiedTime))) return false;
            if (this.CreatedUserId != input.CreatedUserId || (this.CreatedUserId != null && !this.CreatedUserId.Equals(input.CreatedUserId))) return false;
            if (this.CreatedUserName != input.CreatedUserName || (this.CreatedUserName != null && !this.CreatedUserName.Equals(input.CreatedUserName))) return false;
            if (this.ModifiedUserId != input.ModifiedUserId || (this.ModifiedUserId != null && !this.ModifiedUserId.Equals(input.ModifiedUserId))) return false;
            if (this.ModifiedUserName != input.ModifiedUserName || (this.ModifiedUserName != null && !this.ModifiedUserName.Equals(input.ModifiedUserName))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CreatedTime != null) hashCode = hashCode * 59 + this.CreatedTime.GetHashCode();
                if (this.ModifiedTime != null) hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.CreatedUserId != null) hashCode = hashCode * 59 + this.CreatedUserId.GetHashCode();
                if (this.CreatedUserName != null) hashCode = hashCode * 59 + this.CreatedUserName.GetHashCode();
                if (this.ModifiedUserId != null) hashCode = hashCode * 59 + this.ModifiedUserId.GetHashCode();
                if (this.ModifiedUserName != null) hashCode = hashCode * 59 + this.ModifiedUserName.GetHashCode();
                return hashCode;
            }
        }
    }
}
