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
    public class ListProvincesResponse : SdkResponse
    {

        /// <summary>
        /// 查询个数，成功的时候返回。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 省份信息列表，成功的时候返回，具体参见表3。
        /// </summary>
        [JsonProperty("provinces", NullValueHandling = NullValueHandling.Ignore)]
        public List<Province> Provinces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProvincesResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  provinces: ").Append(Provinces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProvincesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProvincesResponse input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Provinces != input.Provinces || (this.Provinces != null && input.Provinces != null && !this.Provinces.SequenceEqual(input.Provinces))) return false;

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
                if (this.Provinces != null) hashCode = hashCode * 59 + this.Provinces.GetHashCode();
                return hashCode;
            }
        }
    }
}
