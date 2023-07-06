using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 数据加工行过滤配置信息
    /// </summary>
    public class GetDataTransformationResp 
    {

        /// <summary>
        /// 数据加工总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 数据过滤配置信息。
        /// </summary>
        [JsonProperty("filter_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataTransformationInfo> FilterConditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDataTransformationResp {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  filterConditions: ").Append(FilterConditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetDataTransformationResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetDataTransformationResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.FilterConditions == input.FilterConditions ||
                    this.FilterConditions != null &&
                    input.FilterConditions != null &&
                    this.FilterConditions.SequenceEqual(input.FilterConditions)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.FilterConditions != null)
                    hashCode = hashCode * 59 + this.FilterConditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
