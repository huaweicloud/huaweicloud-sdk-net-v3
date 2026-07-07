using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// **参数解释**:  备份资源包规格。
    /// </summary>
    public class BackupResourcePackageFlavor 
    {

        /// <summary>
        /// **参数解释**：  备份资源包规格码。  **取值范围**：  不涉及。 
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// **参数解释**：  备份资源包规格。  **取值范围**：  不涉及。 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public string Volume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupResourcePackageFlavor {\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupResourcePackageFlavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupResourcePackageFlavor input)
        {
            if (input == null) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;

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
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                return hashCode;
            }
        }
    }
}
