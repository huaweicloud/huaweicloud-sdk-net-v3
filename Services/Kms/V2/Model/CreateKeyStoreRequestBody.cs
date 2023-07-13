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
    /// 创建专属密钥库请求体
    /// </summary>
    public class CreateKeyStoreRequestBody 
    {

        /// <summary>
        /// 专属密钥库别名，取值范围为1到255个字符，满足正则匹配“^[a-zA-Z0-9:/_-]{1,255}$”，且不与已有的专属密钥库别名重名。
        /// </summary>
        [JsonProperty("keystore_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreAlias { get; set; }

        /// <summary>
        /// DHSM集群Id，要求集群当前未创建专属密钥库。
        /// </summary>
        [JsonProperty("hsm_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HsmClusterId { get; set; }

        /// <summary>
        /// DHSM集群的CA证书
        /// </summary>
        [JsonProperty("hsm_ca_cert", NullValueHandling = NullValueHandling.Ignore)]
        public string HsmCaCert { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKeyStoreRequestBody {\n");
            sb.Append("  keystoreAlias: ").Append(KeystoreAlias).Append("\n");
            sb.Append("  hsmClusterId: ").Append(HsmClusterId).Append("\n");
            sb.Append("  hsmCaCert: ").Append(HsmCaCert).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKeyStoreRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKeyStoreRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.KeystoreAlias == input.KeystoreAlias ||
                    (this.KeystoreAlias != null &&
                    this.KeystoreAlias.Equals(input.KeystoreAlias))
                ) && 
                (
                    this.HsmClusterId == input.HsmClusterId ||
                    (this.HsmClusterId != null &&
                    this.HsmClusterId.Equals(input.HsmClusterId))
                ) && 
                (
                    this.HsmCaCert == input.HsmCaCert ||
                    (this.HsmCaCert != null &&
                    this.HsmCaCert.Equals(input.HsmCaCert))
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
                if (this.KeystoreAlias != null)
                    hashCode = hashCode * 59 + this.KeystoreAlias.GetHashCode();
                if (this.HsmClusterId != null)
                    hashCode = hashCode * 59 + this.HsmClusterId.GetHashCode();
                if (this.HsmCaCert != null)
                    hashCode = hashCode * 59 + this.HsmCaCert.GetHashCode();
                return hashCode;
            }
        }
    }
}
