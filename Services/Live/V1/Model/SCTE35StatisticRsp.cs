using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 获取SCTE35信号的响应体。
    /// </summary>
    public class SCTE35StatisticRsp 
    {

        /// <summary>
        /// 查询到scet35信息的总个数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 详细的scte35信号的数组。
        /// </summary>
        [JsonProperty("scte35_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<SCTE35InfoItem> Scte35Info { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SCTE35StatisticRsp {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  scte35Info: ").Append(Scte35Info).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SCTE35StatisticRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SCTE35StatisticRsp input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Scte35Info != input.Scte35Info || (this.Scte35Info != null && input.Scte35Info != null && !this.Scte35Info.SequenceEqual(input.Scte35Info))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Scte35Info != null) hashCode = hashCode * 59 + this.Scte35Info.GetHashCode();
                return hashCode;
            }
        }
    }
}
