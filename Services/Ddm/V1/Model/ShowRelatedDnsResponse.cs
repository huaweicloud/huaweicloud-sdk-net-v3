using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowRelatedDnsResponse : SdkResponse
    {

        /// <summary>
        /// 关联DN。
        /// </summary>
        [JsonProperty("related_data_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelatedDnVO> RelatedDataNodes { get; set; }

        /// <summary>
        /// 最近恢复时间点。
        /// </summary>
        [JsonProperty("latest_restorable_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestRestorableTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRelatedDnsResponse {\n");
            sb.Append("  relatedDataNodes: ").Append(RelatedDataNodes).Append("\n");
            sb.Append("  latestRestorableTime: ").Append(LatestRestorableTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRelatedDnsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRelatedDnsResponse input)
        {
            if (input == null) return false;
            if (this.RelatedDataNodes != input.RelatedDataNodes || (this.RelatedDataNodes != null && input.RelatedDataNodes != null && !this.RelatedDataNodes.SequenceEqual(input.RelatedDataNodes))) return false;
            if (this.LatestRestorableTime != input.LatestRestorableTime || (this.LatestRestorableTime != null && !this.LatestRestorableTime.Equals(input.LatestRestorableTime))) return false;

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
                if (this.RelatedDataNodes != null) hashCode = hashCode * 59 + this.RelatedDataNodes.GetHashCode();
                if (this.LatestRestorableTime != null) hashCode = hashCode * 59 + this.LatestRestorableTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
