using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAgencyResponse : SdkResponse
    {

        /// <summary>
        /// 委托是否存在。
        /// </summary>
        [JsonProperty("agency_granted", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyGranted { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAgencyResponse {\n");
            sb.Append("  agencyGranted: ").Append(AgencyGranted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAgencyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAgencyResponse input)
        {
            if (input == null) return false;
            if (this.AgencyGranted != input.AgencyGranted || (this.AgencyGranted != null && !this.AgencyGranted.Equals(input.AgencyGranted))) return false;

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
                if (this.AgencyGranted != null) hashCode = hashCode * 59 + this.AgencyGranted.GetHashCode();
                return hashCode;
            }
        }
    }
}
