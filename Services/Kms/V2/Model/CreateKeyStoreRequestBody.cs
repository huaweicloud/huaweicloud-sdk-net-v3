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
        /// 专属密钥库集群类型。DHSM表示专属加密服务集群，CDMS表示密码卡集群,DEFAULT表示KMS原有集群
        /// </summary>
        /// <value>专属密钥库集群类型。DHSM表示专属加密服务集群，CDMS表示密码卡集群,DEFAULT表示KMS原有集群</value>
        [JsonConverter(typeof(EnumClassConverter<KeystoreTypeEnum>))]
        public class KeystoreTypeEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly KeystoreTypeEnum DEFAULT = new KeystoreTypeEnum("DEFAULT");

            /// <summary>
            /// Enum DHSM for value: DHSM
            /// </summary>
            public static readonly KeystoreTypeEnum DHSM = new KeystoreTypeEnum("DHSM");

            /// <summary>
            /// Enum CDMS for value: CDMS
            /// </summary>
            public static readonly KeystoreTypeEnum CDMS = new KeystoreTypeEnum("CDMS");

            /// <summary>
            /// Enum XKS for value: XKS
            /// </summary>
            public static readonly KeystoreTypeEnum XKS = new KeystoreTypeEnum("XKS");

            private static readonly Dictionary<string, KeystoreTypeEnum> StaticFields =
            new Dictionary<string, KeystoreTypeEnum>()
            {
                { "DEFAULT", DEFAULT },
                { "DHSM", DHSM },
                { "CDMS", CDMS },
                { "XKS", XKS },
            };

            private string _value;

            public KeystoreTypeEnum()
            {

            }

            public KeystoreTypeEnum(string value)
            {
                _value = value;
            }

            public static KeystoreTypeEnum FromValue(string value)
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

                if (this.Equals(obj as KeystoreTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeystoreTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeystoreTypeEnum a, KeystoreTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(KeystoreTypeEnum a, KeystoreTypeEnum b)
            {
                return !(a == b);
            }
        }


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
        /// 集群ID。当类型为DHSM时，cluster_id为hsm_cluster_id。当类型为CDMS时，为cdms_cluster_id
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 专属密钥库集群类型。DHSM表示专属加密服务集群，CDMS表示密码卡集群,DEFAULT表示KMS原有集群
        /// </summary>
        [JsonProperty("keystore_type", NullValueHandling = NullValueHandling.Ignore)]
        public KeystoreTypeEnum KeystoreType { get; set; }
        /// <summary>
        /// **参数解释：** 仅XKS类型的密钥库支持；可选，表示Xks-Proxy的域名信息 **约束限制：** ^https://[^\\s]+ **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("proxy_uri_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyUriEndpoint { get; set; }

        /// <summary>
        /// **参数解释：** 仅XKS类型的密钥库支持；必选，Xks-Proxy的路径前缀 **约束限制：** ^/(?:[a-zA-Z0-9/_-]{0,127})$ **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("proxy_uri_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyUriPath { get; set; }

        /// <summary>
        /// **参数解释：** 仅XKS类型的密钥库支持；必选，访问XKS-Proxy的凭据ID **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("proxy_access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyAccessKeyId { get; set; }

        /// <summary>
        /// **参数解释：** 仅XKS类型的密钥库支持；必选，访问XKS-Proxy的凭据Key **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("proxy_secret_access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxySecretAccessKey { get; set; }

        /// <summary>
        /// **参数解释：** 仅XKS类型的密钥库支持；必选，Xks-Proxy的终端节点服务名称 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("proxy_vpc_endpoint_service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyVpcEndpointServiceName { get; set; }

        /// <summary>
        /// **参数解释：** 仅XKS类型的密钥库支持；必选，终端节点服务所属账号 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("proxy_vpc_endpoint_service_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyVpcEndpointServiceOwner { get; set; }



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
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  keystoreType: ").Append(KeystoreType).Append("\n");
            sb.Append("  proxyUriEndpoint: ").Append(ProxyUriEndpoint).Append("\n");
            sb.Append("  proxyUriPath: ").Append(ProxyUriPath).Append("\n");
            sb.Append("  proxyAccessKeyId: ").Append(ProxyAccessKeyId).Append("\n");
            sb.Append("  proxySecretAccessKey: ").Append(ProxySecretAccessKey).Append("\n");
            sb.Append("  proxyVpcEndpointServiceName: ").Append(ProxyVpcEndpointServiceName).Append("\n");
            sb.Append("  proxyVpcEndpointServiceOwner: ").Append(ProxyVpcEndpointServiceOwner).Append("\n");
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
            if (input == null) return false;
            if (this.KeystoreAlias != input.KeystoreAlias || (this.KeystoreAlias != null && !this.KeystoreAlias.Equals(input.KeystoreAlias))) return false;
            if (this.HsmClusterId != input.HsmClusterId || (this.HsmClusterId != null && !this.HsmClusterId.Equals(input.HsmClusterId))) return false;
            if (this.HsmCaCert != input.HsmCaCert || (this.HsmCaCert != null && !this.HsmCaCert.Equals(input.HsmCaCert))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.KeystoreType != input.KeystoreType) return false;
            if (this.ProxyUriEndpoint != input.ProxyUriEndpoint || (this.ProxyUriEndpoint != null && !this.ProxyUriEndpoint.Equals(input.ProxyUriEndpoint))) return false;
            if (this.ProxyUriPath != input.ProxyUriPath || (this.ProxyUriPath != null && !this.ProxyUriPath.Equals(input.ProxyUriPath))) return false;
            if (this.ProxyAccessKeyId != input.ProxyAccessKeyId || (this.ProxyAccessKeyId != null && !this.ProxyAccessKeyId.Equals(input.ProxyAccessKeyId))) return false;
            if (this.ProxySecretAccessKey != input.ProxySecretAccessKey || (this.ProxySecretAccessKey != null && !this.ProxySecretAccessKey.Equals(input.ProxySecretAccessKey))) return false;
            if (this.ProxyVpcEndpointServiceName != input.ProxyVpcEndpointServiceName || (this.ProxyVpcEndpointServiceName != null && !this.ProxyVpcEndpointServiceName.Equals(input.ProxyVpcEndpointServiceName))) return false;
            if (this.ProxyVpcEndpointServiceOwner != input.ProxyVpcEndpointServiceOwner || (this.ProxyVpcEndpointServiceOwner != null && !this.ProxyVpcEndpointServiceOwner.Equals(input.ProxyVpcEndpointServiceOwner))) return false;

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
                if (this.KeystoreAlias != null) hashCode = hashCode * 59 + this.KeystoreAlias.GetHashCode();
                if (this.HsmClusterId != null) hashCode = hashCode * 59 + this.HsmClusterId.GetHashCode();
                if (this.HsmCaCert != null) hashCode = hashCode * 59 + this.HsmCaCert.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                hashCode = hashCode * 59 + this.KeystoreType.GetHashCode();
                if (this.ProxyUriEndpoint != null) hashCode = hashCode * 59 + this.ProxyUriEndpoint.GetHashCode();
                if (this.ProxyUriPath != null) hashCode = hashCode * 59 + this.ProxyUriPath.GetHashCode();
                if (this.ProxyAccessKeyId != null) hashCode = hashCode * 59 + this.ProxyAccessKeyId.GetHashCode();
                if (this.ProxySecretAccessKey != null) hashCode = hashCode * 59 + this.ProxySecretAccessKey.GetHashCode();
                if (this.ProxyVpcEndpointServiceName != null) hashCode = hashCode * 59 + this.ProxyVpcEndpointServiceName.GetHashCode();
                if (this.ProxyVpcEndpointServiceOwner != null) hashCode = hashCode * 59 + this.ProxyVpcEndpointServiceOwner.GetHashCode();
                return hashCode;
            }
        }
    }
}
