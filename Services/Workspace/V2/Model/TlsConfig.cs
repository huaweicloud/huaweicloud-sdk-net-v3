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
    /// TLS信息。
    /// </summary>
    public class TlsConfig 
    {

        /// <summary>
        /// pem内容, 有则更新，无则上传。查询不返回。
        /// </summary>
        [JsonProperty("cert_pem", NullValueHandling = NullValueHandling.Ignore)]
        public string CertPem { get; set; }

        /// <summary>
        /// 证书生效开始时间，时间参考样例 2022-01-25T09:24:27。
        /// </summary>
        [JsonProperty("cert_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CertStartTime { get; set; }

        /// <summary>
        /// 证书生效截止时间，时间参考样例 2022-01-25T09:24:27。
        /// </summary>
        [JsonProperty("cert_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CertEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TlsConfig {\n");
            sb.Append("  certPem: ").Append(CertPem).Append("\n");
            sb.Append("  certStartTime: ").Append(CertStartTime).Append("\n");
            sb.Append("  certEndTime: ").Append(CertEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TlsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TlsConfig input)
        {
            if (input == null) return false;
            if (this.CertPem != input.CertPem || (this.CertPem != null && !this.CertPem.Equals(input.CertPem))) return false;
            if (this.CertStartTime != input.CertStartTime || (this.CertStartTime != null && !this.CertStartTime.Equals(input.CertStartTime))) return false;
            if (this.CertEndTime != input.CertEndTime || (this.CertEndTime != null && !this.CertEndTime.Equals(input.CertEndTime))) return false;

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
                if (this.CertPem != null) hashCode = hashCode * 59 + this.CertPem.GetHashCode();
                if (this.CertStartTime != null) hashCode = hashCode * 59 + this.CertStartTime.GetHashCode();
                if (this.CertEndTime != null) hashCode = hashCode * 59 + this.CertEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
