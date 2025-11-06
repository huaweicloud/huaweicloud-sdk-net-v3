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
    /// 
    /// </summary>
    public class BasicRoleDto 
    {

        /// <summary>
        /// **参数解释：** 角色ID。 **取值范围：** 1-2147483647
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：** 角色名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：**  关联角色ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("related_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedRoleId { get; set; }

        /// <summary>
        /// **参数解释：** 角色中文名。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("chinese_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ChineseName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BasicRoleDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  relatedRoleId: ").Append(RelatedRoleId).Append("\n");
            sb.Append("  chineseName: ").Append(ChineseName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BasicRoleDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BasicRoleDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RelatedRoleId != input.RelatedRoleId || (this.RelatedRoleId != null && !this.RelatedRoleId.Equals(input.RelatedRoleId))) return false;
            if (this.ChineseName != input.ChineseName || (this.ChineseName != null && !this.ChineseName.Equals(input.ChineseName))) return false;

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
                if (this.RelatedRoleId != null) hashCode = hashCode * 59 + this.RelatedRoleId.GetHashCode();
                if (this.ChineseName != null) hashCode = hashCode * 59 + this.ChineseName.GetHashCode();
                return hashCode;
            }
        }
    }
}
