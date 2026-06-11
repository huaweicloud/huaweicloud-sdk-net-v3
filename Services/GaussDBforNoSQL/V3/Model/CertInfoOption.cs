using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// **参数解释：** CCM证书信息。 **取值范围：** 开启ssl，不传此参数，表示使用默认证书。
    /// </summary>
    public class CertInfoOption 
    {

        /// <summary>
        /// **参数解释：** 证书ID。 **取值范围：** 根据CCM证书列表接口获取证书ID。
        /// </summary>
        [JsonProperty("cert_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CertId { get; set; }

        /// <summary>
        /// **参数解释：** 证书类型。 **取值范围：**   - PCA：CCM PCA 证书。   - SSL：CCM SSL 证书。
        /// </summary>
        [JsonProperty("cert_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CertType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertInfoOption {\n");
            sb.Append("  certId: ").Append(CertId).Append("\n");
            sb.Append("  certType: ").Append(CertType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertInfoOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertInfoOption input)
        {
            if (input == null) return false;
            if (this.CertId != input.CertId || (this.CertId != null && !this.CertId.Equals(input.CertId))) return false;
            if (this.CertType != input.CertType || (this.CertType != null && !this.CertType.Equals(input.CertType))) return false;

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
                if (this.CertId != null) hashCode = hashCode * 59 + this.CertId.GetHashCode();
                if (this.CertType != null) hashCode = hashCode * 59 + this.CertType.GetHashCode();
                return hashCode;
            }
        }
    }
}
