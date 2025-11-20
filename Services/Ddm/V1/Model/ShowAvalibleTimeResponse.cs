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
    public class ShowAvalibleTimeResponse : SdkResponse
    {

        /// <summary>
        /// 可恢复时间点。
        /// </summary>
        [JsonProperty("restorable_time_intervals", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreTimeInterval> RestorableTimeIntervals { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAvalibleTimeResponse {\n");
            sb.Append("  restorableTimeIntervals: ").Append(RestorableTimeIntervals).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAvalibleTimeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAvalibleTimeResponse input)
        {
            if (input == null) return false;
            if (this.RestorableTimeIntervals != input.RestorableTimeIntervals || (this.RestorableTimeIntervals != null && input.RestorableTimeIntervals != null && !this.RestorableTimeIntervals.SequenceEqual(input.RestorableTimeIntervals))) return false;

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
                if (this.RestorableTimeIntervals != null) hashCode = hashCode * 59 + this.RestorableTimeIntervals.GetHashCode();
                return hashCode;
            }
        }
    }
}
