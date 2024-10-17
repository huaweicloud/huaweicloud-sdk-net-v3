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
    /// 节点信息。
    /// </summary>
    public class ClickHouseNodeInfo 
    {

        /// <summary>
        /// 实例节点ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例节点名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 实例节点类型。 取值范围： - master：主节点 - slave：备节点
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 实例节点状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例节点周期。
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public ClickHouseNodeInfoVolume Volume { get; set; }

        /// <summary>
        /// 实例节点cpu数量。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 实例节点内存大小（GB）。
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public string Mem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public ClickHouseNodeInfoDatastore Datastore { get; set; }

        /// <summary>
        /// 节点优先级。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 冻结标志。 取值范围： - 0：不冻结 - 1：冻结
        /// </summary>
        [JsonProperty("frozen_flag", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrozenFlag { get; set; }

        /// <summary>
        /// 数据库端口号。取值范围：0~65535。
        /// </summary>
        [JsonProperty("db_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbPort { get; set; }

        /// <summary>
        /// 支付模式。 取值范围： - 0：按需计费 - 1：包周期
        /// </summary>
        [JsonProperty("pay_model", NullValueHandling = NullValueHandling.Ignore)]
        public string PayModel { get; set; }

        /// <summary>
        /// 包周期订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 节点数据ip。
        /// </summary>
        [JsonProperty("traffic_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficIp { get; set; }

        /// <summary>
        /// 节点数据ipv6。
        /// </summary>
        [JsonProperty("traffic_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficIpv6 { get; set; }

        /// <summary>
        /// 节点数据vip。
        /// </summary>
        [JsonProperty("traffic_vip", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficVip { get; set; }

        /// <summary>
        /// 节点数据vipV6。
        /// </summary>
        [JsonProperty("traffic_vipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficVipv6 { get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 可用区描述。
        /// </summary>
        [JsonProperty("az_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AzDescription { get; set; }

        /// <summary>
        /// 可用区类型。
        /// </summary>
        [JsonProperty("az_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AzType { get; set; }

        /// <summary>
        /// 节点所在区。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 节点创建时间。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// 节点更新时间。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }

        /// <summary>
        /// 节点规格ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 节点规格码。
        /// </summary>
        [JsonProperty("flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorRef { get; set; }

        /// <summary>
        /// IASS规格码。
        /// </summary>
        [JsonProperty("iass_flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string IassFlavorRef { get; set; }

        /// <summary>
        /// 公网最大连接数。
        /// </summary>
        [JsonProperty("max_connections", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConnections { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 参数更新是否需要重启。
        /// </summary>
        [JsonProperty("need_restart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedRestart { get; set; }

        /// <summary>
        /// 安全组
        /// </summary>
        [JsonProperty("sg_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SgId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClickHouseNodeInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  frozenFlag: ").Append(FrozenFlag).Append("\n");
            sb.Append("  dbPort: ").Append(DbPort).Append("\n");
            sb.Append("  payModel: ").Append(PayModel).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  trafficIp: ").Append(TrafficIp).Append("\n");
            sb.Append("  trafficIpv6: ").Append(TrafficIpv6).Append("\n");
            sb.Append("  trafficVip: ").Append(TrafficVip).Append("\n");
            sb.Append("  trafficVipv6: ").Append(TrafficVipv6).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  azDescription: ").Append(AzDescription).Append("\n");
            sb.Append("  azType: ").Append(AzType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  flavorRef: ").Append(FlavorRef).Append("\n");
            sb.Append("  iassFlavorRef: ").Append(IassFlavorRef).Append("\n");
            sb.Append("  maxConnections: ").Append(MaxConnections).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  needRestart: ").Append(NeedRestart).Append("\n");
            sb.Append("  sgId: ").Append(SgId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClickHouseNodeInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClickHouseNodeInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Mem != input.Mem || (this.Mem != null && !this.Mem.Equals(input.Mem))) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.FrozenFlag != input.FrozenFlag || (this.FrozenFlag != null && !this.FrozenFlag.Equals(input.FrozenFlag))) return false;
            if (this.DbPort != input.DbPort || (this.DbPort != null && !this.DbPort.Equals(input.DbPort))) return false;
            if (this.PayModel != input.PayModel || (this.PayModel != null && !this.PayModel.Equals(input.PayModel))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.TrafficIp != input.TrafficIp || (this.TrafficIp != null && !this.TrafficIp.Equals(input.TrafficIp))) return false;
            if (this.TrafficIpv6 != input.TrafficIpv6 || (this.TrafficIpv6 != null && !this.TrafficIpv6.Equals(input.TrafficIpv6))) return false;
            if (this.TrafficVip != input.TrafficVip || (this.TrafficVip != null && !this.TrafficVip.Equals(input.TrafficVip))) return false;
            if (this.TrafficVipv6 != input.TrafficVipv6 || (this.TrafficVipv6 != null && !this.TrafficVipv6.Equals(input.TrafficVipv6))) return false;
            if (this.AzCode != input.AzCode || (this.AzCode != null && !this.AzCode.Equals(input.AzCode))) return false;
            if (this.AzDescription != input.AzDescription || (this.AzDescription != null && !this.AzDescription.Equals(input.AzDescription))) return false;
            if (this.AzType != input.AzType || (this.AzType != null && !this.AzType.Equals(input.AzType))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.FlavorRef != input.FlavorRef || (this.FlavorRef != null && !this.FlavorRef.Equals(input.FlavorRef))) return false;
            if (this.IassFlavorRef != input.IassFlavorRef || (this.IassFlavorRef != null && !this.IassFlavorRef.Equals(input.IassFlavorRef))) return false;
            if (this.MaxConnections != input.MaxConnections || (this.MaxConnections != null && !this.MaxConnections.Equals(input.MaxConnections))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.NeedRestart != input.NeedRestart || (this.NeedRestart != null && !this.NeedRestart.Equals(input.NeedRestart))) return false;
            if (this.SgId != input.SgId || (this.SgId != null && !this.SgId.Equals(input.SgId))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null) hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.FrozenFlag != null) hashCode = hashCode * 59 + this.FrozenFlag.GetHashCode();
                if (this.DbPort != null) hashCode = hashCode * 59 + this.DbPort.GetHashCode();
                if (this.PayModel != null) hashCode = hashCode * 59 + this.PayModel.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.TrafficIp != null) hashCode = hashCode * 59 + this.TrafficIp.GetHashCode();
                if (this.TrafficIpv6 != null) hashCode = hashCode * 59 + this.TrafficIpv6.GetHashCode();
                if (this.TrafficVip != null) hashCode = hashCode * 59 + this.TrafficVip.GetHashCode();
                if (this.TrafficVipv6 != null) hashCode = hashCode * 59 + this.TrafficVipv6.GetHashCode();
                if (this.AzCode != null) hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.AzDescription != null) hashCode = hashCode * 59 + this.AzDescription.GetHashCode();
                if (this.AzType != null) hashCode = hashCode * 59 + this.AzType.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.FlavorRef != null) hashCode = hashCode * 59 + this.FlavorRef.GetHashCode();
                if (this.IassFlavorRef != null) hashCode = hashCode * 59 + this.IassFlavorRef.GetHashCode();
                if (this.MaxConnections != null) hashCode = hashCode * 59 + this.MaxConnections.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.NeedRestart != null) hashCode = hashCode * 59 + this.NeedRestart.GetHashCode();
                if (this.SgId != null) hashCode = hashCode * 59 + this.SgId.GetHashCode();
                return hashCode;
            }
        }
    }
}
