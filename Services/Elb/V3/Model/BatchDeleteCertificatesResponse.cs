using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteCertificatesResponse : SdkResponse
    {

        /// <summary>
        /// 证书批量删除后的响应结果。
        /// </summary>
        [JsonProperty("certificates", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchDeleteCertificatesResp> Certificates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteCertificatesResponse {\n");
            sb.Append("  certificates: ").Append(Certificates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteCertificatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteCertificatesResponse input)
        {
            if (input == null) return false;
            if (this.Certificates != input.Certificates || (this.Certificates != null && input.Certificates != null && !this.Certificates.SequenceEqual(input.Certificates))) return false;

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
                if (this.Certificates != null) hashCode = hashCode * 59 + this.Certificates.GetHashCode();
                return hashCode;
            }
        }
    }
}
