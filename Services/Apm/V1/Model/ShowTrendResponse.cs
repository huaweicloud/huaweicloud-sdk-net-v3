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
    public class ShowTrendResponse : SdkResponse
    {

        /// <summary>
        /// 趋势图数据列表。
        /// </summary>
        [JsonProperty("line_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FrontLine> LineList { get; set; }

        /// <summary>
        /// 最后日期时间。
        /// </summary>
        [JsonProperty("latest_data_Time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LatestDataTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrendResponse {\n");
            sb.Append("  lineList: ").Append(LineList).Append("\n");
            sb.Append("  latestDataTime: ").Append(LatestDataTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrendResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrendResponse input)
        {
            if (input == null) return false;
            if (this.LineList != input.LineList || (this.LineList != null && input.LineList != null && !this.LineList.SequenceEqual(input.LineList))) return false;
            if (this.LatestDataTime != input.LatestDataTime || (this.LatestDataTime != null && !this.LatestDataTime.Equals(input.LatestDataTime))) return false;

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
                if (this.LineList != null) hashCode = hashCode * 59 + this.LineList.GetHashCode();
                if (this.LatestDataTime != null) hashCode = hashCode * 59 + this.LatestDataTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
