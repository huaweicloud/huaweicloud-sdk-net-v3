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
    /// 自定义安全策略创建参数。
    /// </summary>
    public class CreateSecurityPolicyOption 
    {
        /// <summary>
        /// Defines ciphers
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<CiphersEnum>))]
        public class CiphersEnum
        {
            /// <summary>
            /// Enum ECDHE_RSA_AES256_GCM_SHA384 for value: ECDHE-RSA-AES256-GCM-SHA384
            /// </summary>
            public static readonly CiphersEnum ECDHE_RSA_AES256_GCM_SHA384 = new CiphersEnum("ECDHE-RSA-AES256-GCM-SHA384");

            /// <summary>
            /// Enum ECDHE_RSA_AES128_GCM_SHA256 for value: ECDHE-RSA-AES128-GCM-SHA256
            /// </summary>
            public static readonly CiphersEnum ECDHE_RSA_AES128_GCM_SHA256 = new CiphersEnum("ECDHE-RSA-AES128-GCM-SHA256");

            /// <summary>
            /// Enum ECDHE_ECDSA_AES256_GCM_SHA384 for value: ECDHE-ECDSA-AES256-GCM-SHA384
            /// </summary>
            public static readonly CiphersEnum ECDHE_ECDSA_AES256_GCM_SHA384 = new CiphersEnum("ECDHE-ECDSA-AES256-GCM-SHA384");

            /// <summary>
            /// Enum ECDHE_ECDSA_AES128_GCM_SHA256 for value: ECDHE-ECDSA-AES128-GCM-SHA256
            /// </summary>
            public static readonly CiphersEnum ECDHE_ECDSA_AES128_GCM_SHA256 = new CiphersEnum("ECDHE-ECDSA-AES128-GCM-SHA256");

            /// <summary>
            /// Enum AES128_GCM_SHA256 for value: AES128-GCM-SHA256
            /// </summary>
            public static readonly CiphersEnum AES128_GCM_SHA256 = new CiphersEnum("AES128-GCM-SHA256");

            /// <summary>
            /// Enum AES256_GCM_SHA384 for value: AES256-GCM-SHA384
            /// </summary>
            public static readonly CiphersEnum AES256_GCM_SHA384 = new CiphersEnum("AES256-GCM-SHA384");

            /// <summary>
            /// Enum ECDHE_ECDSA_AES128_SHA256 for value: ECDHE-ECDSA-AES128-SHA256
            /// </summary>
            public static readonly CiphersEnum ECDHE_ECDSA_AES128_SHA256 = new CiphersEnum("ECDHE-ECDSA-AES128-SHA256");

            /// <summary>
            /// Enum ECDHE_RSA_AES128_SHA256 for value: ECDHE-RSA-AES128-SHA256
            /// </summary>
            public static readonly CiphersEnum ECDHE_RSA_AES128_SHA256 = new CiphersEnum("ECDHE-RSA-AES128-SHA256");

            /// <summary>
            /// Enum AES128_SHA256 for value: AES128-SHA256
            /// </summary>
            public static readonly CiphersEnum AES128_SHA256 = new CiphersEnum("AES128-SHA256");

            /// <summary>
            /// Enum AES256_SHA256 for value: AES256-SHA256
            /// </summary>
            public static readonly CiphersEnum AES256_SHA256 = new CiphersEnum("AES256-SHA256");

            /// <summary>
            /// Enum ECDHE_ECDSA_AES256_SHA384 for value: ECDHE-ECDSA-AES256-SHA384
            /// </summary>
            public static readonly CiphersEnum ECDHE_ECDSA_AES256_SHA384 = new CiphersEnum("ECDHE-ECDSA-AES256-SHA384");

            /// <summary>
            /// Enum ECDHE_RSA_AES256_SHA384 for value: ECDHE-RSA-AES256-SHA384
            /// </summary>
            public static readonly CiphersEnum ECDHE_RSA_AES256_SHA384 = new CiphersEnum("ECDHE-RSA-AES256-SHA384");

            /// <summary>
            /// Enum ECDHE_ECDSA_AES128_SHA for value: ECDHE-ECDSA-AES128-SHA
            /// </summary>
            public static readonly CiphersEnum ECDHE_ECDSA_AES128_SHA = new CiphersEnum("ECDHE-ECDSA-AES128-SHA");

            /// <summary>
            /// Enum ECDHE_RSA_AES128_SHA for value: ECDHE-RSA-AES128-SHA
            /// </summary>
            public static readonly CiphersEnum ECDHE_RSA_AES128_SHA = new CiphersEnum("ECDHE-RSA-AES128-SHA");

            /// <summary>
            /// Enum ECDHE_RSA_AES256_SHA for value: ECDHE-RSA-AES256-SHA
            /// </summary>
            public static readonly CiphersEnum ECDHE_RSA_AES256_SHA = new CiphersEnum("ECDHE-RSA-AES256-SHA");

            /// <summary>
            /// Enum ECDHE_ECDSA_AES256_SHA for value: ECDHE-ECDSA-AES256-SHA
            /// </summary>
            public static readonly CiphersEnum ECDHE_ECDSA_AES256_SHA = new CiphersEnum("ECDHE-ECDSA-AES256-SHA");

            /// <summary>
            /// Enum AES128_SHA for value: AES128-SHA
            /// </summary>
            public static readonly CiphersEnum AES128_SHA = new CiphersEnum("AES128-SHA");

            /// <summary>
            /// Enum AES256_SHA for value: AES256-SHA
            /// </summary>
            public static readonly CiphersEnum AES256_SHA = new CiphersEnum("AES256-SHA");

            /// <summary>
            /// Enum CAMELLIA128_SHA for value: CAMELLIA128-SHA
            /// </summary>
            public static readonly CiphersEnum CAMELLIA128_SHA = new CiphersEnum("CAMELLIA128-SHA");

            /// <summary>
            /// Enum DES_CBC3_SHA for value: DES-CBC3-SHA
            /// </summary>
            public static readonly CiphersEnum DES_CBC3_SHA = new CiphersEnum("DES-CBC3-SHA");

            /// <summary>
            /// Enum CAMELLIA256_SHA for value: CAMELLIA256-SHA
            /// </summary>
            public static readonly CiphersEnum CAMELLIA256_SHA = new CiphersEnum("CAMELLIA256-SHA");

            /// <summary>
            /// Enum ECDHE_RSA_CHACHA20_POLY1305 for value: ECDHE-RSA-CHACHA20-POLY1305
            /// </summary>
            public static readonly CiphersEnum ECDHE_RSA_CHACHA20_POLY1305 = new CiphersEnum("ECDHE-RSA-CHACHA20-POLY1305");

            /// <summary>
            /// Enum ECDHE_ECDSA_CHACHA20_POLY1305 for value: ECDHE-ECDSA-CHACHA20-POLY1305
            /// </summary>
            public static readonly CiphersEnum ECDHE_ECDSA_CHACHA20_POLY1305 = new CiphersEnum("ECDHE-ECDSA-CHACHA20-POLY1305");

            /// <summary>
            /// Enum TLS_AES_128_GCM_SHA256 for value: TLS_AES_128_GCM_SHA256
            /// </summary>
            public static readonly CiphersEnum TLS_AES_128_GCM_SHA256 = new CiphersEnum("TLS_AES_128_GCM_SHA256");

            /// <summary>
            /// Enum TLS_AES_256_GCM_SHA384 for value: TLS_AES_256_GCM_SHA384
            /// </summary>
            public static readonly CiphersEnum TLS_AES_256_GCM_SHA384 = new CiphersEnum("TLS_AES_256_GCM_SHA384");

            /// <summary>
            /// Enum TLS_CHACHA20_POLY1305_SHA256 for value: TLS_CHACHA20_POLY1305_SHA256
            /// </summary>
            public static readonly CiphersEnum TLS_CHACHA20_POLY1305_SHA256 = new CiphersEnum("TLS_CHACHA20_POLY1305_SHA256");

            /// <summary>
            /// Enum TLS_AES_128_CCM_SHA256 for value: TLS_AES_128_CCM_SHA256
            /// </summary>
            public static readonly CiphersEnum TLS_AES_128_CCM_SHA256 = new CiphersEnum("TLS_AES_128_CCM_SHA256");

            /// <summary>
            /// Enum TLS_AES_128_CCM_8_SHA256 for value: TLS_AES_128_CCM_8_SHA256
            /// </summary>
            public static readonly CiphersEnum TLS_AES_128_CCM_8_SHA256 = new CiphersEnum("TLS_AES_128_CCM_8_SHA256");

            /// <summary>
            /// Enum ECC_SM4_SM3 for value: ECC-SM4-SM3
            /// </summary>
            public static readonly CiphersEnum ECC_SM4_SM3 = new CiphersEnum("ECC-SM4-SM3");

            /// <summary>
            /// Enum ECDHE_SM4_SM3 for value: ECDHE-SM4-SM3
            /// </summary>
            public static readonly CiphersEnum ECDHE_SM4_SM3 = new CiphersEnum("ECDHE-SM4-SM3");

            private static readonly Dictionary<string, CiphersEnum> StaticFields =
            new Dictionary<string, CiphersEnum>()
            {
                { "ECDHE-RSA-AES256-GCM-SHA384", ECDHE_RSA_AES256_GCM_SHA384 },
                { "ECDHE-RSA-AES128-GCM-SHA256", ECDHE_RSA_AES128_GCM_SHA256 },
                { "ECDHE-ECDSA-AES256-GCM-SHA384", ECDHE_ECDSA_AES256_GCM_SHA384 },
                { "ECDHE-ECDSA-AES128-GCM-SHA256", ECDHE_ECDSA_AES128_GCM_SHA256 },
                { "AES128-GCM-SHA256", AES128_GCM_SHA256 },
                { "AES256-GCM-SHA384", AES256_GCM_SHA384 },
                { "ECDHE-ECDSA-AES128-SHA256", ECDHE_ECDSA_AES128_SHA256 },
                { "ECDHE-RSA-AES128-SHA256", ECDHE_RSA_AES128_SHA256 },
                { "AES128-SHA256", AES128_SHA256 },
                { "AES256-SHA256", AES256_SHA256 },
                { "ECDHE-ECDSA-AES256-SHA384", ECDHE_ECDSA_AES256_SHA384 },
                { "ECDHE-RSA-AES256-SHA384", ECDHE_RSA_AES256_SHA384 },
                { "ECDHE-ECDSA-AES128-SHA", ECDHE_ECDSA_AES128_SHA },
                { "ECDHE-RSA-AES128-SHA", ECDHE_RSA_AES128_SHA },
                { "ECDHE-RSA-AES256-SHA", ECDHE_RSA_AES256_SHA },
                { "ECDHE-ECDSA-AES256-SHA", ECDHE_ECDSA_AES256_SHA },
                { "AES128-SHA", AES128_SHA },
                { "AES256-SHA", AES256_SHA },
                { "CAMELLIA128-SHA", CAMELLIA128_SHA },
                { "DES-CBC3-SHA", DES_CBC3_SHA },
                { "CAMELLIA256-SHA", CAMELLIA256_SHA },
                { "ECDHE-RSA-CHACHA20-POLY1305", ECDHE_RSA_CHACHA20_POLY1305 },
                { "ECDHE-ECDSA-CHACHA20-POLY1305", ECDHE_ECDSA_CHACHA20_POLY1305 },
                { "TLS_AES_128_GCM_SHA256", TLS_AES_128_GCM_SHA256 },
                { "TLS_AES_256_GCM_SHA384", TLS_AES_256_GCM_SHA384 },
                { "TLS_CHACHA20_POLY1305_SHA256", TLS_CHACHA20_POLY1305_SHA256 },
                { "TLS_AES_128_CCM_SHA256", TLS_AES_128_CCM_SHA256 },
                { "TLS_AES_128_CCM_8_SHA256", TLS_AES_128_CCM_8_SHA256 },
                { "ECC-SM4-SM3", ECC_SM4_SM3 },
                { "ECDHE-SM4-SM3", ECDHE_SM4_SM3 },
            };

            private string Value;

            public CiphersEnum(string value)
            {
                Value = value;
            }

            public static CiphersEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as CiphersEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CiphersEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(CiphersEnum a, CiphersEnum b)
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

            public static bool operator !=(CiphersEnum a, CiphersEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 自定义安全策略的名称。默认空字符串\&quot;\&quot;。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 自定义安全策略的描述信息。默认空字符串\&quot;\&quot;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 所属企业项目ID。  [不支持该字段，请勿使用。](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 自定义安全策略选择的TLS协议列表。取值：TLSv1, TLSv1.1, TLSv1.2, TLSv1.3, GMTLS
        /// </summary>
        [JsonProperty("protocols", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Protocols { get; set; }

        /// <summary>
        /// 自定义策略的加密套件列表。支持以下加密套件： ECDHE-RSA-AES256-GCM-SHA384,ECDHE-RSA-AES128-GCM-SHA256,ECDHE-ECDSA-AES256-GCM-SHA384,ECDHE-ECDSA-AES128-GCM-SHA256,AES128-GCM-SHA256,AES256-GCM-SHA384,ECDHE-ECDSA-AES128-SHA256,ECDHE-RSA-AES128-SHA256,AES128-SHA256,AES256-SHA256,ECDHE-ECDSA-AES256-SHA384,ECDHE-RSA-AES256-SHA384,ECDHE-ECDSA-AES128-SHA,ECDHE-RSA-AES128-SHA,ECDHE-RSA-AES256-SHA,ECDHE-ECDSA-AES256-SHA,AES128-SHA,AES256-SHA,CAMELLIA128-SHA,DES-CBC3-SHA,CAMELLIA256-SHA,ECDHE-RSA-CHACHA20-POLY1305,ECDHE-ECDSA-CHACHA20-POLY1305,TLS_AES_128_GCM_SHA256,TLS_AES_256_GCM_SHA384,TLS_CHACHA20_POLY1305_SHA256,TLS_AES_128_CCM_SHA256,TLS_AES_128_CCM_8_SHA256,ECC-SM4-SM3, ECDHE-SM4-SM3
        /// </summary>
        [JsonProperty("ciphers", NullValueHandling = NullValueHandling.Ignore)]
        public List<CiphersEnum> Ciphers { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSecurityPolicyOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  protocols: ").Append(Protocols).Append("\n");
            sb.Append("  ciphers: ").Append(Ciphers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSecurityPolicyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSecurityPolicyOption input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Protocols == input.Protocols ||
                    this.Protocols != null &&
                    input.Protocols != null &&
                    this.Protocols.SequenceEqual(input.Protocols)
                ) && 
                (
                    this.Ciphers == input.Ciphers ||
                    this.Ciphers != null &&
                    input.Ciphers != null &&
                    this.Ciphers.SequenceEqual(input.Ciphers)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Protocols != null)
                    hashCode = hashCode * 59 + this.Protocols.GetHashCode();
                if (this.Ciphers != null)
                    hashCode = hashCode * 59 + this.Ciphers.GetHashCode();
                return hashCode;
            }
        }
    }
}
