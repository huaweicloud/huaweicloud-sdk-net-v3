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
    /// 测试套件信息
    /// </summary>
    public class TaskInfo 
    {

        /// <summary>
        /// 指定创建任务的uri
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 分支/迭代uri
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 处理人/责任人id
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 父任务uri
        /// </summary>
        [JsonProperty("parent_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentUri { get; set; }

        /// <summary>
        /// 动态任务用例过滤条件
        /// </summary>
        [JsonProperty("test_case_condition", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseCondition { get; set; }

        /// <summary>
        /// 测试阶段
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public string Stage { get; set; }

        /// <summary>
        /// 服务类型0:功能测试 1:接口测试 11:性能测试
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 标记id
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 模块id
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [JsonProperty("module_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        /// <summary>
        /// 发布版本号
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 状态code
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("ext_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtParam { get; set; }

        /// <summary>
        /// 执行方式 1：串行，2：并行
        /// </summary>
        [JsonProperty("execute_way", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteWay { get; set; }

        /// <summary>
        /// 执行类型（0：冒烟，1：定时）
        /// </summary>
        [JsonProperty("execute_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteType { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 计划开始时间戳，当传入-1时，时间置为空
        /// </summary>
        [JsonProperty("plan_start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanStartTimestamp { get; set; }

        /// <summary>
        /// 计划结束时间戳，当传入-1时，时间置为空
        /// </summary>
        [JsonProperty("plan_end_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanEndTimestamp { get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 任务关联用例uri数组，CloudDragon环境
        /// </summary>
        [JsonProperty("assign_case_uris", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssignCaseUris { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("case_operation_info", NullValueHandling = NullValueHandling.Ignore)]
        public CaseOperationInfo CaseOperationInfo { get; set; }

        /// <summary>
        /// 是否只需要修改测试套状态
        /// </summary>
        [JsonProperty("only_update_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyUpdateStatus { get; set; }

        /// <summary>
        /// 是否异步
        /// </summary>
        [JsonProperty("is_async", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAsync { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskInfo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  parentUri: ").Append(ParentUri).Append("\n");
            sb.Append("  testCaseCondition: ").Append(TestCaseCondition).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  moduleName: ").Append(ModuleName).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  extParam: ").Append(ExtParam).Append("\n");
            sb.Append("  executeWay: ").Append(ExecuteWay).Append("\n");
            sb.Append("  executeType: ").Append(ExecuteType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  planStartTimestamp: ").Append(PlanStartTimestamp).Append("\n");
            sb.Append("  planEndTimestamp: ").Append(PlanEndTimestamp).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  assignCaseUris: ").Append(AssignCaseUris).Append("\n");
            sb.Append("  caseOperationInfo: ").Append(CaseOperationInfo).Append("\n");
            sb.Append("  onlyUpdateStatus: ").Append(OnlyUpdateStatus).Append("\n");
            sb.Append("  isAsync: ").Append(IsAsync).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskInfo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.ParentUri != input.ParentUri || (this.ParentUri != null && !this.ParentUri.Equals(input.ParentUri))) return false;
            if (this.TestCaseCondition != input.TestCaseCondition || (this.TestCaseCondition != null && !this.TestCaseCondition.Equals(input.TestCaseCondition))) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.ModuleName != input.ModuleName || (this.ModuleName != null && !this.ModuleName.Equals(input.ModuleName))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.ExtParam != input.ExtParam || (this.ExtParam != null && !this.ExtParam.Equals(input.ExtParam))) return false;
            if (this.ExecuteWay != input.ExecuteWay || (this.ExecuteWay != null && !this.ExecuteWay.Equals(input.ExecuteWay))) return false;
            if (this.ExecuteType != input.ExecuteType || (this.ExecuteType != null && !this.ExecuteType.Equals(input.ExecuteType))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PlanStartTimestamp != input.PlanStartTimestamp || (this.PlanStartTimestamp != null && !this.PlanStartTimestamp.Equals(input.PlanStartTimestamp))) return false;
            if (this.PlanEndTimestamp != input.PlanEndTimestamp || (this.PlanEndTimestamp != null && !this.PlanEndTimestamp.Equals(input.PlanEndTimestamp))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.AssignCaseUris != input.AssignCaseUris || (this.AssignCaseUris != null && input.AssignCaseUris != null && !this.AssignCaseUris.SequenceEqual(input.AssignCaseUris))) return false;
            if (this.CaseOperationInfo != input.CaseOperationInfo || (this.CaseOperationInfo != null && !this.CaseOperationInfo.Equals(input.CaseOperationInfo))) return false;
            if (this.OnlyUpdateStatus != input.OnlyUpdateStatus || (this.OnlyUpdateStatus != null && !this.OnlyUpdateStatus.Equals(input.OnlyUpdateStatus))) return false;
            if (this.IsAsync != input.IsAsync || (this.IsAsync != null && !this.IsAsync.Equals(input.IsAsync))) return false;

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
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.ParentUri != null) hashCode = hashCode * 59 + this.ParentUri.GetHashCode();
                if (this.TestCaseCondition != null) hashCode = hashCode * 59 + this.TestCaseCondition.GetHashCode();
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.ModuleName != null) hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ExtParam != null) hashCode = hashCode * 59 + this.ExtParam.GetHashCode();
                if (this.ExecuteWay != null) hashCode = hashCode * 59 + this.ExecuteWay.GetHashCode();
                if (this.ExecuteType != null) hashCode = hashCode * 59 + this.ExecuteType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PlanStartTimestamp != null) hashCode = hashCode * 59 + this.PlanStartTimestamp.GetHashCode();
                if (this.PlanEndTimestamp != null) hashCode = hashCode * 59 + this.PlanEndTimestamp.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.AssignCaseUris != null) hashCode = hashCode * 59 + this.AssignCaseUris.GetHashCode();
                if (this.CaseOperationInfo != null) hashCode = hashCode * 59 + this.CaseOperationInfo.GetHashCode();
                if (this.OnlyUpdateStatus != null) hashCode = hashCode * 59 + this.OnlyUpdateStatus.GetHashCode();
                if (this.IsAsync != null) hashCode = hashCode * 59 + this.IsAsync.GetHashCode();
                return hashCode;
            }
        }
    }
}
