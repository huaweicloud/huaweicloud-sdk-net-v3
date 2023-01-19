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
    public class NeutronListFloatingIpsResponse : SdkResponse
    {

        /// <summary>
        /// floatingip对象列表
        /// </summary>
        [JsonProperty("floatingips", NullValueHandling = NullValueHandling.Ignore)]
        public List<FloatingIpResp> Floatingips { get; set; }

        /// <summary>
        /// marker分页结构
        /// </summary>
        [JsonProperty("floatingips_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<Pager> FloatingipsLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronListFloatingIpsResponse {\n");
            sb.Append("  floatingips: ").Append(Floatingips).Append("\n");
            sb.Append("  floatingipsLinks: ").Append(FloatingipsLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronListFloatingIpsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronListFloatingIpsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Floatingips == input.Floatingips ||
                    this.Floatingips != null &&
                    input.Floatingips != null &&
                    this.Floatingips.SequenceEqual(input.Floatingips)
                ) && 
                (
                    this.FloatingipsLinks == input.FloatingipsLinks ||
                    this.FloatingipsLinks != null &&
                    input.FloatingipsLinks != null &&
                    this.FloatingipsLinks.SequenceEqual(input.FloatingipsLinks)
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
                if (this.Floatingips != null)
                    hashCode = hashCode * 59 + this.Floatingips.GetHashCode();
                if (this.FloatingipsLinks != null)
                    hashCode = hashCode * 59 + this.FloatingipsLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
