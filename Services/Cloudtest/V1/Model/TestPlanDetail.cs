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
    /// 测试计划详情
    /// </summary>
    public class TestPlanDetail 
    {

        /// <summary>
        /// 测试计划id
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 测试计划名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 测试计划开始时间
        /// </summary>
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// 测试计划截止时间
        /// </summary>
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 测试计划实际完成时间（测试计划实际完成指测试计划下所有测试用例处于完成状态）
        /// </summary>
        [JsonProperty("finish_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FinishDate { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 当前测试计划所处的阶段
        /// </summary>
        [JsonProperty("current_stage", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentStage { get; set; }

        /// <summary>
        /// 获取超期时间,正值表示已超期
        /// </summary>
        [JsonProperty("expire_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpireDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public TestPlanDetailCreator Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public TestPlanDetailOwner Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("design_stage", NullValueHandling = NullValueHandling.Ignore)]
        public TestPlanDetailDesignStage DesignStage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("execute_stage", NullValueHandling = NullValueHandling.Ignore)]
        public TestPlanDetailExecuteStage ExecuteStage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("report_stage", NullValueHandling = NullValueHandling.Ignore)]
        public TestPlanDetailReportStage ReportStage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iteration", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndId Iteration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestPlanDetail {\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  finishDate: ").Append(FinishDate).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  currentStage: ").Append(CurrentStage).Append("\n");
            sb.Append("  expireDay: ").Append(ExpireDay).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  designStage: ").Append(DesignStage).Append("\n");
            sb.Append("  executeStage: ").Append(ExecuteStage).Append("\n");
            sb.Append("  reportStage: ").Append(ReportStage).Append("\n");
            sb.Append("  iteration: ").Append(Iteration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestPlanDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestPlanDetail input)
        {
            if (input == null) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.FinishDate != input.FinishDate || (this.FinishDate != null && !this.FinishDate.Equals(input.FinishDate))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CurrentStage != input.CurrentStage || (this.CurrentStage != null && !this.CurrentStage.Equals(input.CurrentStage))) return false;
            if (this.ExpireDay != input.ExpireDay || (this.ExpireDay != null && !this.ExpireDay.Equals(input.ExpireDay))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.DesignStage != input.DesignStage || (this.DesignStage != null && !this.DesignStage.Equals(input.DesignStage))) return false;
            if (this.ExecuteStage != input.ExecuteStage || (this.ExecuteStage != null && !this.ExecuteStage.Equals(input.ExecuteStage))) return false;
            if (this.ReportStage != input.ReportStage || (this.ReportStage != null && !this.ReportStage.Equals(input.ReportStage))) return false;
            if (this.Iteration != input.Iteration || (this.Iteration != null && !this.Iteration.Equals(input.Iteration))) return false;

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
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.FinishDate != null) hashCode = hashCode * 59 + this.FinishDate.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CurrentStage != null) hashCode = hashCode * 59 + this.CurrentStage.GetHashCode();
                if (this.ExpireDay != null) hashCode = hashCode * 59 + this.ExpireDay.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.DesignStage != null) hashCode = hashCode * 59 + this.DesignStage.GetHashCode();
                if (this.ExecuteStage != null) hashCode = hashCode * 59 + this.ExecuteStage.GetHashCode();
                if (this.ReportStage != null) hashCode = hashCode * 59 + this.ReportStage.GetHashCode();
                if (this.Iteration != null) hashCode = hashCode * 59 + this.Iteration.GetHashCode();
                return hashCode;
            }
        }
    }
}
