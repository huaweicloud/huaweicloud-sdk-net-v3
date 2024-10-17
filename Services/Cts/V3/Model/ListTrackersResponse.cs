using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTrackersResponse : SdkResponse
    {

        /// <summary>
        /// 本次查询追踪器列表返回的追踪器数组。
        /// </summary>
        [JsonProperty("trackers", NullValueHandling = NullValueHandling.Ignore)]
        public List<TrackerResponseBody> Trackers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTrackersResponse {\n");
            sb.Append("  trackers: ").Append(Trackers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTrackersResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTrackersResponse input)
        {
            if (input == null) return false;
            if (this.Trackers != input.Trackers || (this.Trackers != null && input.Trackers != null && !this.Trackers.SequenceEqual(input.Trackers))) return false;

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
                if (this.Trackers != null) hashCode = hashCode * 59 + this.Trackers.GetHashCode();
                return hashCode;
            }
        }
    }
}
