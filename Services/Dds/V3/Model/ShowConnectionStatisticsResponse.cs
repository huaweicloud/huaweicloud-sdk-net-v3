using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowConnectionStatisticsResponse : SdkResponse
    {

        /// <summary>
        /// 总连接数，包括内部连接与外部连接。
        /// </summary>
        [JsonProperty("total_connections", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalConnections { get; set; }

        /// <summary>
        /// 内部总连接数。
        /// </summary>
        [JsonProperty("total_inner_connections", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalInnerConnections { get; set; }

        /// <summary>
        /// 外部总连接数。
        /// </summary>
        [JsonProperty("total_outer_connections", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalOuterConnections { get; set; }

        /// <summary>
        /// 内部连接统计信息数组，最大记录数为200条。
        /// </summary>
        [JsonProperty("inner_connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryConnectionsResponse> InnerConnections { get; set; }

        /// <summary>
        /// 外部连接统计信息数组，最大记录数为200条。
        /// </summary>
        [JsonProperty("outer_connections", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryConnectionsResponse> OuterConnections { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConnectionStatisticsResponse {\n");
            sb.Append("  totalConnections: ").Append(TotalConnections).Append("\n");
            sb.Append("  totalInnerConnections: ").Append(TotalInnerConnections).Append("\n");
            sb.Append("  totalOuterConnections: ").Append(TotalOuterConnections).Append("\n");
            sb.Append("  innerConnections: ").Append(InnerConnections).Append("\n");
            sb.Append("  outerConnections: ").Append(OuterConnections).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConnectionStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConnectionStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.TotalConnections != input.TotalConnections || (this.TotalConnections != null && !this.TotalConnections.Equals(input.TotalConnections))) return false;
            if (this.TotalInnerConnections != input.TotalInnerConnections || (this.TotalInnerConnections != null && !this.TotalInnerConnections.Equals(input.TotalInnerConnections))) return false;
            if (this.TotalOuterConnections != input.TotalOuterConnections || (this.TotalOuterConnections != null && !this.TotalOuterConnections.Equals(input.TotalOuterConnections))) return false;
            if (this.InnerConnections != input.InnerConnections || (this.InnerConnections != null && input.InnerConnections != null && !this.InnerConnections.SequenceEqual(input.InnerConnections))) return false;
            if (this.OuterConnections != input.OuterConnections || (this.OuterConnections != null && input.OuterConnections != null && !this.OuterConnections.SequenceEqual(input.OuterConnections))) return false;

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
                if (this.TotalConnections != null) hashCode = hashCode * 59 + this.TotalConnections.GetHashCode();
                if (this.TotalInnerConnections != null) hashCode = hashCode * 59 + this.TotalInnerConnections.GetHashCode();
                if (this.TotalOuterConnections != null) hashCode = hashCode * 59 + this.TotalOuterConnections.GetHashCode();
                if (this.InnerConnections != null) hashCode = hashCode * 59 + this.InnerConnections.GetHashCode();
                if (this.OuterConnections != null) hashCode = hashCode * 59 + this.OuterConnections.GetHashCode();
                return hashCode;
            }
        }
    }
}
