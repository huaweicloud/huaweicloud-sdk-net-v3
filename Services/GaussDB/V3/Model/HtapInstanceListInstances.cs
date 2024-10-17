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
    public class HtapInstanceListInstances 
    {

        /// <summary>
        /// HTAP实例ID，严格匹配UUID规则。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// HTAP实例名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// HTAP数据库引擎名。
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// HTAP数据库引擎版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 租户在某一region下的project ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance_state", NullValueHandling = NullValueHandling.Ignore)]
        public HtapInstanceListInstanceState InstanceState { get; set; }

        /// <summary>
        /// HTAP实例创建时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// HTAP实例是否冻结。
        /// </summary>
        [JsonProperty("is_frozen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFrozen { get; set; }

        /// <summary>
        /// HTAP实例部署模式。
        /// </summary>
        [JsonProperty("ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string HaMode { get; set; }

        /// <summary>
        /// 计费模式。当前仅支持按需计费。 0：按需计费 1：包周期
        /// </summary>
        [JsonProperty("pay_model", NullValueHandling = NullValueHandling.Ignore)]
        public string PayModel { get; set; }

        /// <summary>
        /// 包周期计费订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 包周期计费备用订单ID。
        /// </summary>
        [JsonProperty("alter_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlterOrderId { get; set; }

        /// <summary>
        /// 读写内网地址。
        /// </summary>
        [JsonProperty("data_vip", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVip { get; set; }

        /// <summary>
        /// 可读节点信息
        /// </summary>
        [JsonProperty("readable_node_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReadableNodeInfos> ReadableNodeInfos { get; set; }

        /// <summary>
        /// 代理IP。
        /// </summary>
        [JsonProperty("proxy_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProxyIps { get; set; }

        /// <summary>
        /// 读写内网地址IPV6。
        /// </summary>
        [JsonProperty("data_vip_v6", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVipV6 { get; set; }

        /// <summary>
        /// 数据库访问端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 可用区信息。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<HtapInstanceListAvailableZones> AvailableZones { get; set; }

        /// <summary>
        /// 实例动作。
        /// </summary>
        [JsonProperty("current_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryAction> CurrentActions { get; set; }

        /// <summary>
        /// 存储类型。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// 服务器类型。
        /// </summary>
        [JsonProperty("server_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerType { get; set; }

        /// <summary>
        /// 企业项目ID。如果帐户开通企业项目服务则该参数必选，未开启该参数不可选。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 专属资源池ID，只有开通专属资源池后才支持此参数。
        /// </summary>
        [JsonProperty("dedicated_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public HtapInstanceListNetwork Network { get; set; }

        /// <summary>
        /// ClickHouse主节点ID。
        /// </summary>
        [JsonProperty("ch_master_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChMasterNodeId { get; set; }

        /// <summary>
        /// 节点个数。
        /// </summary>
        [JsonProperty("node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtapInstanceListInstances {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  instanceState: ").Append(InstanceState).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  isFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  haMode: ").Append(HaMode).Append("\n");
            sb.Append("  payModel: ").Append(PayModel).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  alterOrderId: ").Append(AlterOrderId).Append("\n");
            sb.Append("  dataVip: ").Append(DataVip).Append("\n");
            sb.Append("  readableNodeInfos: ").Append(ReadableNodeInfos).Append("\n");
            sb.Append("  proxyIps: ").Append(ProxyIps).Append("\n");
            sb.Append("  dataVipV6: ").Append(DataVipV6).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  currentActions: ").Append(CurrentActions).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  dedicatedResourceId: ").Append(DedicatedResourceId).Append("\n");
            sb.Append("  network: ").Append(Network).Append("\n");
            sb.Append("  chMasterNodeId: ").Append(ChMasterNodeId).Append("\n");
            sb.Append("  nodeNum: ").Append(NodeNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HtapInstanceListInstances);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HtapInstanceListInstances input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.InstanceState != input.InstanceState || (this.InstanceState != null && !this.InstanceState.Equals(input.InstanceState))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.IsFrozen != input.IsFrozen || (this.IsFrozen != null && !this.IsFrozen.Equals(input.IsFrozen))) return false;
            if (this.HaMode != input.HaMode || (this.HaMode != null && !this.HaMode.Equals(input.HaMode))) return false;
            if (this.PayModel != input.PayModel || (this.PayModel != null && !this.PayModel.Equals(input.PayModel))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.AlterOrderId != input.AlterOrderId || (this.AlterOrderId != null && !this.AlterOrderId.Equals(input.AlterOrderId))) return false;
            if (this.DataVip != input.DataVip || (this.DataVip != null && !this.DataVip.Equals(input.DataVip))) return false;
            if (this.ReadableNodeInfos != input.ReadableNodeInfos || (this.ReadableNodeInfos != null && input.ReadableNodeInfos != null && !this.ReadableNodeInfos.SequenceEqual(input.ReadableNodeInfos))) return false;
            if (this.ProxyIps != input.ProxyIps || (this.ProxyIps != null && input.ProxyIps != null && !this.ProxyIps.SequenceEqual(input.ProxyIps))) return false;
            if (this.DataVipV6 != input.DataVipV6 || (this.DataVipV6 != null && !this.DataVipV6.Equals(input.DataVipV6))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.CurrentActions != input.CurrentActions || (this.CurrentActions != null && input.CurrentActions != null && !this.CurrentActions.SequenceEqual(input.CurrentActions))) return false;
            if (this.VolumeType != input.VolumeType || (this.VolumeType != null && !this.VolumeType.Equals(input.VolumeType))) return false;
            if (this.ServerType != input.ServerType || (this.ServerType != null && !this.ServerType.Equals(input.ServerType))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.DedicatedResourceId != input.DedicatedResourceId || (this.DedicatedResourceId != null && !this.DedicatedResourceId.Equals(input.DedicatedResourceId))) return false;
            if (this.Network != input.Network || (this.Network != null && !this.Network.Equals(input.Network))) return false;
            if (this.ChMasterNodeId != input.ChMasterNodeId || (this.ChMasterNodeId != null && !this.ChMasterNodeId.Equals(input.ChMasterNodeId))) return false;
            if (this.NodeNum != input.NodeNum || (this.NodeNum != null && !this.NodeNum.Equals(input.NodeNum))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.InstanceState != null) hashCode = hashCode * 59 + this.InstanceState.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.IsFrozen != null) hashCode = hashCode * 59 + this.IsFrozen.GetHashCode();
                if (this.HaMode != null) hashCode = hashCode * 59 + this.HaMode.GetHashCode();
                if (this.PayModel != null) hashCode = hashCode * 59 + this.PayModel.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.AlterOrderId != null) hashCode = hashCode * 59 + this.AlterOrderId.GetHashCode();
                if (this.DataVip != null) hashCode = hashCode * 59 + this.DataVip.GetHashCode();
                if (this.ReadableNodeInfos != null) hashCode = hashCode * 59 + this.ReadableNodeInfos.GetHashCode();
                if (this.ProxyIps != null) hashCode = hashCode * 59 + this.ProxyIps.GetHashCode();
                if (this.DataVipV6 != null) hashCode = hashCode * 59 + this.DataVipV6.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.CurrentActions != null) hashCode = hashCode * 59 + this.CurrentActions.GetHashCode();
                if (this.VolumeType != null) hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.ServerType != null) hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DedicatedResourceId != null) hashCode = hashCode * 59 + this.DedicatedResourceId.GetHashCode();
                if (this.Network != null) hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.ChMasterNodeId != null) hashCode = hashCode * 59 + this.ChMasterNodeId.GetHashCode();
                if (this.NodeNum != null) hashCode = hashCode * 59 + this.NodeNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
