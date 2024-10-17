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
    public class ShowCertificatePrivateKeyEchoResponse : SdkResponse
    {

        /// <summary>
        /// 请求ID。  注：自动生成 。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// 证书回显开关，项目粒度的,默认情况下,\&quot;private_key_echo\&quot;是true,证书的返回体中展示私钥。 当值为false时,证书的返回体中不展示私钥。
        /// </summary>
        [JsonProperty("private_key_echo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateKeyEcho { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCertificatePrivateKeyEchoResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  privateKeyEcho: ").Append(PrivateKeyEcho).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCertificatePrivateKeyEchoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCertificatePrivateKeyEchoResponse input)
        {
            if (input == null) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;
            if (this.PrivateKeyEcho != input.PrivateKeyEcho || (this.PrivateKeyEcho != null && !this.PrivateKeyEcho.Equals(input.PrivateKeyEcho))) return false;

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
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.PrivateKeyEcho != null) hashCode = hashCode * 59 + this.PrivateKeyEcho.GetHashCode();
                return hashCode;
            }
        }
    }
}
