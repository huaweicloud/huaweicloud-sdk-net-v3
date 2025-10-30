using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSaleCyclesRequest 
    {

        /// <summary>
        /// 地区编码
        /// </summary>
        [SDKProperty("zone_code", IsQuery = true)]
        [JsonProperty("zone_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSaleCyclesRequest {\n");
            sb.Append("  zoneCode: ").Append(ZoneCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSaleCyclesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSaleCyclesRequest input)
        {
            if (input == null) return false;
            if (this.ZoneCode != input.ZoneCode || (this.ZoneCode != null && !this.ZoneCode.Equals(input.ZoneCode))) return false;

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
                if (this.ZoneCode != null) hashCode = hashCode * 59 + this.ZoneCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
