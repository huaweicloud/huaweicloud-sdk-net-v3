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
    /// 创建监听器的请求参数。
    /// </summary>
    public class CreateListenerOption 
    {
        /// <summary>
        /// 参数解释：修改保护状态。  取值范围： - nonProtection: 不保护，默认值为nonProtection - consoleProtection: 控制台修改保护
        /// </summary>
        /// <value>参数解释：修改保护状态。  取值范围： - nonProtection: 不保护，默认值为nonProtection - consoleProtection: 控制台修改保护</value>
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
        /// 参数解释：监听器的管理状态。  约束限制：只支持设置为true。  [不支持该字段，请勿使用。](tag:dt,hcso_dt)
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 参数解释：监听器默认的后端服务器组ID。当请求没有匹配的转发策略时，转发到默认后端服务器上处理。
        /// </summary>
        [JsonProperty("default_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPoolId { get; set; }

        /// <summary>
        /// 参数解释：监听器使用的CA证书ID。  约束限制： - 当且仅当type&#x3D;client时，才会使用该字段对应的证书。 - 监听器协议为QUIC时不支持该字段。  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt,dt)
        /// </summary>
        [JsonProperty("client_ca_tls_container_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientCaTlsContainerRef { get; set; }

        /// <summary>
        /// 参数解释：监听器使用的服务器证书ID。  约束限制：当监听器协议为HTTPS、TLS或QUIC时，该字段必传，且对应的证书的type必须是server类型。
        /// </summary>
        [JsonProperty("default_tls_container_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultTlsContainerRef { get; set; }

        /// <summary>
        /// 参数解释：监听器的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 参数解释：客户端与LB之间的HTTPS请求的HTTP2功能的开启状态。 开启后，可提升客户端与LB间的访问性能，但LB与后端服务器间仍采用HTTP1.X协议。  约束限制： - 仅HTTPS协议监听器有效。 - QUIC监听器不能设置该字段，固定返回为true。 - 其他协议的监听器可设置该字段但无效，无论取值如何都不影响监听器正常运行。  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt,dt)
        /// </summary>
        [JsonProperty("http2_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Http2Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("insert_headers", NullValueHandling = NullValueHandling.Ignore)]
        public ListenerInsertHeaders InsertHeaders { get; set; }

        /// <summary>
        /// 参数解释：监听器所属的负载均衡器的ID列表。  约束限制： 一个监听器只支持关联到一个LB。
        /// </summary>
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// 参数解释：监听器的名称。  注意：若名称为空，则在控制台的监听器列表无法选择并查看监听器详情。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数解释：监听器所在的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 参数解释：监听器的监听协议。  [ 约束限制： - 共享型LB上的HTTPS监听器只支持设置为TERMINATED_HTTPS。 传入HTTPS将会自动转为TERMINATED_HTTPS。 - 独享型LB上的HTTPS监听器只支持设置为HTTPS，传入TERMINATED_HTTPS将会自动转为HTTPS。  取值范围：TCP、UDP、HTTP、HTTPS、TERMINATED_HTTPS、QUIC、TLS。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [取值范围：TCP、UDP、HTTP、HTTPS。](tag:hcso_dt) [取值范围：TCP、UDP、IP、HTTP、HTTPS。IP为网关型LB上的监听器独有的协议。](tag:hws_eu)  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt,dt)
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 参数解释：监听器的监听端口。  约束限制： - QUIC监听器端口不能是4789，且不能和UDP监听器端口重复。 - 传0时表示开启监听端口范围的能力，此时port_ranges为必填字段。 [- 共享型LB上的HTTP和TERMINATED_HTTPS监听器不支持设置21端口。](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt,dt)
        /// </summary>
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// 参数解释：监听器使用的SNI证书（带域名的服务器证书）ID列表。  约束限制： - QUIC监听器仅支持RSA证书。 - 列表对应的所有SNI证书的域名不允许存在重复。 - 列表对应的所有SNI证书的域名总数不超过200。  [不支持QUIC。](tag:tm,hws_eu,g42,hk_g42,hcso_dt,dt)
        /// </summary>
        [JsonProperty("sni_container_refs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SniContainerRefs { get; set; }

        /// <summary>
        /// 参数解释：监听器使用的SNI证书泛域名匹配方式。  取值范围： - longest_suffix 表示最长尾缀匹配。 - wildcard 表示标准域名分级匹配。  默认取值：wildcard。
        /// </summary>
        [JsonProperty("sni_match_algo", NullValueHandling = NullValueHandling.Ignore)]
        public string SniMatchAlgo { get; set; }

        /// <summary>
        /// 参数解释：标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 参数解释：监听器使用的安全策略。  [约束限制： - 仅对HTTPS协议类型的监听器且关联LB为独享型时有效。 - QUIC监听器不支持该字段。 - 若同时设置了security_policy_id和tls_ciphers_policy，则仅security_policy_id生效。 - 加密套件的优先顺序为ecc套件、rsa套件、tls1.3协议的套件（即支持ecc又支持rsa） ](tag:hws,hws_hk,hws_eu,g42,hk_g42,ocb,tlf,ctc,hcso,ct,sbc,tm,cmcc,dt)  [约束限制： - 仅对HTTPS协议类型的监听器有效](tag:hcso_dt)  [取值范围：tls-1-0-inherit、tls-1-0、tls-1-1、 tls-1-2、tls-1-2-strict、tls-1-2-fs、tls-1-0-with-1-3、 tls-1-2-fs-with-1-3、 hybrid-policy-1-0、tls-1-2-strict-no-cbc，默认：tls-1-2。 ](tag:hws,hws_hk,ocb,tlf,ctc,hcso,ct,sbc,tm,cmcc,dt)  [取值范围：tls-1-0、tls-1-1、tls-1-2、 tls-1-2-strict，默认：tls-1-2。](tag:hws_eu,g42,hk_g42,hcso_dt)  [不支持tls1.3协议的套件。](tag:tm,hws_eu,g42,hk_g42) [不支持QUIC。](tag:tm,dt)
        /// </summary>
        [JsonProperty("tls_ciphers_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string TlsCiphersPolicy { get; set; }

        /// <summary>
        /// 参数解释：自定义安全策略的ID。  [约束限制： - 仅对HTTPS协议类型的监听器且关联LB为独享型时有效。 - QUIC监听器不支持该字段。 - 若同时设置了security_policy_id和tls_ciphers_policy，则仅security_policy_id生效。 - 加密套件的优先顺序为ecc套件、rsa套件、tls1.3协议的套件 （即支持ecc又支持rsa） ](tag:hws,hws_hk,hws_eu,g42,hk_g42,ocb,tlf,ctc,hcso,ct,sbc,tm,cmcc,dt)  [约束限制： - 仅对HTTPS协议类型的监听器有效](tag:hcso_dt)  [不支持tls1.3协议的套件。](tag:tm,hws_eu,g42,hk_g42)  [不支持QUIC。](tag:tm,dt)
        /// </summary>
        [JsonProperty("security_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// 参数解释：是否开启后端服务器的重试。  [约束限制： - 若关联是共享型LB，仅在protocol为HTTP、TERMINATED_HTTPS时才能传入该字段。 - 若关联是独享型LB，仅在protocol为HTTP、HTTPS和QUIC时才能传入该字段。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [约束限制： - 仅在protocol为HTTP、HTTPS时才能传入该字段。](tag:hws_eu,hcso_dt)  取值范围：true 开启重试，false 不开启重试。默认：true。  [不支持QUIC。](tag:tm,dt)
        /// </summary>
        [JsonProperty("enable_member_retry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMemberRetry { get; set; }

        /// <summary>
        /// 参数解释：客户端连接空闲超时时间。在超过keepalive_timeout时长一直没有请求，负载均衡会暂时中断当前连接，直到下一次请求时重新建立新的连接。  约束限制：共享型实例的UDP监听器不支持此字段。  取值范围： - TCP监听器[和IP监听器](tag:hws_eu)：10-4000s，默认值为300s。 - 若为HTTP/HTTPS/TERMINATED_HTTPS监听器，取值范围为（0-4000s）默认值为60s。
        /// </summary>
        [JsonProperty("keepalive_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepaliveTimeout { get; set; }

        /// <summary>
        /// 参数解释：等待客户端请求超时时间，包括两种情况： - 读取整个客户端请求头的超时时长：如果客户端未在超时时长内发送完整个请求头，则请求将被中断 - 两个连续body体的数据包到达LB的时间间隔，超出client_timeout将会断开连接。  约束限制：仅协议为HTTP/HTTPS的监听器支持该字段。  取值范围： 1-300s。  默认取值：60s。
        /// </summary>
        [JsonProperty("client_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientTimeout { get; set; }

        /// <summary>
        /// 参数解释：等待后端服务器响应超时时间。请求转发后端服务器后，在等待超时member_timeout时长没有响应，负载均衡将终止等待，并返回HTTP504错误码。  约束限制：仅支持协议为HTTP/HTTPS的监听器。  取值范围：1-300s。  默认取值：60s。
        /// </summary>
        [JsonProperty("member_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemberTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipgroup", NullValueHandling = NullValueHandling.Ignore)]
        public CreateListenerIpGroupOption Ipgroup { get; set; }

        /// <summary>
        /// 参数解释：是否透传客户端IP地址。开启后客户端IP地址将透传到后端服务器。  [约束限制： - 仅作用于共享型LB的TCP/UDP监听器。 - 开启特性后，ELB和后端服务器之间直接使用真实的IP访问，需要确保已正确设置服务器的安全组以及访问控制策略。 - 开启特性后，不支持同一台服务器既作为后端服务器又作为客户端的场景。 - 开启特性后，不支持变更后端服务器规格。  取值范围： - 共享型LB的TCP/UDP监听器可设置为true或false，不传默认为false。 - 共享型LB的HTTP/HTTPS监听器只支持设置为true，不传默认为true。 - 独享型负载均衡器所有协议的监听器只支持设置为true，不传默认为true。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,hk_vdf,srg,fcs,dt)  [约束限制：只设支持置为true，不传默认为true。](tag:hws_eu,hcso_dt)
        /// </summary>
        [JsonProperty("transparent_client_ip_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TransparentClientIpEnable { get; set; }

        /// <summary>
        /// 参数解释：是否开启proxy_protocol。  约束限制：仅TLS监听器可指定，其他协议的监听器该字段不生效，proxy_protocol不开启。
        /// </summary>
        [JsonProperty("proxy_protocol_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProxyProtocolEnable { get; set; }

        /// <summary>
        /// 参数解释：是否开启高级转发策略功能。开启高级转发策略后，支持更灵活的转发策略和转发规则设置。  开启后支持如下场景： - 转发策略的action字段支持指定为REDIRECT_TO_URL, FIXED_RESPONSE，即支持URL重定向和响应固定的内容给客户端。 - 转发策略支持指定priority、redirect_url_config、fixed_response_config字段。 - 转发规则rule的type可以指定METHOD, HEADER, QUERY_STRING, SOURCE_IP这几种取值。 - 转发规则rule的type为HOST_NAME时，转发规则rule的value支持通配符*。 - 转发规则支持指定conditions字段。  约束限制： - 开启后不支持关闭。 - 开启高级转发策略后，监听器关联的转发策略的匹配优先级由转发策略的priority字段来决定，不再自动排序。具体说明详见转发策略的priority字段的说明。  取值范围：true开启，false不开启。  默认取值：false。[西南-贵阳一和华南-广州局点，该配置默认true。](tag:hws)  [荷兰region不支持该字段，请勿使用。](tag:dt)
        /// </summary>
        [JsonProperty("enhance_l7policy_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnhanceL7policyEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("quic_config", NullValueHandling = NullValueHandling.Ignore)]
        public CreateListenerQuicConfigOption QuicConfig { get; set; }

        /// <summary>
        /// 参数解释：修改保护状态。  取值范围： - nonProtection: 不保护，默认值为nonProtection - consoleProtection: 控制台修改保护
        /// </summary>
        [JsonProperty("protection_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectionStatusEnum ProtectionStatus { get; set; }
        /// <summary>
        /// 参数解释：设置保护的原因。作为protection_status的转态设置的原因。  约束限制：仅当protection_status为consoleProtection时有效。  取值范围：除&#39;&lt;&#39;和&#39;&gt;&#39;外通用Unicode字符集字符，最大255个字符。
        /// </summary>
        [JsonProperty("protection_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtectionReason { get; set; }

        /// <summary>
        /// 参数解释：ELB是否开启gzip压缩。  [约束限制：仅HTTP/HTTPS类型监听器支持配置。](tag:tm,hws_eu,g42,hk_g42,hcso_dt,dt) [约束限制：仅HTTP/HTTPS/QUIC类型监听器支持配置。](tag:hws,hws_hk,hws_test,hcs,hcs_sm,hcso,hk_vdf,srg,fcs,fcs_vm,mix,ocb,ctc,cmcc,ct,sbc,hws_ocb,hk_sbc)  取值范围：true，false  默认取值：false
        /// </summary>
        [JsonProperty("gzip_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GzipEnable { get; set; }

        /// <summary>
        /// 参数解释：端口监听范围（闭区间)，最多指定10个端口组，每个组范围不可有重叠部分。  约束限制： - 仅当protocol_port为0或未传入protoco_port时可以传入该字段。 - 仅TCP, UDP，TLS监听支持该字段
        /// </summary>
        [JsonProperty("port_ranges", NullValueHandling = NullValueHandling.Ignore)]
        public List<PortRange> PortRanges { get; set; }

        /// <summary>
        /// 参数解释：监听器0-RTT能力开关。  约束限制：仅HTTPS类型监听器支持配置，需要依赖TLSv1.3安全策略协议。开启 ssl_early_data 后，有重放攻击的风险，请谨慎开启。  取值范围：true，false  默认取值：false
        /// </summary>
        [JsonProperty("ssl_early_data_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEarlyDataEnable { get; set; }

        /// <summary>
        /// 参数解释：监听器新建限速。  约束限制：当该限速值大于LB的限速值时，以LB的限速值生效  取值范围：0-1000000  默认取值：0，表示不限速。
        /// </summary>
        [JsonProperty("cps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cps { get; set; }

        /// <summary>
        /// 参数解释：监听器并发限速  约束限制：当该限速值大于LB的限速值时，以LB的限速值生效  取值范围：0-1000000  默认取值：0，表示不限速。
        /// </summary>
        [JsonProperty("connection", NullValueHandling = NullValueHandling.Ignore)]
        public int? Connection { get; set; }

        /// <summary>
        /// 参数解释： 监听器地址族转换能力开关，可以实现客户端通过访问LB的IPv4或者IPv6地址，来访问IPv4后端和IPv6后端。  约束限制： 仅对于TCP、UDP协议类型的监听器生效，与transparent_client_ip_enable，获取客户端ip功能开关互斥，开启地址族转换同时需要保证获取客户端ip功能关闭。  取值范围： - true：开启地址族转换功能 - false：关闭地址族转换功能  默认取值：false
        /// </summary>
        [JsonProperty("nat64_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nat64Enable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListenerOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  defaultPoolId: ").Append(DefaultPoolId).Append("\n");
            sb.Append("  clientCaTlsContainerRef: ").Append(ClientCaTlsContainerRef).Append("\n");
            sb.Append("  defaultTlsContainerRef: ").Append(DefaultTlsContainerRef).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  http2Enable: ").Append(Http2Enable).Append("\n");
            sb.Append("  insertHeaders: ").Append(InsertHeaders).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  sniContainerRefs: ").Append(SniContainerRefs).Append("\n");
            sb.Append("  sniMatchAlgo: ").Append(SniMatchAlgo).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tlsCiphersPolicy: ").Append(TlsCiphersPolicy).Append("\n");
            sb.Append("  securityPolicyId: ").Append(SecurityPolicyId).Append("\n");
            sb.Append("  enableMemberRetry: ").Append(EnableMemberRetry).Append("\n");
            sb.Append("  keepaliveTimeout: ").Append(KeepaliveTimeout).Append("\n");
            sb.Append("  clientTimeout: ").Append(ClientTimeout).Append("\n");
            sb.Append("  memberTimeout: ").Append(MemberTimeout).Append("\n");
            sb.Append("  ipgroup: ").Append(Ipgroup).Append("\n");
            sb.Append("  transparentClientIpEnable: ").Append(TransparentClientIpEnable).Append("\n");
            sb.Append("  proxyProtocolEnable: ").Append(ProxyProtocolEnable).Append("\n");
            sb.Append("  enhanceL7policyEnable: ").Append(EnhanceL7policyEnable).Append("\n");
            sb.Append("  quicConfig: ").Append(QuicConfig).Append("\n");
            sb.Append("  protectionStatus: ").Append(ProtectionStatus).Append("\n");
            sb.Append("  protectionReason: ").Append(ProtectionReason).Append("\n");
            sb.Append("  gzipEnable: ").Append(GzipEnable).Append("\n");
            sb.Append("  portRanges: ").Append(PortRanges).Append("\n");
            sb.Append("  sslEarlyDataEnable: ").Append(SslEarlyDataEnable).Append("\n");
            sb.Append("  cps: ").Append(Cps).Append("\n");
            sb.Append("  connection: ").Append(Connection).Append("\n");
            sb.Append("  nat64Enable: ").Append(Nat64Enable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateListenerOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateListenerOption input)
        {
            if (input == null) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.DefaultPoolId != input.DefaultPoolId || (this.DefaultPoolId != null && !this.DefaultPoolId.Equals(input.DefaultPoolId))) return false;
            if (this.ClientCaTlsContainerRef != input.ClientCaTlsContainerRef || (this.ClientCaTlsContainerRef != null && !this.ClientCaTlsContainerRef.Equals(input.ClientCaTlsContainerRef))) return false;
            if (this.DefaultTlsContainerRef != input.DefaultTlsContainerRef || (this.DefaultTlsContainerRef != null && !this.DefaultTlsContainerRef.Equals(input.DefaultTlsContainerRef))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Http2Enable != input.Http2Enable || (this.Http2Enable != null && !this.Http2Enable.Equals(input.Http2Enable))) return false;
            if (this.InsertHeaders != input.InsertHeaders || (this.InsertHeaders != null && !this.InsertHeaders.Equals(input.InsertHeaders))) return false;
            if (this.LoadbalancerId != input.LoadbalancerId || (this.LoadbalancerId != null && !this.LoadbalancerId.Equals(input.LoadbalancerId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.ProtocolPort != input.ProtocolPort || (this.ProtocolPort != null && !this.ProtocolPort.Equals(input.ProtocolPort))) return false;
            if (this.SniContainerRefs != input.SniContainerRefs || (this.SniContainerRefs != null && input.SniContainerRefs != null && !this.SniContainerRefs.SequenceEqual(input.SniContainerRefs))) return false;
            if (this.SniMatchAlgo != input.SniMatchAlgo || (this.SniMatchAlgo != null && !this.SniMatchAlgo.Equals(input.SniMatchAlgo))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TlsCiphersPolicy != input.TlsCiphersPolicy || (this.TlsCiphersPolicy != null && !this.TlsCiphersPolicy.Equals(input.TlsCiphersPolicy))) return false;
            if (this.SecurityPolicyId != input.SecurityPolicyId || (this.SecurityPolicyId != null && !this.SecurityPolicyId.Equals(input.SecurityPolicyId))) return false;
            if (this.EnableMemberRetry != input.EnableMemberRetry || (this.EnableMemberRetry != null && !this.EnableMemberRetry.Equals(input.EnableMemberRetry))) return false;
            if (this.KeepaliveTimeout != input.KeepaliveTimeout || (this.KeepaliveTimeout != null && !this.KeepaliveTimeout.Equals(input.KeepaliveTimeout))) return false;
            if (this.ClientTimeout != input.ClientTimeout || (this.ClientTimeout != null && !this.ClientTimeout.Equals(input.ClientTimeout))) return false;
            if (this.MemberTimeout != input.MemberTimeout || (this.MemberTimeout != null && !this.MemberTimeout.Equals(input.MemberTimeout))) return false;
            if (this.Ipgroup != input.Ipgroup || (this.Ipgroup != null && !this.Ipgroup.Equals(input.Ipgroup))) return false;
            if (this.TransparentClientIpEnable != input.TransparentClientIpEnable || (this.TransparentClientIpEnable != null && !this.TransparentClientIpEnable.Equals(input.TransparentClientIpEnable))) return false;
            if (this.ProxyProtocolEnable != input.ProxyProtocolEnable || (this.ProxyProtocolEnable != null && !this.ProxyProtocolEnable.Equals(input.ProxyProtocolEnable))) return false;
            if (this.EnhanceL7policyEnable != input.EnhanceL7policyEnable || (this.EnhanceL7policyEnable != null && !this.EnhanceL7policyEnable.Equals(input.EnhanceL7policyEnable))) return false;
            if (this.QuicConfig != input.QuicConfig || (this.QuicConfig != null && !this.QuicConfig.Equals(input.QuicConfig))) return false;
            if (this.ProtectionStatus != input.ProtectionStatus) return false;
            if (this.ProtectionReason != input.ProtectionReason || (this.ProtectionReason != null && !this.ProtectionReason.Equals(input.ProtectionReason))) return false;
            if (this.GzipEnable != input.GzipEnable || (this.GzipEnable != null && !this.GzipEnable.Equals(input.GzipEnable))) return false;
            if (this.PortRanges != input.PortRanges || (this.PortRanges != null && input.PortRanges != null && !this.PortRanges.SequenceEqual(input.PortRanges))) return false;
            if (this.SslEarlyDataEnable != input.SslEarlyDataEnable || (this.SslEarlyDataEnable != null && !this.SslEarlyDataEnable.Equals(input.SslEarlyDataEnable))) return false;
            if (this.Cps != input.Cps || (this.Cps != null && !this.Cps.Equals(input.Cps))) return false;
            if (this.Connection != input.Connection || (this.Connection != null && !this.Connection.Equals(input.Connection))) return false;
            if (this.Nat64Enable != input.Nat64Enable || (this.Nat64Enable != null && !this.Nat64Enable.Equals(input.Nat64Enable))) return false;

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
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.DefaultPoolId != null) hashCode = hashCode * 59 + this.DefaultPoolId.GetHashCode();
                if (this.ClientCaTlsContainerRef != null) hashCode = hashCode * 59 + this.ClientCaTlsContainerRef.GetHashCode();
                if (this.DefaultTlsContainerRef != null) hashCode = hashCode * 59 + this.DefaultTlsContainerRef.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Http2Enable != null) hashCode = hashCode * 59 + this.Http2Enable.GetHashCode();
                if (this.InsertHeaders != null) hashCode = hashCode * 59 + this.InsertHeaders.GetHashCode();
                if (this.LoadbalancerId != null) hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.ProtocolPort != null) hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.SniContainerRefs != null) hashCode = hashCode * 59 + this.SniContainerRefs.GetHashCode();
                if (this.SniMatchAlgo != null) hashCode = hashCode * 59 + this.SniMatchAlgo.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TlsCiphersPolicy != null) hashCode = hashCode * 59 + this.TlsCiphersPolicy.GetHashCode();
                if (this.SecurityPolicyId != null) hashCode = hashCode * 59 + this.SecurityPolicyId.GetHashCode();
                if (this.EnableMemberRetry != null) hashCode = hashCode * 59 + this.EnableMemberRetry.GetHashCode();
                if (this.KeepaliveTimeout != null) hashCode = hashCode * 59 + this.KeepaliveTimeout.GetHashCode();
                if (this.ClientTimeout != null) hashCode = hashCode * 59 + this.ClientTimeout.GetHashCode();
                if (this.MemberTimeout != null) hashCode = hashCode * 59 + this.MemberTimeout.GetHashCode();
                if (this.Ipgroup != null) hashCode = hashCode * 59 + this.Ipgroup.GetHashCode();
                if (this.TransparentClientIpEnable != null) hashCode = hashCode * 59 + this.TransparentClientIpEnable.GetHashCode();
                if (this.ProxyProtocolEnable != null) hashCode = hashCode * 59 + this.ProxyProtocolEnable.GetHashCode();
                if (this.EnhanceL7policyEnable != null) hashCode = hashCode * 59 + this.EnhanceL7policyEnable.GetHashCode();
                if (this.QuicConfig != null) hashCode = hashCode * 59 + this.QuicConfig.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectionStatus.GetHashCode();
                if (this.ProtectionReason != null) hashCode = hashCode * 59 + this.ProtectionReason.GetHashCode();
                if (this.GzipEnable != null) hashCode = hashCode * 59 + this.GzipEnable.GetHashCode();
                if (this.PortRanges != null) hashCode = hashCode * 59 + this.PortRanges.GetHashCode();
                if (this.SslEarlyDataEnable != null) hashCode = hashCode * 59 + this.SslEarlyDataEnable.GetHashCode();
                if (this.Cps != null) hashCode = hashCode * 59 + this.Cps.GetHashCode();
                if (this.Connection != null) hashCode = hashCode * 59 + this.Connection.GetHashCode();
                if (this.Nat64Enable != null) hashCode = hashCode * 59 + this.Nat64Enable.GetHashCode();
                return hashCode;
            }
        }
    }
}
