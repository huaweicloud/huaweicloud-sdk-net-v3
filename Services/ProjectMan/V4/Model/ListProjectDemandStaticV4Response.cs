using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListProjectDemandStaticV4Response : SdkResponse
    {

        /// <summary>
        /// 需求统计
        /// </summary>
        [JsonProperty("demand_statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<DemandStatisticResponseV4> DemandStatistics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectDemandStaticV4Response {\n");
            sb.Append("  demandStatistics: ").Append(DemandStatistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectDemandStaticV4Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectDemandStaticV4Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DemandStatistics == input.DemandStatistics ||
                    this.DemandStatistics != null &&
                    input.DemandStatistics != null &&
                    this.DemandStatistics.SequenceEqual(input.DemandStatistics)
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
                if (this.DemandStatistics != null)
                    hashCode = hashCode * 59 + this.DemandStatistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
