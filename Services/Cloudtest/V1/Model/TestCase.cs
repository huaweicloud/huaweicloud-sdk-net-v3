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
    public class TestCase 
    {

        /// <summary>
        /// 自动化类型
        /// </summary>
        [JsonProperty("auto_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoType { get; set; }

        /// <summary>
        /// 用例设计描述
        /// </summary>
        [JsonProperty("case_design_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseDesignDesc { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseName { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("case_num", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseNum { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建人名字
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonProperty("creator_num", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorNum { get; set; }

        /// <summary>
        /// 删除状态
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public string Deleted { get; set; }

        /// <summary>
        /// 预期结果
        /// </summary>
        [JsonProperty("expected_results", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedResults { get; set; }

        /// <summary>
        /// 额外模板字段：以json形式存储，前台解析
        /// </summary>
        [JsonProperty("extra_param", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 因子组合json
        /// </summary>
        [JsonProperty("factor_combination_json", NullValueHandling = NullValueHandling.Ignore)]
        public string FactorCombinationJson { get; set; }

        /// <summary>
        /// 操作及预期结果
        /// </summary>
        [JsonProperty("operation_and_expected_result", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationAndExpectedResult { get; set; }

        /// <summary>
        /// id 主键
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("is_archive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsArchive { get; set; }

        /// <summary>
        /// 脑图id
        /// </summary>
        [JsonProperty("mindmap_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MindmapId { get; set; }

        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [JsonProperty("batch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchId { get; set; }

        /// <summary>
        /// 分支ID
        /// </summary>
        [JsonProperty("branch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchId { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 用例前置步骤
        /// </summary>
        [JsonProperty("prerequisite", NullValueHandling = NullValueHandling.Ignore)]
        public string Prerequisite { get; set; }

        /// <summary>
        /// 测试用例级别
        /// </summary>
        [JsonProperty("test_case_level", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseLevel { get; set; }

        /// <summary>
        /// 测试步骤
        /// </summary>
        [JsonProperty("test_procedure", NullValueHandling = NullValueHandling.Ignore)]
        public string TestProcedure { get; set; }

        /// <summary>
        /// 更新人名字
        /// </summary>
        [JsonProperty("update_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateName { get; set; }

        /// <summary>
        /// 更新人工号
        /// </summary>
        [JsonProperty("update_num", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateNum { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// url
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// uri
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCase {\n");
            sb.Append("  autoType: ").Append(AutoType).Append("\n");
            sb.Append("  caseDesignDesc: ").Append(CaseDesignDesc).Append("\n");
            sb.Append("  caseName: ").Append(CaseName).Append("\n");
            sb.Append("  caseNum: ").Append(CaseNum).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  creatorNum: ").Append(CreatorNum).Append("\n");
            sb.Append("  deleted: ").Append(Deleted).Append("\n");
            sb.Append("  expectedResults: ").Append(ExpectedResults).Append("\n");
            sb.Append("  extraParam: ").Append(ExtraParam).Append("\n");
            sb.Append("  factorCombinationJson: ").Append(FactorCombinationJson).Append("\n");
            sb.Append("  operationAndExpectedResult: ").Append(OperationAndExpectedResult).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isArchive: ").Append(IsArchive).Append("\n");
            sb.Append("  mindmapId: ").Append(MindmapId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  batchId: ").Append(BatchId).Append("\n");
            sb.Append("  branchId: ").Append(BranchId).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  prerequisite: ").Append(Prerequisite).Append("\n");
            sb.Append("  testCaseLevel: ").Append(TestCaseLevel).Append("\n");
            sb.Append("  testProcedure: ").Append(TestProcedure).Append("\n");
            sb.Append("  updateName: ").Append(UpdateName).Append("\n");
            sb.Append("  updateNum: ").Append(UpdateNum).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCase input)
        {
            if (input == null) return false;
            if (this.AutoType != input.AutoType || (this.AutoType != null && !this.AutoType.Equals(input.AutoType))) return false;
            if (this.CaseDesignDesc != input.CaseDesignDesc || (this.CaseDesignDesc != null && !this.CaseDesignDesc.Equals(input.CaseDesignDesc))) return false;
            if (this.CaseName != input.CaseName || (this.CaseName != null && !this.CaseName.Equals(input.CaseName))) return false;
            if (this.CaseNum != input.CaseNum || (this.CaseNum != null && !this.CaseNum.Equals(input.CaseNum))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.CreatorNum != input.CreatorNum || (this.CreatorNum != null && !this.CreatorNum.Equals(input.CreatorNum))) return false;
            if (this.Deleted != input.Deleted || (this.Deleted != null && !this.Deleted.Equals(input.Deleted))) return false;
            if (this.ExpectedResults != input.ExpectedResults || (this.ExpectedResults != null && !this.ExpectedResults.Equals(input.ExpectedResults))) return false;
            if (this.ExtraParam != input.ExtraParam || (this.ExtraParam != null && !this.ExtraParam.Equals(input.ExtraParam))) return false;
            if (this.FactorCombinationJson != input.FactorCombinationJson || (this.FactorCombinationJson != null && !this.FactorCombinationJson.Equals(input.FactorCombinationJson))) return false;
            if (this.OperationAndExpectedResult != input.OperationAndExpectedResult || (this.OperationAndExpectedResult != null && !this.OperationAndExpectedResult.Equals(input.OperationAndExpectedResult))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsArchive != input.IsArchive || (this.IsArchive != null && !this.IsArchive.Equals(input.IsArchive))) return false;
            if (this.MindmapId != input.MindmapId || (this.MindmapId != null && !this.MindmapId.Equals(input.MindmapId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.BatchId != input.BatchId || (this.BatchId != null && !this.BatchId.Equals(input.BatchId))) return false;
            if (this.BranchId != input.BranchId || (this.BranchId != null && !this.BranchId.Equals(input.BranchId))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.Prerequisite != input.Prerequisite || (this.Prerequisite != null && !this.Prerequisite.Equals(input.Prerequisite))) return false;
            if (this.TestCaseLevel != input.TestCaseLevel || (this.TestCaseLevel != null && !this.TestCaseLevel.Equals(input.TestCaseLevel))) return false;
            if (this.TestProcedure != input.TestProcedure || (this.TestProcedure != null && !this.TestProcedure.Equals(input.TestProcedure))) return false;
            if (this.UpdateName != input.UpdateName || (this.UpdateName != null && !this.UpdateName.Equals(input.UpdateName))) return false;
            if (this.UpdateNum != input.UpdateNum || (this.UpdateNum != null && !this.UpdateNum.Equals(input.UpdateNum))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;

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
                if (this.AutoType != null) hashCode = hashCode * 59 + this.AutoType.GetHashCode();
                if (this.CaseDesignDesc != null) hashCode = hashCode * 59 + this.CaseDesignDesc.GetHashCode();
                if (this.CaseName != null) hashCode = hashCode * 59 + this.CaseName.GetHashCode();
                if (this.CaseNum != null) hashCode = hashCode * 59 + this.CaseNum.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.CreatorNum != null) hashCode = hashCode * 59 + this.CreatorNum.GetHashCode();
                if (this.Deleted != null) hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.ExpectedResults != null) hashCode = hashCode * 59 + this.ExpectedResults.GetHashCode();
                if (this.ExtraParam != null) hashCode = hashCode * 59 + this.ExtraParam.GetHashCode();
                if (this.FactorCombinationJson != null) hashCode = hashCode * 59 + this.FactorCombinationJson.GetHashCode();
                if (this.OperationAndExpectedResult != null) hashCode = hashCode * 59 + this.OperationAndExpectedResult.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsArchive != null) hashCode = hashCode * 59 + this.IsArchive.GetHashCode();
                if (this.MindmapId != null) hashCode = hashCode * 59 + this.MindmapId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.BatchId != null) hashCode = hashCode * 59 + this.BatchId.GetHashCode();
                if (this.BranchId != null) hashCode = hashCode * 59 + this.BranchId.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.Prerequisite != null) hashCode = hashCode * 59 + this.Prerequisite.GetHashCode();
                if (this.TestCaseLevel != null) hashCode = hashCode * 59 + this.TestCaseLevel.GetHashCode();
                if (this.TestProcedure != null) hashCode = hashCode * 59 + this.TestProcedure.GetHashCode();
                if (this.UpdateName != null) hashCode = hashCode * 59 + this.UpdateName.GetHashCode();
                if (this.UpdateNum != null) hashCode = hashCode * 59 + this.UpdateNum.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
