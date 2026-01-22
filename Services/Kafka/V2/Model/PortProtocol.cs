using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// **参数解释**： 设置Kafka实例的接入方式。PLAINTEXT表示明文接入，SASL_SSL[或者SASL_PLAINTEXT](tag:hws,hws_hk,hws_eu)表示密文接入。 **约束限制**： 内网访问不支持关闭，明文接入和密文接入至少开启一个。 [跨VPC访问的安全协议等于内网访问的安全协议，若内网同时开启了密文访问和明文访问，则跨VPC访问的安全协议会优先使用密文访问的安全协议。](tag:hws,hws_hk,hws_eu)
    /// </summary>
    public class PortProtocol 
    {

        /// <summary>
        /// **参数解释**： 是否开启内网明文访问连接方式。 **约束限制**： 不涉及。 **取值范围**： - true：开启内网明文访问连接方式，连接地址：ip:9092，访问协议PLAINTEXT。 - false：关闭内网明文访问。 **默认取值**： false。
        /// </summary>
        [JsonProperty("private_plain_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivatePlainEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启安全协议为SASL_SSL的内网密文接入方式。 **约束限制**： [private_sasl_ssl_enable和private_sasl_plaintext_enable不能同时为true。](tag:hws,hws_eu,hws_hk,ctc,g42,hk_g42,tm,hk_tm,dt,ax,sbc,hk_sbc,srg,fcs,cmcc)[不涉及。](tag:hcs,ocb,hws_ocb) **取值范围**： - true：开启安全协议为SASL_SSL的内网密文接入方式。          - false：关闭安全协议为SASL_SSL的内网接入方式。 **默认取值**： false。
        /// </summary>
        [JsonProperty("private_sasl_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateSaslSslEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启安全协议为SASL_PLAINTEXT的内网密文接入方式。 **约束限制**： [private_sasl_plaintext_enable和private_sasl_ssl_enable不能同时为true。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt,ax,sbc,hk_sbc,srg,fcs,cmcc)[华为云Stack不支持此参数。](tag:hcs) **取值范围**： - true：开启安全协议为SASL_PLAINTEXT的内网密文接入方式，连接地址：ip:9093，访问协议SASL_PLAINTEXT。     - false：关闭安全协议为SASL_PLAINTEXT的内网密文接入方式。 **默认取值**： false。
        /// </summary>
        [JsonProperty("private_sasl_plaintext_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateSaslPlaintextEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启公网明文访问连接方式。 **约束限制**： 开启公网明文接入前，需要先开启公网访问功能。 **取值范围**： - true：开启公网明文访问连接方式，连接地址：ip:9094，访问协议PLAINTEXT。     - false：关闭公网明文接入方式。 **默认取值**： false。
        /// </summary>
        [JsonProperty("public_plain_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicPlainEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启安全协议为SASL_SSL的公网密文接入。 **约束限制**： [public_sasl_ssl_enable和public_sasl_plaintext_enable不能同时为true。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt,ax,sbc,hk_sbc,srg,fcs,cmcc)[不涉及。](tag:hcs) 为true时，需要实例开启公网。 **取值范围**： - true：开启安全协议为SASL_SSL的公网密文接入方式，连接地址：ip:9095，访问协议：SASL_SSL。 - false：关闭安全协议为SASL_SSL的公网密文接入方式。 **默认取值**： false。
        /// </summary>
        [JsonProperty("public_sasl_ssl_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicSaslSslEnable { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启安全协议为SASL_PLAINTEXT的公网密文接入方式。 **约束限制**： [public_sasl_plaintext_enable和public_sasl_ssl_enable不能同时为true。](tag:hws,hws_eu,hws_hk,ocb,hws_ocb,ctc,g42,hk_g42,tm,hk_tm,dt,ax,sbc,hk_sbc,srg,fcs,cmcc)[华为云Stack不支持此参数。](tag:hcs) 为true时，需要实例开启公网。 **取值范围**： - true：开启安全协议为SASL_PLAINTEXT的公网密文接入方式，连接地址：ip:9095，访问协议：SASL_PLAINTEXT。           - false：关闭安全协议为SASL_PLAINTEXT的公网密文接入方式。 **默认取值**： false。
        /// </summary>
        [JsonProperty("public_sasl_plaintext_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PublicSaslPlaintextEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortProtocol {\n");
            sb.Append("  privatePlainEnable: ").Append(PrivatePlainEnable).Append("\n");
            sb.Append("  privateSaslSslEnable: ").Append(PrivateSaslSslEnable).Append("\n");
            sb.Append("  privateSaslPlaintextEnable: ").Append(PrivateSaslPlaintextEnable).Append("\n");
            sb.Append("  publicPlainEnable: ").Append(PublicPlainEnable).Append("\n");
            sb.Append("  publicSaslSslEnable: ").Append(PublicSaslSslEnable).Append("\n");
            sb.Append("  publicSaslPlaintextEnable: ").Append(PublicSaslPlaintextEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PortProtocol);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PortProtocol input)
        {
            if (input == null) return false;
            if (this.PrivatePlainEnable != input.PrivatePlainEnable || (this.PrivatePlainEnable != null && !this.PrivatePlainEnable.Equals(input.PrivatePlainEnable))) return false;
            if (this.PrivateSaslSslEnable != input.PrivateSaslSslEnable || (this.PrivateSaslSslEnable != null && !this.PrivateSaslSslEnable.Equals(input.PrivateSaslSslEnable))) return false;
            if (this.PrivateSaslPlaintextEnable != input.PrivateSaslPlaintextEnable || (this.PrivateSaslPlaintextEnable != null && !this.PrivateSaslPlaintextEnable.Equals(input.PrivateSaslPlaintextEnable))) return false;
            if (this.PublicPlainEnable != input.PublicPlainEnable || (this.PublicPlainEnable != null && !this.PublicPlainEnable.Equals(input.PublicPlainEnable))) return false;
            if (this.PublicSaslSslEnable != input.PublicSaslSslEnable || (this.PublicSaslSslEnable != null && !this.PublicSaslSslEnable.Equals(input.PublicSaslSslEnable))) return false;
            if (this.PublicSaslPlaintextEnable != input.PublicSaslPlaintextEnable || (this.PublicSaslPlaintextEnable != null && !this.PublicSaslPlaintextEnable.Equals(input.PublicSaslPlaintextEnable))) return false;

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
                if (this.PrivatePlainEnable != null) hashCode = hashCode * 59 + this.PrivatePlainEnable.GetHashCode();
                if (this.PrivateSaslSslEnable != null) hashCode = hashCode * 59 + this.PrivateSaslSslEnable.GetHashCode();
                if (this.PrivateSaslPlaintextEnable != null) hashCode = hashCode * 59 + this.PrivateSaslPlaintextEnable.GetHashCode();
                if (this.PublicPlainEnable != null) hashCode = hashCode * 59 + this.PublicPlainEnable.GetHashCode();
                if (this.PublicSaslSslEnable != null) hashCode = hashCode * 59 + this.PublicSaslSslEnable.GetHashCode();
                if (this.PublicSaslPlaintextEnable != null) hashCode = hashCode * 59 + this.PublicSaslPlaintextEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
