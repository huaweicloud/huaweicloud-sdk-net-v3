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
    public class RuleInstanceContent 
    {

        /// <summary>
        /// **参数解释**： 分组名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释**： 是否可编辑。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Editable { get; set; }

        /// <summary>
        /// **参数解释**： 分组类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： 继承后的子策略是否可以修改阈值。 **取值范围**： - true：可以修改阈值。 - false：不可以修改阈值。 
        /// </summary>
        [JsonProperty("can_modify_when_inherit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanModifyWhenInherit { get; set; }

        /// <summary>
        /// **参数解释**： 规则属性列表。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public List<RuleInstanceProperty> Properties { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleInstanceContent {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  editable: ").Append(Editable).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  canModifyWhenInherit: ").Append(CanModifyWhenInherit).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleInstanceContent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleInstanceContent input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.Editable != input.Editable || (this.Editable != null && !this.Editable.Equals(input.Editable))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.CanModifyWhenInherit != input.CanModifyWhenInherit || (this.CanModifyWhenInherit != null && !this.CanModifyWhenInherit.Equals(input.CanModifyWhenInherit))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && input.Properties != null && !this.Properties.SequenceEqual(input.Properties))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Editable != null) hashCode = hashCode * 59 + this.Editable.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CanModifyWhenInherit != null) hashCode = hashCode * 59 + this.CanModifyWhenInherit.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }
    }
}
