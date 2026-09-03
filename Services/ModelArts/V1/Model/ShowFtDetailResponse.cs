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
    public class ShowFtDetailResponse : SdkResponse
    {

        /// <summary>
        /// 项目id。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 训练任务id。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 训练任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 训练任务描述信息。
        /// </summary>
        [JsonProperty("task_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public JobMetadataResponse Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("spec", NullValueHandling = NullValueHandling.Ignore)]
        public SpecResponse Spec { get; set; }

        /// <summary>
        /// 模型id。
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// **参数解释：** 模型类型，取值为TextGeneration|ImageUnderstanding，依次为：文本生成、图像理解。 **约束限制：** 不涉及 **取值范围：** TextGeneration|ImageUnderstanding **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("model_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelType { get; set; }

        /// <summary>
        /// 模型来源
        /// </summary>
        [JsonProperty("model_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelSource { get; set; }

        /// <summary>
        /// **参数解释：** 训练类型，支持SFT（全量微调）、PRETRAIN（预训练）、LORA（lora微调）、DPO（dpo强化学习）、RFT（rft强化学习）。 **约束限制：** 不涉及 **取值范围：** SFT（全量微调）、PRETRAIN（预训练）、LORA（lora微调）、DPO（dpo强化学习）、RFT（rft强化学习） 默认取值： SFT
        /// </summary>
        [JsonProperty("train_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainType { get; set; }

        /// <summary>
        /// 断点续训相关配置。
        /// </summary>
        [JsonProperty("checkpoint_config", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckpointConfig { get; set; }

        /// <summary>
        /// 训练任参数信息。
        /// </summary>
        [JsonProperty("task_parameters", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskParameters { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 训练任务更新时间，当修改、或者训练任务状态发生变化时进行更新。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 训练任务进度。
        /// </summary>
        [JsonProperty("train_process", NullValueHandling = NullValueHandling.Ignore)]
        public double? TrainProcess { get; set; }

        /// <summary>
        /// 该训练任务数据集相关的配置。
        /// </summary>
        [JsonProperty("datasets_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatasetConfig> DatasetsConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status Status { get; set; }

        /// <summary>
        /// 自动发布配置信息
        /// </summary>
        [JsonProperty("auto_publish_config", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoPublishConfig { get; set; }

        /// <summary>
        /// 模型资产名
        /// </summary>
        [JsonProperty("asset_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetCode { get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// 模型资产描述信息
        /// </summary>
        [JsonProperty("asset_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetDesc { get; set; }

        /// <summary>
        /// 模型系列
        /// </summary>
        [JsonProperty("asset_series", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetSeries { get; set; }

        /// <summary>
        /// 资产版本
        /// </summary>
        [JsonProperty("asset_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetVersion { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetType { get; set; }

        /// <summary>
        /// 资产来源
        /// </summary>
        [JsonProperty("asset_source", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetSource { get; set; }

        /// <summary>
        /// 资产组id
        /// </summary>
        [JsonProperty("asset_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetGroupId { get; set; }

        /// <summary>
        /// 资产子类型
        /// </summary>
        [JsonProperty("sub_asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SubAssetType { get; set; }

        /// <summary>
        /// 资产类别
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 资产API版本
        /// </summary>
        [JsonProperty("api_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// 根资产ID
        /// </summary>
        [JsonProperty("root_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootAssetId { get; set; }

        /// <summary>
        /// 训练任务耗时
        /// </summary>
        [JsonProperty("train_cost_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TrainCostTime { get; set; }

        /// <summary>
        /// 任务所属工作空间名称
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 资源池类型
        /// </summary>
        [JsonProperty("pool_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolType { get; set; }

        /// <summary>
        /// 资源池ID
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 使用的资源池实例数
        /// </summary>
        [JsonProperty("pool_node_count", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolNodeCount { get; set; }

        /// <summary>
        /// 使用的资源池卡数
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 训练预估时长
        /// </summary>
        [JsonProperty("training_info", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainingInfo { get; set; }

        /// <summary>
        /// **参数解释**：训练产物输出路径，如\&quot;obs://yyy/test/\&quot;。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("train_output_path", NullValueHandling = NullValueHandling.Ignore)]
        public string TrainOutputPath { get; set; }

        /// <summary>
        /// 训练模型类型
        /// </summary>
        [JsonProperty("asset_capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetCapabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("continue_task", NullValueHandling = NullValueHandling.Ignore)]
        public ContinueTask ContinueTask { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFtDetailResponse {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskDesc: ").Append(TaskDesc).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  spec: ").Append(Spec).Append("\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  modelType: ").Append(ModelType).Append("\n");
            sb.Append("  modelSource: ").Append(ModelSource).Append("\n");
            sb.Append("  trainType: ").Append(TrainType).Append("\n");
            sb.Append("  checkpointConfig: ").Append(CheckpointConfig).Append("\n");
            sb.Append("  taskParameters: ").Append(TaskParameters).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  trainProcess: ").Append(TrainProcess).Append("\n");
            sb.Append("  datasetsConfig: ").Append(DatasetsConfig).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  autoPublishConfig: ").Append(AutoPublishConfig).Append("\n");
            sb.Append("  assetCode: ").Append(AssetCode).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetDesc: ").Append(AssetDesc).Append("\n");
            sb.Append("  assetSeries: ").Append(AssetSeries).Append("\n");
            sb.Append("  assetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  assetSource: ").Append(AssetSource).Append("\n");
            sb.Append("  assetGroupId: ").Append(AssetGroupId).Append("\n");
            sb.Append("  subAssetType: ").Append(SubAssetType).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  rootAssetId: ").Append(RootAssetId).Append("\n");
            sb.Append("  trainCostTime: ").Append(TrainCostTime).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  poolType: ").Append(PoolType).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  poolNodeCount: ").Append(PoolNodeCount).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  trainingInfo: ").Append(TrainingInfo).Append("\n");
            sb.Append("  trainOutputPath: ").Append(TrainOutputPath).Append("\n");
            sb.Append("  assetCapabilities: ").Append(AssetCapabilities).Append("\n");
            sb.Append("  continueTask: ").Append(ContinueTask).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFtDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFtDetailResponse input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TaskDesc != input.TaskDesc || (this.TaskDesc != null && !this.TaskDesc.Equals(input.TaskDesc))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;
            if (this.Spec != input.Spec || (this.Spec != null && !this.Spec.Equals(input.Spec))) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.ModelType != input.ModelType || (this.ModelType != null && !this.ModelType.Equals(input.ModelType))) return false;
            if (this.ModelSource != input.ModelSource || (this.ModelSource != null && !this.ModelSource.Equals(input.ModelSource))) return false;
            if (this.TrainType != input.TrainType || (this.TrainType != null && !this.TrainType.Equals(input.TrainType))) return false;
            if (this.CheckpointConfig != input.CheckpointConfig || (this.CheckpointConfig != null && !this.CheckpointConfig.Equals(input.CheckpointConfig))) return false;
            if (this.TaskParameters != input.TaskParameters || (this.TaskParameters != null && !this.TaskParameters.Equals(input.TaskParameters))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.TrainProcess != input.TrainProcess || (this.TrainProcess != null && !this.TrainProcess.Equals(input.TrainProcess))) return false;
            if (this.DatasetsConfig != input.DatasetsConfig || (this.DatasetsConfig != null && input.DatasetsConfig != null && !this.DatasetsConfig.SequenceEqual(input.DatasetsConfig))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.AutoPublishConfig != input.AutoPublishConfig || (this.AutoPublishConfig != null && !this.AutoPublishConfig.Equals(input.AutoPublishConfig))) return false;
            if (this.AssetCode != input.AssetCode || (this.AssetCode != null && !this.AssetCode.Equals(input.AssetCode))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetDesc != input.AssetDesc || (this.AssetDesc != null && !this.AssetDesc.Equals(input.AssetDesc))) return false;
            if (this.AssetSeries != input.AssetSeries || (this.AssetSeries != null && !this.AssetSeries.Equals(input.AssetSeries))) return false;
            if (this.AssetVersion != input.AssetVersion || (this.AssetVersion != null && !this.AssetVersion.Equals(input.AssetVersion))) return false;
            if (this.AssetType != input.AssetType || (this.AssetType != null && !this.AssetType.Equals(input.AssetType))) return false;
            if (this.AssetSource != input.AssetSource || (this.AssetSource != null && !this.AssetSource.Equals(input.AssetSource))) return false;
            if (this.AssetGroupId != input.AssetGroupId || (this.AssetGroupId != null && !this.AssetGroupId.Equals(input.AssetGroupId))) return false;
            if (this.SubAssetType != input.SubAssetType || (this.SubAssetType != null && !this.SubAssetType.Equals(input.SubAssetType))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.RootAssetId != input.RootAssetId || (this.RootAssetId != null && !this.RootAssetId.Equals(input.RootAssetId))) return false;
            if (this.TrainCostTime != input.TrainCostTime || (this.TrainCostTime != null && !this.TrainCostTime.Equals(input.TrainCostTime))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.PoolType != input.PoolType || (this.PoolType != null && !this.PoolType.Equals(input.PoolType))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.PoolNodeCount != input.PoolNodeCount || (this.PoolNodeCount != null && !this.PoolNodeCount.Equals(input.PoolNodeCount))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.TrainingInfo != input.TrainingInfo || (this.TrainingInfo != null && !this.TrainingInfo.Equals(input.TrainingInfo))) return false;
            if (this.TrainOutputPath != input.TrainOutputPath || (this.TrainOutputPath != null && !this.TrainOutputPath.Equals(input.TrainOutputPath))) return false;
            if (this.AssetCapabilities != input.AssetCapabilities || (this.AssetCapabilities != null && input.AssetCapabilities != null && !this.AssetCapabilities.SequenceEqual(input.AssetCapabilities))) return false;
            if (this.ContinueTask != input.ContinueTask || (this.ContinueTask != null && !this.ContinueTask.Equals(input.ContinueTask))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskDesc != null) hashCode = hashCode * 59 + this.TaskDesc.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Spec != null) hashCode = hashCode * 59 + this.Spec.GetHashCode();
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                if (this.ModelType != null) hashCode = hashCode * 59 + this.ModelType.GetHashCode();
                if (this.ModelSource != null) hashCode = hashCode * 59 + this.ModelSource.GetHashCode();
                if (this.TrainType != null) hashCode = hashCode * 59 + this.TrainType.GetHashCode();
                if (this.CheckpointConfig != null) hashCode = hashCode * 59 + this.CheckpointConfig.GetHashCode();
                if (this.TaskParameters != null) hashCode = hashCode * 59 + this.TaskParameters.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.TrainProcess != null) hashCode = hashCode * 59 + this.TrainProcess.GetHashCode();
                if (this.DatasetsConfig != null) hashCode = hashCode * 59 + this.DatasetsConfig.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AutoPublishConfig != null) hashCode = hashCode * 59 + this.AutoPublishConfig.GetHashCode();
                if (this.AssetCode != null) hashCode = hashCode * 59 + this.AssetCode.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetDesc != null) hashCode = hashCode * 59 + this.AssetDesc.GetHashCode();
                if (this.AssetSeries != null) hashCode = hashCode * 59 + this.AssetSeries.GetHashCode();
                if (this.AssetVersion != null) hashCode = hashCode * 59 + this.AssetVersion.GetHashCode();
                if (this.AssetType != null) hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.AssetSource != null) hashCode = hashCode * 59 + this.AssetSource.GetHashCode();
                if (this.AssetGroupId != null) hashCode = hashCode * 59 + this.AssetGroupId.GetHashCode();
                if (this.SubAssetType != null) hashCode = hashCode * 59 + this.SubAssetType.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.RootAssetId != null) hashCode = hashCode * 59 + this.RootAssetId.GetHashCode();
                if (this.TrainCostTime != null) hashCode = hashCode * 59 + this.TrainCostTime.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.PoolType != null) hashCode = hashCode * 59 + this.PoolType.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.PoolNodeCount != null) hashCode = hashCode * 59 + this.PoolNodeCount.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.TrainingInfo != null) hashCode = hashCode * 59 + this.TrainingInfo.GetHashCode();
                if (this.TrainOutputPath != null) hashCode = hashCode * 59 + this.TrainOutputPath.GetHashCode();
                if (this.AssetCapabilities != null) hashCode = hashCode * 59 + this.AssetCapabilities.GetHashCode();
                if (this.ContinueTask != null) hashCode = hashCode * 59 + this.ContinueTask.GetHashCode();
                return hashCode;
            }
        }
    }
}
