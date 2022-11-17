using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class NeutronUpdateFloatingIpResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("floatingip", NullValueHandling = NullValueHandling.Ignore)]
        public PostAndPutFloatingIpResp Floatingip { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronUpdateFloatingIpResponse {\n");
            sb.Append("  floatingip: ").Append(Floatingip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronUpdateFloatingIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronUpdateFloatingIpResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Floatingip == input.Floatingip ||
                    (this.Floatingip != null &&
                    this.Floatingip.Equals(input.Floatingip))
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
                if (this.Floatingip != null)
                    hashCode = hashCode * 59 + this.Floatingip.GetHashCode();
                return hashCode;
            }
        }
    }
}
