using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 创建监听器的请求体
    /// </summary>
    public class CreateListenerReq 
    {
        /// <summary>
        /// 监听器的监听协议
        /// </summary>
        /// <value>监听器的监听协议</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum UDP for value: UDP
            /// </summary>
            public static readonly ProtocolEnum UDP = new ProtocolEnum("UDP");

            /// <summary>
            /// Enum TCP for value: TCP
            /// </summary>
            public static readonly ProtocolEnum TCP = new ProtocolEnum("TCP");

            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            public static readonly ProtocolEnum HTTP = new ProtocolEnum("HTTP");

            /// <summary>
            /// Enum TERMINATED_HTTPS for value: TERMINATED_HTTPS
            /// </summary>
            public static readonly ProtocolEnum TERMINATED_HTTPS = new ProtocolEnum("TERMINATED_HTTPS");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "UDP", UDP },
                { "TCP", TCP },
                { "HTTP", HTTP },
                { "TERMINATED_HTTPS", TERMINATED_HTTPS },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 监听器使用的安全策略，仅对TERMINATED_HTTPS协议类型的监听器有效，且默认值为tls-1-0。  取值包括：tls-1-0, tls-1-1, tls-1-2, tls-1-2-strict多种安全策略。
        /// </summary>
        /// <value>监听器使用的安全策略，仅对TERMINATED_HTTPS协议类型的监听器有效，且默认值为tls-1-0。  取值包括：tls-1-0, tls-1-1, tls-1-2, tls-1-2-strict多种安全策略。</value>
        [JsonConverter(typeof(EnumClassConverter<TlsCiphersPolicyEnum>))]
        public class TlsCiphersPolicyEnum
        {
            /// <summary>
            /// Enum TLS_1_0 for value: tls-1-0
            /// </summary>
            public static readonly TlsCiphersPolicyEnum TLS_1_0 = new TlsCiphersPolicyEnum("tls-1-0");

            /// <summary>
            /// Enum TLS_1_1 for value: tls-1-1
            /// </summary>
            public static readonly TlsCiphersPolicyEnum TLS_1_1 = new TlsCiphersPolicyEnum("tls-1-1");

            /// <summary>
            /// Enum TLS_1_2 for value: tls-1-2
            /// </summary>
            public static readonly TlsCiphersPolicyEnum TLS_1_2 = new TlsCiphersPolicyEnum("tls-1-2");

            /// <summary>
            /// Enum TLS_1_2_STRICT for value: tls-1-2-strict
            /// </summary>
            public static readonly TlsCiphersPolicyEnum TLS_1_2_STRICT = new TlsCiphersPolicyEnum("tls-1-2-strict");

            private static readonly Dictionary<string, TlsCiphersPolicyEnum> StaticFields =
            new Dictionary<string, TlsCiphersPolicyEnum>()
            {
                { "tls-1-0", TLS_1_0 },
                { "tls-1-1", TLS_1_1 },
                { "tls-1-2", TLS_1_2 },
                { "tls-1-2-strict", TLS_1_2_STRICT },
            };

            private string _value;

            public TlsCiphersPolicyEnum()
            {

            }

            public TlsCiphersPolicyEnum(string value)
            {
                _value = value;
            }

            public static TlsCiphersPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as TlsCiphersPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TlsCiphersPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TlsCiphersPolicyEnum a, TlsCiphersPolicyEnum b)
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

            public static bool operator !=(TlsCiphersPolicyEnum a, TlsCiphersPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 监听器关联的负载均衡器 ID
        /// </summary>
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// 监听器的监听协议
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 监听器的监听端口。如果监听协议为UDP，端口号不支持4789。
        /// </summary>
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// 监听器所在的项目ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 监听器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 监听器的描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 监听器器的管理状态。只支持设定为true，该字段的值无实际意义。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 监听器的最大连接数。该字段为预留字段，暂未启用。默认为-1。
        /// </summary>
        [JsonProperty("connection_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectionLimit { get; set; }

        /// <summary>
        /// HTTP2功能的开启状态。该字段只有当监听器的协议是TERMINATED_HTTPS时才有意义。
        /// </summary>
        [JsonProperty("http2_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Http2Enable { get; set; }

        /// <summary>
        /// 监听器的默认后端云服务器组ID。当请求没有匹配的转发策略时，转发到默认后端云服务器上处理。当该字段为null时，表示监听器无默认的后端云服务器组。
        /// </summary>
        [JsonProperty("default_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPoolId { get; set; }

        /// <summary>
        /// 监听器使用的服务器证书ID。当protocol参数为TERMINATED_HTTPS时，为必选字段
        /// </summary>
        [JsonProperty("default_tls_container_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultTlsContainerRef { get; set; }

        /// <summary>
        /// 监听器使用的CA证书ID。
        /// </summary>
        [JsonProperty("client_ca_tls_container_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientCaTlsContainerRef { get; set; }

        /// <summary>
        /// 监听器使用的SNI证书（带域名的服务器证书）ID的列表。 该字段不为空列表时，SNI特性开启。该字段为空列表时，SNI特性关闭。
        /// </summary>
        [JsonProperty("sni_container_refs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SniContainerRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insert_headers", NullValueHandling = NullValueHandling.Ignore)]
        public InsertHeader InsertHeaders { get; set; }

        /// <summary>
        /// 监听器使用的安全策略，仅对TERMINATED_HTTPS协议类型的监听器有效，且默认值为tls-1-0。  取值包括：tls-1-0, tls-1-1, tls-1-2, tls-1-2-strict多种安全策略。
        /// </summary>
        [JsonProperty("tls_ciphers_policy", NullValueHandling = NullValueHandling.Ignore)]
        public TlsCiphersPolicyEnum TlsCiphersPolicy { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListenerReq {\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  connectionLimit: ").Append(ConnectionLimit).Append("\n");
            sb.Append("  http2Enable: ").Append(Http2Enable).Append("\n");
            sb.Append("  defaultPoolId: ").Append(DefaultPoolId).Append("\n");
            sb.Append("  defaultTlsContainerRef: ").Append(DefaultTlsContainerRef).Append("\n");
            sb.Append("  clientCaTlsContainerRef: ").Append(ClientCaTlsContainerRef).Append("\n");
            sb.Append("  sniContainerRefs: ").Append(SniContainerRefs).Append("\n");
            sb.Append("  insertHeaders: ").Append(InsertHeaders).Append("\n");
            sb.Append("  tlsCiphersPolicy: ").Append(TlsCiphersPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateListenerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateListenerReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    (this.LoadbalancerId != null &&
                    this.LoadbalancerId.Equals(input.LoadbalancerId))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    (this.ProtocolPort != null &&
                    this.ProtocolPort.Equals(input.ProtocolPort))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
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
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.ConnectionLimit == input.ConnectionLimit ||
                    (this.ConnectionLimit != null &&
                    this.ConnectionLimit.Equals(input.ConnectionLimit))
                ) && 
                (
                    this.Http2Enable == input.Http2Enable ||
                    (this.Http2Enable != null &&
                    this.Http2Enable.Equals(input.Http2Enable))
                ) && 
                (
                    this.DefaultPoolId == input.DefaultPoolId ||
                    (this.DefaultPoolId != null &&
                    this.DefaultPoolId.Equals(input.DefaultPoolId))
                ) && 
                (
                    this.DefaultTlsContainerRef == input.DefaultTlsContainerRef ||
                    (this.DefaultTlsContainerRef != null &&
                    this.DefaultTlsContainerRef.Equals(input.DefaultTlsContainerRef))
                ) && 
                (
                    this.ClientCaTlsContainerRef == input.ClientCaTlsContainerRef ||
                    (this.ClientCaTlsContainerRef != null &&
                    this.ClientCaTlsContainerRef.Equals(input.ClientCaTlsContainerRef))
                ) && 
                (
                    this.SniContainerRefs == input.SniContainerRefs ||
                    this.SniContainerRefs != null &&
                    input.SniContainerRefs != null &&
                    this.SniContainerRefs.SequenceEqual(input.SniContainerRefs)
                ) && 
                (
                    this.InsertHeaders == input.InsertHeaders ||
                    (this.InsertHeaders != null &&
                    this.InsertHeaders.Equals(input.InsertHeaders))
                ) && 
                (
                    this.TlsCiphersPolicy == input.TlsCiphersPolicy ||
                    (this.TlsCiphersPolicy != null &&
                    this.TlsCiphersPolicy.Equals(input.TlsCiphersPolicy))
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
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.ConnectionLimit != null)
                    hashCode = hashCode * 59 + this.ConnectionLimit.GetHashCode();
                if (this.Http2Enable != null)
                    hashCode = hashCode * 59 + this.Http2Enable.GetHashCode();
                if (this.DefaultPoolId != null)
                    hashCode = hashCode * 59 + this.DefaultPoolId.GetHashCode();
                if (this.DefaultTlsContainerRef != null)
                    hashCode = hashCode * 59 + this.DefaultTlsContainerRef.GetHashCode();
                if (this.ClientCaTlsContainerRef != null)
                    hashCode = hashCode * 59 + this.ClientCaTlsContainerRef.GetHashCode();
                if (this.SniContainerRefs != null)
                    hashCode = hashCode * 59 + this.SniContainerRefs.GetHashCode();
                if (this.InsertHeaders != null)
                    hashCode = hashCode * 59 + this.InsertHeaders.GetHashCode();
                if (this.TlsCiphersPolicy != null)
                    hashCode = hashCode * 59 + this.TlsCiphersPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
