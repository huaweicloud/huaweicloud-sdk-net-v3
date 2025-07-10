using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDriftDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 漂移详细信息。
        /// </summary>
        [JsonProperty("drift_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<DriftDetail> DriftDetails { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDriftDetailsResponse {\n");
            sb.Append("  driftDetails: ").Append(DriftDetails).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDriftDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDriftDetailsResponse input)
        {
            if (input == null) return false;
            if (this.DriftDetails != input.DriftDetails || (this.DriftDetails != null && input.DriftDetails != null && !this.DriftDetails.SequenceEqual(input.DriftDetails))) return false;

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
                if (this.DriftDetails != null) hashCode = hashCode * 59 + this.DriftDetails.GetHashCode();
                return hashCode;
            }
        }
    }
}
