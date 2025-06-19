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
    public class CreateTestCaseReq 
    {

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("activity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 是否添加到计划
        /// </summary>
        [JsonProperty("addToPlan", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddToPlan { get; set; }

        /// <summary>
        /// 创建时可选择导入的aw目录直接产生测试步骤
        /// </summary>
        [JsonProperty("aw_cata_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<BasicAwCata> AwCataList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("aw_instance", NullValueHandling = NullValueHandling.Ignore)]
        public CaseAwInstance AwInstance { get; set; }

        /// <summary>
        /// 用例类型：0商用现有类型，1从内部导过来的用例类型
        /// </summary>
        [JsonProperty("case_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseType { get; set; }

        /// <summary>
        /// 用例局部变量
        /// </summary>
        [JsonProperty("case_variable_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AwVariable> CaseVariableList { get; set; }

        /// <summary>
        /// 演示标志
        /// </summary>
        [JsonProperty("demoFlag", NullValueHandling = NullValueHandling.Ignore)]
        public string DemoFlag { get; set; }

        /// <summary>
        /// 错误测试阶段
        /// </summary>
        [JsonProperty("errorStep", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ErrorStep { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// import信息List
        /// </summary>
        [JsonProperty("import_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImportInfoList { get; set; }

        /// <summary>
        /// 是否设置为关键字操作
        /// </summary>
        [JsonProperty("isKeyWord", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsKeyWord { get; set; }

        /// <summary>
        /// 是否同步
        /// </summary>
        [JsonProperty("isSync", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSync { get; set; }

        /// <summary>
        /// 问题ID
        /// </summary>
        [JsonProperty("issueId", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 被复制用例的tmsscaseuri
        /// </summary>
        [JsonProperty("old_tmss_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string OldTmssCaseUri { get; set; }

        /// <summary>
        /// 被复制用例的tmsscaseuri列表，内部使用
        /// </summary>
        [JsonProperty("old_tmss_case_uri_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OldTmssCaseUriList { get; set; }

        /// <summary>
        /// 包名
        /// </summary>
        [JsonProperty("package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        /// <summary>
        /// 计划ID
        /// </summary>
        [JsonProperty("planId", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 工程ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 新服务新建用例版本号
        /// </summary>
        [JsonProperty("releaseDev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 脚本名(类名)
        /// </summary>
        [JsonProperty("script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptName { get; set; }

        /// <summary>
        /// 脚本路径
        /// </summary>
        [JsonProperty("script_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptPath { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 来源的方式
        /// </summary>
        [JsonProperty("sourceWay", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceWay { get; set; }

        /// <summary>
        /// 选择用例中测试步骤生成关键字时的原用例tmssCaseUri
        /// </summary>
        [JsonProperty("src_tmss_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcTmssCaseUri { get; set; }

        /// <summary>
        /// tmss用例uri
        /// </summary>
        [JsonProperty("tmss_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TmssCaseUri { get; set; }

        /// <summary>
        /// tmss用例uri
        /// </summary>
        [JsonProperty("tmss_feature_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TmssFeatureUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tmss_property", NullValueHandling = NullValueHandling.Ignore)]
        public TmssTestcase TmssProperty { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 环境参数分组id
        /// </summary>
        [JsonProperty("variableGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public string VariableGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTestCaseReq {\n");
            sb.Append("  activityId: ").Append(ActivityId).Append("\n");
            sb.Append("  addToPlan: ").Append(AddToPlan).Append("\n");
            sb.Append("  awCataList: ").Append(AwCataList).Append("\n");
            sb.Append("  awInstance: ").Append(AwInstance).Append("\n");
            sb.Append("  caseType: ").Append(CaseType).Append("\n");
            sb.Append("  caseVariableList: ").Append(CaseVariableList).Append("\n");
            sb.Append("  demoFlag: ").Append(DemoFlag).Append("\n");
            sb.Append("  errorStep: ").Append(ErrorStep).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  importInfoList: ").Append(ImportInfoList).Append("\n");
            sb.Append("  isKeyWord: ").Append(IsKeyWord).Append("\n");
            sb.Append("  isSync: ").Append(IsSync).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  oldTmssCaseUri: ").Append(OldTmssCaseUri).Append("\n");
            sb.Append("  oldTmssCaseUriList: ").Append(OldTmssCaseUriList).Append("\n");
            sb.Append("  packageName: ").Append(PackageName).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  scriptPath: ").Append(ScriptPath).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  sourceWay: ").Append(SourceWay).Append("\n");
            sb.Append("  srcTmssCaseUri: ").Append(SrcTmssCaseUri).Append("\n");
            sb.Append("  tmssCaseUri: ").Append(TmssCaseUri).Append("\n");
            sb.Append("  tmssFeatureUri: ").Append(TmssFeatureUri).Append("\n");
            sb.Append("  tmssProperty: ").Append(TmssProperty).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  variableGroupId: ").Append(VariableGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTestCaseReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTestCaseReq input)
        {
            if (input == null) return false;
            if (this.ActivityId != input.ActivityId || (this.ActivityId != null && !this.ActivityId.Equals(input.ActivityId))) return false;
            if (this.AddToPlan != input.AddToPlan || (this.AddToPlan != null && !this.AddToPlan.Equals(input.AddToPlan))) return false;
            if (this.AwCataList != input.AwCataList || (this.AwCataList != null && input.AwCataList != null && !this.AwCataList.SequenceEqual(input.AwCataList))) return false;
            if (this.AwInstance != input.AwInstance || (this.AwInstance != null && !this.AwInstance.Equals(input.AwInstance))) return false;
            if (this.CaseType != input.CaseType || (this.CaseType != null && !this.CaseType.Equals(input.CaseType))) return false;
            if (this.CaseVariableList != input.CaseVariableList || (this.CaseVariableList != null && input.CaseVariableList != null && !this.CaseVariableList.SequenceEqual(input.CaseVariableList))) return false;
            if (this.DemoFlag != input.DemoFlag || (this.DemoFlag != null && !this.DemoFlag.Equals(input.DemoFlag))) return false;
            if (this.ErrorStep != input.ErrorStep || (this.ErrorStep != null && input.ErrorStep != null && !this.ErrorStep.SequenceEqual(input.ErrorStep))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ImportInfoList != input.ImportInfoList || (this.ImportInfoList != null && input.ImportInfoList != null && !this.ImportInfoList.SequenceEqual(input.ImportInfoList))) return false;
            if (this.IsKeyWord != input.IsKeyWord || (this.IsKeyWord != null && !this.IsKeyWord.Equals(input.IsKeyWord))) return false;
            if (this.IsSync != input.IsSync || (this.IsSync != null && !this.IsSync.Equals(input.IsSync))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.OldTmssCaseUri != input.OldTmssCaseUri || (this.OldTmssCaseUri != null && !this.OldTmssCaseUri.Equals(input.OldTmssCaseUri))) return false;
            if (this.OldTmssCaseUriList != input.OldTmssCaseUriList || (this.OldTmssCaseUriList != null && input.OldTmssCaseUriList != null && !this.OldTmssCaseUriList.SequenceEqual(input.OldTmssCaseUriList))) return false;
            if (this.PackageName != input.PackageName || (this.PackageName != null && !this.PackageName.Equals(input.PackageName))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && !this.ScriptName.Equals(input.ScriptName))) return false;
            if (this.ScriptPath != input.ScriptPath || (this.ScriptPath != null && !this.ScriptPath.Equals(input.ScriptPath))) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.SourceWay != input.SourceWay || (this.SourceWay != null && !this.SourceWay.Equals(input.SourceWay))) return false;
            if (this.SrcTmssCaseUri != input.SrcTmssCaseUri || (this.SrcTmssCaseUri != null && !this.SrcTmssCaseUri.Equals(input.SrcTmssCaseUri))) return false;
            if (this.TmssCaseUri != input.TmssCaseUri || (this.TmssCaseUri != null && !this.TmssCaseUri.Equals(input.TmssCaseUri))) return false;
            if (this.TmssFeatureUri != input.TmssFeatureUri || (this.TmssFeatureUri != null && !this.TmssFeatureUri.Equals(input.TmssFeatureUri))) return false;
            if (this.TmssProperty != input.TmssProperty || (this.TmssProperty != null && !this.TmssProperty.Equals(input.TmssProperty))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.VariableGroupId != input.VariableGroupId || (this.VariableGroupId != null && !this.VariableGroupId.Equals(input.VariableGroupId))) return false;

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
                if (this.ActivityId != null) hashCode = hashCode * 59 + this.ActivityId.GetHashCode();
                if (this.AddToPlan != null) hashCode = hashCode * 59 + this.AddToPlan.GetHashCode();
                if (this.AwCataList != null) hashCode = hashCode * 59 + this.AwCataList.GetHashCode();
                if (this.AwInstance != null) hashCode = hashCode * 59 + this.AwInstance.GetHashCode();
                if (this.CaseType != null) hashCode = hashCode * 59 + this.CaseType.GetHashCode();
                if (this.CaseVariableList != null) hashCode = hashCode * 59 + this.CaseVariableList.GetHashCode();
                if (this.DemoFlag != null) hashCode = hashCode * 59 + this.DemoFlag.GetHashCode();
                if (this.ErrorStep != null) hashCode = hashCode * 59 + this.ErrorStep.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImportInfoList != null) hashCode = hashCode * 59 + this.ImportInfoList.GetHashCode();
                if (this.IsKeyWord != null) hashCode = hashCode * 59 + this.IsKeyWord.GetHashCode();
                if (this.IsSync != null) hashCode = hashCode * 59 + this.IsSync.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OldTmssCaseUri != null) hashCode = hashCode * 59 + this.OldTmssCaseUri.GetHashCode();
                if (this.OldTmssCaseUriList != null) hashCode = hashCode * 59 + this.OldTmssCaseUriList.GetHashCode();
                if (this.PackageName != null) hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.ScriptPath != null) hashCode = hashCode * 59 + this.ScriptPath.GetHashCode();
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SourceWay != null) hashCode = hashCode * 59 + this.SourceWay.GetHashCode();
                if (this.SrcTmssCaseUri != null) hashCode = hashCode * 59 + this.SrcTmssCaseUri.GetHashCode();
                if (this.TmssCaseUri != null) hashCode = hashCode * 59 + this.TmssCaseUri.GetHashCode();
                if (this.TmssFeatureUri != null) hashCode = hashCode * 59 + this.TmssFeatureUri.GetHashCode();
                if (this.TmssProperty != null) hashCode = hashCode * 59 + this.TmssProperty.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VariableGroupId != null) hashCode = hashCode * 59 + this.VariableGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
