using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateDomainMultiCertificatesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("https", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateDomainMultiCertificatesResponseBodyContent Https { get; set; }

        /// <summary>
        /// 执行结果，success，fail
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateDomainMultiCertificatesResponseBodyResult> Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDomainMultiCertificatesResponse {\n");
            sb.Append("  https: ").Append(Https).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDomainMultiCertificatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDomainMultiCertificatesResponse input)
        {
            if (input == null) return false;
            if (this.Https != input.Https || (this.Https != null && !this.Https.Equals(input.Https))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Result != input.Result || (this.Result != null && input.Result != null && !this.Result.SequenceEqual(input.Result))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.Https != null) hashCode = hashCode * 59 + this.Https.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
