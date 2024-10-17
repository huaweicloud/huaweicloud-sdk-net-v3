using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CertInfo 
    {

        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonProperty("cert_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CertName { get; set; }

        /// <summary>
        /// 证书id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 适用域名
        /// </summary>
        [JsonProperty("apply_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyDomain { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 过期状态
        /// </summary>
        [JsonProperty("expire_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpireStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertInfo {\n");
            sb.Append("  certName: ").Append(CertName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  applyDomain: ").Append(ApplyDomain).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  expireStatus: ").Append(ExpireStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertInfo input)
        {
            if (input == null) return false;
            if (this.CertName != input.CertName || (this.CertName != null && !this.CertName.Equals(input.CertName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ApplyDomain != input.ApplyDomain || (this.ApplyDomain != null && !this.ApplyDomain.Equals(input.ApplyDomain))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ExpireStatus != input.ExpireStatus || (this.ExpireStatus != null && !this.ExpireStatus.Equals(input.ExpireStatus))) return false;

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
                if (this.CertName != null) hashCode = hashCode * 59 + this.CertName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ApplyDomain != null) hashCode = hashCode * 59 + this.ApplyDomain.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ExpireStatus != null) hashCode = hashCode * 59 + this.ExpireStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
