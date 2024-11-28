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
    public class CreateAgencyResponse : SdkResponse
    {

        /// <summary>
        /// 委托详情列表。
        /// </summary>
        [JsonProperty("agencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Agency> Agencies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAgencyResponse {\n");
            sb.Append("  agencies: ").Append(Agencies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAgencyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAgencyResponse input)
        {
            if (input == null) return false;
            if (this.Agencies != input.Agencies || (this.Agencies != null && input.Agencies != null && !this.Agencies.SequenceEqual(input.Agencies))) return false;

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
                if (this.Agencies != null) hashCode = hashCode * 59 + this.Agencies.GetHashCode();
                return hashCode;
            }
        }
    }
}
