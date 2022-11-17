using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListStatisticsOfRunningInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 该租户下处于“运行中”状态的实例的统计信息。
        /// </summary>
        [JsonProperty("statistics", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceStatistic> Statistics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStatisticsOfRunningInstancesResponse {\n");
            sb.Append("  statistics: ").Append(Statistics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStatisticsOfRunningInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStatisticsOfRunningInstancesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statistics == input.Statistics ||
                    this.Statistics != null &&
                    input.Statistics != null &&
                    this.Statistics.SequenceEqual(input.Statistics)
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
                if (this.Statistics != null)
                    hashCode = hashCode * 59 + this.Statistics.GetHashCode();
                return hashCode;
            }
        }
    }
}
