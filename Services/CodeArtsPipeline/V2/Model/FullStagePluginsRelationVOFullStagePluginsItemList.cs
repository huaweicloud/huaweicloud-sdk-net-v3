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
    public class FullStagePluginsRelationVOFullStagePluginsItemList 
    {

        /// <summary>
        /// **参数解释**： 插件列表。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("plugins_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FullStagePluginsRelationVOPluginsList> PluginsList { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件展示名。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件业务类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// **参数解释**： 扩展插件唯一ID。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UniqueId { get; set; }

        /// <summary>
        /// **参数解释**： 运行条件。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Conditions { get; set; }

        /// <summary>
        /// **参数解释**： 额外属性。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("addables", NullValueHandling = NullValueHandling.Ignore)]
        public List<FullStagePluginsRelationVOAddables> Addables { get; set; }

        /// <summary>
        /// **参数解释**： 是否可编辑。 **取值范围**： - true：可编辑。 - false：不可编辑。 
        /// </summary>
        [JsonProperty("editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Editable { get; set; }

        /// <summary>
        /// **参数解释**： 是否可移除。 **取值范围**： - true：可移除。 - false：不可移除。 
        /// </summary>
        [JsonProperty("removable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Removable { get; set; }

        /// <summary>
        /// **参数解释**： 是否可复制。 **取值范围**： - true：可复制。 - false：不可复制。 
        /// </summary>
        [JsonProperty("cloneable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cloneable { get; set; }

        /// <summary>
        /// **参数解释**： 是否禁用。 **取值范围**： - true：禁用。 - false：未禁用。 
        /// </summary>
        [JsonProperty("disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullStagePluginsRelationVOFullStagePluginsItemList {\n");
            sb.Append("  pluginsList: ").Append(PluginsList).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  uniqueId: ").Append(UniqueId).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  addables: ").Append(Addables).Append("\n");
            sb.Append("  editable: ").Append(Editable).Append("\n");
            sb.Append("  removable: ").Append(Removable).Append("\n");
            sb.Append("  cloneable: ").Append(Cloneable).Append("\n");
            sb.Append("  disabled: ").Append(Disabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullStagePluginsRelationVOFullStagePluginsItemList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullStagePluginsRelationVOFullStagePluginsItemList input)
        {
            if (input == null) return false;
            if (this.PluginsList != input.PluginsList || (this.PluginsList != null && input.PluginsList != null && !this.PluginsList.SequenceEqual(input.PluginsList))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.UniqueId != input.UniqueId || (this.UniqueId != null && !this.UniqueId.Equals(input.UniqueId))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;
            if (this.Addables != input.Addables || (this.Addables != null && input.Addables != null && !this.Addables.SequenceEqual(input.Addables))) return false;
            if (this.Editable != input.Editable || (this.Editable != null && !this.Editable.Equals(input.Editable))) return false;
            if (this.Removable != input.Removable || (this.Removable != null && !this.Removable.Equals(input.Removable))) return false;
            if (this.Cloneable != input.Cloneable || (this.Cloneable != null && !this.Cloneable.Equals(input.Cloneable))) return false;
            if (this.Disabled != input.Disabled || (this.Disabled != null && !this.Disabled.Equals(input.Disabled))) return false;

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
                if (this.PluginsList != null) hashCode = hashCode * 59 + this.PluginsList.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.UniqueId != null) hashCode = hashCode * 59 + this.UniqueId.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Addables != null) hashCode = hashCode * 59 + this.Addables.GetHashCode();
                if (this.Editable != null) hashCode = hashCode * 59 + this.Editable.GetHashCode();
                if (this.Removable != null) hashCode = hashCode * 59 + this.Removable.GetHashCode();
                if (this.Cloneable != null) hashCode = hashCode * 59 + this.Cloneable.GetHashCode();
                if (this.Disabled != null) hashCode = hashCode * 59 + this.Disabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
