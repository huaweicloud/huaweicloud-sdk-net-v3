using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateEWFirewallResp 
    {

        /// <summary>
        /// 东西向防护id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("er", NullValueHandling = NullValueHandling.Ignore)]
        public Er Er { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("inspertion_vpc", NullValueHandling = NullValueHandling.Ignore)]
        public CreateEWFirewallInspectVpcResp InspertionVpc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEWFirewallResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  er: ").Append(Er).Append("\n");
            sb.Append("  inspertionVpc: ").Append(InspertionVpc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEWFirewallResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEWFirewallResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Er != input.Er || (this.Er != null && !this.Er.Equals(input.Er))) return false;
            if (this.InspertionVpc != input.InspertionVpc || (this.InspertionVpc != null && !this.InspertionVpc.Equals(input.InspertionVpc))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Er != null) hashCode = hashCode * 59 + this.Er.GetHashCode();
                if (this.InspertionVpc != null) hashCode = hashCode * 59 + this.InspertionVpc.GetHashCode();
                return hashCode;
            }
        }
    }
}
