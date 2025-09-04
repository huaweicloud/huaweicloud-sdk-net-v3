using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCitiesResponse : SdkResponse
    {

        /// <summary>
        /// 查询个数，成功的时候返回。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 城市信息列表，成功的时候返回，具体参见表2。
        /// </summary>
        [JsonProperty("cities", NullValueHandling = NullValueHandling.Ignore)]
        public List<City> Cities { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCitiesResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  cities: ").Append(Cities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCitiesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCitiesResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Cities != input.Cities || (this.Cities != null && input.Cities != null && !this.Cities.SequenceEqual(input.Cities))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Cities != null) hashCode = hashCode * 59 + this.Cities.GetHashCode();
                return hashCode;
            }
        }
    }
}
