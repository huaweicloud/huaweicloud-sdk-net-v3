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
    public class TestCaseBasicInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alert_template", NullValueHandling = NullValueHandling.Ignore)]
        public AlertTemplate AlertTemplate { get; set; }

        /// <summary>
        /// tmss用例类型
        /// </summary>
        [JsonProperty("caseType", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseType { get; set; }

        /// <summary>
        /// 执行机类型
        /// </summary>
        [JsonProperty("executor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorType { get; set; }

        /// <summary>
        /// 用例id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否收藏
        /// </summary>
        [JsonProperty("is_forbidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForbidden { get; set; }

        /// <summary>
        /// 用例id
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 用例包更新时间
        /// </summary>
        [JsonProperty("project_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProjectUpdateTime { get; set; }

        /// <summary>
        /// 用例包名
        /// </summary>
        [JsonProperty("scriptProjectName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptProjectName { get; set; }

        /// <summary>
        /// 用例状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public int? State { get; set; }

        /// <summary>
        /// svn脚本路径
        /// </summary>
        [JsonProperty("svn_script_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SvnScriptPath { get; set; }

        /// <summary>
        /// tmss版本地址
        /// </summary>
        [JsonProperty("tmssVersionUri", NullValueHandling = NullValueHandling.Ignore)]
        public string TmssVersionUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseBasicInfo {\n");
            sb.Append("  alertTemplate: ").Append(AlertTemplate).Append("\n");
            sb.Append("  caseType: ").Append(CaseType).Append("\n");
            sb.Append("  executorType: ").Append(ExecutorType).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isForbidden: ").Append(IsForbidden).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  projectUpdateTime: ").Append(ProjectUpdateTime).Append("\n");
            sb.Append("  scriptProjectName: ").Append(ScriptProjectName).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  svnScriptPath: ").Append(SvnScriptPath).Append("\n");
            sb.Append("  tmssVersionUri: ").Append(TmssVersionUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseBasicInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseBasicInfo input)
        {
            if (input == null) return false;
            if (this.AlertTemplate != input.AlertTemplate || (this.AlertTemplate != null && !this.AlertTemplate.Equals(input.AlertTemplate))) return false;
            if (this.CaseType != input.CaseType || (this.CaseType != null && !this.CaseType.Equals(input.CaseType))) return false;
            if (this.ExecutorType != input.ExecutorType || (this.ExecutorType != null && !this.ExecutorType.Equals(input.ExecutorType))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsForbidden != input.IsForbidden || (this.IsForbidden != null && !this.IsForbidden.Equals(input.IsForbidden))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.ProjectUpdateTime != input.ProjectUpdateTime || (this.ProjectUpdateTime != null && !this.ProjectUpdateTime.Equals(input.ProjectUpdateTime))) return false;
            if (this.ScriptProjectName != input.ScriptProjectName || (this.ScriptProjectName != null && !this.ScriptProjectName.Equals(input.ScriptProjectName))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.SvnScriptPath != input.SvnScriptPath || (this.SvnScriptPath != null && !this.SvnScriptPath.Equals(input.SvnScriptPath))) return false;
            if (this.TmssVersionUri != input.TmssVersionUri || (this.TmssVersionUri != null && !this.TmssVersionUri.Equals(input.TmssVersionUri))) return false;

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
                if (this.AlertTemplate != null) hashCode = hashCode * 59 + this.AlertTemplate.GetHashCode();
                if (this.CaseType != null) hashCode = hashCode * 59 + this.CaseType.GetHashCode();
                if (this.ExecutorType != null) hashCode = hashCode * 59 + this.ExecutorType.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsForbidden != null) hashCode = hashCode * 59 + this.IsForbidden.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.ProjectUpdateTime != null) hashCode = hashCode * 59 + this.ProjectUpdateTime.GetHashCode();
                if (this.ScriptProjectName != null) hashCode = hashCode * 59 + this.ScriptProjectName.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.SvnScriptPath != null) hashCode = hashCode * 59 + this.SvnScriptPath.GetHashCode();
                if (this.TmssVersionUri != null) hashCode = hashCode * 59 + this.TmssVersionUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
