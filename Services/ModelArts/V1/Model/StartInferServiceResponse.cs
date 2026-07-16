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
    /// Response Object
    /// </summary>
    public class StartInferServiceResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 服务ID，在[创建服务](CreateInferService.xml)时即可在返回体中获取，也可通过[查询服务列表](ListInferServices.xml)获取当前用户拥有的服务，其中service_id字段即为服务ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 服务名，用户在[创建服务](CreateInferService.xml)时自定义的名称。 **取值范围：** 支持1-64位字符，可包含字母、中文、数字、中划线、下划线。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 工作空间ID。 **取值范围：** - 0：默认空间ID。 - 由数字和小写字母组成的32位字符：其他空间ID，可参考[工作空间创建](CreateWorkspace.xml)。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 推理服务类型。 **取值范围：** - REAL_TIME：在线服务。 - ASYNC_REAL_TIME：异步服务。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 部署方式。 **取值范围：** - SINGLE：单机单卡。 - MULTI：多机多卡。
        /// </summary>
        [JsonProperty("deploy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployType { get; set; }

        /// <summary>
        /// **参数解释：** 服务当前状态。 **取值范围：** - DEPLOYING：部署中 。 - FAILED：失败 。 - STOPPED：停止。 - RUNNING：运行中。 - DELETING：删除中 。 - STOPPING：停止中 。 - CONCERNING：告警 。 - UPGRADING：升级中 。 - ERROR：异常 。 - INIT：待部署。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 在线服务失败原因。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceVersionResponse Version { get; set; }

        /// <summary>
        /// **参数解释：** 在线服务访问地址，创建服务接口无返回，详情接口中返回。
        /// </summary>
        [JsonProperty("predict_url", NullValueHandling = NullValueHandling.Ignore)]
        public List<PredictUrlResponse> PredictUrl { get; set; }

        /// <summary>
        /// **参数解释：** 服务绑定的dispatcher组ID，创建服务接口无返回，详情接口中返回。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("dispatcher_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DispatcherGroupId { get; set; }

        /// <summary>
        /// **参数解释：** TMS对接标签类。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsResponse> Tags { get; set; }

        /// <summary>
        /// **参数解释：** 部署超时时间。
        /// </summary>
        [JsonProperty("deploy_timeout_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeployTimeoutMinutes { get; set; }

        /// <summary>
        /// **参数解释：** 定时停止配置。
        /// </summary>
        [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduleConfigResponse> Schedule { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间，根据创建时的当前时间自动生成。 **取值范围：** 毫秒级时间戳，13位数字，如1609459200000。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间，根据更新时的当前时间自动生成。 **取值范围：** 毫秒级时间戳，13位数字，如1609459200000。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 模型类型。 **取值范围：** - TEXT_GENERATION：文本生成 - IMAGE_UNDERSTANDING：图像理解 - VIDEO_GENERATION：视频生成 - IMAGE_GENERATION：图像生成 - RERANK：重排序 - VECTOR_MODEL：向量模型 - EMBEDDING：Embedding嵌入
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// **参数解释：** 服务提供者的账号id（创建服务时通过X-Auth-Token-Provider请求头解析iam token而来），该值不为空时，该服务的所有更新操作需要在请求头中添加X-Auth-Token-Provider，取值为该账号id的domain级或project级token。
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

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
            sb.Append("class StartInferServiceResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  deployType: ").Append(DeployType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  failureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  predictUrl: ").Append(PredictUrl).Append("\n");
            sb.Append("  dispatcherGroupId: ").Append(DispatcherGroupId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  deployTimeoutMinutes: ").Append(DeployTimeoutMinutes).Append("\n");
            sb.Append("  schedule: ").Append(Schedule).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  frozenInfos: ").Append(FrozenInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartInferServiceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartInferServiceResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.DeployType != input.DeployType || (this.DeployType != null && !this.DeployType.Equals(input.DeployType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.FailureReason != input.FailureReason || (this.FailureReason != null && !this.FailureReason.Equals(input.FailureReason))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.PredictUrl != input.PredictUrl || (this.PredictUrl != null && input.PredictUrl != null && !this.PredictUrl.SequenceEqual(input.PredictUrl))) return false;
            if (this.DispatcherGroupId != input.DispatcherGroupId || (this.DispatcherGroupId != null && !this.DispatcherGroupId.Equals(input.DispatcherGroupId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.DeployTimeoutMinutes != input.DeployTimeoutMinutes || (this.DeployTimeoutMinutes != null && !this.DeployTimeoutMinutes.Equals(input.DeployTimeoutMinutes))) return false;
            if (this.Schedule != input.Schedule || (this.Schedule != null && input.Schedule != null && !this.Schedule.SequenceEqual(input.Schedule))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
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
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeployType != null) hashCode = hashCode * 59 + this.DeployType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FailureReason != null) hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.PredictUrl != null) hashCode = hashCode * 59 + this.PredictUrl.GetHashCode();
                if (this.DispatcherGroupId != null) hashCode = hashCode * 59 + this.DispatcherGroupId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.DeployTimeoutMinutes != null) hashCode = hashCode * 59 + this.DeployTimeoutMinutes.GetHashCode();
                if (this.Schedule != null) hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.FrozenInfos != null) hashCode = hashCode * 59 + this.FrozenInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
