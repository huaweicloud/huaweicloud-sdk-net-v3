using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 创建云服务请求。
    /// </summary>
    public class CreateAppServerReq 
    {

        /// <summary>
        /// 创建云服务类型，当前仅支持创建云应用：createApps。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 服务器组唯一标识。
        /// </summary>
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// 可用分区。 &gt; - [将服务创建到指定的可用分区，如果不指定则使用系统随机的可用分区](tag:HW)[将服务创建到指定的可用分区](tag:HCS)。 &gt; - [获取方式详见可用区管理ListAvailabilityZone：\&quot;GET  /v1/{project_id}/availability-zone\&quot;。](tag:HW)[获取方式详见可用区管理ListAvailabilityZone：\&quot;GET  /v1/{project_id}/availability-zone/summary\&quot;。](tag:HCS)
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 订购数量。
        /// </summary>
        [JsonProperty("subscription_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionNum { get; set; }

        /// <summary>
        /// 服务对应的网卡信息，当前未使用该字段。
        /// </summary>
        [JsonProperty("nics", NullValueHandling = NullValueHandling.Ignore)]
        public List<Nic> Nics { get; set; }

        /// <summary>
        /// OU名称，在对接AD时使用，需提前在AD中创建OU。
        /// </summary>
        [JsonProperty("ou_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OuName { get; set; }

        /// <summary>
        /// 产品ID。 &gt; - 获取方式详见产品套餐管理ListProduct：\&quot;GET /v1/{project_id}/product\&quot;。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 规格ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 操作系统类型，当前仅支持Windows。
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("root_volume", NullValueHandling = NullValueHandling.Ignore)]
        public Volume RootVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public WdhParam SchedulerHints { get; set; }

        /// <summary>
        /// 网卡对应的子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 是否自动升级hda版本。
        /// </summary>
        [JsonProperty("update_access_agent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateAccessAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_server_extend_param", NullValueHandling = NullValueHandling.Ignore)]
        public CreateServerExtendParam CreateServerExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAppServerReq {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  subscriptionNum: ").Append(SubscriptionNum).Append("\n");
            sb.Append("  nics: ").Append(Nics).Append("\n");
            sb.Append("  ouName: ").Append(OuName).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  rootVolume: ").Append(RootVolume).Append("\n");
            sb.Append("  schedulerHints: ").Append(SchedulerHints).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  updateAccessAgent: ").Append(UpdateAccessAgent).Append("\n");
            sb.Append("  createServerExtendParam: ").Append(CreateServerExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAppServerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAppServerReq input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ServerGroupId != input.ServerGroupId || (this.ServerGroupId != null && !this.ServerGroupId.Equals(input.ServerGroupId))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.SubscriptionNum != input.SubscriptionNum || (this.SubscriptionNum != null && !this.SubscriptionNum.Equals(input.SubscriptionNum))) return false;
            if (this.Nics != input.Nics || (this.Nics != null && input.Nics != null && !this.Nics.SequenceEqual(input.Nics))) return false;
            if (this.OuName != input.OuName || (this.OuName != null && !this.OuName.Equals(input.OuName))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.RootVolume != input.RootVolume || (this.RootVolume != null && !this.RootVolume.Equals(input.RootVolume))) return false;
            if (this.SchedulerHints != input.SchedulerHints || (this.SchedulerHints != null && !this.SchedulerHints.Equals(input.SchedulerHints))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.VpcId != input.VpcId || (this.VpcId != null && !this.VpcId.Equals(input.VpcId))) return false;
            if (this.UpdateAccessAgent != input.UpdateAccessAgent || (this.UpdateAccessAgent != null && !this.UpdateAccessAgent.Equals(input.UpdateAccessAgent))) return false;
            if (this.CreateServerExtendParam != input.CreateServerExtendParam || (this.CreateServerExtendParam != null && !this.CreateServerExtendParam.Equals(input.CreateServerExtendParam))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ServerGroupId != null) hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.SubscriptionNum != null) hashCode = hashCode * 59 + this.SubscriptionNum.GetHashCode();
                if (this.Nics != null) hashCode = hashCode * 59 + this.Nics.GetHashCode();
                if (this.OuName != null) hashCode = hashCode * 59 + this.OuName.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.RootVolume != null) hashCode = hashCode * 59 + this.RootVolume.GetHashCode();
                if (this.SchedulerHints != null) hashCode = hashCode * 59 + this.SchedulerHints.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.VpcId != null) hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.UpdateAccessAgent != null) hashCode = hashCode * 59 + this.UpdateAccessAgent.GetHashCode();
                if (this.CreateServerExtendParam != null) hashCode = hashCode * 59 + this.CreateServerExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
