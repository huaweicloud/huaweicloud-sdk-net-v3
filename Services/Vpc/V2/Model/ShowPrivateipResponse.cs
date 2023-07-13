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
    /// Response Object
    /// </summary>
    public class ShowPrivateipResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("privateip", NullValueHandling = NullValueHandling.Ignore)]
        public Privateip Privateip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPrivateipResponse {\n");
            sb.Append("  privateip: ").Append(Privateip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPrivateipResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPrivateipResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Privateip == input.Privateip ||
                    (this.Privateip != null &&
                    this.Privateip.Equals(input.Privateip))
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
                if (this.Privateip != null)
                    hashCode = hashCode * 59 + this.Privateip.GetHashCode();
                return hashCode;
            }
        }
    }
}
