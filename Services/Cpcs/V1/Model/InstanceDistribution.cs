using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceDistribution 
    {

        /// <summary>
        /// 加解密服务实例数量
        /// </summary>
        [JsonProperty("encrypt_decrypt", NullValueHandling = NullValueHandling.Ignore)]
        public int? EncryptDecrypt { get; set; }

        /// <summary>
        /// 签名验签服务实例数量
        /// </summary>
        [JsonProperty("sign_verify", NullValueHandling = NullValueHandling.Ignore)]
        public int? SignVerify { get; set; }

        /// <summary>
        /// 密钥管理服务实例数量
        /// </summary>
        [JsonProperty("kms", NullValueHandling = NullValueHandling.Ignore)]
        public int? Kms { get; set; }

        /// <summary>
        /// 时间戳服务实例数量
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// 协同签名服务实例数量
        /// </summary>
        [JsonProperty("colla_sign", NullValueHandling = NullValueHandling.Ignore)]
        public int? CollaSign { get; set; }

        /// <summary>
        /// 动态口令服务实例数量
        /// </summary>
        [JsonProperty("otp", NullValueHandling = NullValueHandling.Ignore)]
        public int? Otp { get; set; }

        /// <summary>
        /// 数据库加密服务实例数量
        /// </summary>
        [JsonProperty("db_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbEncrypt { get; set; }

        /// <summary>
        /// 文件加密服务实例数量
        /// </summary>
        [JsonProperty("file_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileEncrypt { get; set; }

        /// <summary>
        /// 电子签章服务实例数量
        /// </summary>
        [JsonProperty("digit_seal", NullValueHandling = NullValueHandling.Ignore)]
        public int? DigitSeal { get; set; }

        /// <summary>
        /// ssl vpn服务实例数量
        /// </summary>
        [JsonProperty("ssl_vpn", NullValueHandling = NullValueHandling.Ignore)]
        public int? SslVpn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceDistribution {\n");
            sb.Append("  encryptDecrypt: ").Append(EncryptDecrypt).Append("\n");
            sb.Append("  signVerify: ").Append(SignVerify).Append("\n");
            sb.Append("  kms: ").Append(Kms).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  collaSign: ").Append(CollaSign).Append("\n");
            sb.Append("  otp: ").Append(Otp).Append("\n");
            sb.Append("  dbEncrypt: ").Append(DbEncrypt).Append("\n");
            sb.Append("  fileEncrypt: ").Append(FileEncrypt).Append("\n");
            sb.Append("  digitSeal: ").Append(DigitSeal).Append("\n");
            sb.Append("  sslVpn: ").Append(SslVpn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceDistribution);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceDistribution input)
        {
            if (input == null) return false;
            if (this.EncryptDecrypt != input.EncryptDecrypt || (this.EncryptDecrypt != null && !this.EncryptDecrypt.Equals(input.EncryptDecrypt))) return false;
            if (this.SignVerify != input.SignVerify || (this.SignVerify != null && !this.SignVerify.Equals(input.SignVerify))) return false;
            if (this.Kms != input.Kms || (this.Kms != null && !this.Kms.Equals(input.Kms))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.CollaSign != input.CollaSign || (this.CollaSign != null && !this.CollaSign.Equals(input.CollaSign))) return false;
            if (this.Otp != input.Otp || (this.Otp != null && !this.Otp.Equals(input.Otp))) return false;
            if (this.DbEncrypt != input.DbEncrypt || (this.DbEncrypt != null && !this.DbEncrypt.Equals(input.DbEncrypt))) return false;
            if (this.FileEncrypt != input.FileEncrypt || (this.FileEncrypt != null && !this.FileEncrypt.Equals(input.FileEncrypt))) return false;
            if (this.DigitSeal != input.DigitSeal || (this.DigitSeal != null && !this.DigitSeal.Equals(input.DigitSeal))) return false;
            if (this.SslVpn != input.SslVpn || (this.SslVpn != null && !this.SslVpn.Equals(input.SslVpn))) return false;

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
                if (this.EncryptDecrypt != null) hashCode = hashCode * 59 + this.EncryptDecrypt.GetHashCode();
                if (this.SignVerify != null) hashCode = hashCode * 59 + this.SignVerify.GetHashCode();
                if (this.Kms != null) hashCode = hashCode * 59 + this.Kms.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.CollaSign != null) hashCode = hashCode * 59 + this.CollaSign.GetHashCode();
                if (this.Otp != null) hashCode = hashCode * 59 + this.Otp.GetHashCode();
                if (this.DbEncrypt != null) hashCode = hashCode * 59 + this.DbEncrypt.GetHashCode();
                if (this.FileEncrypt != null) hashCode = hashCode * 59 + this.FileEncrypt.GetHashCode();
                if (this.DigitSeal != null) hashCode = hashCode * 59 + this.DigitSeal.GetHashCode();
                if (this.SslVpn != null) hashCode = hashCode * 59 + this.SslVpn.GetHashCode();
                return hashCode;
            }
        }
    }
}
