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
    /// 
    /// </summary>
    public class CertInfoResp 
    {

        /// <summary>
        /// 播放域名
        /// </summary>
        [JsonProperty("play_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 租户名
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// 证书开始时间，格式：YYYY-MM-DDTHH:mm:ssZ，UTC时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 证书过期时间，格式：YYYY-MM-DDTHH:mm:ssZ，UTC时间
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 证书类型, 1：国密证书， 0:默认，标准国际证书
        /// </summary>
        [JsonProperty("cert_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CertType { get; set; }

        /// <summary>
        /// 国密证书类型, 1：签名证书， 2:加密证书
        /// </summary>
        [JsonProperty("gm_cert_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? GmCertType { get; set; }

        /// <summary>
        /// 证书来源。 - scm：云证书与管理服务CCM。 - user：自有证书。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// scm来源的证书名, 自有证书为空
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// scm来源的证书ID, 自有证书为空
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertInfoResp {\n");
            sb.Append("  playDomain: ").Append(PlayDomain).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  certType: ").Append(CertType).Append("\n");
            sb.Append("  gmCertType: ").Append(GmCertType).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertInfoResp input)
        {
            if (input == null) return false;
            if (this.PlayDomain != input.PlayDomain || (this.PlayDomain != null && !this.PlayDomain.Equals(input.PlayDomain))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.CertType != input.CertType || (this.CertType != null && !this.CertType.Equals(input.CertType))) return false;
            if (this.GmCertType != input.GmCertType || (this.GmCertType != null && !this.GmCertType.Equals(input.GmCertType))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;
            if (this.CertId != input.CertId || (this.CertId != null && !this.CertId.Equals(input.CertId))) return false;

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
                if (this.PlayDomain != null) hashCode = hashCode * 59 + this.PlayDomain.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.CertType != null) hashCode = hashCode * 59 + this.CertType.GetHashCode();
                if (this.GmCertType != null) hashCode = hashCode * 59 + this.GmCertType.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.CertId != null) hashCode = hashCode * 59 + this.CertId.GetHashCode();
                return hashCode;
            }
        }
    }
}
