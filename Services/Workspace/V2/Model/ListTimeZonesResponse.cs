using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTimeZonesResponse : SdkResponse
    {

        /// <summary>
        /// 时区列表。
        /// </summary>
        [JsonProperty("time_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<Timezones> TimeZones { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTimeZonesResponse {\n");
            sb.Append("  timeZones: ").Append(TimeZones).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTimeZonesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTimeZonesResponse input)
        {
            if (input == null) return false;
            if (this.TimeZones != input.TimeZones || (this.TimeZones != null && input.TimeZones != null && !this.TimeZones.SequenceEqual(input.TimeZones))) return false;

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
                if (this.TimeZones != null) hashCode = hashCode * 59 + this.TimeZones.GetHashCode();
                return hashCode;
            }
        }
    }
}
