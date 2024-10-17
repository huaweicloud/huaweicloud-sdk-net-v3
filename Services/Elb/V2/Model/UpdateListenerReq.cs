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
    /// 更新监听器的请求体。
    /// </summary>
    public class UpdateListenerReq 
    {
        /// <summary>
        /// 修改保护状态, 取值： - nonProtection: 不保护 - consoleProtection: 控制台修改保护
        /// </summary>
        /// <value>修改保护状态, 取值： - nonProtection: 不保护 - consoleProtection: 控制台修改保护</value>
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
        /// 监听器使用的SNI证书（带域名的服务器证书）ID的列表。
        /// </summary>
        [JsonProperty("sni_container_refs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SniContainerRefs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insert_headers", NullValueHandling = NullValueHandling.Ignore)]
        public InsertHeader InsertHeaders { get; set; }

        /// <summary>
        /// 监听器使用的安全策略，仅对TERMINATED_HTTPS协议类型的监听器有效。  取值包括：tls-1-0, tls-1-1, tls-1-2, tls-1-2-strict多种安全策略。  加密套件的排序为国密套件、ecc套件、rsa套件、tls1.3协议的套件（即支持ecc又支持rsa）
        /// </summary>
        [JsonProperty("tls_ciphers_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsCiphersPolicy { get; set; }

        /// <summary>
        /// 监听器的管理状态。  该字段为预留字段，暂未启动。只支持设定为true
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 修改保护状态, 取值： - nonProtection: 不保护 - consoleProtection: 控制台修改保护
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectionStatusEnum ProtectionStatus { get; set; }
        /// <summary>
        /// 设置保护的原因 &gt;仅当protection_status为consoleProtection时有效。
        /// </summary>
        [JsonProperty("protection_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectionReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateListenerReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  connectionLimit: ").Append(ConnectionLimit).Append("\n");
            sb.Append("  http2Enable: ").Append(Http2Enable).Append("\n");
            sb.Append("  defaultPoolId: ").Append(DefaultPoolId).Append("\n");
            sb.Append("  defaultTlsContainerRef: ").Append(DefaultTlsContainerRef).Append("\n");
            sb.Append("  clientCaTlsContainerRef: ").Append(ClientCaTlsContainerRef).Append("\n");
            sb.Append("  sniContainerRefs: ").Append(SniContainerRefs).Append("\n");
            sb.Append("  insertHeaders: ").Append(InsertHeaders).Append("\n");
            sb.Append("  tlsCiphersPolicy: ").Append(TlsCiphersPolicy).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
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
            return this.Equals(input as UpdateListenerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateListenerReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ConnectionLimit != input.ConnectionLimit || (this.ConnectionLimit != null && !this.ConnectionLimit.Equals(input.ConnectionLimit))) return false;
            if (this.Http2Enable != input.Http2Enable || (this.Http2Enable != null && !this.Http2Enable.Equals(input.Http2Enable))) return false;
            if (this.DefaultPoolId != input.DefaultPoolId || (this.DefaultPoolId != null && !this.DefaultPoolId.Equals(input.DefaultPoolId))) return false;
            if (this.DefaultTlsContainerRef != input.DefaultTlsContainerRef || (this.DefaultTlsContainerRef != null && !this.DefaultTlsContainerRef.Equals(input.DefaultTlsContainerRef))) return false;
            if (this.ClientCaTlsContainerRef != input.ClientCaTlsContainerRef || (this.ClientCaTlsContainerRef != null && !this.ClientCaTlsContainerRef.Equals(input.ClientCaTlsContainerRef))) return false;
            if (this.SniContainerRefs != input.SniContainerRefs || (this.SniContainerRefs != null && input.SniContainerRefs != null && !this.SniContainerRefs.SequenceEqual(input.SniContainerRefs))) return false;
            if (this.InsertHeaders != input.InsertHeaders || (this.InsertHeaders != null && !this.InsertHeaders.Equals(input.InsertHeaders))) return false;
            if (this.TlsCiphersPolicy != input.TlsCiphersPolicy || (this.TlsCiphersPolicy != null && !this.TlsCiphersPolicy.Equals(input.TlsCiphersPolicy))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ConnectionLimit != null) hashCode = hashCode * 59 + this.ConnectionLimit.GetHashCode();
                if (this.Http2Enable != null) hashCode = hashCode * 59 + this.Http2Enable.GetHashCode();
                if (this.DefaultPoolId != null) hashCode = hashCode * 59 + this.DefaultPoolId.GetHashCode();
                if (this.DefaultTlsContainerRef != null) hashCode = hashCode * 59 + this.DefaultTlsContainerRef.GetHashCode();
                if (this.ClientCaTlsContainerRef != null) hashCode = hashCode * 59 + this.ClientCaTlsContainerRef.GetHashCode();
                if (this.SniContainerRefs != null) hashCode = hashCode * 59 + this.SniContainerRefs.GetHashCode();
                if (this.InsertHeaders != null) hashCode = hashCode * 59 + this.InsertHeaders.GetHashCode();
                if (this.TlsCiphersPolicy != null) hashCode = hashCode * 59 + this.TlsCiphersPolicy.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ProtectionReason != null) hashCode = hashCode * 59 + this.ProtectionReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
