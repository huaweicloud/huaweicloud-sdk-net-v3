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
    /// 
    /// </summary>
    public class ImportKeyMaterialRequestBody 
    {

        /// <summary>
        /// 密钥ID，36字节，满足正则匹配“^[0-9a-z]{8}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{4}-[0-9a-z]{12}$”。 例如：0d0466b0-e727-4d9c-b35d-f84bb474a37f。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 密钥导入令牌，base64格式，满足正则匹配“^[0-9a-zA-Z+/&#x3D;]{200,6144}$”。
        /// </summary>
        [JsonProperty("import_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportToken { get; set; }

        /// <summary>
        /// 加密后的对称密钥材料，base64格式，满足正则匹配“^[0-9a-zA-Z+/&#x3D;]{344,360}$”。若导入非对称密钥，则该参数为用于加密私钥的临时中间密钥。
        /// </summary>
        [JsonProperty("encrypted_key_material", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedKeyMaterial { get; set; }

        /// <summary>
        /// 使用临时中间密钥加密后的私钥，导入非对称密钥需要该参数，base64格式，满足正则匹配“^[0-9a-zA-Z+/&#x3D;]{200,6144}$”。
        /// </summary>
        [JsonProperty("encrypted_privatekey", NullValueHandling = NullValueHandling.Ignore)]
        public string EncryptedPrivatekey { get; set; }

        /// <summary>
        /// 密钥材料到期时间，时间戳，即从1970年1月1日至该时间的总秒数，KMS会在该时间的24小时内删除密钥材料。 例如：1550291833
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// 请求消息序列号，36字节序列号。 例如：919c82d4-8046-4722-9094-35c3c6524cff
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public string Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportKeyMaterialRequestBody {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  importToken: ").Append(ImportToken).Append("\n");
            sb.Append("  encryptedKeyMaterial: ").Append(EncryptedKeyMaterial).Append("\n");
            sb.Append("  encryptedPrivatekey: ").Append(EncryptedPrivatekey).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportKeyMaterialRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportKeyMaterialRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeyId == input.KeyId ||
                    (this.KeyId != null &&
                    this.KeyId.Equals(input.KeyId))
                ) && 
                (
                    this.ImportToken == input.ImportToken ||
                    (this.ImportToken != null &&
                    this.ImportToken.Equals(input.ImportToken))
                ) && 
                (
                    this.EncryptedKeyMaterial == input.EncryptedKeyMaterial ||
                    (this.EncryptedKeyMaterial != null &&
                    this.EncryptedKeyMaterial.Equals(input.EncryptedKeyMaterial))
                ) && 
                (
                    this.EncryptedPrivatekey == input.EncryptedPrivatekey ||
                    (this.EncryptedPrivatekey != null &&
                    this.EncryptedPrivatekey.Equals(input.EncryptedPrivatekey))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.KeyId != null)
                    hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.ImportToken != null)
                    hashCode = hashCode * 59 + this.ImportToken.GetHashCode();
                if (this.EncryptedKeyMaterial != null)
                    hashCode = hashCode * 59 + this.EncryptedKeyMaterial.GetHashCode();
                if (this.EncryptedPrivatekey != null)
                    hashCode = hashCode * 59 + this.EncryptedPrivatekey.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
