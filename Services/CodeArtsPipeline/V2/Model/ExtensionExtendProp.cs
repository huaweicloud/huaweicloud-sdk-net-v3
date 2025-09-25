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
    public class ExtensionExtendProp 
    {

        /// <summary>
        /// **参数解释**： API选项。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("api_options", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiOptions { get; set; }

        /// <summary>
        /// **参数解释**： API类型。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("api_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiType { get; set; }

        /// <summary>
        /// **参数解释**： 显示占位符。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("show_placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string ShowPlaceholder { get; set; }

        /// <summary>
        /// **参数解释**： 选项。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public string Options { get; set; }

        /// <summary>
        /// **参数解释**： 禁用条件。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("disabled_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public string DisabledConditions { get; set; }

        /// <summary>
        /// **参数解释**： 可见条件。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("visible_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public string VisibleConditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtensionExtendProp {\n");
            sb.Append("  apiOptions: ").Append(ApiOptions).Append("\n");
            sb.Append("  apiType: ").Append(ApiType).Append("\n");
            sb.Append("  showPlaceholder: ").Append(ShowPlaceholder).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  disabledConditions: ").Append(DisabledConditions).Append("\n");
            sb.Append("  visibleConditions: ").Append(VisibleConditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtensionExtendProp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtensionExtendProp input)
        {
            if (input == null) return false;
            if (this.ApiOptions != input.ApiOptions || (this.ApiOptions != null && !this.ApiOptions.Equals(input.ApiOptions))) return false;
            if (this.ApiType != input.ApiType || (this.ApiType != null && !this.ApiType.Equals(input.ApiType))) return false;
            if (this.ShowPlaceholder != input.ShowPlaceholder || (this.ShowPlaceholder != null && !this.ShowPlaceholder.Equals(input.ShowPlaceholder))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;
            if (this.DisabledConditions != input.DisabledConditions || (this.DisabledConditions != null && !this.DisabledConditions.Equals(input.DisabledConditions))) return false;
            if (this.VisibleConditions != input.VisibleConditions || (this.VisibleConditions != null && !this.VisibleConditions.Equals(input.VisibleConditions))) return false;

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
                if (this.ApiOptions != null) hashCode = hashCode * 59 + this.ApiOptions.GetHashCode();
                if (this.ApiType != null) hashCode = hashCode * 59 + this.ApiType.GetHashCode();
                if (this.ShowPlaceholder != null) hashCode = hashCode * 59 + this.ShowPlaceholder.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.DisabledConditions != null) hashCode = hashCode * 59 + this.DisabledConditions.GetHashCode();
                if (this.VisibleConditions != null) hashCode = hashCode * 59 + this.VisibleConditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
