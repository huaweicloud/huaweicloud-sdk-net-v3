using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Proxy 
    {

        /// <summary>
        /// Proxy实例ID。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// Proxy实例开启状态，取值范围如下。 - open：打开。 - closed：关闭。 - frozen：已冻结。 - opening：打开中。 - closing：关闭中。 - freezing：冻结中。 - unfreezing：解冻中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Proxy读写分离地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// elb模式的虚拟IP信息。
        /// </summary>
        [JsonProperty("elb_vip", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbVip { get; set; }

        /// <summary>
        /// 弹性公网IP信息。
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public string Eip { get; set; }

        /// <summary>
        /// Proxy端口信息。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// Proxy实例状态。 - abnormal：异常。 - normal：正常。 - creating：创建中。 - deleted：已删除。
        /// </summary>
        [JsonProperty("pool_status", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolStatus { get; set; }

        /// <summary>
        /// 延时阈值（单位：KB）。
        /// </summary>
        [JsonProperty("delay_threshold_in_kilobytes", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelayThresholdInKilobytes { get; set; }

        /// <summary>
        /// Proxy实例规格的CPU数量。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// Proxy实例规格的内存数量。
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public string Mem { get; set; }

        /// <summary>
        /// Proxy节点个数。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// Proxy节点信息。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProxyNode> Nodes { get; set; }

        /// <summary>
        /// Proxy主备模式，取值范围：Ha。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Proxy {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  elbVip: ").Append(ElbVip).Append("\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  poolStatus: ").Append(PoolStatus).Append("\n");
            sb.Append("  delayThresholdInKilobytes: ").Append(DelayThresholdInKilobytes).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Proxy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Proxy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.ElbVip == input.ElbVip ||
                    (this.ElbVip != null &&
                    this.ElbVip.Equals(input.ElbVip))
                ) && 
                (
                    this.Eip == input.Eip ||
                    (this.Eip != null &&
                    this.Eip.Equals(input.Eip))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.PoolStatus == input.PoolStatus ||
                    (this.PoolStatus != null &&
                    this.PoolStatus.Equals(input.PoolStatus))
                ) && 
                (
                    this.DelayThresholdInKilobytes == input.DelayThresholdInKilobytes ||
                    (this.DelayThresholdInKilobytes != null &&
                    this.DelayThresholdInKilobytes.Equals(input.DelayThresholdInKilobytes))
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Mem == input.Mem ||
                    (this.Mem != null &&
                    this.Mem.Equals(input.Mem))
                ) && 
                (
                    this.NodeNum == input.NodeNum ||
                    (this.NodeNum != null &&
                    this.NodeNum.Equals(input.NodeNum))
                ) && 
                (
                    this.Nodes == input.Nodes ||
                    this.Nodes != null &&
                    input.Nodes != null &&
                    this.Nodes.SequenceEqual(input.Nodes)
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ElbVip != null)
                    hashCode = hashCode * 59 + this.ElbVip.GetHashCode();
                if (this.Eip != null)
                    hashCode = hashCode * 59 + this.Eip.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.PoolStatus != null)
                    hashCode = hashCode * 59 + this.PoolStatus.GetHashCode();
                if (this.DelayThresholdInKilobytes != null)
                    hashCode = hashCode * 59 + this.DelayThresholdInKilobytes.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null)
                    hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.NodeNum != null)
                    hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.Nodes != null)
                    hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
