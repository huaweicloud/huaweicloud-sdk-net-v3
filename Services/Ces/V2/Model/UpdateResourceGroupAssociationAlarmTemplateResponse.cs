using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateResourceGroupAssociationAlarmTemplateResponse : SdkResponse
    {

        /// <summary>
        /// 资源分组ID，以rg开头，后跟22位由字母或数字组成的字符串
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 关联的告警模板的ID列表
        /// </summary>
        [JsonProperty("template_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TemplateIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateResourceGroupAssociationAlarmTemplateResponse {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  templateIds: ").Append(TemplateIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateResourceGroupAssociationAlarmTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateResourceGroupAssociationAlarmTemplateResponse input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.TemplateIds != input.TemplateIds || (this.TemplateIds != null && input.TemplateIds != null && !this.TemplateIds.SequenceEqual(input.TemplateIds))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.TemplateIds != null) hashCode = hashCode * 59 + this.TemplateIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
