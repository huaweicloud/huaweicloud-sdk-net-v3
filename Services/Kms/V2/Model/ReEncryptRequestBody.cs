using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// 重加密的请求体
    /// </summary>
    public class ReEncryptRequestBody 
    {

        /// <summary>
        /// 原密钥ID，用于解密密文。对于非对称密钥加密的密文source_key_id必填。对于对称密钥加密的密文，推荐填写source_key_id。kms会优先使用您填写的source_key_id进行解密。不填时会尝试从密文中解析出加密时使用的密钥ID进行解密。
        /// </summary>
        [JsonProperty("source_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceKeyId { get; set; }

        /// <summary>
        /// 加密原密文时使用的aad信息。如果加密时，没指定aad，则不能填写，否则会造成解密失败
        /// </summary>
        [JsonProperty("source_additional_authenticated_data", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceAdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// 加密原密文时使用的加密算法。默认值为“SYMMETRIC_DEFAULT”，合法枚举值如下： SYMMETRIC_DEFAULT RSAES_OAEP_SHA_1 RSAES_OAEP_SHA_256 SM2_ENCRYPT 注意：RSAES_OAEP_SHA_1已不再安全，请谨慎使用
        /// </summary>
        [JsonProperty("source_encryption_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceEncryptionAlgorithm { get; set; }

        /// <summary>
        /// 目的密钥ID,用于加密解密后的明文
        /// </summary>
        [JsonProperty("destination_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationKeyId { get; set; }

        /// <summary>
        /// 如果指定了值，会在重加密时，作为aad参与计算
        /// </summary>
        [JsonProperty("destination_additional_authenticated_data", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationAdditionalAuthenticatedData { get; set; }

        /// <summary>
        /// 重加密新密文时使用的加密算法。默认值为“SYMMETRIC_DEFAULT”，合法枚举值如下： SYMMETRIC_DEFAULT RSAES_OAEP_SHA_1 RSAES_OAEP_SHA_256 SM2_ENCRYPT 注意：RSAES_OAEP_SHA_1已不再安全，请谨慎使用
        /// </summary>
        [JsonProperty("destination_encryption_algorithm", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationEncryptionAlgorithm { get; set; }

        /// <summary>
        /// 当密文是CBC 模式加密的 数据密钥时，需要指定datakey_cipher_length。表示明文密钥材料的字节数
        /// </summary>
        [JsonProperty("datakey_cipher_length", NullValueHandling = NullValueHandling.Ignore)]
        public string DatakeyCipherLength { get; set; }

        /// <summary>
        /// 需要进行重加密的密文。
        /// </summary>
        [JsonProperty("cipher_text", NullValueHandling = NullValueHandling.Ignore)]
        public string CipherText { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReEncryptRequestBody {\n");
            sb.Append("  sourceKeyId: ").Append(SourceKeyId).Append("\n");
            sb.Append("  sourceAdditionalAuthenticatedData: ").Append(SourceAdditionalAuthenticatedData).Append("\n");
            sb.Append("  sourceEncryptionAlgorithm: ").Append(SourceEncryptionAlgorithm).Append("\n");
            sb.Append("  destinationKeyId: ").Append(DestinationKeyId).Append("\n");
            sb.Append("  destinationAdditionalAuthenticatedData: ").Append(DestinationAdditionalAuthenticatedData).Append("\n");
            sb.Append("  destinationEncryptionAlgorithm: ").Append(DestinationEncryptionAlgorithm).Append("\n");
            sb.Append("  datakeyCipherLength: ").Append(DatakeyCipherLength).Append("\n");
            sb.Append("  cipherText: ").Append(CipherText).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReEncryptRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReEncryptRequestBody input)
        {
            if (input == null) return false;
            if (this.SourceKeyId != input.SourceKeyId || (this.SourceKeyId != null && !this.SourceKeyId.Equals(input.SourceKeyId))) return false;
            if (this.SourceAdditionalAuthenticatedData != input.SourceAdditionalAuthenticatedData || (this.SourceAdditionalAuthenticatedData != null && !this.SourceAdditionalAuthenticatedData.Equals(input.SourceAdditionalAuthenticatedData))) return false;
            if (this.SourceEncryptionAlgorithm != input.SourceEncryptionAlgorithm || (this.SourceEncryptionAlgorithm != null && !this.SourceEncryptionAlgorithm.Equals(input.SourceEncryptionAlgorithm))) return false;
            if (this.DestinationKeyId != input.DestinationKeyId || (this.DestinationKeyId != null && !this.DestinationKeyId.Equals(input.DestinationKeyId))) return false;
            if (this.DestinationAdditionalAuthenticatedData != input.DestinationAdditionalAuthenticatedData || (this.DestinationAdditionalAuthenticatedData != null && !this.DestinationAdditionalAuthenticatedData.Equals(input.DestinationAdditionalAuthenticatedData))) return false;
            if (this.DestinationEncryptionAlgorithm != input.DestinationEncryptionAlgorithm || (this.DestinationEncryptionAlgorithm != null && !this.DestinationEncryptionAlgorithm.Equals(input.DestinationEncryptionAlgorithm))) return false;
            if (this.DatakeyCipherLength != input.DatakeyCipherLength || (this.DatakeyCipherLength != null && !this.DatakeyCipherLength.Equals(input.DatakeyCipherLength))) return false;
            if (this.CipherText != input.CipherText || (this.CipherText != null && !this.CipherText.Equals(input.CipherText))) return false;

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
                if (this.SourceKeyId != null) hashCode = hashCode * 59 + this.SourceKeyId.GetHashCode();
                if (this.SourceAdditionalAuthenticatedData != null) hashCode = hashCode * 59 + this.SourceAdditionalAuthenticatedData.GetHashCode();
                if (this.SourceEncryptionAlgorithm != null) hashCode = hashCode * 59 + this.SourceEncryptionAlgorithm.GetHashCode();
                if (this.DestinationKeyId != null) hashCode = hashCode * 59 + this.DestinationKeyId.GetHashCode();
                if (this.DestinationAdditionalAuthenticatedData != null) hashCode = hashCode * 59 + this.DestinationAdditionalAuthenticatedData.GetHashCode();
                if (this.DestinationEncryptionAlgorithm != null) hashCode = hashCode * 59 + this.DestinationEncryptionAlgorithm.GetHashCode();
                if (this.DatakeyCipherLength != null) hashCode = hashCode * 59 + this.DatakeyCipherLength.GetHashCode();
                if (this.CipherText != null) hashCode = hashCode * 59 + this.CipherText.GetHashCode();
                return hashCode;
            }
        }
    }
}
