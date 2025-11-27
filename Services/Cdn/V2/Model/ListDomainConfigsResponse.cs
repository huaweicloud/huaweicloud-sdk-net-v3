using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDomainConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 域名cname状态。
        /// </summary>
        [JsonProperty("cname_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<CnameStatus> CnameStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainConfigsResponse {\n");
            sb.Append("  cnameStatus: ").Append(CnameStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainConfigsResponse input)
        {
            if (input == null) return false;
            if (this.CnameStatus != input.CnameStatus || (this.CnameStatus != null && input.CnameStatus != null && !this.CnameStatus.SequenceEqual(input.CnameStatus))) return false;

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
                if (this.CnameStatus != null) hashCode = hashCode * 59 + this.CnameStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
