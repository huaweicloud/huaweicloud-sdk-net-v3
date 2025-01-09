using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowGrowthRateResponse : SdkResponse
    {

        /// <summary>
        /// 环比值
        /// </summary>
        [JsonProperty("growth_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? GrowthRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGrowthRateResponse {\n");
            sb.Append("  growthRate: ").Append(GrowthRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGrowthRateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGrowthRateResponse input)
        {
            if (input == null) return false;
            if (this.GrowthRate != input.GrowthRate || (this.GrowthRate != null && !this.GrowthRate.Equals(input.GrowthRate))) return false;

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
                if (this.GrowthRate != null) hashCode = hashCode * 59 + this.GrowthRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
