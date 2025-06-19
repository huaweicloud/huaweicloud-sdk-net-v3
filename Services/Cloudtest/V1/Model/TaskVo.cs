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
    /// 测试任务集合
    /// </summary>
    public class TaskVo 
    {

        /// <summary>
        /// 测试任务URI
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 测试任务名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 测试阶段
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public string Stage { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("author_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorId { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("author_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorName { get; set; }

        /// <summary>
        /// 责任人ID
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 责任人名称
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 父任务URI
        /// </summary>
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 父任务路径
        /// </summary>
        [JsonProperty("parent_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentPath { get; set; }

        /// <summary>
        /// 源任务URI
        /// </summary>
        [JsonProperty("origin_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginUri { get; set; }

        /// <summary>
        /// 版本URI
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 分支URI
        /// </summary>
        [JsonProperty("branch_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchUri { get; set; }

        /// <summary>
        /// 版本名称
        /// </summary>
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("creation_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("create_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateDateTimestamp { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 更新时间时间戳
        /// </summary>
        [JsonProperty("update_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimeTimestamp { get; set; }

        /// <summary>
        /// 关联关系修改时时间
        /// </summary>
        [JsonProperty("relation_change_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RelationChangeTime { get; set; }

        /// <summary>
        /// 关联关系修改时间时间戳
        /// </summary>
        [JsonProperty("relation_change_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? RelationChangeTimeTimestamp { get; set; }

        /// <summary>
        /// 动态任务用例过滤条件
        /// </summary>
        [JsonProperty("test_case_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseCondition { get; set; }

        /// <summary>
        /// 修改人Id
        /// </summary>
        [JsonProperty("updator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatorId { get; set; }

        /// <summary>
        /// 修改人名称
        /// </summary>
        [JsonProperty("updator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatorName { get; set; }

        /// <summary>
        /// 关联关系修改人Id
        /// </summary>
        [JsonProperty("relation_changer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelationChangerId { get; set; }

        /// <summary>
        /// 服务类型ID
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// 服务类型名称
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 标签名称集合
        /// </summary>
        [JsonProperty("tag_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [JsonProperty("module_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        /// <summary>
        /// 模块path
        /// </summary>
        [JsonProperty("module_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ModulePath { get; set; }

        /// <summary>
        /// 模块路径名称
        /// </summary>
        [JsonProperty("module_path_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModulePathName { get; set; }

        /// <summary>
        /// 发布版本号
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("ext_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtParam { get; set; }

        /// <summary>
        /// 执行方式（1：串行，2：并行）
        /// </summary>
        [JsonProperty("execute_way", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteWay { get; set; }

        /// <summary>
        /// 执行类型（0：冒烟，1：定时）
        /// </summary>
        [JsonProperty("execute_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteType { get; set; }

        /// <summary>
        /// 生命周期状态Code
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 生命周期状态名称
        /// </summary>
        [JsonProperty("status_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusName { get; set; }

        /// <summary>
        /// 执行结果Code
        /// </summary>
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResultCode { get; set; }

        /// <summary>
        /// 执行状态名称
        /// </summary>
        [JsonProperty("result_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultName { get; set; }

        /// <summary>
        /// Echo执行状态Code
        /// </summary>
        [JsonProperty("execute_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteStatusCode { get; set; }

        /// <summary>
        /// Echo执行状态名称
        /// </summary>
        [JsonProperty("execute_status_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteStatusName { get; set; }

        /// <summary>
        /// 执行人ID
        /// </summary>
        [JsonProperty("executor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// 执行人名称
        /// </summary>
        [JsonProperty("executor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorName { get; set; }

        /// <summary>
        /// 最近执行时间
        /// </summary>
        [JsonProperty("execute_latest_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExecuteLatestTime { get; set; }

        /// <summary>
        /// 最近执行时间时间戳
        /// </summary>
        [JsonProperty("execute_latest_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExecuteLatestTimeTimestamp { get; set; }

        /// <summary>
        /// 执行时长
        /// </summary>
        [JsonProperty("execute_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteDuration { get; set; }

        /// <summary>
        /// 执行次数
        /// </summary>
        [JsonProperty("execute_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteTimes { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("case_operation_info", NullValueHandling = NullValueHandling.Ignore)]
        public CaseOperationVo CaseOperationInfo { get; set; }

        /// <summary>
        /// 关联用例数
        /// </summary>
        [JsonProperty("assign_case_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssignCaseNum { get; set; }

        /// <summary>
        /// 已完成用例数量
        /// </summary>
        [JsonProperty("finish_case_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FinishCaseNum { get; set; }

        /// <summary>
        /// 关联缺陷数量
        /// </summary>
        [JsonProperty("assign_defect_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssignDefectNum { get; set; }

        /// <summary>
        /// 任务关联用例变更提示信息
        /// </summary>
        [JsonProperty("task_assign_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskAssignMsg { get; set; }

        /// <summary>
        /// 测试套所属迭代uri，非迭代下创建的测试套返回null
        /// </summary>
        [JsonProperty("iterator_version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorVersionUri { get; set; }

        /// <summary>
        /// 用户自定义结果对应的用例数目
        /// </summary>
        [JsonProperty("result_number_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndValueAndCodeVo> ResultNumberList { get; set; }

        /// <summary>
        /// 测试套完成时间
        /// </summary>
        [JsonProperty("finish_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FinishDate { get; set; }

        /// <summary>
        /// 测试套完成时间戳
        /// </summary>
        [JsonProperty("finish_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? FinishDateTimestamp { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [JsonProperty("plan_start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PlanStartDate { get; set; }

        /// <summary>
        /// 计划开始时间戳
        /// </summary>
        [JsonProperty("plan_start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanStartTimestamp { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [JsonProperty("plan_end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PlanEndDate { get; set; }

        /// <summary>
        /// 计划结束时间戳
        /// </summary>
        [JsonProperty("plan_end_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanEndTimestamp { get; set; }

        /// <summary>
        /// 测试套超期状态值，分别为：无状态(null)、未超期(0)、即将超期(1)、已超期(2)、延期完成(3)、按期完成(4)
        /// </summary>
        [JsonProperty("expiration_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpirationStatus { get; set; }

        /// <summary>
        /// 测试套超期状态名称，分别为：无状态(不显示状态)、未超期(Unexpired)、即将超期(About to expire)、已超期(Expired)、延期完成(Delayed completion)、按期完成(On schedule completion)
        /// </summary>
        [JsonProperty("expiration_status_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationStatusName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  authorId: ").Append(AuthorId).Append("\n");
            sb.Append("  authorName: ").Append(AuthorName).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  parentPath: ").Append(ParentPath).Append("\n");
            sb.Append("  originUri: ").Append(OriginUri).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  branchUri: ").Append(BranchUri).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  creationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  createDateTimestamp: ").Append(CreateDateTimestamp).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimeTimestamp: ").Append(UpdateTimeTimestamp).Append("\n");
            sb.Append("  relationChangeTime: ").Append(RelationChangeTime).Append("\n");
            sb.Append("  relationChangeTimeTimestamp: ").Append(RelationChangeTimeTimestamp).Append("\n");
            sb.Append("  testCaseCondition: ").Append(TestCaseCondition).Append("\n");
            sb.Append("  updatorId: ").Append(UpdatorId).Append("\n");
            sb.Append("  updatorName: ").Append(UpdatorName).Append("\n");
            sb.Append("  relationChangerId: ").Append(RelationChangerId).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  tagList: ").Append(TagList).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  moduleName: ").Append(ModuleName).Append("\n");
            sb.Append("  modulePath: ").Append(ModulePath).Append("\n");
            sb.Append("  modulePathName: ").Append(ModulePathName).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  extParam: ").Append(ExtParam).Append("\n");
            sb.Append("  executeWay: ").Append(ExecuteWay).Append("\n");
            sb.Append("  executeType: ").Append(ExecuteType).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  statusName: ").Append(StatusName).Append("\n");
            sb.Append("  resultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  resultName: ").Append(ResultName).Append("\n");
            sb.Append("  executeStatusCode: ").Append(ExecuteStatusCode).Append("\n");
            sb.Append("  executeStatusName: ").Append(ExecuteStatusName).Append("\n");
            sb.Append("  executorId: ").Append(ExecutorId).Append("\n");
            sb.Append("  executorName: ").Append(ExecutorName).Append("\n");
            sb.Append("  executeLatestTime: ").Append(ExecuteLatestTime).Append("\n");
            sb.Append("  executeLatestTimeTimestamp: ").Append(ExecuteLatestTimeTimestamp).Append("\n");
            sb.Append("  executeDuration: ").Append(ExecuteDuration).Append("\n");
            sb.Append("  executeTimes: ").Append(ExecuteTimes).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  caseOperationInfo: ").Append(CaseOperationInfo).Append("\n");
            sb.Append("  assignCaseNum: ").Append(AssignCaseNum).Append("\n");
            sb.Append("  finishCaseNum: ").Append(FinishCaseNum).Append("\n");
            sb.Append("  assignDefectNum: ").Append(AssignDefectNum).Append("\n");
            sb.Append("  taskAssignMsg: ").Append(TaskAssignMsg).Append("\n");
            sb.Append("  iteratorVersionUri: ").Append(IteratorVersionUri).Append("\n");
            sb.Append("  resultNumberList: ").Append(ResultNumberList).Append("\n");
            sb.Append("  finishDate: ").Append(FinishDate).Append("\n");
            sb.Append("  finishDateTimestamp: ").Append(FinishDateTimestamp).Append("\n");
            sb.Append("  planStartDate: ").Append(PlanStartDate).Append("\n");
            sb.Append("  planStartTimestamp: ").Append(PlanStartTimestamp).Append("\n");
            sb.Append("  planEndDate: ").Append(PlanEndDate).Append("\n");
            sb.Append("  planEndTimestamp: ").Append(PlanEndTimestamp).Append("\n");
            sb.Append("  expirationStatus: ").Append(ExpirationStatus).Append("\n");
            sb.Append("  expirationStatusName: ").Append(ExpirationStatusName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.AuthorId != input.AuthorId || (this.AuthorId != null && !this.AuthorId.Equals(input.AuthorId))) return false;
            if (this.AuthorName != input.AuthorName || (this.AuthorName != null && !this.AuthorName.Equals(input.AuthorName))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.OwnerName != input.OwnerName || (this.OwnerName != null && !this.OwnerName.Equals(input.OwnerName))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.ParentPath != input.ParentPath || (this.ParentPath != null && !this.ParentPath.Equals(input.ParentPath))) return false;
            if (this.OriginUri != input.OriginUri || (this.OriginUri != null && !this.OriginUri.Equals(input.OriginUri))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.BranchUri != input.BranchUri || (this.BranchUri != null && !this.BranchUri.Equals(input.BranchUri))) return false;
            if (this.VersionName != input.VersionName || (this.VersionName != null && !this.VersionName.Equals(input.VersionName))) return false;
            if (this.CreationDate != input.CreationDate || (this.CreationDate != null && !this.CreationDate.Equals(input.CreationDate))) return false;
            if (this.CreateDateTimestamp != input.CreateDateTimestamp || (this.CreateDateTimestamp != null && !this.CreateDateTimestamp.Equals(input.CreateDateTimestamp))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimeTimestamp != input.UpdateTimeTimestamp || (this.UpdateTimeTimestamp != null && !this.UpdateTimeTimestamp.Equals(input.UpdateTimeTimestamp))) return false;
            if (this.RelationChangeTime != input.RelationChangeTime || (this.RelationChangeTime != null && !this.RelationChangeTime.Equals(input.RelationChangeTime))) return false;
            if (this.RelationChangeTimeTimestamp != input.RelationChangeTimeTimestamp || (this.RelationChangeTimeTimestamp != null && !this.RelationChangeTimeTimestamp.Equals(input.RelationChangeTimeTimestamp))) return false;
            if (this.TestCaseCondition != input.TestCaseCondition || (this.TestCaseCondition != null && !this.TestCaseCondition.Equals(input.TestCaseCondition))) return false;
            if (this.UpdatorId != input.UpdatorId || (this.UpdatorId != null && !this.UpdatorId.Equals(input.UpdatorId))) return false;
            if (this.UpdatorName != input.UpdatorName || (this.UpdatorName != null && !this.UpdatorName.Equals(input.UpdatorName))) return false;
            if (this.RelationChangerId != input.RelationChangerId || (this.RelationChangerId != null && !this.RelationChangerId.Equals(input.RelationChangerId))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.TagList != input.TagList || (this.TagList != null && input.TagList != null && !this.TagList.SequenceEqual(input.TagList))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.ModuleName != input.ModuleName || (this.ModuleName != null && !this.ModuleName.Equals(input.ModuleName))) return false;
            if (this.ModulePath != input.ModulePath || (this.ModulePath != null && !this.ModulePath.Equals(input.ModulePath))) return false;
            if (this.ModulePathName != input.ModulePathName || (this.ModulePathName != null && !this.ModulePathName.Equals(input.ModulePathName))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.ExtParam != input.ExtParam || (this.ExtParam != null && !this.ExtParam.Equals(input.ExtParam))) return false;
            if (this.ExecuteWay != input.ExecuteWay || (this.ExecuteWay != null && !this.ExecuteWay.Equals(input.ExecuteWay))) return false;
            if (this.ExecuteType != input.ExecuteType || (this.ExecuteType != null && !this.ExecuteType.Equals(input.ExecuteType))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.StatusName != input.StatusName || (this.StatusName != null && !this.StatusName.Equals(input.StatusName))) return false;
            if (this.ResultCode != input.ResultCode || (this.ResultCode != null && !this.ResultCode.Equals(input.ResultCode))) return false;
            if (this.ResultName != input.ResultName || (this.ResultName != null && !this.ResultName.Equals(input.ResultName))) return false;
            if (this.ExecuteStatusCode != input.ExecuteStatusCode || (this.ExecuteStatusCode != null && !this.ExecuteStatusCode.Equals(input.ExecuteStatusCode))) return false;
            if (this.ExecuteStatusName != input.ExecuteStatusName || (this.ExecuteStatusName != null && !this.ExecuteStatusName.Equals(input.ExecuteStatusName))) return false;
            if (this.ExecutorId != input.ExecutorId || (this.ExecutorId != null && !this.ExecutorId.Equals(input.ExecutorId))) return false;
            if (this.ExecutorName != input.ExecutorName || (this.ExecutorName != null && !this.ExecutorName.Equals(input.ExecutorName))) return false;
            if (this.ExecuteLatestTime != input.ExecuteLatestTime || (this.ExecuteLatestTime != null && !this.ExecuteLatestTime.Equals(input.ExecuteLatestTime))) return false;
            if (this.ExecuteLatestTimeTimestamp != input.ExecuteLatestTimeTimestamp || (this.ExecuteLatestTimeTimestamp != null && !this.ExecuteLatestTimeTimestamp.Equals(input.ExecuteLatestTimeTimestamp))) return false;
            if (this.ExecuteDuration != input.ExecuteDuration || (this.ExecuteDuration != null && !this.ExecuteDuration.Equals(input.ExecuteDuration))) return false;
            if (this.ExecuteTimes != input.ExecuteTimes || (this.ExecuteTimes != null && !this.ExecuteTimes.Equals(input.ExecuteTimes))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.CaseOperationInfo != input.CaseOperationInfo || (this.CaseOperationInfo != null && !this.CaseOperationInfo.Equals(input.CaseOperationInfo))) return false;
            if (this.AssignCaseNum != input.AssignCaseNum || (this.AssignCaseNum != null && !this.AssignCaseNum.Equals(input.AssignCaseNum))) return false;
            if (this.FinishCaseNum != input.FinishCaseNum || (this.FinishCaseNum != null && !this.FinishCaseNum.Equals(input.FinishCaseNum))) return false;
            if (this.AssignDefectNum != input.AssignDefectNum || (this.AssignDefectNum != null && !this.AssignDefectNum.Equals(input.AssignDefectNum))) return false;
            if (this.TaskAssignMsg != input.TaskAssignMsg || (this.TaskAssignMsg != null && !this.TaskAssignMsg.Equals(input.TaskAssignMsg))) return false;
            if (this.IteratorVersionUri != input.IteratorVersionUri || (this.IteratorVersionUri != null && !this.IteratorVersionUri.Equals(input.IteratorVersionUri))) return false;
            if (this.ResultNumberList != input.ResultNumberList || (this.ResultNumberList != null && input.ResultNumberList != null && !this.ResultNumberList.SequenceEqual(input.ResultNumberList))) return false;
            if (this.FinishDate != input.FinishDate || (this.FinishDate != null && !this.FinishDate.Equals(input.FinishDate))) return false;
            if (this.FinishDateTimestamp != input.FinishDateTimestamp || (this.FinishDateTimestamp != null && !this.FinishDateTimestamp.Equals(input.FinishDateTimestamp))) return false;
            if (this.PlanStartDate != input.PlanStartDate || (this.PlanStartDate != null && !this.PlanStartDate.Equals(input.PlanStartDate))) return false;
            if (this.PlanStartTimestamp != input.PlanStartTimestamp || (this.PlanStartTimestamp != null && !this.PlanStartTimestamp.Equals(input.PlanStartTimestamp))) return false;
            if (this.PlanEndDate != input.PlanEndDate || (this.PlanEndDate != null && !this.PlanEndDate.Equals(input.PlanEndDate))) return false;
            if (this.PlanEndTimestamp != input.PlanEndTimestamp || (this.PlanEndTimestamp != null && !this.PlanEndTimestamp.Equals(input.PlanEndTimestamp))) return false;
            if (this.ExpirationStatus != input.ExpirationStatus || (this.ExpirationStatus != null && !this.ExpirationStatus.Equals(input.ExpirationStatus))) return false;
            if (this.ExpirationStatusName != input.ExpirationStatusName || (this.ExpirationStatusName != null && !this.ExpirationStatusName.Equals(input.ExpirationStatusName))) return false;

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
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.AuthorId != null) hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.AuthorName != null) hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.OwnerName != null) hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.ParentPath != null) hashCode = hashCode * 59 + this.ParentPath.GetHashCode();
                if (this.OriginUri != null) hashCode = hashCode * 59 + this.OriginUri.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.BranchUri != null) hashCode = hashCode * 59 + this.BranchUri.GetHashCode();
                if (this.VersionName != null) hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.CreationDate != null) hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.CreateDateTimestamp != null) hashCode = hashCode * 59 + this.CreateDateTimestamp.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimeTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimeTimestamp.GetHashCode();
                if (this.RelationChangeTime != null) hashCode = hashCode * 59 + this.RelationChangeTime.GetHashCode();
                if (this.RelationChangeTimeTimestamp != null) hashCode = hashCode * 59 + this.RelationChangeTimeTimestamp.GetHashCode();
                if (this.TestCaseCondition != null) hashCode = hashCode * 59 + this.TestCaseCondition.GetHashCode();
                if (this.UpdatorId != null) hashCode = hashCode * 59 + this.UpdatorId.GetHashCode();
                if (this.UpdatorName != null) hashCode = hashCode * 59 + this.UpdatorName.GetHashCode();
                if (this.RelationChangerId != null) hashCode = hashCode * 59 + this.RelationChangerId.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.TagList != null) hashCode = hashCode * 59 + this.TagList.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.ModuleName != null) hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.ModulePath != null) hashCode = hashCode * 59 + this.ModulePath.GetHashCode();
                if (this.ModulePathName != null) hashCode = hashCode * 59 + this.ModulePathName.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.ExtParam != null) hashCode = hashCode * 59 + this.ExtParam.GetHashCode();
                if (this.ExecuteWay != null) hashCode = hashCode * 59 + this.ExecuteWay.GetHashCode();
                if (this.ExecuteType != null) hashCode = hashCode * 59 + this.ExecuteType.GetHashCode();
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.StatusName != null) hashCode = hashCode * 59 + this.StatusName.GetHashCode();
                if (this.ResultCode != null) hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.ResultName != null) hashCode = hashCode * 59 + this.ResultName.GetHashCode();
                if (this.ExecuteStatusCode != null) hashCode = hashCode * 59 + this.ExecuteStatusCode.GetHashCode();
                if (this.ExecuteStatusName != null) hashCode = hashCode * 59 + this.ExecuteStatusName.GetHashCode();
                if (this.ExecutorId != null) hashCode = hashCode * 59 + this.ExecutorId.GetHashCode();
                if (this.ExecutorName != null) hashCode = hashCode * 59 + this.ExecutorName.GetHashCode();
                if (this.ExecuteLatestTime != null) hashCode = hashCode * 59 + this.ExecuteLatestTime.GetHashCode();
                if (this.ExecuteLatestTimeTimestamp != null) hashCode = hashCode * 59 + this.ExecuteLatestTimeTimestamp.GetHashCode();
                if (this.ExecuteDuration != null) hashCode = hashCode * 59 + this.ExecuteDuration.GetHashCode();
                if (this.ExecuteTimes != null) hashCode = hashCode * 59 + this.ExecuteTimes.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.CaseOperationInfo != null) hashCode = hashCode * 59 + this.CaseOperationInfo.GetHashCode();
                if (this.AssignCaseNum != null) hashCode = hashCode * 59 + this.AssignCaseNum.GetHashCode();
                if (this.FinishCaseNum != null) hashCode = hashCode * 59 + this.FinishCaseNum.GetHashCode();
                if (this.AssignDefectNum != null) hashCode = hashCode * 59 + this.AssignDefectNum.GetHashCode();
                if (this.TaskAssignMsg != null) hashCode = hashCode * 59 + this.TaskAssignMsg.GetHashCode();
                if (this.IteratorVersionUri != null) hashCode = hashCode * 59 + this.IteratorVersionUri.GetHashCode();
                if (this.ResultNumberList != null) hashCode = hashCode * 59 + this.ResultNumberList.GetHashCode();
                if (this.FinishDate != null) hashCode = hashCode * 59 + this.FinishDate.GetHashCode();
                if (this.FinishDateTimestamp != null) hashCode = hashCode * 59 + this.FinishDateTimestamp.GetHashCode();
                if (this.PlanStartDate != null) hashCode = hashCode * 59 + this.PlanStartDate.GetHashCode();
                if (this.PlanStartTimestamp != null) hashCode = hashCode * 59 + this.PlanStartTimestamp.GetHashCode();
                if (this.PlanEndDate != null) hashCode = hashCode * 59 + this.PlanEndDate.GetHashCode();
                if (this.PlanEndTimestamp != null) hashCode = hashCode * 59 + this.PlanEndTimestamp.GetHashCode();
                if (this.ExpirationStatus != null) hashCode = hashCode * 59 + this.ExpirationStatus.GetHashCode();
                if (this.ExpirationStatusName != null) hashCode = hashCode * 59 + this.ExpirationStatusName.GetHashCode();
                return hashCode;
            }
        }
    }
}
