using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    ///  
    /// </summary>
    public class NovaKeypair 
    {

        /// <summary>
        /// 密钥对应指纹信息。
        /// </summary>
        [JsonProperty("fingerprint", NullValueHandling = NullValueHandling.Ignore)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// 密钥名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 密钥对应publicKey信息。
        /// </summary>
        [JsonProperty("public_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicKey { get; set; }

        /// <summary>
        /// 密钥对应privateKey信息。  - 创建SSH密钥时，响应中包括private_key的信息。 - 导入SSH密钥时，响应中不包括private_key的信息。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 密钥所属用户ID。
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 密钥类型，默认“ssh”  微版本2.2以上支持
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaKeypair {\n");
            sb.Append("  fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  publicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaKeypair);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaKeypair input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fingerprint == input.Fingerprint ||
                    (this.Fingerprint != null &&
                    this.Fingerprint.Equals(input.Fingerprint))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
                ) && 
                (
                    this.PrivateKey == input.PrivateKey ||
                    (this.PrivateKey != null &&
                    this.PrivateKey.Equals(input.PrivateKey))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Fingerprint != null)
                    hashCode = hashCode * 59 + this.Fingerprint.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PublicKey != null)
                    hashCode = hashCode * 59 + this.PublicKey.GetHashCode();
                if (this.PrivateKey != null)
                    hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
