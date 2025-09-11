using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListKmsTdeKeyResponseBodyKeyDetails 
    {

        /// <summary>
        /// **参数解释**: 秘钥ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// **参数解释**: 默认主密钥标识。 **取值范围**: 默认主密钥标识为1，非默认标识为0。
        /// </summary>
        [JsonProperty("default_key_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultKeyFlag { get; set; }

        /// <summary>
        /// **参数解释**: 密钥别名。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("key_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyAlias { get; set; }

        /// <summary>
        /// **参数解释**: 密钥生成算法。 **取值范围**: - AES_256 - SM4 - RSA_2048 - RSA_3072 - RSA_4096 - EC_P256 - EC_P384 - SM2 - ALL
        /// </summary>
        [JsonProperty("key_spec", NullValueHandling = NullValueHandling.Ignore)]
        public string KeySpec { get; set; }

        /// <summary>
        /// **参数解释**: 用户域ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释**: 秘钥状态。 **取值范围**: - “1”表示待激活状态。 - “2”表示启用状态。 - “3”表示禁用状态。 - “4”表示计划删除状态。 - “5”表示等待导入状态。
        /// </summary>
        [JsonProperty("key_state", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyState { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKmsTdeKeyResponseBodyKeyDetails {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  defaultKeyFlag: ").Append(DefaultKeyFlag).Append("\n");
            sb.Append("  keyAlias: ").Append(KeyAlias).Append("\n");
            sb.Append("  keySpec: ").Append(KeySpec).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  keyState: ").Append(KeyState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKmsTdeKeyResponseBodyKeyDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKmsTdeKeyResponseBodyKeyDetails input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.DefaultKeyFlag != input.DefaultKeyFlag || (this.DefaultKeyFlag != null && !this.DefaultKeyFlag.Equals(input.DefaultKeyFlag))) return false;
            if (this.KeyAlias != input.KeyAlias || (this.KeyAlias != null && !this.KeyAlias.Equals(input.KeyAlias))) return false;
            if (this.KeySpec != input.KeySpec || (this.KeySpec != null && !this.KeySpec.Equals(input.KeySpec))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.KeyState != input.KeyState || (this.KeyState != null && !this.KeyState.Equals(input.KeyState))) return false;

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
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                if (this.DefaultKeyFlag != null) hashCode = hashCode * 59 + this.DefaultKeyFlag.GetHashCode();
                if (this.KeyAlias != null) hashCode = hashCode * 59 + this.KeyAlias.GetHashCode();
                if (this.KeySpec != null) hashCode = hashCode * 59 + this.KeySpec.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.KeyState != null) hashCode = hashCode * 59 + this.KeyState.GetHashCode();
                return hashCode;
            }
        }
    }
}
