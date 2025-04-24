using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Extension 
    {

        /// <summary>
        /// ep id
        /// </summary>
        [JsonProperty("ep_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpId { get; set; }

        /// <summary>
        /// ep service id
        /// </summary>
        [JsonProperty("ep_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpServiceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Extension {\n");
            sb.Append("  epId: ").Append(EpId).Append("\n");
            sb.Append("  epServiceId: ").Append(EpServiceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Extension);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Extension input)
        {
            if (input == null) return false;
            if (this.EpId != input.EpId || (this.EpId != null && !this.EpId.Equals(input.EpId))) return false;
            if (this.EpServiceId != input.EpServiceId || (this.EpServiceId != null && !this.EpServiceId.Equals(input.EpServiceId))) return false;

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
                if (this.EpId != null) hashCode = hashCode * 59 + this.EpId.GetHashCode();
                if (this.EpServiceId != null) hashCode = hashCode * 59 + this.EpServiceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
