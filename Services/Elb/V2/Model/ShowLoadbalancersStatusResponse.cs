using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowLoadbalancersStatusResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("statuses", NullValueHandling = NullValueHandling.Ignore)]
        public StatusResp Statuses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLoadbalancersStatusResponse {\n");
            sb.Append("  statuses: ").Append(Statuses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLoadbalancersStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLoadbalancersStatusResponse input)
        {
            if (input == null) return false;
            if (this.Statuses != input.Statuses || (this.Statuses != null && !this.Statuses.Equals(input.Statuses))) return false;

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
                if (this.Statuses != null) hashCode = hashCode * 59 + this.Statuses.GetHashCode();
                return hashCode;
            }
        }
    }
}
