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
    /// 查询质量报告看板统计信息请求体
    /// </summary>
    public class TestReportInfoRequestBody 
    {

        /// <summary>
        /// 测试计划id,(plan_id和branch_id不能同时为空，优先取plan_id)
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 分支id,(plan_id和branch_id不能同时为空，优先取plan_id)
        /// </summary>
        [JsonProperty("branch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchId { get; set; }

        /// <summary>
        /// 模块ID(查询未设置传入-2)
        /// </summary>
        [JsonProperty("module_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 筛选迭代ID(查询未设置传入-2)
        /// </summary>
        [JsonProperty("fixed_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FixedVersionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestReportInfoRequestBody {\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  branchId: ").Append(BranchId).Append("\n");
            sb.Append("  moduleId: ").Append(ModuleId).Append("\n");
            sb.Append("  fixedVersionId: ").Append(FixedVersionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestReportInfoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestReportInfoRequestBody input)
        {
            if (input == null) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.BranchId != input.BranchId || (this.BranchId != null && !this.BranchId.Equals(input.BranchId))) return false;
            if (this.ModuleId != input.ModuleId || (this.ModuleId != null && !this.ModuleId.Equals(input.ModuleId))) return false;
            if (this.FixedVersionId != input.FixedVersionId || (this.FixedVersionId != null && !this.FixedVersionId.Equals(input.FixedVersionId))) return false;

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
                if (this.BranchId != null) hashCode = hashCode * 59 + this.BranchId.GetHashCode();
                if (this.ModuleId != null) hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.FixedVersionId != null) hashCode = hashCode * 59 + this.FixedVersionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
