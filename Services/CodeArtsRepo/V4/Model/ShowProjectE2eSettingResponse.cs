using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowProjectE2eSettingResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("e2e_policies", NullValueHandling = NullValueHandling.Ignore)]
        public E2ePolicyDto E2ePolicies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("req", NullValueHandling = NullValueHandling.Ignore)]
        public ReqSettingDto Req { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public LinkSettingDto Link { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectE2eSettingResponse {\n");
            sb.Append("  e2ePolicies: ").Append(E2ePolicies).Append("\n");
            sb.Append("  req: ").Append(Req).Append("\n");
            sb.Append("  link: ").Append(Link).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectE2eSettingResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectE2eSettingResponse input)
        {
            if (input == null) return false;
            if (this.E2ePolicies != input.E2ePolicies || (this.E2ePolicies != null && !this.E2ePolicies.Equals(input.E2ePolicies))) return false;
            if (this.Req != input.Req || (this.Req != null && !this.Req.Equals(input.Req))) return false;
            if (this.Link != input.Link || (this.Link != null && !this.Link.Equals(input.Link))) return false;

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
                if (this.E2ePolicies != null) hashCode = hashCode * 59 + this.E2ePolicies.GetHashCode();
                if (this.Req != null) hashCode = hashCode * 59 + this.Req.GetHashCode();
                if (this.Link != null) hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }
}
