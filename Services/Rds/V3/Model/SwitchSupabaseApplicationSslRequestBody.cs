using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// SSL开关请求体。
    /// </summary>
    public class SwitchSupabaseApplicationSslRequestBody 
    {

        /// <summary>
        /// 是否开启SSL。false时cert_id必须为空；true时cert_id必填。
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// 证书ID。enable_ssl&#x3D;true时必填。
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchSupabaseApplicationSslRequestBody {\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchSupabaseApplicationSslRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchSupabaseApplicationSslRequestBody input)
        {
            if (input == null) return false;
            if (this.EnableSsl != input.EnableSsl || (this.EnableSsl != null && !this.EnableSsl.Equals(input.EnableSsl))) return false;
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
                if (this.EnableSsl != null) hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.CertId != null) hashCode = hashCode * 59 + this.CertId.GetHashCode();
                return hashCode;
            }
        }
    }
}
