using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 实例节点信息。
    /// </summary>
    public class NodeResult 
    {

        /// <summary>
        /// 节点ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 节点名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 节点类型，取值为“master”、“slave”，分别对应于主节点、备节点。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 节点状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 节点内网IP。分布式实例类型下该参数仅针对CN节点有效，主备版实例类型下该参数对所有节点有效，且在弹性云服务器创建成功后参数值存在。
        /// </summary>
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 绑定的外网IP。分布式实例类型下该参数仅针对CN节点有效，主备版实例类型下该参数对所有节点有效，且在弹性云服务器创建成功并绑定弹性公网IP后参数值存在。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 节点上组件信息（例组件ID:分布式ID），多个组件信息用;隔开。
        /// </summary>
        [JsonProperty("component_names", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  componentNames: ").Append(ComponentNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.PrivateIp == input.PrivateIp ||
                    (this.PrivateIp != null &&
                    this.PrivateIp.Equals(input.PrivateIp))
                ) && 
                (
                    this.PublicIp == input.PublicIp ||
                    (this.PublicIp != null &&
                    this.PublicIp.Equals(input.PublicIp))
                ) && 
                (
                    this.ComponentNames == input.ComponentNames ||
                    (this.ComponentNames != null &&
                    this.ComponentNames.Equals(input.ComponentNames))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.PrivateIp != null)
                    hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.PublicIp != null)
                    hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.ComponentNames != null)
                    hashCode = hashCode * 59 + this.ComponentNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
