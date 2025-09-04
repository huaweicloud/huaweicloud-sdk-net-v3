using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListMeasureUnitsResponse : SdkResponse
    {

        /// <summary>
        /// 度量单位信息，具体参见表2。
        /// </summary>
        [JsonProperty("measure_units", NullValueHandling = NullValueHandling.Ignore)]
        public List<MeasureUnitRest> MeasureUnits { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMeasureUnitsResponse {\n");
            sb.Append("  measureUnits: ").Append(MeasureUnits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMeasureUnitsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMeasureUnitsResponse input)
        {
            if (input == null) return false;
            if (this.MeasureUnits != input.MeasureUnits || (this.MeasureUnits != null && input.MeasureUnits != null && !this.MeasureUnits.SequenceEqual(input.MeasureUnits))) return false;

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
                if (this.MeasureUnits != null) hashCode = hashCode * 59 + this.MeasureUnits.GetHashCode();
                return hashCode;
            }
        }
    }
}
