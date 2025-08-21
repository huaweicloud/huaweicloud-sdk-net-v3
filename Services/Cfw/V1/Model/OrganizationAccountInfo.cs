using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class OrganizationAccountInfo 
    {

        /// <summary>
        /// **参数解释**： 是否已添加 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("delegated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delegated { get; set; }

        /// <summary>
        /// **参数解释**： 账号的唯一标识符 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 账号名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 组织节点类型 **取值范围**： account
        /// </summary>
        [JsonProperty("org_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgType { get; set; }

        /// <summary>
        /// **参数解释**： 父节点（根或组织单元）的唯一标识符（ID） **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 账号的统一资源名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("urn", NullValueHandling = NullValueHandling.Ignore)]
        public string Urn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationAccountInfo {\n");
            sb.Append("  delegated: ").Append(Delegated).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  orgType: ").Append(OrgType).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  urn: ").Append(Urn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganizationAccountInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrganizationAccountInfo input)
        {
            if (input == null) return false;
            if (this.Delegated != input.Delegated || (this.Delegated != null && !this.Delegated.Equals(input.Delegated))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.OrgType != input.OrgType || (this.OrgType != null && !this.OrgType.Equals(input.OrgType))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Urn != input.Urn || (this.Urn != null && !this.Urn.Equals(input.Urn))) return false;

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
                if (this.Delegated != null) hashCode = hashCode * 59 + this.Delegated.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OrgType != null) hashCode = hashCode * 59 + this.OrgType.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Urn != null) hashCode = hashCode * 59 + this.Urn.GetHashCode();
                return hashCode;
            }
        }
    }
}
