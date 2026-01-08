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
    /// 监听器复制到实例相关配置参数。
    /// </summary>
    public class CloneListenerOption 
    {

        /// <summary>
        /// **参数解释**：新监听器的名称。 **约束限制**：不涉及 **取值范围**：[0-255]个字符，传入空字符串则取默认值。 **默认取值**：原监听器名称+ “-copy”。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：新监听器所在的负载均衡器ID（UUID）。 **约束限制**： - 不支持复制到网关型负载均衡器。 - 目的负载均衡器类型需要支持源监听器协议。源监听器协议为HTTP、HTTPS，目的负载均衡器需要为应用型负载均衡器；源监听器协议为TCP、UDP、TLS，目的负载均衡器需要为网络型负载均衡器。 - 只支持共享型负载均衡器复制到共享型负载均衡器，独享型负载均衡器复制到独享型负载均衡器。 - 源监听器的负载均衡器启用IP类型后端转发，目的负载均衡器也需要启动IP类型后端转发功能。 - 源监听器协议为TLS，目的负载均衡器需要支持创建TLS协议监听器。 **取值范围**：标准的UUID格式，长度为36个字符。 **默认取值**：不涉及
        /// </summary>
        [JsonProperty("loadbalancer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LoadbalancerId { get; set; }

        /// <summary>
        /// **参数解释**：新监听器的监听端口。 **约束限制**： - 不能与目的负载均衡器下已有监听器监听端口重复。 - 0表示开启监听端口范围的能力，此时port_ranges为必填字段。 - 共享型负载均衡器上的HTTP和TERMINATED_HTTPS监听器不支持设置21端口。 **取值范围**：0-65535 **默认取值**：不涉及
        /// </summary>
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// **参数解释**：端口监听范围（闭区间)，最多指定10个端口组，每个组范围不可有重叠部分。 **约束限制**： - 仅当protocol_port为0或未传入protocol_port时可以传入该字段。 - 仅TCP, UDP，TLS监听器支持该字段。 - 不能与目的负载均衡器下已有端口冲突
        /// </summary>
        [JsonProperty("port_ranges", NullValueHandling = NullValueHandling.Ignore)]
        public List<PortRange> PortRanges { get; set; }

        /// <summary>
        /// **参数解释**：新监听器是否复用或复制源监听器的后端服务器组和后端服务器的标识。 - 复用：目的负载均衡器将会直接使用源负载均衡器的后端服务器组。 - 复制：系统将会根据原有配置创建新的后端服务器组，然后将其关联到目的负载均衡器使用。 **约束限制**： - 配置为true时，需要开启后端服务器组多挂实例功能。 - 只在独享型场景复制、同VPC场景可配。 **取值范围**： - true：复用源监听器的后端服务器组。 - false：复制源监听器的后端服务器组。 **默认取值**：false
        /// </summary>
        [JsonProperty("reuse_pool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReusePool { get; set; }

        /// <summary>
        /// **参数解释**：源监听器下后端服务器子网信息和新监听器下后端服务器子网信息一一对应关系。 **约束限制**： - 将监听器复制到不同VPC下的负载均衡器时，该字段必填。复制到同一个VPC下的负载均衡器时不填。 - 若源监听器所在负载均衡器已开启ip_target_enable（该功能默认不开启），则不允许跨VPC复制，即该字段不允许填。 - 每一组subnet_cidr_id都需要是新监听器下后端服务器的VPC子网ID，每一组dst_subnet_cidr_id都需要为源监听器下后端服务器的的VPC子网ID，不允许少填多填、或重复对应关系。 - 每一组的subnet_cidr_id和dst_subnet_cidr_id的两个子网必须存在且网段相同。
        /// </summary>
        [JsonProperty("subnet_mapping_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubnetMappingList> SubnetMappingList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneListenerOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  loadbalancerId: ").Append(LoadbalancerId).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  portRanges: ").Append(PortRanges).Append("\n");
            sb.Append("  reusePool: ").Append(ReusePool).Append("\n");
            sb.Append("  subnetMappingList: ").Append(SubnetMappingList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloneListenerOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloneListenerOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.LoadbalancerId != input.LoadbalancerId || (this.LoadbalancerId != null && !this.LoadbalancerId.Equals(input.LoadbalancerId))) return false;
            if (this.ProtocolPort != input.ProtocolPort || (this.ProtocolPort != null && !this.ProtocolPort.Equals(input.ProtocolPort))) return false;
            if (this.PortRanges != input.PortRanges || (this.PortRanges != null && input.PortRanges != null && !this.PortRanges.SequenceEqual(input.PortRanges))) return false;
            if (this.ReusePool != input.ReusePool || (this.ReusePool != null && !this.ReusePool.Equals(input.ReusePool))) return false;
            if (this.SubnetMappingList != input.SubnetMappingList || (this.SubnetMappingList != null && input.SubnetMappingList != null && !this.SubnetMappingList.SequenceEqual(input.SubnetMappingList))) return false;

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
                if (this.LoadbalancerId != null) hashCode = hashCode * 59 + this.LoadbalancerId.GetHashCode();
                if (this.ProtocolPort != null) hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.PortRanges != null) hashCode = hashCode * 59 + this.PortRanges.GetHashCode();
                if (this.ReusePool != null) hashCode = hashCode * 59 + this.ReusePool.GetHashCode();
                if (this.SubnetMappingList != null) hashCode = hashCode * 59 + this.SubnetMappingList.GetHashCode();
                return hashCode;
            }
        }
    }
}
