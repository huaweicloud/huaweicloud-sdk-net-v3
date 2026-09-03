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
    public class CloudTestSuiteBasicInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("caseOperationInfo", NullValueHandling = NullValueHandling.Ignore)]
        public CloudTestCaseOperationInfo CaseOperationInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("create_user", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("create_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 数据类型：0为测试套，1为文件夹，cloudTest前台传入
        /// </summary>
        [JsonProperty("doc_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DocType { get; set; }

        /// <summary>
        /// 测试套状态
        /// </summary>
        [JsonProperty("execute_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteStatus { get; set; }

        /// <summary>
        /// 执行总次数
        /// </summary>
        [JsonProperty("execute_times", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteTimes { get; set; }

        /// <summary>
        /// 执行类型：0为冒烟测试，1为定时执行
        /// </summary>
        [JsonProperty("execute_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecuteType { get; set; }

        /// <summary>
        /// 执行方式：1为串行，2为并行，与echo的executeModel字段相同
        /// </summary>
        [JsonProperty("execute_way", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteWay { get; set; }

        /// <summary>
        /// 测试套超期状态
        /// </summary>
        [JsonProperty("expiration_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpirationStatus { get; set; }

        /// <summary>
        /// 参数配置
        /// </summary>
        [JsonProperty("extParam", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtParam { get; set; }

        /// <summary>
        /// 唯一ID，主键
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 测试计划Uri，TMSS需要此值
        /// </summary>
        [JsonProperty("iterator_version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string IteratorVersionUri { get; set; }

        /// <summary>
        /// 模块Id
        /// </summary>
        [JsonProperty("moduleId", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        [JsonProperty("moduleName", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        /// <summary>
        /// 测试套名称，与echo的name字段相同
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 目录Id
        /// </summary>
        [JsonProperty("nodeId", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 处理者ID
        /// </summary>
        [JsonProperty("ownerId", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 测试计划id，可为空
        /// </summary>
        [JsonProperty("planId", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>
        [JsonProperty("plan_end_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanEndTimestamp { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [JsonProperty("plan_start_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlanStartTimestamp { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("projectId", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// 项目UUID，与echo的testServiceId字段相同
        /// </summary>
        [JsonProperty("projectUUId", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUUId { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("releaseDev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 测试套执行结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public int? Result { get; set; }

        /// <summary>
        /// 测试套状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 测试套id，更新时需要同时传id、testSuiteId，2个字段值相同，与echo的taskId字段相同
        /// </summary>
        [JsonProperty("testSuiteId", NullValueHandling = NullValueHandling.Ignore)]
        public string TestSuiteId { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("testSuiteNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TestSuiteNumber { get; set; }

        /// <summary>
        /// 测试套类型：0为功能测试，1为接口测试，6为Pistar，cloudTest前台传入
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("update_user", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUser { get; set; }

        /// <summary>
        /// 更新人ID
        /// </summary>
        [JsonProperty("update_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUserId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudTestSuiteBasicInfo {\n");
            sb.Append("  caseOperationInfo: ").Append(CaseOperationInfo).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createUser: ").Append(CreateUser).Append("\n");
            sb.Append("  createUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  docType: ").Append(DocType).Append("\n");
            sb.Append("  executeStatus: ").Append(ExecuteStatus).Append("\n");
            sb.Append("  executeTimes: ").Append(ExecuteTimes).Append("\n");
            sb.Append("  executeType: ").Append(ExecuteType).Append("\n");
            sb.Append("  executeWay: ").Append(ExecuteWay).Append("\n");
            sb.Append("  expirationStatus: ").Append(ExpirationStatus).Append("\n");
            sb.Append("  extParam: ").Append(ExtParam).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  iteratorVersionUri: ").Append(IteratorVersionUri).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  moduleName: ").Append(ModuleName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  planEndTimestamp: ").Append(PlanEndTimestamp).Append("\n");
            sb.Append("  planStartTimestamp: ").Append(PlanStartTimestamp).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectUUId: ").Append(ProjectUUId).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  testSuiteId: ").Append(TestSuiteId).Append("\n");
            sb.Append("  testSuiteNumber: ").Append(TestSuiteNumber).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateUser: ").Append(UpdateUser).Append("\n");
            sb.Append("  updateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudTestSuiteBasicInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudTestSuiteBasicInfo input)
        {
            if (input == null) return false;
            if (this.CaseOperationInfo != input.CaseOperationInfo || (this.CaseOperationInfo != null && !this.CaseOperationInfo.Equals(input.CaseOperationInfo))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateUser != input.CreateUser || (this.CreateUser != null && !this.CreateUser.Equals(input.CreateUser))) return false;
            if (this.CreateUserId != input.CreateUserId || (this.CreateUserId != null && !this.CreateUserId.Equals(input.CreateUserId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DocType != input.DocType || (this.DocType != null && !this.DocType.Equals(input.DocType))) return false;
            if (this.ExecuteStatus != input.ExecuteStatus || (this.ExecuteStatus != null && !this.ExecuteStatus.Equals(input.ExecuteStatus))) return false;
            if (this.ExecuteTimes != input.ExecuteTimes || (this.ExecuteTimes != null && !this.ExecuteTimes.Equals(input.ExecuteTimes))) return false;
            if (this.ExecuteType != input.ExecuteType || (this.ExecuteType != null && !this.ExecuteType.Equals(input.ExecuteType))) return false;
            if (this.ExecuteWay != input.ExecuteWay || (this.ExecuteWay != null && !this.ExecuteWay.Equals(input.ExecuteWay))) return false;
            if (this.ExpirationStatus != input.ExpirationStatus || (this.ExpirationStatus != null && !this.ExpirationStatus.Equals(input.ExpirationStatus))) return false;
            if (this.ExtParam != input.ExtParam || (this.ExtParam != null && !this.ExtParam.Equals(input.ExtParam))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IteratorVersionUri != input.IteratorVersionUri || (this.IteratorVersionUri != null && !this.IteratorVersionUri.Equals(input.IteratorVersionUri))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.ModuleName != input.ModuleName || (this.ModuleName != null && !this.ModuleName.Equals(input.ModuleName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.PlanEndTimestamp != input.PlanEndTimestamp || (this.PlanEndTimestamp != null && !this.PlanEndTimestamp.Equals(input.PlanEndTimestamp))) return false;
            if (this.PlanStartTimestamp != input.PlanStartTimestamp || (this.PlanStartTimestamp != null && !this.PlanStartTimestamp.Equals(input.PlanStartTimestamp))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectUUId != input.ProjectUUId || (this.ProjectUUId != null && !this.ProjectUUId.Equals(input.ProjectUUId))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.TestSuiteId != input.TestSuiteId || (this.TestSuiteId != null && !this.TestSuiteId.Equals(input.TestSuiteId))) return false;
            if (this.TestSuiteNumber != input.TestSuiteNumber || (this.TestSuiteNumber != null && !this.TestSuiteNumber.Equals(input.TestSuiteNumber))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateUser != input.UpdateUser || (this.UpdateUser != null && !this.UpdateUser.Equals(input.UpdateUser))) return false;
            if (this.UpdateUserId != input.UpdateUserId || (this.UpdateUserId != null && !this.UpdateUserId.Equals(input.UpdateUserId))) return false;

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
                if (this.CaseOperationInfo != null) hashCode = hashCode * 59 + this.CaseOperationInfo.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateUser != null) hashCode = hashCode * 59 + this.CreateUser.GetHashCode();
                if (this.CreateUserId != null) hashCode = hashCode * 59 + this.CreateUserId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DocType != null) hashCode = hashCode * 59 + this.DocType.GetHashCode();
                if (this.ExecuteStatus != null) hashCode = hashCode * 59 + this.ExecuteStatus.GetHashCode();
                if (this.ExecuteTimes != null) hashCode = hashCode * 59 + this.ExecuteTimes.GetHashCode();
                if (this.ExecuteType != null) hashCode = hashCode * 59 + this.ExecuteType.GetHashCode();
                if (this.ExecuteWay != null) hashCode = hashCode * 59 + this.ExecuteWay.GetHashCode();
                if (this.ExpirationStatus != null) hashCode = hashCode * 59 + this.ExpirationStatus.GetHashCode();
                if (this.ExtParam != null) hashCode = hashCode * 59 + this.ExtParam.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IteratorVersionUri != null) hashCode = hashCode * 59 + this.IteratorVersionUri.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.ModuleName != null) hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.PlanEndTimestamp != null) hashCode = hashCode * 59 + this.PlanEndTimestamp.GetHashCode();
                if (this.PlanStartTimestamp != null) hashCode = hashCode * 59 + this.PlanStartTimestamp.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectUUId != null) hashCode = hashCode * 59 + this.ProjectUUId.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TestSuiteId != null) hashCode = hashCode * 59 + this.TestSuiteId.GetHashCode();
                if (this.TestSuiteNumber != null) hashCode = hashCode * 59 + this.TestSuiteNumber.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateUser != null) hashCode = hashCode * 59 + this.UpdateUser.GetHashCode();
                if (this.UpdateUserId != null) hashCode = hashCode * 59 + this.UpdateUserId.GetHashCode();
                return hashCode;
            }
        }
    }
}
