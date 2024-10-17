using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 时间序列查询参数详情。
    /// </summary>
    public class SeriesAPIQueryItemParam 
    {

        /// <summary>
        /// 通过该数组传递的参数信息进行时间序列查询。
        /// </summary>
        [JsonProperty("series", NullValueHandling = NullValueHandling.Ignore)]
        public List<QuerySeriesOptionParam> Series { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeriesAPIQueryItemParam {\n");
            sb.Append("  series: ").Append(Series).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SeriesAPIQueryItemParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SeriesAPIQueryItemParam input)
        {
            if (input == null) return false;
            if (this.Series != input.Series || (this.Series != null && input.Series != null && !this.Series.SequenceEqual(input.Series))) return false;

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
                if (this.Series != null) hashCode = hashCode * 59 + this.Series.GetHashCode();
                return hashCode;
            }
        }
    }
}
