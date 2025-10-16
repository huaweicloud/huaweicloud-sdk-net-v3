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
    public class ShowStatisticInterfaceResponseBodyMetrics 
    {

        /// <summary>
        /// 杂凑
        /// </summary>
        [JsonProperty("pkiDigestBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? PkiDigestBusiStatistic { get; set; }

        /// <summary>
        /// 解密
        /// </summary>
        [JsonProperty("pkiDecryptBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? PkiDecryptBusiStatistic { get; set; }

        /// <summary>
        /// 生成密钥
        /// </summary>
        [JsonProperty("pkiGenerateKeyBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? PkiGenerateKeyBusiStatistic { get; set; }

        /// <summary>
        /// 验章次数
        /// </summary>
        [JsonProperty("pkiVerifyBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? PkiVerifyBusiStatistic { get; set; }

        /// <summary>
        /// 加密
        /// </summary>
        [JsonProperty("pkiEncryptBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? PkiEncryptBusiStatistic { get; set; }

        /// <summary>
        /// 验证次数
        /// </summary>
        [JsonProperty("tsaVerifyBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? TsaVerifyBusiStatistic { get; set; }

        /// <summary>
        /// 解析次数
        /// </summary>
        [JsonProperty("tsaParseBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? TsaParseBusiStatistic { get; set; }

        /// <summary>
        /// svs验签
        /// </summary>
        [JsonProperty("svsVerifyBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsVerifyBusiStatistic { get; set; }

        /// <summary>
        /// 生成随机
        /// </summary>
        [JsonProperty("pkiRandomBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? PkiRandomBusiStatistic { get; set; }

        /// <summary>
        /// 统计时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// svs获取证书等相关证书操作
        /// </summary>
        [JsonProperty("svsCertBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsCertBusiStatistic { get; set; }

        /// <summary>
        /// svs编码
        /// </summary>
        [JsonProperty("svsEncodeBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsEncodeBusiStatistic { get; set; }

        /// <summary>
        /// 申请次数
        /// </summary>
        [JsonProperty("tsaApplyBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? TsaApplyBusiStatistic { get; set; }

        /// <summary>
        /// svs签名
        /// </summary>
        [JsonProperty("svsSignBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsSignBusiStatistic { get; set; }

        /// <summary>
        /// svs解密
        /// </summary>
        [JsonProperty("svsDecryptBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsDecryptBusiStatistic { get; set; }

        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("kmsBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? KmsBusiStatistic { get; set; }

        /// <summary>
        /// 验章次数
        /// </summary>
        [JsonProperty("sealVerifyBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SealVerifyBusiStatistic { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("pkiSignBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? PkiSignBusiStatistic { get; set; }

        /// <summary>
        /// 口令验证
        /// </summary>
        [JsonProperty("secauthBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SecauthBusiStatistic { get; set; }

        /// <summary>
        /// 签章次数
        /// </summary>
        [JsonProperty("sealSignBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SealSignBusiStatistic { get; set; }

        /// <summary>
        /// 签名次数
        /// </summary>
        [JsonProperty("splitBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SplitBusiStatistic { get; set; }

        /// <summary>
        /// svs生成随机
        /// </summary>
        [JsonProperty("svsRandomBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsRandomBusiStatistic { get; set; }

        /// <summary>
        /// svs加密
        /// </summary>
        [JsonProperty("svsEncryptBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsEncryptBusiStatistic { get; set; }

        /// <summary>
        /// 解密次数
        /// </summary>
        [JsonProperty("smsDecBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SmsDecBusiStatistic { get; set; }

        /// <summary>
        /// svs杂凑
        /// </summary>
        [JsonProperty("svsDigestBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsDigestBusiStatistic { get; set; }

        /// <summary>
        /// svs解码
        /// </summary>
        [JsonProperty("svsDecodeBusiStatistic", NullValueHandling = NullValueHandling.Ignore)]
        public double? SvsDecodeBusiStatistic { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatisticInterfaceResponseBodyMetrics {\n");
            sb.Append("  pkiDigestBusiStatistic: ").Append(PkiDigestBusiStatistic).Append("\n");
            sb.Append("  pkiDecryptBusiStatistic: ").Append(PkiDecryptBusiStatistic).Append("\n");
            sb.Append("  pkiGenerateKeyBusiStatistic: ").Append(PkiGenerateKeyBusiStatistic).Append("\n");
            sb.Append("  pkiVerifyBusiStatistic: ").Append(PkiVerifyBusiStatistic).Append("\n");
            sb.Append("  pkiEncryptBusiStatistic: ").Append(PkiEncryptBusiStatistic).Append("\n");
            sb.Append("  tsaVerifyBusiStatistic: ").Append(TsaVerifyBusiStatistic).Append("\n");
            sb.Append("  tsaParseBusiStatistic: ").Append(TsaParseBusiStatistic).Append("\n");
            sb.Append("  svsVerifyBusiStatistic: ").Append(SvsVerifyBusiStatistic).Append("\n");
            sb.Append("  pkiRandomBusiStatistic: ").Append(PkiRandomBusiStatistic).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  svsCertBusiStatistic: ").Append(SvsCertBusiStatistic).Append("\n");
            sb.Append("  svsEncodeBusiStatistic: ").Append(SvsEncodeBusiStatistic).Append("\n");
            sb.Append("  tsaApplyBusiStatistic: ").Append(TsaApplyBusiStatistic).Append("\n");
            sb.Append("  svsSignBusiStatistic: ").Append(SvsSignBusiStatistic).Append("\n");
            sb.Append("  svsDecryptBusiStatistic: ").Append(SvsDecryptBusiStatistic).Append("\n");
            sb.Append("  kmsBusiStatistic: ").Append(KmsBusiStatistic).Append("\n");
            sb.Append("  sealVerifyBusiStatistic: ").Append(SealVerifyBusiStatistic).Append("\n");
            sb.Append("  pkiSignBusiStatistic: ").Append(PkiSignBusiStatistic).Append("\n");
            sb.Append("  secauthBusiStatistic: ").Append(SecauthBusiStatistic).Append("\n");
            sb.Append("  sealSignBusiStatistic: ").Append(SealSignBusiStatistic).Append("\n");
            sb.Append("  splitBusiStatistic: ").Append(SplitBusiStatistic).Append("\n");
            sb.Append("  svsRandomBusiStatistic: ").Append(SvsRandomBusiStatistic).Append("\n");
            sb.Append("  svsEncryptBusiStatistic: ").Append(SvsEncryptBusiStatistic).Append("\n");
            sb.Append("  smsDecBusiStatistic: ").Append(SmsDecBusiStatistic).Append("\n");
            sb.Append("  svsDigestBusiStatistic: ").Append(SvsDigestBusiStatistic).Append("\n");
            sb.Append("  svsDecodeBusiStatistic: ").Append(SvsDecodeBusiStatistic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatisticInterfaceResponseBodyMetrics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatisticInterfaceResponseBodyMetrics input)
        {
            if (input == null) return false;
            if (this.PkiDigestBusiStatistic != input.PkiDigestBusiStatistic || (this.PkiDigestBusiStatistic != null && !this.PkiDigestBusiStatistic.Equals(input.PkiDigestBusiStatistic))) return false;
            if (this.PkiDecryptBusiStatistic != input.PkiDecryptBusiStatistic || (this.PkiDecryptBusiStatistic != null && !this.PkiDecryptBusiStatistic.Equals(input.PkiDecryptBusiStatistic))) return false;
            if (this.PkiGenerateKeyBusiStatistic != input.PkiGenerateKeyBusiStatistic || (this.PkiGenerateKeyBusiStatistic != null && !this.PkiGenerateKeyBusiStatistic.Equals(input.PkiGenerateKeyBusiStatistic))) return false;
            if (this.PkiVerifyBusiStatistic != input.PkiVerifyBusiStatistic || (this.PkiVerifyBusiStatistic != null && !this.PkiVerifyBusiStatistic.Equals(input.PkiVerifyBusiStatistic))) return false;
            if (this.PkiEncryptBusiStatistic != input.PkiEncryptBusiStatistic || (this.PkiEncryptBusiStatistic != null && !this.PkiEncryptBusiStatistic.Equals(input.PkiEncryptBusiStatistic))) return false;
            if (this.TsaVerifyBusiStatistic != input.TsaVerifyBusiStatistic || (this.TsaVerifyBusiStatistic != null && !this.TsaVerifyBusiStatistic.Equals(input.TsaVerifyBusiStatistic))) return false;
            if (this.TsaParseBusiStatistic != input.TsaParseBusiStatistic || (this.TsaParseBusiStatistic != null && !this.TsaParseBusiStatistic.Equals(input.TsaParseBusiStatistic))) return false;
            if (this.SvsVerifyBusiStatistic != input.SvsVerifyBusiStatistic || (this.SvsVerifyBusiStatistic != null && !this.SvsVerifyBusiStatistic.Equals(input.SvsVerifyBusiStatistic))) return false;
            if (this.PkiRandomBusiStatistic != input.PkiRandomBusiStatistic || (this.PkiRandomBusiStatistic != null && !this.PkiRandomBusiStatistic.Equals(input.PkiRandomBusiStatistic))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.SvsCertBusiStatistic != input.SvsCertBusiStatistic || (this.SvsCertBusiStatistic != null && !this.SvsCertBusiStatistic.Equals(input.SvsCertBusiStatistic))) return false;
            if (this.SvsEncodeBusiStatistic != input.SvsEncodeBusiStatistic || (this.SvsEncodeBusiStatistic != null && !this.SvsEncodeBusiStatistic.Equals(input.SvsEncodeBusiStatistic))) return false;
            if (this.TsaApplyBusiStatistic != input.TsaApplyBusiStatistic || (this.TsaApplyBusiStatistic != null && !this.TsaApplyBusiStatistic.Equals(input.TsaApplyBusiStatistic))) return false;
            if (this.SvsSignBusiStatistic != input.SvsSignBusiStatistic || (this.SvsSignBusiStatistic != null && !this.SvsSignBusiStatistic.Equals(input.SvsSignBusiStatistic))) return false;
            if (this.SvsDecryptBusiStatistic != input.SvsDecryptBusiStatistic || (this.SvsDecryptBusiStatistic != null && !this.SvsDecryptBusiStatistic.Equals(input.SvsDecryptBusiStatistic))) return false;
            if (this.KmsBusiStatistic != input.KmsBusiStatistic || (this.KmsBusiStatistic != null && !this.KmsBusiStatistic.Equals(input.KmsBusiStatistic))) return false;
            if (this.SealVerifyBusiStatistic != input.SealVerifyBusiStatistic || (this.SealVerifyBusiStatistic != null && !this.SealVerifyBusiStatistic.Equals(input.SealVerifyBusiStatistic))) return false;
            if (this.PkiSignBusiStatistic != input.PkiSignBusiStatistic || (this.PkiSignBusiStatistic != null && !this.PkiSignBusiStatistic.Equals(input.PkiSignBusiStatistic))) return false;
            if (this.SecauthBusiStatistic != input.SecauthBusiStatistic || (this.SecauthBusiStatistic != null && !this.SecauthBusiStatistic.Equals(input.SecauthBusiStatistic))) return false;
            if (this.SealSignBusiStatistic != input.SealSignBusiStatistic || (this.SealSignBusiStatistic != null && !this.SealSignBusiStatistic.Equals(input.SealSignBusiStatistic))) return false;
            if (this.SplitBusiStatistic != input.SplitBusiStatistic || (this.SplitBusiStatistic != null && !this.SplitBusiStatistic.Equals(input.SplitBusiStatistic))) return false;
            if (this.SvsRandomBusiStatistic != input.SvsRandomBusiStatistic || (this.SvsRandomBusiStatistic != null && !this.SvsRandomBusiStatistic.Equals(input.SvsRandomBusiStatistic))) return false;
            if (this.SvsEncryptBusiStatistic != input.SvsEncryptBusiStatistic || (this.SvsEncryptBusiStatistic != null && !this.SvsEncryptBusiStatistic.Equals(input.SvsEncryptBusiStatistic))) return false;
            if (this.SmsDecBusiStatistic != input.SmsDecBusiStatistic || (this.SmsDecBusiStatistic != null && !this.SmsDecBusiStatistic.Equals(input.SmsDecBusiStatistic))) return false;
            if (this.SvsDigestBusiStatistic != input.SvsDigestBusiStatistic || (this.SvsDigestBusiStatistic != null && !this.SvsDigestBusiStatistic.Equals(input.SvsDigestBusiStatistic))) return false;
            if (this.SvsDecodeBusiStatistic != input.SvsDecodeBusiStatistic || (this.SvsDecodeBusiStatistic != null && !this.SvsDecodeBusiStatistic.Equals(input.SvsDecodeBusiStatistic))) return false;

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
                if (this.PkiDigestBusiStatistic != null) hashCode = hashCode * 59 + this.PkiDigestBusiStatistic.GetHashCode();
                if (this.PkiDecryptBusiStatistic != null) hashCode = hashCode * 59 + this.PkiDecryptBusiStatistic.GetHashCode();
                if (this.PkiGenerateKeyBusiStatistic != null) hashCode = hashCode * 59 + this.PkiGenerateKeyBusiStatistic.GetHashCode();
                if (this.PkiVerifyBusiStatistic != null) hashCode = hashCode * 59 + this.PkiVerifyBusiStatistic.GetHashCode();
                if (this.PkiEncryptBusiStatistic != null) hashCode = hashCode * 59 + this.PkiEncryptBusiStatistic.GetHashCode();
                if (this.TsaVerifyBusiStatistic != null) hashCode = hashCode * 59 + this.TsaVerifyBusiStatistic.GetHashCode();
                if (this.TsaParseBusiStatistic != null) hashCode = hashCode * 59 + this.TsaParseBusiStatistic.GetHashCode();
                if (this.SvsVerifyBusiStatistic != null) hashCode = hashCode * 59 + this.SvsVerifyBusiStatistic.GetHashCode();
                if (this.PkiRandomBusiStatistic != null) hashCode = hashCode * 59 + this.PkiRandomBusiStatistic.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.SvsCertBusiStatistic != null) hashCode = hashCode * 59 + this.SvsCertBusiStatistic.GetHashCode();
                if (this.SvsEncodeBusiStatistic != null) hashCode = hashCode * 59 + this.SvsEncodeBusiStatistic.GetHashCode();
                if (this.TsaApplyBusiStatistic != null) hashCode = hashCode * 59 + this.TsaApplyBusiStatistic.GetHashCode();
                if (this.SvsSignBusiStatistic != null) hashCode = hashCode * 59 + this.SvsSignBusiStatistic.GetHashCode();
                if (this.SvsDecryptBusiStatistic != null) hashCode = hashCode * 59 + this.SvsDecryptBusiStatistic.GetHashCode();
                if (this.KmsBusiStatistic != null) hashCode = hashCode * 59 + this.KmsBusiStatistic.GetHashCode();
                if (this.SealVerifyBusiStatistic != null) hashCode = hashCode * 59 + this.SealVerifyBusiStatistic.GetHashCode();
                if (this.PkiSignBusiStatistic != null) hashCode = hashCode * 59 + this.PkiSignBusiStatistic.GetHashCode();
                if (this.SecauthBusiStatistic != null) hashCode = hashCode * 59 + this.SecauthBusiStatistic.GetHashCode();
                if (this.SealSignBusiStatistic != null) hashCode = hashCode * 59 + this.SealSignBusiStatistic.GetHashCode();
                if (this.SplitBusiStatistic != null) hashCode = hashCode * 59 + this.SplitBusiStatistic.GetHashCode();
                if (this.SvsRandomBusiStatistic != null) hashCode = hashCode * 59 + this.SvsRandomBusiStatistic.GetHashCode();
                if (this.SvsEncryptBusiStatistic != null) hashCode = hashCode * 59 + this.SvsEncryptBusiStatistic.GetHashCode();
                if (this.SmsDecBusiStatistic != null) hashCode = hashCode * 59 + this.SmsDecBusiStatistic.GetHashCode();
                if (this.SvsDigestBusiStatistic != null) hashCode = hashCode * 59 + this.SvsDigestBusiStatistic.GetHashCode();
                if (this.SvsDecodeBusiStatistic != null) hashCode = hashCode * 59 + this.SvsDecodeBusiStatistic.GetHashCode();
                return hashCode;
            }
        }
    }
}
