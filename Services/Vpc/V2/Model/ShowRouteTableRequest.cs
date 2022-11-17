using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowRouteTableRequest 
    {

        /// <summary>
        /// 路由表ID
        /// </summary>
        [SDKProperty("routetable_id", IsPath = true)]
        [JsonProperty("routetable_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutetableId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRouteTableRequest {\n");
            sb.Append("  routetableId: ").Append(RoutetableId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRouteTableRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRouteTableRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RoutetableId == input.RoutetableId ||
                    (this.RoutetableId != null &&
                    this.RoutetableId.Equals(input.RoutetableId))
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
                if (this.RoutetableId != null)
                    hashCode = hashCode * 59 + this.RoutetableId.GetHashCode();
                return hashCode;
            }
        }
    }
}
