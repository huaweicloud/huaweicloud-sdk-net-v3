using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Target 
    {

        /// <summary>
        /// 触发器类型，可选http
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 触发地址，不可修改
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 请求头，格式为key1:value1;key2:value2
        /// </summary>
        [JsonProperty("auth_header", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthHeader { get; set; }

        /// <summary>
        /// 是否跳过证书认证
        /// </summary>
        [JsonProperty("skip_cert_verify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipCertVerify { get; set; }

        /// <summary>
        /// 触发地址类型，可选internal(内网)，internet(公网)。internal必须为内网ip形式。
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Target {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  authHeader: ").Append(AuthHeader).Append("\n");
            sb.Append("  skipCertVerify: ").Append(SkipCertVerify).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Target);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Target input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.AuthHeader != input.AuthHeader || (this.AuthHeader != null && !this.AuthHeader.Equals(input.AuthHeader))) return false;
            if (this.SkipCertVerify != input.SkipCertVerify || (this.SkipCertVerify != null && !this.SkipCertVerify.Equals(input.SkipCertVerify))) return false;
            if (this.AddressType != input.AddressType || (this.AddressType != null && !this.AddressType.Equals(input.AddressType))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AuthHeader != null) hashCode = hashCode * 59 + this.AuthHeader.GetHashCode();
                if (this.SkipCertVerify != null) hashCode = hashCode * 59 + this.SkipCertVerify.GetHashCode();
                if (this.AddressType != null) hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                return hashCode;
            }
        }
    }
}
