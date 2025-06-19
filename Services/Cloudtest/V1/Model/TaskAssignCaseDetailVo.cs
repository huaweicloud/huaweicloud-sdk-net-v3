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
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class TaskAssignCaseDetailVo 
    {

        /// <summary>
        /// 关联关系uri
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sort { get; set; }

        /// <summary>
        /// 责任人id
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 测试阶段
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public int? Stage { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 任务uri
        /// </summary>
        [JsonProperty("task_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskUri { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("updator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatorName { get; set; }

        /// <summary>
        /// 更新人id
        /// </summary>
        [JsonProperty("updator", NullValueHandling = NullValueHandling.Ignore)]
        public string Updator { get; set; }

        /// <summary>
        /// 用例uri
        /// </summary>
        [JsonProperty("case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseUri { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [JsonProperty("is_available", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAvailable { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("test_case_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseName { get; set; }

        /// <summary>
        /// 用例目录Uri
        /// </summary>
        [JsonProperty("feature_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string FeatureUri { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("test_case_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseNumber { get; set; }

        /// <summary>
        /// 脚本路径
        /// </summary>
        [JsonProperty("svn_script_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SvnScriptPath { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusCode { get; set; }

        /// <summary>
        /// 状态名称
        /// </summary>
        [JsonProperty("status_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusName { get; set; }

        /// <summary>
        /// 结果id
        /// </summary>
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果名称
        /// </summary>
        [JsonProperty("result_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultName { get; set; }

        /// <summary>
        /// 责任人名称
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 最新执行时间
        /// </summary>
        [JsonProperty("execute_latest_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ExecuteLatestTime { get; set; }

        /// <summary>
        /// 执行时长
        /// </summary>
        [JsonProperty("execute_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteDuration { get; set; }

        /// <summary>
        /// 是否是关键用例
        /// </summary>
        [JsonProperty("is_keyword", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsKeyword { get; set; }

        /// <summary>
        /// 脚本名称
        /// </summary>
        [JsonProperty("net_work_script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NetWorkScriptName { get; set; }

        /// <summary>
        /// 用例等级
        /// </summary>
        [JsonProperty("rank_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RankId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskAssignCaseDetailVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  taskUri: ").Append(TaskUri).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updatorName: ").Append(UpdatorName).Append("\n");
            sb.Append("  updator: ").Append(Updator).Append("\n");
            sb.Append("  caseUri: ").Append(CaseUri).Append("\n");
            sb.Append("  isAvailable: ").Append(IsAvailable).Append("\n");
            sb.Append("  testCaseName: ").Append(TestCaseName).Append("\n");
            sb.Append("  featureUri: ").Append(FeatureUri).Append("\n");
            sb.Append("  testCaseNumber: ").Append(TestCaseNumber).Append("\n");
            sb.Append("  svnScriptPath: ").Append(SvnScriptPath).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  statusName: ").Append(StatusName).Append("\n");
            sb.Append("  resultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  resultName: ").Append(ResultName).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  executeLatestTime: ").Append(ExecuteLatestTime).Append("\n");
            sb.Append("  executeDuration: ").Append(ExecuteDuration).Append("\n");
            sb.Append("  isKeyword: ").Append(IsKeyword).Append("\n");
            sb.Append("  netWorkScriptName: ").Append(NetWorkScriptName).Append("\n");
            sb.Append("  rankId: ").Append(RankId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskAssignCaseDetailVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskAssignCaseDetailVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.TaskUri != input.TaskUri || (this.TaskUri != null && !this.TaskUri.Equals(input.TaskUri))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdatorName != input.UpdatorName || (this.UpdatorName != null && !this.UpdatorName.Equals(input.UpdatorName))) return false;
            if (this.Updator != input.Updator || (this.Updator != null && !this.Updator.Equals(input.Updator))) return false;
            if (this.CaseUri != input.CaseUri || (this.CaseUri != null && !this.CaseUri.Equals(input.CaseUri))) return false;
            if (this.IsAvailable != input.IsAvailable || (this.IsAvailable != null && !this.IsAvailable.Equals(input.IsAvailable))) return false;
            if (this.TestCaseName != input.TestCaseName || (this.TestCaseName != null && !this.TestCaseName.Equals(input.TestCaseName))) return false;
            if (this.FeatureUri != input.FeatureUri || (this.FeatureUri != null && !this.FeatureUri.Equals(input.FeatureUri))) return false;
            if (this.TestCaseNumber != input.TestCaseNumber || (this.TestCaseNumber != null && !this.TestCaseNumber.Equals(input.TestCaseNumber))) return false;
            if (this.SvnScriptPath != input.SvnScriptPath || (this.SvnScriptPath != null && !this.SvnScriptPath.Equals(input.SvnScriptPath))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.StatusName != input.StatusName || (this.StatusName != null && !this.StatusName.Equals(input.StatusName))) return false;
            if (this.ResultCode != input.ResultCode || (this.ResultCode != null && !this.ResultCode.Equals(input.ResultCode))) return false;
            if (this.ResultName != input.ResultName || (this.ResultName != null && !this.ResultName.Equals(input.ResultName))) return false;
            if (this.OwnerName != input.OwnerName || (this.OwnerName != null && !this.OwnerName.Equals(input.OwnerName))) return false;
            if (this.ExecuteLatestTime != input.ExecuteLatestTime || (this.ExecuteLatestTime != null && !this.ExecuteLatestTime.Equals(input.ExecuteLatestTime))) return false;
            if (this.ExecuteDuration != input.ExecuteDuration || (this.ExecuteDuration != null && !this.ExecuteDuration.Equals(input.ExecuteDuration))) return false;
            if (this.IsKeyword != input.IsKeyword || (this.IsKeyword != null && !this.IsKeyword.Equals(input.IsKeyword))) return false;
            if (this.NetWorkScriptName != input.NetWorkScriptName || (this.NetWorkScriptName != null && !this.NetWorkScriptName.Equals(input.NetWorkScriptName))) return false;
            if (this.RankId != input.RankId || (this.RankId != null && !this.RankId.Equals(input.RankId))) return false;

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
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.TaskUri != null) hashCode = hashCode * 59 + this.TaskUri.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdatorName != null) hashCode = hashCode * 59 + this.UpdatorName.GetHashCode();
                if (this.Updator != null) hashCode = hashCode * 59 + this.Updator.GetHashCode();
                if (this.CaseUri != null) hashCode = hashCode * 59 + this.CaseUri.GetHashCode();
                if (this.IsAvailable != null) hashCode = hashCode * 59 + this.IsAvailable.GetHashCode();
                if (this.TestCaseName != null) hashCode = hashCode * 59 + this.TestCaseName.GetHashCode();
                if (this.FeatureUri != null) hashCode = hashCode * 59 + this.FeatureUri.GetHashCode();
                if (this.TestCaseNumber != null) hashCode = hashCode * 59 + this.TestCaseNumber.GetHashCode();
                if (this.SvnScriptPath != null) hashCode = hashCode * 59 + this.SvnScriptPath.GetHashCode();
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.StatusName != null) hashCode = hashCode * 59 + this.StatusName.GetHashCode();
                if (this.ResultCode != null) hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.ResultName != null) hashCode = hashCode * 59 + this.ResultName.GetHashCode();
                if (this.OwnerName != null) hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.ExecuteLatestTime != null) hashCode = hashCode * 59 + this.ExecuteLatestTime.GetHashCode();
                if (this.ExecuteDuration != null) hashCode = hashCode * 59 + this.ExecuteDuration.GetHashCode();
                if (this.IsKeyword != null) hashCode = hashCode * 59 + this.IsKeyword.GetHashCode();
                if (this.NetWorkScriptName != null) hashCode = hashCode * 59 + this.NetWorkScriptName.GetHashCode();
                if (this.RankId != null) hashCode = hashCode * 59 + this.RankId.GetHashCode();
                return hashCode;
            }
        }
    }
}
