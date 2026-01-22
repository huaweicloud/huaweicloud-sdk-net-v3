using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 特性列表。
    /// </summary>
    public class ListConfigFeatures 
    {

        /// <summary>
        /// **参数解释**： 特性ID。     **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("featureId", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureId { get; set; }

        /// <summary>
        /// **参数解释**： 状态。  **取值范围**： - 1：特性开启。 - 0：特性关闭。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// **参数解释**： 特性描述。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigFeatures {\n");
            sb.Append("  featureId: ").Append(FeatureId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigFeatures);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigFeatures input)
        {
            if (input == null) return false;
            if (this.FeatureId != input.FeatureId || (this.FeatureId != null && !this.FeatureId.Equals(input.FeatureId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.FeatureId != null) hashCode = hashCode * 59 + this.FeatureId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
