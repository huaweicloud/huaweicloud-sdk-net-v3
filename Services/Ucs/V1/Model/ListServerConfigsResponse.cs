using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListServerConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("onpremises", NullValueHandling = NullValueHandling.Ignore)]
        public OnPremisesConfig Onpremises { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("federations", NullValueHandling = NullValueHandling.Ignore)]
        public FederationConfig Federations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListServerConfigsResponse {\n");
            sb.Append("  onpremises: ").Append(Onpremises).Append("\n");
            sb.Append("  federations: ").Append(Federations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListServerConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListServerConfigsResponse input)
        {
            if (input == null) return false;
            if (this.Onpremises != input.Onpremises || (this.Onpremises != null && !this.Onpremises.Equals(input.Onpremises))) return false;
            if (this.Federations != input.Federations || (this.Federations != null && !this.Federations.Equals(input.Federations))) return false;

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
                if (this.Onpremises != null) hashCode = hashCode * 59 + this.Onpremises.GetHashCode();
                if (this.Federations != null) hashCode = hashCode * 59 + this.Federations.GetHashCode();
                return hashCode;
            }
        }
    }
}
