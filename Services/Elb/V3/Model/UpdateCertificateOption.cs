using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateCertificateOption 
    {
        /// <summary>
        /// 参数解释：修改保护状态  约束限制：无  取值范围：  - nonProtection: 不保护  - consoleProtection: 控制台修改保护  默认取值：nonProtection
        /// </summary>
        /// <value>参数解释：修改保护状态  约束限制：无  取值范围：  - nonProtection: 不保护  - consoleProtection: 控制台修改保护  默认取值：nonProtection</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectionStatusEnum>))]
        public class ProtectionStatusEnum
        {
            /// <summary>
            /// Enum NONPROTECTION for value: nonProtection
            /// </summary>
            public static readonly ProtectionStatusEnum NONPROTECTION = new ProtectionStatusEnum("nonProtection");

            /// <summary>
            /// Enum CONSOLEPROTECTION for value: consoleProtection
            /// </summary>
            public static readonly ProtectionStatusEnum CONSOLEPROTECTION = new ProtectionStatusEnum("consoleProtection");

            private static readonly Dictionary<string, ProtectionStatusEnum> StaticFields =
            new Dictionary<string, ProtectionStatusEnum>()
            {
                { "nonProtection", NONPROTECTION },
                { "consoleProtection", CONSOLEPROTECTION },
            };

            private string _value;

            public ProtectionStatusEnum()
            {

            }

            public ProtectionStatusEnum(string value)
            {
                _value = value;
            }

            public static ProtectionStatusEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ProtectionStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectionStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtectionStatusEnum a, ProtectionStatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ProtectionStatusEnum a, ProtectionStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 证书的内容。PEM编码格式。 最大长度65536字符。 支持证书链，最大11层(含证书和证书链)。
        /// </summary>
        [JsonProperty("certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        /// <summary>
        /// 证书的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 证书的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 服务器证书的私钥。PEM编码格式。 当type为client时，该参数被忽略，不影响证书的创建和使用。若传入不符合格式值，则会报错。 当type为server时，该字段必须符合格式要求，且私钥必须是有效的。 最大长度8192字符。
        /// </summary>
        [JsonProperty("private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// 服务器证书所签域名。该字段仅type为server时有效。  总长度为0-10000，由若干普通域名或泛域名组成，域名之间以\&quot;,\&quot;分隔，不超过100个域名。  普通域名：由若干字符串组成，字符串间以\&quot;.\&quot;分隔，单个字符串长度不超过63个字符， 只能包含英文字母、数字或\&quot;-\&quot;，且必须以字母或数字开头和结尾。例：www.test.com；  泛域名：在普通域名的基础上仅允许首字母为\&quot;\\*\&quot;。例：\\*.test.com
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// HTTPS协议使用的SM加密证书内容。支持证书链，最大11层(含证书和证书链)。  取值：PEM编码格式。最大长度65536字符。  使用说明：仅type为server_sm时有效。
        /// </summary>
        [JsonProperty("enc_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string EncCertificate { get; set; }

        /// <summary>
        /// HTTPS协议使用的SM加密证书内容。  取值：PEM编码格式。最大长度8192字符。  使用说明：仅type为server_sm时有效。
        /// </summary>
        [JsonProperty("enc_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string EncPrivateKey { get; set; }

        /// <summary>
        /// scm证书id
        /// </summary>
        [JsonProperty("scm_certificate_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmCertificateId { get; set; }

        /// <summary>
        /// 参数解释：证书来源 取值范围：无  默认取值：当scm_certificate_id不为空，且未传入source时，默认取值为“scm”； 其他情况下默认为空。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 参数解释：修改保护状态  约束限制：无  取值范围：  - nonProtection: 不保护  - consoleProtection: 控制台修改保护  默认取值：nonProtection
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectionStatusEnum ProtectionStatus { get; set; }
        /// <summary>
        /// 参数解释：设置修改保护的原因  约束限制：仅当protection_status为consoleProtection时有效  取值范围：无  默认取值：空
        /// </summary>
        [JsonProperty("protection_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectionReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCertificateOption {\n");
            sb.Append("  certificate: ").Append(Certificate).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  privateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  encCertificate: ").Append(EncCertificate).Append("\n");
            sb.Append("  encPrivateKey: ").Append(EncPrivateKey).Append("\n");
            sb.Append("  scmCertificateId: ").Append(ScmCertificateId).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  protectionReason: ").Append(ProtectionReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCertificateOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCertificateOption input)
        {
            if (input == null) return false;
            if (this.Certificate != input.Certificate || (this.Certificate != null && !this.Certificate.Equals(input.Certificate))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PrivateKey != input.PrivateKey || (this.PrivateKey != null && !this.PrivateKey.Equals(input.PrivateKey))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.EncCertificate != input.EncCertificate || (this.EncCertificate != null && !this.EncCertificate.Equals(input.EncCertificate))) return false;
            if (this.EncPrivateKey != input.EncPrivateKey || (this.EncPrivateKey != null && !this.EncPrivateKey.Equals(input.EncPrivateKey))) return false;
            if (this.ScmCertificateId != input.ScmCertificateId || (this.ScmCertificateId != null && !this.ScmCertificateId.Equals(input.ScmCertificateId))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.ProtectionStatus != input.ProtectionStatus) return false;
            if (this.ProtectionReason != input.ProtectionReason || (this.ProtectionReason != null && !this.ProtectionReason.Equals(input.ProtectionReason))) return false;

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
                if (this.Certificate != null) hashCode = hashCode * 59 + this.Certificate.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PrivateKey != null) hashCode = hashCode * 59 + this.PrivateKey.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.EncCertificate != null) hashCode = hashCode * 59 + this.EncCertificate.GetHashCode();
                if (this.EncPrivateKey != null) hashCode = hashCode * 59 + this.EncPrivateKey.GetHashCode();
                if (this.ScmCertificateId != null) hashCode = hashCode * 59 + this.ScmCertificateId.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ProtectionReason != null) hashCode = hashCode * 59 + this.ProtectionReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
