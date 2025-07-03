using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSupportedRegionResponse : SdkResponse
    {

        /// <summary>
        /// region列表。
        /// </summary>
        [JsonProperty("region_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RegionParam> RegionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSupportedRegionResponse {\n");
            sb.Append("  regionList: ").Append(RegionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSupportedRegionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSupportedRegionResponse input)
        {
            if (input == null) return false;
            if (this.RegionList != input.RegionList || (this.RegionList != null && input.RegionList != null && !this.RegionList.SequenceEqual(input.RegionList))) return false;

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
                if (this.RegionList != null) hashCode = hashCode * 59 + this.RegionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
