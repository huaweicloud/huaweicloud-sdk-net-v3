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
    /// 数据库代理信息。
    /// </summary>
    public class ProxyInfo 
    {
        /// <summary>
        /// 数据库代理秒级监控状态。
        /// </summary>
        /// <value>数据库代理秒级监控状态。</value>
        [JsonConverter(typeof(EnumClassConverter<SecondsLevelMonitorFunStatusEnum>))]
        public class SecondsLevelMonitorFunStatusEnum
        {
            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly SecondsLevelMonitorFunStatusEnum OFF = new SecondsLevelMonitorFunStatusEnum("off");

            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly SecondsLevelMonitorFunStatusEnum ON = new SecondsLevelMonitorFunStatusEnum("on");

            private static readonly Dictionary<string, SecondsLevelMonitorFunStatusEnum> StaticFields =
            new Dictionary<string, SecondsLevelMonitorFunStatusEnum>()
            {
                { "off", OFF },
                { "on", ON },
            };

            private string _value;

            public SecondsLevelMonitorFunStatusEnum()
            {

            }

            public SecondsLevelMonitorFunStatusEnum(string value)
            {
                _value = value;
            }

            public static SecondsLevelMonitorFunStatusEnum FromValue(string value)
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

                if (this.Equals(obj as SecondsLevelMonitorFunStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SecondsLevelMonitorFunStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SecondsLevelMonitorFunStatusEnum a, SecondsLevelMonitorFunStatusEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(SecondsLevelMonitorFunStatusEnum a, SecondsLevelMonitorFunStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库代理实例ID。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 数据库代理状态。  取值: NORMAL：表示数据库代理正常。 ENABLING：表示数据库代理正在开启。 DISABLING：表示数据库代理正在关闭。 CHANGING_NODE_NUM：表示数据库代理正在调整节点数量。 SCALING: 表示数据库代理正在规格变更。 UPGRADING: 表示数据库代理正在升级内核版本。 IPMODIFYING: 表示数据库代理正在修改读写分离地址。 RESTARTING: 表示数据库代理正在重启进程。 TRANSACTION_SPLITTING: 表示数据库代理正在变更事务拆分功能状态。 CONNECTION_POOL_SWITCH_OPERATING: 表示数据库代理正在变更会话连接池类型。 PORT_MODIFYING: 表示数据库代理正在修改端口。 PROXY_SSL_SWITCHING: 表示数据库代理正在变更SSL状态。 ALT_SWITCH_OPERATING: 表示数据库代理正在变更ALT状态。 CHANGING_RESOURCES: 表示数据库代理正在进行资源变更。 NORMAL: 表示数据库代理正常。 ABNORMAL: 表示数据库代理异常。 FAILED: 表示数据库代理创建失败。 FROZEN: 表示数据库代理已冻结。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 读写分离地址。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 端口号。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 延时阈值，单位：秒。
        /// </summary>
        [JsonProperty("delay_threshold_in_seconds", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelayThresholdInSeconds { get; set; }

        /// <summary>
        /// 数据库代理规格的CPU大小。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 数据库代理规格的内存大小。
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public string Mem { get; set; }

        /// <summary>
        /// 数据库代理节点个数。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }

        /// <summary>
        /// 数据库代理节点信息列表。
        /// </summary>
        [JsonProperty("nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProxyInfoNodes> Nodes { get; set; }

        /// <summary>
        /// 数据库代理集群模式。 取值：     Cluster：集群模式     Ha：主备模式
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor_info", NullValueHandling = NullValueHandling.Ignore)]
        public ProxyInfoFlavorInfo FlavorInfo { get; set; }

        /// <summary>
        /// 数据库代理事务拆分开关状态。  true：开启。  false：关闭。
        /// </summary>
        [JsonProperty("transaction_split", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionSplit { get; set; }

        /// <summary>
        /// 连接池类型。  取值范围:  CLOSED: 关闭连接池。  SESSION: 开启会话级连接池。
        /// </summary>
        [JsonProperty("connection_pool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionPoolType { get; set; }

        /// <summary>
        /// 数据库代理计费模式。  取值范围： 0:按需计费 1:包周期计费
        /// </summary>
        [JsonProperty("pay_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string PayMode { get; set; }

        /// <summary>
        /// 数据库代理名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库代理读写模式。 取值范围：     readwrite 读写模式     readonly 只读模式
        /// </summary>
        [JsonProperty("proxy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// 数据库代理读写分离地址内网域名。 该字段为空表示未申请读写内网域名。
        /// </summary>
        [JsonProperty("dns_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsName { get; set; }

        /// <summary>
        /// 数据库代理实例所属子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 数据库代理秒级监控状态。
        /// </summary>
        [JsonProperty("seconds_level_monitor_fun_status", NullValueHandling = NullValueHandling.Ignore)]
        public SecondsLevelMonitorFunStatusEnum SecondsLevelMonitorFunStatus { get; set; }
        /// <summary>
        /// ALT开关状态。
        /// </summary>
        [JsonProperty("alt_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AltFlag { get; set; }

        /// <summary>
        /// 是否强制读路由到只读。
        /// </summary>
        [JsonProperty("force_read_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceReadOnly { get; set; }

        /// <summary>
        /// 数据库代理路由模式。 取值范围:     0：表示权重负载模式。     1：表示负载均衡模式（数据库主实例不接受读请求）。     2：表示负载均衡模式（数据库主实例接受读请求）。
        /// </summary>
        [JsonProperty("route_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? RouteMode { get; set; }

        /// <summary>
        /// ssl开关状态。
        /// </summary>
        [JsonProperty("ssl_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslOption { get; set; }

        /// <summary>
        /// 数据库代理是否支持开启负载均衡路由模式。
        /// </summary>
        [JsonProperty("support_balance_route_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportBalanceRouteMode { get; set; }

        /// <summary>
        /// 数据库代理是否支持开启ssl功能。
        /// </summary>
        [JsonProperty("support_proxy_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportProxySsl { get; set; }

        /// <summary>
        /// 数据库代理是否支持切换会话连接池类型。
        /// </summary>
        [JsonProperty("support_switch_connection_pool_type", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportSwitchConnectionPoolType { get; set; }

        /// <summary>
        /// 数据库代理是否支持开启事务拆分。
        /// </summary>
        [JsonProperty("support_transaction_split", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportTransactionSplit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxyInfo {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  delayThresholdInSeconds: ").Append(DelayThresholdInSeconds).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("  nodes: ").Append(Nodes).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  flavorInfo: ").Append(FlavorInfo).Append("\n");
            sb.Append("  transactionSplit: ").Append(TransactionSplit).Append("\n");
            sb.Append("  connectionPoolType: ").Append(ConnectionPoolType).Append("\n");
            sb.Append("  payMode: ").Append(PayMode).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  proxyMode: ").Append(ProxyMode).Append("\n");
            sb.Append("  dnsName: ").Append(DnsName).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  secondsLevelMonitorFunStatus: ").Append(SecondsLevelMonitorFunStatus).Append("\n");
            sb.Append("  altFlag: ").Append(AltFlag).Append("\n");
            sb.Append("  forceReadOnly: ").Append(ForceReadOnly).Append("\n");
            sb.Append("  routeMode: ").Append(RouteMode).Append("\n");
            sb.Append("  sslOption: ").Append(SslOption).Append("\n");
            sb.Append("  supportBalanceRouteMode: ").Append(SupportBalanceRouteMode).Append("\n");
            sb.Append("  supportProxySsl: ").Append(SupportProxySsl).Append("\n");
            sb.Append("  supportSwitchConnectionPoolType: ").Append(SupportSwitchConnectionPoolType).Append("\n");
            sb.Append("  supportTransactionSplit: ").Append(SupportTransactionSplit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxyInfo input)
        {
            if (input == null) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.DelayThresholdInSeconds != input.DelayThresholdInSeconds || (this.DelayThresholdInSeconds != null && !this.DelayThresholdInSeconds.Equals(input.DelayThresholdInSeconds))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Mem != input.Mem || (this.Mem != null && !this.Mem.Equals(input.Mem))) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;
            if (this.Nodes != input.Nodes || (this.Nodes != null && input.Nodes != null && !this.Nodes.SequenceEqual(input.Nodes))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.FlavorInfo != input.FlavorInfo || (this.FlavorInfo != null && !this.FlavorInfo.Equals(input.FlavorInfo))) return false;
            if (this.TransactionSplit != input.TransactionSplit || (this.TransactionSplit != null && !this.TransactionSplit.Equals(input.TransactionSplit))) return false;
            if (this.ConnectionPoolType != input.ConnectionPoolType || (this.ConnectionPoolType != null && !this.ConnectionPoolType.Equals(input.ConnectionPoolType))) return false;
            if (this.PayMode != input.PayMode || (this.PayMode != null && !this.PayMode.Equals(input.PayMode))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProxyMode != input.ProxyMode || (this.ProxyMode != null && !this.ProxyMode.Equals(input.ProxyMode))) return false;
            if (this.DnsName != input.DnsName || (this.DnsName != null && !this.DnsName.Equals(input.DnsName))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.SecondsLevelMonitorFunStatus != input.SecondsLevelMonitorFunStatus) return false;
            if (this.AltFlag != input.AltFlag || (this.AltFlag != null && !this.AltFlag.Equals(input.AltFlag))) return false;
            if (this.ForceReadOnly != input.ForceReadOnly || (this.ForceReadOnly != null && !this.ForceReadOnly.Equals(input.ForceReadOnly))) return false;
            if (this.RouteMode != input.RouteMode || (this.RouteMode != null && !this.RouteMode.Equals(input.RouteMode))) return false;
            if (this.SslOption != input.SslOption || (this.SslOption != null && !this.SslOption.Equals(input.SslOption))) return false;
            if (this.SupportBalanceRouteMode != input.SupportBalanceRouteMode || (this.SupportBalanceRouteMode != null && !this.SupportBalanceRouteMode.Equals(input.SupportBalanceRouteMode))) return false;
            if (this.SupportProxySsl != input.SupportProxySsl || (this.SupportProxySsl != null && !this.SupportProxySsl.Equals(input.SupportProxySsl))) return false;
            if (this.SupportSwitchConnectionPoolType != input.SupportSwitchConnectionPoolType || (this.SupportSwitchConnectionPoolType != null && !this.SupportSwitchConnectionPoolType.Equals(input.SupportSwitchConnectionPoolType))) return false;
            if (this.SupportTransactionSplit != input.SupportTransactionSplit || (this.SupportTransactionSplit != null && !this.SupportTransactionSplit.Equals(input.SupportTransactionSplit))) return false;

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
                if (this.DelayThresholdInSeconds != null) hashCode = hashCode * 59 + this.DelayThresholdInSeconds.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null) hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                if (this.Nodes != null) hashCode = hashCode * 59 + this.Nodes.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.FlavorInfo != null) hashCode = hashCode * 59 + this.FlavorInfo.GetHashCode();
                if (this.TransactionSplit != null) hashCode = hashCode * 59 + this.TransactionSplit.GetHashCode();
                if (this.ConnectionPoolType != null) hashCode = hashCode * 59 + this.ConnectionPoolType.GetHashCode();
                if (this.PayMode != null) hashCode = hashCode * 59 + this.PayMode.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProxyMode != null) hashCode = hashCode * 59 + this.ProxyMode.GetHashCode();
                if (this.DnsName != null) hashCode = hashCode * 59 + this.DnsName.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                hashCode = hashCode * 59 + this.SecondsLevelMonitorFunStatus.GetHashCode();
                if (this.AltFlag != null) hashCode = hashCode * 59 + this.AltFlag.GetHashCode();
                if (this.ForceReadOnly != null) hashCode = hashCode * 59 + this.ForceReadOnly.GetHashCode();
                if (this.RouteMode != null) hashCode = hashCode * 59 + this.RouteMode.GetHashCode();
                if (this.SslOption != null) hashCode = hashCode * 59 + this.SslOption.GetHashCode();
                if (this.SupportBalanceRouteMode != null) hashCode = hashCode * 59 + this.SupportBalanceRouteMode.GetHashCode();
                if (this.SupportProxySsl != null) hashCode = hashCode * 59 + this.SupportProxySsl.GetHashCode();
                if (this.SupportSwitchConnectionPoolType != null) hashCode = hashCode * 59 + this.SupportSwitchConnectionPoolType.GetHashCode();
                if (this.SupportTransactionSplit != null) hashCode = hashCode * 59 + this.SupportTransactionSplit.GetHashCode();
                return hashCode;
            }
        }
    }
}
