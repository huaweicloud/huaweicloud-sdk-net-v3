using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskInfoV4VoReq 
    {

        /// <summary>
        /// 智能告警开关：0为置灰，1为可用
        /// </summary>
        [JsonProperty("alert_action", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertAction { get; set; }

        /// <summary>
        /// 告警配置
        /// </summary>
        [JsonProperty("alert_config", NullValueHandling = NullValueHandling.Ignore)]
        public Object AlertConfig { get; set; }

        /// <summary>
        /// 流水线启动测试套件，携带构建产物
        /// </summary>
        [JsonProperty("build_products", NullValueHandling = NullValueHandling.Ignore)]
        public List<BuildProduct> BuildProducts { get; set; }

        /// <summary>
        /// 用例环境参数
        /// </summary>
        [JsonProperty("case_package_env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CasePackageEnvName { get; set; }

        /// <summary>
        /// 用例包ID
        /// </summary>
        [JsonProperty("case_package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CasePackageId { get; set; }

        /// <summary>
        /// 用例包名
        /// </summary>
        [JsonProperty("case_package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CasePackageName { get; set; }

        /// <summary>
        /// 用例总数
        /// </summary>
        [JsonProperty("case_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseTotal { get; set; }

        /// <summary>
        /// 客户端类型，deviceTest使用
        /// </summary>
        [JsonProperty("client_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cloudTestSuite_basicInfo", NullValueHandling = NullValueHandling.Ignore)]
        public CloudTestSuiteBasicInfo CloudTestSuiteBasicInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
        public string Comments { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("create_user", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 环境类型：0表示用例包环境，1表示全局环境
        /// </summary>
        [JsonProperty("env_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnvType { get; set; }

        /// <summary>
        /// environmentId环境信息
        /// </summary>
        [JsonProperty("environment_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execute_strategies", NullValueHandling = NullValueHandling.Ignore)]
        public ExecuteStrategiesVo ExecuteStrategies { get; set; }

        /// <summary>
        /// 用例类型
        /// </summary>
        [JsonProperty("executor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorType { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("ext_params", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskExtParam> ExtParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("favorite", NullValueHandling = NullValueHandling.Ignore)]
        public string Favorite { get; set; }

        /// <summary>
        /// 唯一ID，主键
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ipGroup", NullValueHandling = NullValueHandling.Ignore)]
        public IpGroup IpGroup { get; set; }

        /// <summary>
        /// 小网拨测替换application的hostIP
        /// </summary>
        [JsonProperty("ipKey", NullValueHandling = NullValueHandling.Ignore)]
        public string IpKey { get; set; }

        /// <summary>
        /// 任务类型，是否debug任务
        /// </summary>
        [JsonProperty("isDebugTask", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsDebugTask { get; set; }

        /// <summary>
        /// 执行标签
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 资源池名称
        /// </summary>
        [JsonProperty("labelName", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelName { get; set; }

        /// <summary>
        /// 资源池类型
        /// </summary>
        [JsonProperty("labelType", NullValueHandling = NullValueHandling.Ignore)]
        public string LabelType { get; set; }

        /// <summary>
        /// 最近一次停止时间 
        /// </summary>
        [JsonProperty("lastStopTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastStopTime { get; set; }

        /// <summary>
        /// 执行区域，冗余处理，修改更新在执行配置字段
        /// </summary>
        [JsonProperty("location_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LocationIds { get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 测试计划Id
        /// </summary>
        [JsonProperty("planId", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("preTestCaseInfo", NullValueHandling = NullValueHandling.Ignore)]
        public PreTestCaseInfo PreTestCaseInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resourcePool", NullValueHandling = NullValueHandling.Ignore)]
        public ResourcePool ResourcePool { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public int? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subtask_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtaskId { get; set; }

        /// <summary>
        /// 子任务总数
        /// </summary>
        [JsonProperty("subtaskTotal", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubtaskTotal { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("taskTypeId", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskTypeId { get; set; }

        /// <summary>
        /// 测试用例列表
        /// </summary>
        [JsonProperty("testCases", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestCaseBasicInfo> TestCases { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("test_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestServiceId { get; set; }

        /// <summary>
        /// 测试套类型
        /// </summary>
        [JsonProperty("testSuiteType", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestSuiteType { get; set; }

        /// <summary>
        /// 提示信息，用于任务操作过程中需要提供给前端的提示信息
        /// </summary>
        [JsonProperty("tip", NullValueHandling = NullValueHandling.Ignore)]
        public string Tip { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("update_user", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUser { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskInfoV4VoReq {\n");
            sb.Append("  alertAction: ").Append(AlertAction).Append("\n");
            sb.Append("  alertConfig: ").Append(AlertConfig).Append("\n");
            sb.Append("  buildProducts: ").Append(BuildProducts).Append("\n");
            sb.Append("  casePackageEnvName: ").Append(CasePackageEnvName).Append("\n");
            sb.Append("  casePackageId: ").Append(CasePackageId).Append("\n");
            sb.Append("  casePackageName: ").Append(CasePackageName).Append("\n");
            sb.Append("  caseTotal: ").Append(CaseTotal).Append("\n");
            sb.Append("  clientType: ").Append(ClientType).Append("\n");
            sb.Append("  cloudTestSuiteBasicInfo: ").Append(CloudTestSuiteBasicInfo).Append("\n");
            sb.Append("  comments: ").Append(Comments).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createUser: ").Append(CreateUser).Append("\n");
            sb.Append("  envType: ").Append(EnvType).Append("\n");
            sb.Append("  environmentGroupId: ").Append(EnvironmentGroupId).Append("\n");
            sb.Append("  executeStrategies: ").Append(ExecuteStrategies).Append("\n");
            sb.Append("  executorType: ").Append(ExecutorType).Append("\n");
            sb.Append("  extParams: ").Append(ExtParams).Append("\n");
            sb.Append("  favorite: ").Append(Favorite).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ipGroup: ").Append(IpGroup).Append("\n");
            sb.Append("  ipKey: ").Append(IpKey).Append("\n");
            sb.Append("  isDebugTask: ").Append(IsDebugTask).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  labelName: ").Append(LabelName).Append("\n");
            sb.Append("  labelType: ").Append(LabelType).Append("\n");
            sb.Append("  lastStopTime: ").Append(LastStopTime).Append("\n");
            sb.Append("  locationIds: ").Append(LocationIds).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  preTestCaseInfo: ").Append(PreTestCaseInfo).Append("\n");
            sb.Append("  resourcePool: ").Append(ResourcePool).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  subtaskId: ").Append(SubtaskId).Append("\n");
            sb.Append("  subtaskTotal: ").Append(SubtaskTotal).Append("\n");
            sb.Append("  taskTypeId: ").Append(TaskTypeId).Append("\n");
            sb.Append("  testCases: ").Append(TestCases).Append("\n");
            sb.Append("  testServiceId: ").Append(TestServiceId).Append("\n");
            sb.Append("  testSuiteType: ").Append(TestSuiteType).Append("\n");
            sb.Append("  tip: ").Append(Tip).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateUser: ").Append(UpdateUser).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskInfoV4VoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskInfoV4VoReq input)
        {
            if (input == null) return false;
            if (this.AlertAction != input.AlertAction || (this.AlertAction != null && !this.AlertAction.Equals(input.AlertAction))) return false;
            if (this.AlertConfig != input.AlertConfig || (this.AlertConfig != null && !this.AlertConfig.Equals(input.AlertConfig))) return false;
            if (this.BuildProducts != input.BuildProducts || (this.BuildProducts != null && input.BuildProducts != null && !this.BuildProducts.SequenceEqual(input.BuildProducts))) return false;
            if (this.CasePackageEnvName != input.CasePackageEnvName || (this.CasePackageEnvName != null && !this.CasePackageEnvName.Equals(input.CasePackageEnvName))) return false;
            if (this.CasePackageId != input.CasePackageId || (this.CasePackageId != null && !this.CasePackageId.Equals(input.CasePackageId))) return false;
            if (this.CasePackageName != input.CasePackageName || (this.CasePackageName != null && !this.CasePackageName.Equals(input.CasePackageName))) return false;
            if (this.CaseTotal != input.CaseTotal || (this.CaseTotal != null && !this.CaseTotal.Equals(input.CaseTotal))) return false;
            if (this.ClientType != input.ClientType || (this.ClientType != null && !this.ClientType.Equals(input.ClientType))) return false;
            if (this.CloudTestSuiteBasicInfo != input.CloudTestSuiteBasicInfo || (this.CloudTestSuiteBasicInfo != null && !this.CloudTestSuiteBasicInfo.Equals(input.CloudTestSuiteBasicInfo))) return false;
            if (this.Comments != input.Comments || (this.Comments != null && !this.Comments.Equals(input.Comments))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateUser != input.CreateUser || (this.CreateUser != null && !this.CreateUser.Equals(input.CreateUser))) return false;
            if (this.EnvType != input.EnvType || (this.EnvType != null && !this.EnvType.Equals(input.EnvType))) return false;
            if (this.EnvironmentGroupId != input.EnvironmentGroupId || (this.EnvironmentGroupId != null && !this.EnvironmentGroupId.Equals(input.EnvironmentGroupId))) return false;
            if (this.ExecuteStrategies != input.ExecuteStrategies || (this.ExecuteStrategies != null && !this.ExecuteStrategies.Equals(input.ExecuteStrategies))) return false;
            if (this.ExecutorType != input.ExecutorType || (this.ExecutorType != null && !this.ExecutorType.Equals(input.ExecutorType))) return false;
            if (this.ExtParams != input.ExtParams || (this.ExtParams != null && input.ExtParams != null && !this.ExtParams.SequenceEqual(input.ExtParams))) return false;
            if (this.Favorite != input.Favorite || (this.Favorite != null && !this.Favorite.Equals(input.Favorite))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IpGroup != input.IpGroup || (this.IpGroup != null && !this.IpGroup.Equals(input.IpGroup))) return false;
            if (this.IpKey != input.IpKey || (this.IpKey != null && !this.IpKey.Equals(input.IpKey))) return false;
            if (this.IsDebugTask != input.IsDebugTask || (this.IsDebugTask != null && !this.IsDebugTask.Equals(input.IsDebugTask))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.LabelName != input.LabelName || (this.LabelName != null && !this.LabelName.Equals(input.LabelName))) return false;
            if (this.LabelType != input.LabelType || (this.LabelType != null && !this.LabelType.Equals(input.LabelType))) return false;
            if (this.LastStopTime != input.LastStopTime || (this.LastStopTime != null && !this.LastStopTime.Equals(input.LastStopTime))) return false;
            if (this.LocationIds != input.LocationIds || (this.LocationIds != null && input.LocationIds != null && !this.LocationIds.SequenceEqual(input.LocationIds))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.PreTestCaseInfo != input.PreTestCaseInfo || (this.PreTestCaseInfo != null && !this.PreTestCaseInfo.Equals(input.PreTestCaseInfo))) return false;
            if (this.ResourcePool != input.ResourcePool || (this.ResourcePool != null && !this.ResourcePool.Equals(input.ResourcePool))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.SubtaskId != input.SubtaskId || (this.SubtaskId != null && !this.SubtaskId.Equals(input.SubtaskId))) return false;
            if (this.SubtaskTotal != input.SubtaskTotal || (this.SubtaskTotal != null && !this.SubtaskTotal.Equals(input.SubtaskTotal))) return false;
            if (this.TaskTypeId != input.TaskTypeId || (this.TaskTypeId != null && !this.TaskTypeId.Equals(input.TaskTypeId))) return false;
            if (this.TestCases != input.TestCases || (this.TestCases != null && input.TestCases != null && !this.TestCases.SequenceEqual(input.TestCases))) return false;
            if (this.TestServiceId != input.TestServiceId || (this.TestServiceId != null && !this.TestServiceId.Equals(input.TestServiceId))) return false;
            if (this.TestSuiteType != input.TestSuiteType || (this.TestSuiteType != null && !this.TestSuiteType.Equals(input.TestSuiteType))) return false;
            if (this.Tip != input.Tip || (this.Tip != null && !this.Tip.Equals(input.Tip))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateUser != input.UpdateUser || (this.UpdateUser != null && !this.UpdateUser.Equals(input.UpdateUser))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;

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
                if (this.AlertAction != null) hashCode = hashCode * 59 + this.AlertAction.GetHashCode();
                if (this.AlertConfig != null) hashCode = hashCode * 59 + this.AlertConfig.GetHashCode();
                if (this.BuildProducts != null) hashCode = hashCode * 59 + this.BuildProducts.GetHashCode();
                if (this.CasePackageEnvName != null) hashCode = hashCode * 59 + this.CasePackageEnvName.GetHashCode();
                if (this.CasePackageId != null) hashCode = hashCode * 59 + this.CasePackageId.GetHashCode();
                if (this.CasePackageName != null) hashCode = hashCode * 59 + this.CasePackageName.GetHashCode();
                if (this.CaseTotal != null) hashCode = hashCode * 59 + this.CaseTotal.GetHashCode();
                if (this.ClientType != null) hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.CloudTestSuiteBasicInfo != null) hashCode = hashCode * 59 + this.CloudTestSuiteBasicInfo.GetHashCode();
                if (this.Comments != null) hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateUser != null) hashCode = hashCode * 59 + this.CreateUser.GetHashCode();
                if (this.EnvType != null) hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.EnvironmentGroupId != null) hashCode = hashCode * 59 + this.EnvironmentGroupId.GetHashCode();
                if (this.ExecuteStrategies != null) hashCode = hashCode * 59 + this.ExecuteStrategies.GetHashCode();
                if (this.ExecutorType != null) hashCode = hashCode * 59 + this.ExecutorType.GetHashCode();
                if (this.ExtParams != null) hashCode = hashCode * 59 + this.ExtParams.GetHashCode();
                if (this.Favorite != null) hashCode = hashCode * 59 + this.Favorite.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IpGroup != null) hashCode = hashCode * 59 + this.IpGroup.GetHashCode();
                if (this.IpKey != null) hashCode = hashCode * 59 + this.IpKey.GetHashCode();
                if (this.IsDebugTask != null) hashCode = hashCode * 59 + this.IsDebugTask.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.LabelName != null) hashCode = hashCode * 59 + this.LabelName.GetHashCode();
                if (this.LabelType != null) hashCode = hashCode * 59 + this.LabelType.GetHashCode();
                if (this.LastStopTime != null) hashCode = hashCode * 59 + this.LastStopTime.GetHashCode();
                if (this.LocationIds != null) hashCode = hashCode * 59 + this.LocationIds.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.PreTestCaseInfo != null) hashCode = hashCode * 59 + this.PreTestCaseInfo.GetHashCode();
                if (this.ResourcePool != null) hashCode = hashCode * 59 + this.ResourcePool.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SubtaskId != null) hashCode = hashCode * 59 + this.SubtaskId.GetHashCode();
                if (this.SubtaskTotal != null) hashCode = hashCode * 59 + this.SubtaskTotal.GetHashCode();
                if (this.TaskTypeId != null) hashCode = hashCode * 59 + this.TaskTypeId.GetHashCode();
                if (this.TestCases != null) hashCode = hashCode * 59 + this.TestCases.GetHashCode();
                if (this.TestServiceId != null) hashCode = hashCode * 59 + this.TestServiceId.GetHashCode();
                if (this.TestSuiteType != null) hashCode = hashCode * 59 + this.TestSuiteType.GetHashCode();
                if (this.Tip != null) hashCode = hashCode * 59 + this.Tip.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateUser != null) hashCode = hashCode * 59 + this.UpdateUser.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
