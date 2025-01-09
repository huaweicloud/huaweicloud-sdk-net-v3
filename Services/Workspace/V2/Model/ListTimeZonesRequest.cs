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
    /// Request Object
    /// </summary>
    public class ListTimeZonesRequest 
    {

        /// <summary>
        /// 按照时区name过滤
        /// </summary>
        [SDKProperty("time_zone_name", IsQuery = true)]
        [JsonProperty("time_zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZoneName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTimeZonesRequest {\n");
            sb.Append("  timeZoneName: ").Append(TimeZoneName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTimeZonesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTimeZonesRequest input)
        {
            if (input == null) return false;
            if (this.TimeZoneName != input.TimeZoneName || (this.TimeZoneName != null && !this.TimeZoneName.Equals(input.TimeZoneName))) return false;

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
                if (this.TimeZoneName != null) hashCode = hashCode * 59 + this.TimeZoneName.GetHashCode();
                return hashCode;
            }
        }
    }
}
