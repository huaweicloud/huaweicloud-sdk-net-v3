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
    /// 关联关系
    /// </summary>
    public class Relation 
    {

        /// <summary>
        /// **参数解释**： 关系code。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 关联的工作项code列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("categories", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// **参数解释**： 工作流场景使用，前置校验中的关联关系校验字段。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("link_field_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkFieldCode { get; set; }

        /// <summary>
        /// **参数解释**： 关系名称，在工作项详情关联项下左侧显示。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("relation_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationName { get; set; }

        /// <summary>
        /// **参数解释**： 关系描述。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 展示范围。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("display_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayScope { get; set; }

        /// <summary>
        /// **参数解释**： 动作行为。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelateAction> Actions { get; set; }

        /// <summary>
        /// **参数解释**： 动作行为。 **取值范围**： - ONE_TO_ONE 一对一 - ONE_TO_MANY 一对多 - MANY_TO_ONE 多对一 - MANY_TO_MANY 多对多
        /// </summary>
        [JsonProperty("relate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelateType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Relation {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  categories: ").Append(Categories).Append("\n");
            sb.Append("  linkFieldCode: ").Append(LinkFieldCode).Append("\n");
            sb.Append("  relationName: ").Append(RelationName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  displayScope: ").Append(DisplayScope).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("  relateType: ").Append(RelateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Relation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Relation input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Categories != input.Categories || (this.Categories != null && input.Categories != null && !this.Categories.SequenceEqual(input.Categories))) return false;
            if (this.LinkFieldCode != input.LinkFieldCode || (this.LinkFieldCode != null && !this.LinkFieldCode.Equals(input.LinkFieldCode))) return false;
            if (this.RelationName != input.RelationName || (this.RelationName != null && !this.RelationName.Equals(input.RelationName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DisplayScope != input.DisplayScope || (this.DisplayScope != null && !this.DisplayScope.Equals(input.DisplayScope))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;
            if (this.RelateType != input.RelateType || (this.RelateType != null && !this.RelateType.Equals(input.RelateType))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Categories != null) hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.LinkFieldCode != null) hashCode = hashCode * 59 + this.LinkFieldCode.GetHashCode();
                if (this.RelationName != null) hashCode = hashCode * 59 + this.RelationName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayScope != null) hashCode = hashCode * 59 + this.DisplayScope.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                if (this.RelateType != null) hashCode = hashCode * 59 + this.RelateType.GetHashCode();
                return hashCode;
            }
        }
    }
}
