using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceEngineDetailResponse : SdkResponse
    {

        /// <summary>
        /// 引擎版本和相应的实例详情。
        /// </summary>
        [JsonProperty("engine_instance_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceEngineDetail> EngineInstanceDetails { get; set; }

        /// <summary>
        /// 引擎版本数量。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceEngineDetailResponse {\n");
            sb.Append("  engineInstanceDetails: ").Append(EngineInstanceDetails).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceEngineDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceEngineDetailResponse input)
        {
            if (input == null) return false;
            if (this.EngineInstanceDetails != input.EngineInstanceDetails || (this.EngineInstanceDetails != null && input.EngineInstanceDetails != null && !this.EngineInstanceDetails.SequenceEqual(input.EngineInstanceDetails))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.EngineInstanceDetails != null) hashCode = hashCode * 59 + this.EngineInstanceDetails.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
