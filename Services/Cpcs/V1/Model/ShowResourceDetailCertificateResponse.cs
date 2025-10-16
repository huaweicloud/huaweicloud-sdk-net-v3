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
    public class ShowResourceDetailCertificateResponse : SdkResponse
    {

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 证书详情列表
        /// </summary>
        [JsonProperty("certificate_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowResourceDetailCertificateResponseBodyCertificateList> CertificateList { get; set; }

        /// <summary>
        /// 证书总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 证书过期数量
        /// </summary>
        [JsonProperty("expired_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiredCount { get; set; }

        /// <summary>
        /// 证书即将过期数量
        /// </summary>
        [JsonProperty("expiring_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiringCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResourceDetailCertificateResponse {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  certificateList: ").Append(CertificateList).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  expiredCount: ").Append(ExpiredCount).Append("\n");
            sb.Append("  expiringCount: ").Append(ExpiringCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResourceDetailCertificateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResourceDetailCertificateResponse input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.CertificateList != input.CertificateList || (this.CertificateList != null && input.CertificateList != null && !this.CertificateList.SequenceEqual(input.CertificateList))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.ExpiredCount != input.ExpiredCount || (this.ExpiredCount != null && !this.ExpiredCount.Equals(input.ExpiredCount))) return false;
            if (this.ExpiringCount != input.ExpiringCount || (this.ExpiringCount != null && !this.ExpiringCount.Equals(input.ExpiringCount))) return false;

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
                if (this.CertificateList != null) hashCode = hashCode * 59 + this.CertificateList.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.ExpiredCount != null) hashCode = hashCode * 59 + this.ExpiredCount.GetHashCode();
                if (this.ExpiringCount != null) hashCode = hashCode * 59 + this.ExpiringCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
