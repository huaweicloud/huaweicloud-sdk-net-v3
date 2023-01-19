using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateRangeSwitchResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("origin_range", NullValueHandling = NullValueHandling.Ignore)]
        public OriginRangeBody OriginRange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRangeSwitchResponse {\n");
            sb.Append("  originRange: ").Append(OriginRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateRangeSwitchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateRangeSwitchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OriginRange == input.OriginRange ||
                    (this.OriginRange != null &&
                    this.OriginRange.Equals(input.OriginRange))
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
                if (this.OriginRange != null)
                    hashCode = hashCode * 59 + this.OriginRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
