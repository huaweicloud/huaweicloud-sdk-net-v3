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
    public class FullStagePluginsRelationVOAddables 
    {

        /// <summary>
        /// **参数解释**： 额外属性1。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("additionalProp1", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdditionalProp1 { get; set; }

        /// <summary>
        /// **参数解释**： 额外属性2。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("additionalProp2", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdditionalProp2 { get; set; }

        /// <summary>
        /// **参数解释**： 额外属性3。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("additionalProp3", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdditionalProp3 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullStagePluginsRelationVOAddables {\n");
            sb.Append("  additionalProp1: ").Append(AdditionalProp1).Append("\n");
            sb.Append("  additionalProp2: ").Append(AdditionalProp2).Append("\n");
            sb.Append("  additionalProp3: ").Append(AdditionalProp3).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullStagePluginsRelationVOAddables);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullStagePluginsRelationVOAddables input)
        {
            if (input == null) return false;
            if (this.AdditionalProp1 != input.AdditionalProp1 || (this.AdditionalProp1 != null && !this.AdditionalProp1.Equals(input.AdditionalProp1))) return false;
            if (this.AdditionalProp2 != input.AdditionalProp2 || (this.AdditionalProp2 != null && !this.AdditionalProp2.Equals(input.AdditionalProp2))) return false;
            if (this.AdditionalProp3 != input.AdditionalProp3 || (this.AdditionalProp3 != null && !this.AdditionalProp3.Equals(input.AdditionalProp3))) return false;

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
                if (this.AdditionalProp1 != null) hashCode = hashCode * 59 + this.AdditionalProp1.GetHashCode();
                if (this.AdditionalProp2 != null) hashCode = hashCode * 59 + this.AdditionalProp2.GetHashCode();
                if (this.AdditionalProp3 != null) hashCode = hashCode * 59 + this.AdditionalProp3.GetHashCode();
                return hashCode;
            }
        }
    }
}
