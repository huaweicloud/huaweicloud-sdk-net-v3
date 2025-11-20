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
    /// Response Object
    /// </summary>
    public class ListGlobalConfigResponse : SdkResponse
    {

        /// <summary>
        /// 支持的tls版本列表
        /// </summary>
        [JsonProperty("support_tls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportTls { get; set; }

        /// <summary>
        /// 加密套件列表
        /// </summary>
        [JsonProperty("cipher", NullValueHandling = NullValueHandling.Ignore)]
        public List<CipherInfo> Cipher { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGlobalConfigResponse {\n");
            sb.Append("  supportTls: ").Append(SupportTls).Append("\n");
            sb.Append("  cipher: ").Append(Cipher).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGlobalConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGlobalConfigResponse input)
        {
            if (input == null) return false;
            if (this.SupportTls != input.SupportTls || (this.SupportTls != null && input.SupportTls != null && !this.SupportTls.SequenceEqual(input.SupportTls))) return false;
            if (this.Cipher != input.Cipher || (this.Cipher != null && input.Cipher != null && !this.Cipher.SequenceEqual(input.Cipher))) return false;

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
                if (this.SupportTls != null) hashCode = hashCode * 59 + this.SupportTls.GetHashCode();
                if (this.Cipher != null) hashCode = hashCode * 59 + this.Cipher.GetHashCode();
                return hashCode;
            }
        }
    }
}
