using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPublicZoneNameServerResponse : SdkResponse
    {

        /// <summary>
        /// 查询单个公网Zone的名称服务器响应。
        /// </summary>
        [JsonProperty("nameservers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Nameserver> Nameservers { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPublicZoneNameServerResponse {\n");
            sb.Append("  nameservers: ").Append(Nameservers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPublicZoneNameServerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPublicZoneNameServerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nameservers == input.Nameservers ||
                    this.Nameservers != null &&
                    input.Nameservers != null &&
                    this.Nameservers.SequenceEqual(input.Nameservers)
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
                if (this.Nameservers != null)
                    hashCode = hashCode * 59 + this.Nameservers.GetHashCode();
                return hashCode;
            }
        }
    }
}
