using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListCertsResponse : SdkResponse
    {

        /// <summary>
        /// 证书列表。
        /// </summary>
        [JsonProperty("cert_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<CertItem> CertList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCertsResponse {\n");
            sb.Append("  certList: ").Append(CertList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCertsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCertsResponse input)
        {
            if (input == null) return false;
            if (this.CertList != input.CertList || (this.CertList != null && input.CertList != null && !this.CertList.SequenceEqual(input.CertList))) return false;

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
                if (this.CertList != null) hashCode = hashCode * 59 + this.CertList.GetHashCode();
                return hashCode;
            }
        }
    }
}
