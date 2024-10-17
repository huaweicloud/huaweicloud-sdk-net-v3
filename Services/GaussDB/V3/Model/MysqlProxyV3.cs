using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlProxyV3 
    {

        /// <summary>
        /// Proxy实例ID。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// Proxy实例开启状态。  取值: - “ACTIVE”，表示数据库代理正常； - “FAILED”，表示数据库代理创建失败； - “DELETED”，表示数据库代理已删除； - “ABNORMAL”，表示数据库代理异常； - “ENABLING PROXY”，表示数据库代理正在开启； - “DISABLING PROXY”，表示数据库代理正在关闭； - “ADDING PROXY NODE”，表示数据库代理正在扩容； - “DELETING READ REPLICAS FROM PROXY”，表示数据库代理正在移除只读节点； - “ADDING READ REPLICAS TO PROXY”，表示数据库代理正在添加只读节点； - “CHANGING WEIGHTS”，表示数据库代理正在修改只读节点权重。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Proxy读写分离地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// Proxy端口信息。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// Proxy实例状态。  取值范围： - ACTIVE，表示数据库代理正常 - ABNORMAL，表示数据库代理异常 - FAILED，表示数据库代理创建失败 - DELETED，表示数据库代理已删除
        /// </summary>
        [JsonProperty("pool_status", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolStatus { get; set; }

        /// <summary>
        /// 延时阈值，单位：秒。
        /// </summary>
        [JsonProperty("delay_threshold_in_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelayThresholdInSeconds { get; set; }

        /// <summary>
        /// Elb模式的虚拟ip信息。
        /// </summary>
        [JsonProperty("elb_vip", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbVip { get; set; }

        /// <summary>
        /// 弹性公网IP信息。
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public string Eip { get; set; }

        /// <summary>
        /// Proxy实例规格的CPU数量。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        /// <summary>
        /// Proxy实例规格的内存数量。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public string Ram { get; set; }

        /// <summary>
        /// Proxy节点个数。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// Proxy主备模式，取值范围：Cluster。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// Proxy节点信息。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlProxyNodes> Nodes { get; set; }

        /// <summary>
        /// Proxy规格信息。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// Proxy实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Proxy事务拆分开关状态【ON/OFF】。
        /// </summary>
        [JsonProperty("transaction_split", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionSplit { get; set; }

        /// <summary>
        /// 连接池类型。  取值范围: - CLOSED: 关闭连接池。 - SESSION: 开启会话级连接池。
        /// </summary>
        [JsonProperty("connection_pool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionPoolType { get; set; }

        /// <summary>
        /// 数据库代理版本是否支持会话级连接池。  取值范围: - true: 支持。 - false: 不支持。
        /// </summary>
        [JsonProperty("switch_connection_pool_type_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchConnectionPoolTypeEnabled { get; set; }

        /// <summary>
        /// 数据库代理路由模式，默认为权重负载模式。  取值范围: - 0，表示权重负载模式; - 1，表示负载均衡模式（数据库主节点不接受读请求）； - 2，表示负载均衡模式（数据库主节点接受读请求）。
        /// </summary>
        [JsonProperty("route_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteMode { get; set; }

        /// <summary>
        /// 数据库代理版本是否支持负载均衡模式。  取值范围: - true 支持; - false 不支持。
        /// </summary>
        [JsonProperty("balance_route_mode_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BalanceRouteModeEnabled { get; set; }

        /// <summary>
        /// 一致性模式。默认值为空，此时以会话一致性参数session_consistence为准。 - session: 会话一致性。 - global: 全局一致性。 - eventual: 最终一致性。
        /// </summary>
        [JsonProperty("consistence_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsistenceMode { get; set; }

        /// <summary>
        /// 数据库代理所属的子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// SSL数据加密开关设置。  取值范围： - true: 开启SSL数据加密。 - false: 关闭SSL数据加密。
        /// </summary>
        [JsonProperty("ssl_option", NullValueHandling = NullValueHandling.Ignore)]
        public string SslOption { get; set; }

        /// <summary>
        /// 新增节点是否自动加入该Proxy。  取值范围： - ON：自动加入。 - OFF：不自动加入。
        /// </summary>
        [JsonProperty("new_node_auto_add_status", NullValueHandling = NullValueHandling.Ignore)]
        public string NewNodeAutoAddStatus { get; set; }

        /// <summary>
        /// 新增节点的读权重。
        /// </summary>
        [JsonProperty("new_node_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewNodeWeight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlProxyV3 {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  poolStatus: ").Append(PoolStatus).Append("\n");
            sb.Append("  delayThresholdInSeconds: ").Append(DelayThresholdInSeconds).Append("\n");
            sb.Append("  elbVip: ").Append(ElbVip).Append("\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  transactionSplit: ").Append(TransactionSplit).Append("\n");
            sb.Append("  connectionPoolType: ").Append(ConnectionPoolType).Append("\n");
            sb.Append("  switchConnectionPoolTypeEnabled: ").Append(SwitchConnectionPoolTypeEnabled).Append("\n");
            sb.Append("  routeMode: ").Append(RouteMode).Append("\n");
            sb.Append("  balanceRouteModeEnabled: ").Append(BalanceRouteModeEnabled).Append("\n");
            sb.Append("  consistenceMode: ").Append(ConsistenceMode).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  sslOption: ").Append(SslOption).Append("\n");
            sb.Append("  newNodeAutoAddStatus: ").Append(NewNodeAutoAddStatus).Append("\n");
            sb.Append("  newNodeWeight: ").Append(NewNodeWeight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlProxyV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlProxyV3 input)
        {
            if (input == null) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.PoolStatus != input.PoolStatus || (this.PoolStatus != null && !this.PoolStatus.Equals(input.PoolStatus))) return false;
            if (this.DelayThresholdInSeconds != input.DelayThresholdInSeconds || (this.DelayThresholdInSeconds != null && !this.DelayThresholdInSeconds.Equals(input.DelayThresholdInSeconds))) return false;
            if (this.ElbVip != input.ElbVip || (this.ElbVip != null && !this.ElbVip.Equals(input.ElbVip))) return false;
            if (this.Eip != input.Eip || (this.Eip != null && !this.Eip.Equals(input.Eip))) return false;
            if (this.Vcpus != input.Vcpus || (this.Vcpus != null && !this.Vcpus.Equals(input.Vcpus))) return false;
            if (this.Ram != input.Ram || (this.Ram != null && !this.Ram.Equals(input.Ram))) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.TransactionSplit != input.TransactionSplit || (this.TransactionSplit != null && !this.TransactionSplit.Equals(input.TransactionSplit))) return false;
            if (this.ConnectionPoolType != input.ConnectionPoolType || (this.ConnectionPoolType != null && !this.ConnectionPoolType.Equals(input.ConnectionPoolType))) return false;
            if (this.SwitchConnectionPoolTypeEnabled != input.SwitchConnectionPoolTypeEnabled || (this.SwitchConnectionPoolTypeEnabled != null && !this.SwitchConnectionPoolTypeEnabled.Equals(input.SwitchConnectionPoolTypeEnabled))) return false;
            if (this.RouteMode != input.RouteMode || (this.RouteMode != null && !this.RouteMode.Equals(input.RouteMode))) return false;
            if (this.BalanceRouteModeEnabled != input.BalanceRouteModeEnabled || (this.BalanceRouteModeEnabled != null && !this.BalanceRouteModeEnabled.Equals(input.BalanceRouteModeEnabled))) return false;
            if (this.ConsistenceMode != input.ConsistenceMode || (this.ConsistenceMode != null && !this.ConsistenceMode.Equals(input.ConsistenceMode))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SslOption != input.SslOption || (this.SslOption != null && !this.SslOption.Equals(input.SslOption))) return false;
            if (this.NewNodeAutoAddStatus != input.NewNodeAutoAddStatus || (this.NewNodeAutoAddStatus != null && !this.NewNodeAutoAddStatus.Equals(input.NewNodeAutoAddStatus))) return false;
            if (this.NewNodeWeight != input.NewNodeWeight || (this.NewNodeWeight != null && !this.NewNodeWeight.Equals(input.NewNodeWeight))) return false;

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
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.PoolStatus != null) hashCode = hashCode * 59 + this.PoolStatus.GetHashCode();
                if (this.DelayThresholdInSeconds != null) hashCode = hashCode * 59 + this.DelayThresholdInSeconds.GetHashCode();
                if (this.ElbVip != null) hashCode = hashCode * 59 + this.ElbVip.GetHashCode();
                if (this.Eip != null) hashCode = hashCode * 59 + this.Eip.GetHashCode();
                if (this.Vcpus != null) hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null) hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TransactionSplit != null) hashCode = hashCode * 59 + this.TransactionSplit.GetHashCode();
                if (this.ConnectionPoolType != null) hashCode = hashCode * 59 + this.ConnectionPoolType.GetHashCode();
                if (this.SwitchConnectionPoolTypeEnabled != null) hashCode = hashCode * 59 + this.SwitchConnectionPoolTypeEnabled.GetHashCode();
                if (this.RouteMode != null) hashCode = hashCode * 59 + this.RouteMode.GetHashCode();
                if (this.BalanceRouteModeEnabled != null) hashCode = hashCode * 59 + this.BalanceRouteModeEnabled.GetHashCode();
                if (this.ConsistenceMode != null) hashCode = hashCode * 59 + this.ConsistenceMode.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.SslOption != null) hashCode = hashCode * 59 + this.SslOption.GetHashCode();
                if (this.NewNodeAutoAddStatus != null) hashCode = hashCode * 59 + this.NewNodeAutoAddStatus.GetHashCode();
                if (this.NewNodeWeight != null) hashCode = hashCode * 59 + this.NewNodeWeight.GetHashCode();
                return hashCode;
            }
        }
    }
}
