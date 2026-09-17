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
    /// 
    /// </summary>
    public class RelateAction 
    {

        /// <summary>
        /// **参数解释**： 关联行为code。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**： 关联行为名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("action_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionDisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 关联的对象列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("relate_object_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelationObject> RelateObjectList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelateAction {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  actionDisplayName: ").Append(ActionDisplayName).Append("\n");
            sb.Append("  relateObjectList: ").Append(RelateObjectList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelateAction);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelateAction input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.ActionDisplayName != input.ActionDisplayName || (this.ActionDisplayName != null && !this.ActionDisplayName.Equals(input.ActionDisplayName))) return false;
            if (this.RelateObjectList != input.RelateObjectList || (this.RelateObjectList != null && input.RelateObjectList != null && !this.RelateObjectList.SequenceEqual(input.RelateObjectList))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionDisplayName != null) hashCode = hashCode * 59 + this.ActionDisplayName.GetHashCode();
                if (this.RelateObjectList != null) hashCode = hashCode * 59 + this.RelateObjectList.GetHashCode();
                return hashCode;
            }
        }
    }
}
