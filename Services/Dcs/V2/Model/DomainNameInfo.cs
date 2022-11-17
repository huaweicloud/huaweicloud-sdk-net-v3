using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DomainNameInfo 
    {

        /// <summary>
        /// 是否开启公网域名解析。 - true：开启 - false：未开启 
        /// </summary>
        [JsonProperty("support_public_resolve", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportPublicResolve { get; set; }

        /// <summary>
        /// 当前域名是否已为最新。 - true：是 - false：否 
        /// </summary>
        [JsonProperty("is_latest_rules", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLatestRules { get; set; }

        /// <summary>
        /// 域名的区域后缀。
        /// </summary>
        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneName { get; set; }

        /// <summary>
        /// 历史域名信息。
        /// </summary>
        [JsonProperty("history_domain_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<DomainNameEntity> HistoryDomainNames { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainNameInfo {\n");
            sb.Append("  supportPublicResolve: ").Append(SupportPublicResolve).Append("\n");
            sb.Append("  isLatestRules: ").Append(IsLatestRules).Append("\n");
            sb.Append("  zoneName: ").Append(ZoneName).Append("\n");
            sb.Append("  historyDomainNames: ").Append(HistoryDomainNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainNameInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DomainNameInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupportPublicResolve == input.SupportPublicResolve ||
                    (this.SupportPublicResolve != null &&
                    this.SupportPublicResolve.Equals(input.SupportPublicResolve))
                ) && 
                (
                    this.IsLatestRules == input.IsLatestRules ||
                    (this.IsLatestRules != null &&
                    this.IsLatestRules.Equals(input.IsLatestRules))
                ) && 
                (
                    this.ZoneName == input.ZoneName ||
                    (this.ZoneName != null &&
                    this.ZoneName.Equals(input.ZoneName))
                ) && 
                (
                    this.HistoryDomainNames == input.HistoryDomainNames ||
                    this.HistoryDomainNames != null &&
                    input.HistoryDomainNames != null &&
                    this.HistoryDomainNames.SequenceEqual(input.HistoryDomainNames)
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
                if (this.SupportPublicResolve != null)
                    hashCode = hashCode * 59 + this.SupportPublicResolve.GetHashCode();
                if (this.IsLatestRules != null)
                    hashCode = hashCode * 59 + this.IsLatestRules.GetHashCode();
                if (this.ZoneName != null)
                    hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                if (this.HistoryDomainNames != null)
                    hashCode = hashCode * 59 + this.HistoryDomainNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
