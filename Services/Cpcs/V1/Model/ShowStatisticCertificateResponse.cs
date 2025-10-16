using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStatisticCertificateResponse : SdkResponse
    {

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 证书分布按算法和证书类型统计
        /// </summary>
        [JsonProperty("certificate_classified_counts", NullValueHandling = NullValueHandling.Ignore)]
        public List<VendorCertificateStatistic> CertificateClassifiedCounts { get; set; }

        /// <summary>
        /// 证书分布按服务类型统计
        /// </summary>
        [JsonProperty("certificate_counts_by_server_type", NullValueHandling = NullValueHandling.Ignore)]
        public List<VendorCertificateStatistic> CertificateCountsByServerType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatisticCertificateResponse {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  certificateClassifiedCounts: ").Append(CertificateClassifiedCounts).Append("\n");
            sb.Append("  certificateCountsByServerType: ").Append(CertificateCountsByServerType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatisticCertificateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatisticCertificateResponse input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.CertificateClassifiedCounts != input.CertificateClassifiedCounts || (this.CertificateClassifiedCounts != null && input.CertificateClassifiedCounts != null && !this.CertificateClassifiedCounts.SequenceEqual(input.CertificateClassifiedCounts))) return false;
            if (this.CertificateCountsByServerType != input.CertificateCountsByServerType || (this.CertificateCountsByServerType != null && input.CertificateCountsByServerType != null && !this.CertificateCountsByServerType.SequenceEqual(input.CertificateCountsByServerType))) return false;

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
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.CertificateClassifiedCounts != null) hashCode = hashCode * 59 + this.CertificateClassifiedCounts.GetHashCode();
                if (this.CertificateCountsByServerType != null) hashCode = hashCode * 59 + this.CertificateCountsByServerType.GetHashCode();
                return hashCode;
            }
        }
    }
}
