using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V1.Model
{
    /// <summary>
    /// 创建凭据请求消息体。
    /// </summary>
    public class CreateSecretRequestBody 
    {

        /// <summary>
        /// 凭据名称。  约束：取值范围为1到64个字符，满足正则匹配“^[a-zA-Z0-9._-]{1,64}$”。 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用于加密保护凭据值的KMS主密钥ID，如果您未指定此参数，凭据管理服务将默认使用名为csms/default的默认主密钥，用于加密您账号在本项目中创建的凭据值。如果用户账号下不存在该名称的主密钥，则凭据管理服务自动为您创建该名称的密钥。
        /// </summary>
        [JsonProperty("kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// 凭据的描述信息。  约束：2048字节。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 二进制类型凭据在base64编码后的明文，凭据管理服务将其加密后，存入凭据的初始版本中。  类型：base64编码的二进制数据对象。  约束：secret_binary和secret_string必须且只能设置一个，最大32K。 
        /// </summary>
        [JsonProperty("secret_binary", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretBinary { get; set; }

        /// <summary>
        /// 文本类型凭据的明文，凭据管理服务将其加密后，存入凭据的初始版本中。  约束：secret_binary和secret_string必须且只能设置一个，最大32K。 
        /// </summary>
        [JsonProperty("secret_string", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretString { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecretRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  kmsKeyId: ").Append(KmsKeyId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  secretBinary: ").Append(SecretBinary).Append("\n");
            sb.Append("  secretString: ").Append(SecretString).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecretRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecretRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.KmsKeyId == input.KmsKeyId ||
                    (this.KmsKeyId != null &&
                    this.KmsKeyId.Equals(input.KmsKeyId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.SecretBinary == input.SecretBinary ||
                    (this.SecretBinary != null &&
                    this.SecretBinary.Equals(input.SecretBinary))
                ) && 
                (
                    this.SecretString == input.SecretString ||
                    (this.SecretString != null &&
                    this.SecretString.Equals(input.SecretString))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.KmsKeyId != null)
                    hashCode = hashCode * 59 + this.KmsKeyId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SecretBinary != null)
                    hashCode = hashCode * 59 + this.SecretBinary.GetHashCode();
                if (this.SecretString != null)
                    hashCode = hashCode * 59 + this.SecretString.GetHashCode();
                return hashCode;
            }
        }
    }
}
