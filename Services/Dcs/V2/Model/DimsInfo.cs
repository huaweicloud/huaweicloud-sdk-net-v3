using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// CES监控维护信息
    /// </summary>
    public class DimsInfo 
    {

        /// <summary>
        /// **参数解释**： CES监控维度路由。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("dim_k", NullValueHandling = NullValueHandling.Ignore)]
        public string DimK { get; set; }

        /// <summary>
        /// **参数解释**： CES监控维度ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("dim_v", NullValueHandling = NullValueHandling.Ignore)]
        public string DimV { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimsInfo {\n");
            sb.Append("  dimK: ").Append(DimK).Append("\n");
            sb.Append("  dimV: ").Append(DimV).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DimsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DimsInfo input)
        {
            if (input == null) return false;
            if (this.DimK != input.DimK || (this.DimK != null && !this.DimK.Equals(input.DimK))) return false;
            if (this.DimV != input.DimV || (this.DimV != null && !this.DimV.Equals(input.DimV))) return false;

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
                if (this.DimK != null) hashCode = hashCode * 59 + this.DimK.GetHashCode();
                if (this.DimV != null) hashCode = hashCode * 59 + this.DimV.GetHashCode();
                return hashCode;
            }
        }
    }
}
