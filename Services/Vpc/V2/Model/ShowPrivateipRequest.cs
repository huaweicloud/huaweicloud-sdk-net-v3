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
    public class ShowPrivateipRequest 
    {

        /// <summary>
        /// 私有IP ID
        /// </summary>
        [SDKProperty("privateip_id", IsPath = true)]
        [JsonProperty("privateip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateipId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPrivateipRequest {\n");
            sb.Append("  privateipId: ").Append(PrivateipId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPrivateipRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPrivateipRequest input)
        {
            if (input == null) return false;
            if (this.PrivateipId != input.PrivateipId || (this.PrivateipId != null && !this.PrivateipId.Equals(input.PrivateipId))) return false;

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
                if (this.PrivateipId != null) hashCode = hashCode * 59 + this.PrivateipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
