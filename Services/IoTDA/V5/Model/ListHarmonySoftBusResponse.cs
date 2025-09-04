using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHarmonySoftBusResponse : SdkResponse
    {

        /// <summary>
        /// 设备组信息列表。
        /// </summary>
        [JsonProperty("harmony_soft_buses", NullValueHandling = NullValueHandling.Ignore)]
        public List<HarmonySoftBusResponseDTO> HarmonySoftBuses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public Page Page { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHarmonySoftBusResponse {\n");
            sb.Append("  harmonySoftBuses: ").Append(HarmonySoftBuses).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHarmonySoftBusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHarmonySoftBusResponse input)
        {
            if (input == null) return false;
            if (this.HarmonySoftBuses != input.HarmonySoftBuses || (this.HarmonySoftBuses != null && input.HarmonySoftBuses != null && !this.HarmonySoftBuses.SequenceEqual(input.HarmonySoftBuses))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;

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
                if (this.HarmonySoftBuses != null) hashCode = hashCode * 59 + this.HarmonySoftBuses.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                return hashCode;
            }
        }
    }
}
