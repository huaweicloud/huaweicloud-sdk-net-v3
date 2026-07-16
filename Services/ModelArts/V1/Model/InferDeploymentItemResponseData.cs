using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InferDeploymentItemResponseData 
    {

        /// <summary>
        /// **参数解释：** 服务ID，在[创建服务](CreateInferService.xml)时即可在返回体中获取，也可通过[查询服务列表](ListInferServices.xml)获取当前用户拥有的服务，其中service_id字段即为服务ID。 **取值范围：** 服务ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 部署名，用户在[创建服务](CreateInferService.xml)时自定义。 **取值范围：** 支持1-128个字符，可以包含字母、汉字、数字、连字符和下划线。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 部署ID。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("infer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InferName { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例组id。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("service_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceGroupName { get; set; }

        /// <summary>
        /// **参数解释：** 服务当前状态，一次只支持一种状态筛选。默认不过滤。 **取值范围：** - DEPLOYING：部署中。 - FAILED：失败。 - STOPPED：停止。 - RUNNING：运行中。 - DELETING：删除中。 - STOPPING：停止中。 - CONCERNING：告警。 - DELETED：已删除。 - RESTARTING：重启中。 - UPGRADING：升级中。 - ERROR：异常。 - INTERRUPTING：中断中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 部署对接lts状态。 **取值范围：** - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("lts_state", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsState { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启镜像流量。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("mirror_traffic_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MirrorTrafficEnable { get; set; }

        /// <summary>
        /// **参数解释：** 镜像流量权重。 **取值范围：** 50。
        /// </summary>
        [JsonProperty("mirror_traffic_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string MirrorTrafficWeight { get; set; }

        /// <summary>
        /// **参数解释：** 权重百分比，分配到此模型的流量权重，仅当模型部署为在线服务时需要配置。 **取值范围：** [0, 100]。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// **参数解释：** 流量比例，单个部署实例预期接收用户的流量与总流量比值，是由流量权重配置和部署状态计算所得的值。 **取值范围：** 0.00%~100.00%。
        /// </summary>
        [JsonProperty("traffic_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficRatio { get; set; }

        /// <summary>
        /// **参数解释：** 专属资源池ID。 **取值范围：** 50。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// **参数解释：** 服务版本号，以数字及点号组成，形如1.0.1。 **取值范围：** 版本长度不超过8位。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 部署类型。 **取值范围：** - SINGLE：单机单卡。 - MULTI：多机多卡。 - DIST：分布式部署。
        /// </summary>
        [JsonProperty("deploy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployType { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间，根据创建时的当前时间自动生成。 **取值范围：** 毫秒级时间戳，13位数字
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间，根据更新时的当前时间自动生成。 **取值范围：** 毫秒级时间戳，13位数字。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 当服务或者部署被冻结时返回的冻结类型信息。
        /// </summary>
        [JsonProperty("frozen_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<FrozenInfo> FrozenInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InferDeploymentItemResponseData {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  inferName: ").Append(InferName).Append("\n");
            sb.Append("  serviceGroupName: ").Append(ServiceGroupName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  ltsState: ").Append(LtsState).Append("\n");
            sb.Append("  mirrorTrafficEnable: ").Append(MirrorTrafficEnable).Append("\n");
            sb.Append("  mirrorTrafficWeight: ").Append(MirrorTrafficWeight).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  trafficRatio: ").Append(TrafficRatio).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  deployType: ").Append(DeployType).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  frozenInfos: ").Append(FrozenInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InferDeploymentItemResponseData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InferDeploymentItemResponseData input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.InferName != input.InferName || (this.InferName != null && !this.InferName.Equals(input.InferName))) return false;
            if (this.ServiceGroupName != input.ServiceGroupName || (this.ServiceGroupName != null && !this.ServiceGroupName.Equals(input.ServiceGroupName))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.LtsState != input.LtsState || (this.LtsState != null && !this.LtsState.Equals(input.LtsState))) return false;
            if (this.MirrorTrafficEnable != input.MirrorTrafficEnable || (this.MirrorTrafficEnable != null && !this.MirrorTrafficEnable.Equals(input.MirrorTrafficEnable))) return false;
            if (this.MirrorTrafficWeight != input.MirrorTrafficWeight || (this.MirrorTrafficWeight != null && !this.MirrorTrafficWeight.Equals(input.MirrorTrafficWeight))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.TrafficRatio != input.TrafficRatio || (this.TrafficRatio != null && !this.TrafficRatio.Equals(input.TrafficRatio))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.DeployType != input.DeployType || (this.DeployType != null && !this.DeployType.Equals(input.DeployType))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.FrozenInfos != input.FrozenInfos || (this.FrozenInfos != null && input.FrozenInfos != null && !this.FrozenInfos.SequenceEqual(input.FrozenInfos))) return false;

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
                if (this.InferName != null) hashCode = hashCode * 59 + this.InferName.GetHashCode();
                if (this.ServiceGroupName != null) hashCode = hashCode * 59 + this.ServiceGroupName.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LtsState != null) hashCode = hashCode * 59 + this.LtsState.GetHashCode();
                if (this.MirrorTrafficEnable != null) hashCode = hashCode * 59 + this.MirrorTrafficEnable.GetHashCode();
                if (this.MirrorTrafficWeight != null) hashCode = hashCode * 59 + this.MirrorTrafficWeight.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.TrafficRatio != null) hashCode = hashCode * 59 + this.TrafficRatio.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.DeployType != null) hashCode = hashCode * 59 + this.DeployType.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.FrozenInfos != null) hashCode = hashCode * 59 + this.FrozenInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
