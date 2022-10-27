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
    /// Request Object
    /// </summary>
    public class ListListenersRequest 
    {

        /// <summary>
        /// 每页返回的个数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 上一页最后一条记录的ID。  使用说明： - 必须与limit一起使用。 - 不指定时表示查询第一页。 - 该字段不允许为空或无效的ID。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 是否反向查询。  取值： - true：查询上一页。 - false：查询下一页，默认。  使用说明： - 必须与limit一起使用。 - 当page_reverse&#x3D;true时，若要查询上一页，marker取值为当前页返回值的previous_marker。
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 监听器的前端监听端口。  支持多值查询，查询条件格式：*protocol_port&#x3D;xxx&amp;protocol_port&#x3D;xxx*。
        /// </summary>
        [SDKProperty("protocol_port", IsQuery = true)]
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProtocolPort { get; set; }

        /// <summary>
        /// 监听器的监听协议。  [取值：TCP、UDP、HTTP、HTTPS、TERMINATED_HTTPS、QUIC。  说明：TERMINATED_HTTPS为共享型LB上的监听器独有的协议。 ](tag:hws,hws_hk,ocb,ctc,hcs,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt)  [取值：TCP、UDP、HTTP、HTTPS。](tag:hws_eu,hcso_dt)  支持多值查询，查询条件格式：*protocol&#x3D;xxx&amp;protocol&#x3D;xxx*。
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Protocol { get; set; }

        /// <summary>
        /// 监听器的描述信息。  支持多值查询，查询条件格式：*description&#x3D;xxx&amp;description&#x3D;xxx*。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Description { get; set; }

        /// <summary>
        /// 监听器的服务器证书ID。  支持多值查询，查询条件格式： *default_tls_container_ref&#x3D;xxx&amp;default_tls_container_ref&#x3D;xxx*。
        /// </summary>
        [SDKProperty("default_tls_container_ref", IsQuery = true)]
        [JsonProperty("default_tls_container_ref", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DefaultTlsContainerRef { get; set; }

        /// <summary>
        /// 监听器的CA证书ID。  支持多值查询，查询条件格式： *client_ca_tls_container_ref&#x3D;xxx&amp;client_ca_tls_container_ref&#x3D;xxx*。
        /// </summary>
        [SDKProperty("client_ca_tls_container_ref", IsQuery = true)]
        [JsonProperty("client_ca_tls_container_ref", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClientCaTlsContainerRef { get; set; }

        /// <summary>
        /// 监听器的管理状态，只能设置为true。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// ​监听器的最大连接数。  取值：-1表示不限制连接数。  支持多值查询，查询条件格式：*connection_limit&#x3D;xxx&amp;connection_limit&#x3D;xxx*。  不支持该字段，请勿使用。
        /// </summary>
        [SDKProperty("connection_limit", IsQuery = true)]
        [JsonProperty("connection_limit", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ConnectionLimit { get; set; }

        /// <summary>
        /// 监听器的默认后端云服务器组ID。当请求没有匹配的转发策略时，转发到默认后端云服务器上处理。  支持多值查询，查询条件格式：*default_pool_id&#x3D;xxx&amp;default_pool_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("default_pool_id", IsQuery = true)]
        [JsonProperty("default_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DefaultPoolId { get; set; }

        /// <summary>
        /// 监听器ID。  支持多值查询，查询条件格式：*id&#x3D;xxx&amp;id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 监听器名称。  支持多值查询，查询条件格式：*name&#x3D;xxx&amp;name&#x3D;xxx*。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 客户端与LB之间的HTTPS请求的HTTP2功能的开启状态。 开启后，可提升客户端与LB间的访问性能，但LB与后端服务器间仍采用HTTP1.X协议。  使用说明： - 仅HTTPS协议监听器有效。 - QUIC监听器不能设置该字段，固定返回为true。 - 其他协议的监听器可设置该字段但无效，无论取值如何都不影响监听器正常运行。
        /// </summary>
        [SDKProperty("http2_enable", IsQuery = true)]
        [JsonProperty("http2_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Http2Enable { get; set; }

        /// <summary>
        /// 监听器所属的负载均衡器ID。  支持多值查询，查询条件格式：*loadbalancer_id&#x3D;xxx&amp;loadbalancer_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("loadbalancer_id", IsQuery = true)]
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerId { get; set; }

        /// <summary>
        /// 监听器使用的安全策略。  支持多值查询，查询条件格式：*tls_ciphers_policy&#x3D;xxx&amp;tls_ciphers_policy&#x3D;xxx*。
        /// </summary>
        [SDKProperty("tls_ciphers_policy", IsQuery = true)]
        [JsonProperty("tls_ciphers_policy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TlsCiphersPolicy { get; set; }

        /// <summary>
        /// 后端云服务器的IP地址。仅用于查询条件，不作为响应参数字段。  支持多值查询，查询条件格式：*member_address&#x3D;xxx&amp;member_address&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_address", IsQuery = true)]
        [JsonProperty("member_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberAddress { get; set; }

        /// <summary>
        /// 后端云服务器对应的弹性云服务器的ID。仅用于查询条件，不作为响应参数字段。  支持多值查询，查询条件格式：*member_device_id&#x3D;xxx&amp;member_device_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_device_id", IsQuery = true)]
        [JsonProperty("member_device_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberDeviceId { get; set; }

        /// <summary>
        /// 企业项目ID。不传时查询default企业项目\&quot;0\&quot;下的资源，鉴权按照default企业项目鉴权； 如果传值，则传已存在的企业项目ID或all_granted_eps（表示查询所有企业项目）进行查询。  支持多值查询，查询条件格式：*enterprise_project_id&#x3D;xxx&amp;enterprise_project_id&#x3D;xxx*。  [不支持该字段，请勿使用。](tag:dt,dt_test,hcso_dt)
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 是否开启后端服务器的重试。  取值：true 开启重试，false 不开启重试。
        /// </summary>
        [SDKProperty("enable_member_retry", IsQuery = true)]
        [JsonProperty("enable_member_retry", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMemberRetry { get; set; }

        /// <summary>
        /// 等待后端服务器响应超时时间。请求转发后端服务器后，在等待超时member_timeout时长没有响应，负载均衡将终止等待，并返回 HTTP504错误码。  取值：1-300s。  支持多值查询，查询条件格式：*member_timeout&#x3D;xxx&amp;member_timeout&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_timeout", IsQuery = true)]
        [JsonProperty("member_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> MemberTimeout { get; set; }

        /// <summary>
        /// 等待客户端请求超时时间，包括两种情况： - 读取整个客户端请求头的超时时长：如果客户端未在超时时长内发送完整个请求头，则请求将被中断 - 两个连续body体的数据包到达LB的时间间隔，超出client_timeout将会断开连接。  取值：1-300s。  支持多值查询，查询条件格式：*client_timeout&#x3D;xxx&amp;client_timeout&#x3D;xxx*。
        /// </summary>
        [SDKProperty("client_timeout", IsQuery = true)]
        [JsonProperty("client_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ClientTimeout { get; set; }

        /// <summary>
        /// 客户端连接空闲超时时间。在超过keepalive_timeout时长一直没有请求， 负载均衡会暂时中断当前连接，直到一下次请求时重新建立新的连接。  取值： - TCP监听器：10-4000s。 - HTTP/HTTPS/TERMINATED_HTTPS监听器：0-4000s。 - UDP监听器不支持此字段。  支持多值查询，查询条件格式：*keepalive_timeout&#x3D;xxx&amp;keepalive_timeout&#x3D;xxx*。
        /// </summary>
        [SDKProperty("keepalive_timeout", IsQuery = true)]
        [JsonProperty("keepalive_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> KeepaliveTimeout { get; set; }

        /// <summary>
        /// 是否透传客户端IP地址。开启后客户端IP地址将透传到后端服务器。  [仅作用于共享型LB的TCP/UDP监听器。取值：true开启，false不开启。 ](tag:hws,hws_hk,ocb,ctc,g42,tm,cmcc,hk_g42,hws_ocb,fcs,dt,hk_tm)
        /// </summary>
        [SDKProperty("transparent_client_ip_enable", IsQuery = true)]
        [JsonProperty("transparent_client_ip_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TransparentClientIpEnable { get; set; }

        /// <summary>
        /// 是否开启高级转发策略功能。开启高级转发策略后，支持更灵活的转发策略和转发规则设置。  取值：true开启，false不开启。
        /// </summary>
        [SDKProperty("enhance_l7policy_enable", IsQuery = true)]
        [JsonProperty("enhance_l7policy_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnhanceL7policyEnable { get; set; }

        /// <summary>
        /// 后端云服务器ID。仅用于查询条件，不作为响应参数字段。  支持多值查询，查询条件格式：*member_instance_id&#x3D;xxx&amp;member_instance_id&#x3D;xxx*。
        /// </summary>
        [SDKProperty("member_instance_id", IsQuery = true)]
        [JsonProperty("member_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MemberInstanceId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListListenersRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  defaultTlsContainerRef: ").Append(DefaultTlsContainerRef).Append("\n");
            sb.Append("  clientCaTlsContainerRef: ").Append(ClientCaTlsContainerRef).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  connectionLimit: ").Append(ConnectionLimit).Append("\n");
            sb.Append("  defaultPoolId: ").Append(DefaultPoolId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  http2Enable: ").Append(Http2Enable).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  tlsCiphersPolicy: ").Append(TlsCiphersPolicy).Append("\n");
            sb.Append("  memberAddress: ").Append(MemberAddress).Append("\n");
            sb.Append("  memberDeviceId: ").Append(MemberDeviceId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enableMemberRetry: ").Append(EnableMemberRetry).Append("\n");
            sb.Append("  memberTimeout: ").Append(MemberTimeout).Append("\n");
            sb.Append("  clientTimeout: ").Append(ClientTimeout).Append("\n");
            sb.Append("  keepaliveTimeout: ").Append(KeepaliveTimeout).Append("\n");
            sb.Append("  transparentClientIpEnable: ").Append(TransparentClientIpEnable).Append("\n");
            sb.Append("  enhanceL7policyEnable: ").Append(EnhanceL7policyEnable).Append("\n");
            sb.Append("  memberInstanceId: ").Append(MemberInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListListenersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListListenersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.PageReverse == input.PageReverse ||
                    (this.PageReverse != null &&
                    this.PageReverse.Equals(input.PageReverse))
                ) && 
                (
                    this.ProtocolPort == input.ProtocolPort ||
                    this.ProtocolPort != null &&
                    input.ProtocolPort != null &&
                    this.ProtocolPort.SequenceEqual(input.ProtocolPort)
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    this.Protocol != null &&
                    input.Protocol != null &&
                    this.Protocol.SequenceEqual(input.Protocol)
                ) && 
                (
                    this.Description == input.Description ||
                    this.Description != null &&
                    input.Description != null &&
                    this.Description.SequenceEqual(input.Description)
                ) && 
                (
                    this.DefaultTlsContainerRef == input.DefaultTlsContainerRef ||
                    this.DefaultTlsContainerRef != null &&
                    input.DefaultTlsContainerRef != null &&
                    this.DefaultTlsContainerRef.SequenceEqual(input.DefaultTlsContainerRef)
                ) && 
                (
                    this.ClientCaTlsContainerRef == input.ClientCaTlsContainerRef ||
                    this.ClientCaTlsContainerRef != null &&
                    input.ClientCaTlsContainerRef != null &&
                    this.ClientCaTlsContainerRef.SequenceEqual(input.ClientCaTlsContainerRef)
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.ConnectionLimit == input.ConnectionLimit ||
                    this.ConnectionLimit != null &&
                    input.ConnectionLimit != null &&
                    this.ConnectionLimit.SequenceEqual(input.ConnectionLimit)
                ) && 
                (
                    this.DefaultPoolId == input.DefaultPoolId ||
                    this.DefaultPoolId != null &&
                    input.DefaultPoolId != null &&
                    this.DefaultPoolId.SequenceEqual(input.DefaultPoolId)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id != null &&
                    input.Id != null &&
                    this.Id.SequenceEqual(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name != null &&
                    input.Name != null &&
                    this.Name.SequenceEqual(input.Name)
                ) && 
                (
                    this.Http2Enable == input.Http2Enable ||
                    (this.Http2Enable != null &&
                    this.Http2Enable.Equals(input.Http2Enable))
                ) && 
                (
                    this.LoadbalancerId == input.LoadbalancerId ||
                    this.LoadbalancerId != null &&
                    input.LoadbalancerId != null &&
                    this.LoadbalancerId.SequenceEqual(input.LoadbalancerId)
                ) && 
                (
                    this.TlsCiphersPolicy == input.TlsCiphersPolicy ||
                    this.TlsCiphersPolicy != null &&
                    input.TlsCiphersPolicy != null &&
                    this.TlsCiphersPolicy.SequenceEqual(input.TlsCiphersPolicy)
                ) && 
                (
                    this.MemberAddress == input.MemberAddress ||
                    this.MemberAddress != null &&
                    input.MemberAddress != null &&
                    this.MemberAddress.SequenceEqual(input.MemberAddress)
                ) && 
                (
                    this.MemberDeviceId == input.MemberDeviceId ||
                    this.MemberDeviceId != null &&
                    input.MemberDeviceId != null &&
                    this.MemberDeviceId.SequenceEqual(input.MemberDeviceId)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    this.EnterpriseProjectId != null &&
                    input.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId)
                ) && 
                (
                    this.EnableMemberRetry == input.EnableMemberRetry ||
                    (this.EnableMemberRetry != null &&
                    this.EnableMemberRetry.Equals(input.EnableMemberRetry))
                ) && 
                (
                    this.MemberTimeout == input.MemberTimeout ||
                    this.MemberTimeout != null &&
                    input.MemberTimeout != null &&
                    this.MemberTimeout.SequenceEqual(input.MemberTimeout)
                ) && 
                (
                    this.ClientTimeout == input.ClientTimeout ||
                    this.ClientTimeout != null &&
                    input.ClientTimeout != null &&
                    this.ClientTimeout.SequenceEqual(input.ClientTimeout)
                ) && 
                (
                    this.KeepaliveTimeout == input.KeepaliveTimeout ||
                    this.KeepaliveTimeout != null &&
                    input.KeepaliveTimeout != null &&
                    this.KeepaliveTimeout.SequenceEqual(input.KeepaliveTimeout)
                ) && 
                (
                    this.TransparentClientIpEnable == input.TransparentClientIpEnable ||
                    (this.TransparentClientIpEnable != null &&
                    this.TransparentClientIpEnable.Equals(input.TransparentClientIpEnable))
                ) && 
                (
                    this.EnhanceL7policyEnable == input.EnhanceL7policyEnable ||
                    (this.EnhanceL7policyEnable != null &&
                    this.EnhanceL7policyEnable.Equals(input.EnhanceL7policyEnable))
                ) && 
                (
                    this.MemberInstanceId == input.MemberInstanceId ||
                    this.MemberInstanceId != null &&
                    input.MemberInstanceId != null &&
                    this.MemberInstanceId.SequenceEqual(input.MemberInstanceId)
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null)
                    hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                if (this.ProtocolPort != null)
                    hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DefaultTlsContainerRef != null)
                    hashCode = hashCode * 59 + this.DefaultTlsContainerRef.GetHashCode();
                if (this.ClientCaTlsContainerRef != null)
                    hashCode = hashCode * 59 + this.ClientCaTlsContainerRef.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.ConnectionLimit != null)
                    hashCode = hashCode * 59 + this.ConnectionLimit.GetHashCode();
                if (this.DefaultPoolId != null)
                    hashCode = hashCode * 59 + this.DefaultPoolId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Http2Enable != null)
                    hashCode = hashCode * 59 + this.Http2Enable.GetHashCode();
                if (this.LoadbalancerId != null)
                    hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.TlsCiphersPolicy != null)
                    hashCode = hashCode * 59 + this.TlsCiphersPolicy.GetHashCode();
                if (this.MemberAddress != null)
                    hashCode = hashCode * 59 + this.MemberAddress.GetHashCode();
                if (this.MemberDeviceId != null)
                    hashCode = hashCode * 59 + this.MemberDeviceId.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnableMemberRetry != null)
                    hashCode = hashCode * 59 + this.EnableMemberRetry.GetHashCode();
                if (this.MemberTimeout != null)
                    hashCode = hashCode * 59 + this.MemberTimeout.GetHashCode();
                if (this.ClientTimeout != null)
                    hashCode = hashCode * 59 + this.ClientTimeout.GetHashCode();
                if (this.KeepaliveTimeout != null)
                    hashCode = hashCode * 59 + this.KeepaliveTimeout.GetHashCode();
                if (this.TransparentClientIpEnable != null)
                    hashCode = hashCode * 59 + this.TransparentClientIpEnable.GetHashCode();
                if (this.EnhanceL7policyEnable != null)
                    hashCode = hashCode * 59 + this.EnhanceL7policyEnable.GetHashCode();
                if (this.MemberInstanceId != null)
                    hashCode = hashCode * 59 + this.MemberInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
