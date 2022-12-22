using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 修改终端节点服务接口请求结构体
    /// </summary>
    public class UpdateEndpointServiceRequestBody 
    {

        /// <summary>
        /// 是否需要审批。 ● false：不需审批，创建的终端节点连接直接为accepted状态。 ● true：需审批，创建的终端节点连接需要终端节点服务所属用户审核后方可使用。 默认为true，需要审批。
        /// </summary>
        [JsonProperty("approval_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApprovalEnabled { get; set; }

        /// <summary>
        /// 终端节点服务的名称，长度不大于16，允许传入大小写字母、数字、下划线、中划线。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务开放的端口映射列表，详细内容请参见表4-22。 同一个终端节点服务下，不允许重复的端口映射。 若多个终端节点服务共用一个port_id， 则终端节点之间服务的所有端口映射的server_port和protocol的组合不能重复， 单次最多添加200个。
        /// </summary>
        [JsonProperty("ports", NullValueHandling = NullValueHandling.Ignore)]
        public List<PortList> Ports { get; set; }

        /// <summary>
        /// 标识终端节点服务后端资源的ID， 格式为通用唯一识别码（Universally UniqueIdentifier，下文简称UUID）。 取值为： ● LB类型：增强型负载均衡器内网IP对应的端口ID。 详细内容请参考《弹性负载均衡API参考》中的“查询负载均衡详情”， 详见响应消息中的“vip_port_id”字段。 ● VM类型：弹性云服务器IP地址对应的网卡ID。 详细内容请参考《弹性云服务器API参考》中的“查询云服务器网卡信息”， 详见响应消息中的“port_id”字段。 ● VIP类型：虚拟资源所在物理服务器对应的网卡ID。 说明 当后端资源为“LB类型”时，仅支持修改为同类型后端资源的“vip_port_id”。 例如，共享型负载均衡仅支持更换为共享型负载均衡，不支持更换为独享型负载均衡。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 虚拟IP的网卡ID。
        /// </summary>
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipPortId { get; set; }

        /// <summary>
        /// 描述字段，支持中英文字母、数字等字符，不支持“&lt;”或“&gt;”字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEndpointServiceRequestBody {\n");
            sb.Append("  approvalEnabled: ").Append(ApprovalEnabled).Append("\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ports: ").Append(Ports).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  vipPortId: ").Append(VipPortId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateEndpointServiceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateEndpointServiceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApprovalEnabled == input.ApprovalEnabled ||
                    (this.ApprovalEnabled != null &&
                    this.ApprovalEnabled.Equals(input.ApprovalEnabled))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Ports == input.Ports ||
                    this.Ports != null &&
                    input.Ports != null &&
                    this.Ports.SequenceEqual(input.Ports)
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.VipPortId == input.VipPortId ||
                    (this.VipPortId != null &&
                    this.VipPortId.Equals(input.VipPortId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ApprovalEnabled != null)
                    hashCode = hashCode * 59 + this.ApprovalEnabled.GetHashCode();
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.Ports != null)
                    hashCode = hashCode * 59 + this.Ports.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.VipPortId != null)
                    hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
