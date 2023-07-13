using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDomainResponse : SdkResponse
    {

        /// <summary>
        /// 查询结果的总数量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }

        /// <summary>
        /// 直播域名列表
        /// </summary>
        [JsonProperty("domain_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DecoupledLiveDomainInfo> DomainInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  domainInfo: ").Append(DomainInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.DomainInfo == input.DomainInfo ||
                    this.DomainInfo != null &&
                    input.DomainInfo != null &&
                    this.DomainInfo.SequenceEqual(input.DomainInfo)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.DomainInfo != null)
                    hashCode = hashCode * 59 + this.DomainInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
