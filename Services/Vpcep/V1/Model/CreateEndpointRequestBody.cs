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
    /// 创建终端节接口请求结构体
    /// </summary>
    public class CreateEndpointRequestBody 
    {

        /// <summary>
        /// 创建Interface类型Client必选。 需要指定vpc_id对应VPC下已创建的网络（network）的ID，UUID格式。 详细内容请参考《虚拟私有云API参考》中的“查询子网”，详见响应消息中的“id”字段。 创建连接Interface类型终端节点服务的终端节点时，此参数必选。 说明:  - VPC的子网网段不能与198.19.128.0/17重叠  - VPC路由表中自定义路由的目的地址不能与198.19.128.0/17重叠
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 终端节点服务的ID。 可以通过查询终端节点服务概 要获取要连接的终端节点服务 ID。
        /// </summary>
        [JsonProperty("endpoint_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointServiceId { get; set; }

        /// <summary>
        /// 终端节点所在的VPC的ID。 详细内容请参考《虚拟私有云API参考》中的“查询VPC”， 详见响应消息中的“id”字段。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 是否创建域名。  - true：创建域名  - false：不创建域名 默认值为false。 说明 当创建连接gateway类型终端节点服务的终端节点时， “enable_dns”设置为true或者false，均不创建域名。
        /// </summary>
        [JsonProperty("enable_dns", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDns { get; set; }

        /// <summary>
        /// 标签列表，没有标签默认为空数组。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagList> Tags { get; set; }

        /// <summary>
        /// 路由表ID列表。详细内容请参考《虚拟私有云API参考》中的“查询VPC路由”， 详见响应消息中的“id”字段。 创建连接gateway类型终端节点服务的终节点时，此参数必选。 说明 不设置此参数时，选择默认路由表。
        /// </summary>
        [JsonProperty("routetables", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Routetables { get; set; }

        /// <summary>
        /// 访问所连接的终端节点服务的IP。 创建终端节点时，可以指定访问所连接的终端节点服务的IP，目前只支持IPv4类型 。 创建连接Interface类型终端节点服务的终端节点时，此参数必选。
        /// </summary>
        [JsonProperty("port_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PortIp { get; set; }

        /// <summary>
        /// 添加用于控制访问终端节点的白名单。 创建终端节点时，支持访问控制，使用此参数可以添加IPv4或CIDR，默认空列表。 仅当创建连接Interface类型终端节点服务的终端节点时，支持设置此参数。
        /// </summary>
        [JsonProperty("whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Whitelist { get; set; }

        /// <summary>
        /// 是否开启网络ACL隔离。
        /// </summary>
        [JsonProperty("enable_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWhitelist { get; set; }

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
            sb.Append("class CreateEndpointRequestBody {\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  endpointServiceId: ").Append(EndpointServiceId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  enableDns: ").Append(EnableDns).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  routetables: ").Append(Routetables).Append("\n");
            sb.Append("  portIp: ").Append(PortIp).Append("\n");
            sb.Append("  whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("  enableWhitelist: ").Append(EnableWhitelist).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEndpointRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateEndpointRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubnetId == input.SubnetId ||
                    (this.SubnetId != null &&
                    this.SubnetId.Equals(input.SubnetId))
                ) && 
                (
                    this.EndpointServiceId == input.EndpointServiceId ||
                    (this.EndpointServiceId != null &&
                    this.EndpointServiceId.Equals(input.EndpointServiceId))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.EnableDns == input.EnableDns ||
                    (this.EnableDns != null &&
                    this.EnableDns.Equals(input.EnableDns))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Routetables == input.Routetables ||
                    this.Routetables != null &&
                    input.Routetables != null &&
                    this.Routetables.SequenceEqual(input.Routetables)
                ) && 
                (
                    this.PortIp == input.PortIp ||
                    (this.PortIp != null &&
                    this.PortIp.Equals(input.PortIp))
                ) && 
                (
                    this.Whitelist == input.Whitelist ||
                    this.Whitelist != null &&
                    input.Whitelist != null &&
                    this.Whitelist.SequenceEqual(input.Whitelist)
                ) && 
                (
                    this.EnableWhitelist == input.EnableWhitelist ||
                    (this.EnableWhitelist != null &&
                    this.EnableWhitelist.Equals(input.EnableWhitelist))
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
                if (this.SubnetId != null)
                    hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.EndpointServiceId != null)
                    hashCode = hashCode * 59 + this.EndpointServiceId.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.EnableDns != null)
                    hashCode = hashCode * 59 + this.EnableDns.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Routetables != null)
                    hashCode = hashCode * 59 + this.Routetables.GetHashCode();
                if (this.PortIp != null)
                    hashCode = hashCode * 59 + this.PortIp.GetHashCode();
                if (this.Whitelist != null)
                    hashCode = hashCode * 59 + this.Whitelist.GetHashCode();
                if (this.EnableWhitelist != null)
                    hashCode = hashCode * 59 + this.EnableWhitelist.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
