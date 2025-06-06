using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAvailabilityZoneInfosResponse : SdkResponse
    {

        /// <summary>
        /// 可用区集合
        /// </summary>
        [JsonProperty("azs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AzInfo> Azs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAvailabilityZoneInfosResponse {\n");
            sb.Append("  azs: ").Append(Azs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAvailabilityZoneInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAvailabilityZoneInfosResponse input)
        {
            if (input == null) return false;
            if (this.Azs != input.Azs || (this.Azs != null && input.Azs != null && !this.Azs.SequenceEqual(input.Azs))) return false;

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
                if (this.Azs != null) hashCode = hashCode * 59 + this.Azs.GetHashCode();
                return hashCode;
            }
        }
    }
}
