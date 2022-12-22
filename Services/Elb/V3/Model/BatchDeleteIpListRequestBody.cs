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
    /// This is a auto create Response Object
    /// </summary>
    public class BatchDeleteIpListRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public BatchDeleteIpListOption Ipgroup { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteIpListRequestBody {\n");
            sb.Append("  ipgroup: ").Append(Ipgroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteIpListRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteIpListRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ipgroup == input.Ipgroup ||
                    (this.Ipgroup != null &&
                    this.Ipgroup.Equals(input.Ipgroup))
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
                if (this.Ipgroup != null)
                    hashCode = hashCode * 59 + this.Ipgroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
