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
    /// 查询用户用例关联缺陷的统计信息请求体
    /// </summary>
    public class ShowTestCaseAndDefectInfoRequestBody 
    {

        /// <summary>
        /// 起始偏移量，表示从此偏移量开始查询，offset大于等于0，小于等于100000
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量,最大支持100条
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分支ID
        /// </summary>
        [JsonProperty("branch_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchId { get; set; }

        /// <summary>
        /// 用例创建时间段开始
        /// </summary>
        [JsonProperty("create_testcase_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTestcaseStartTime { get; set; }

        /// <summary>
        /// 用例创建时间段截止
        /// </summary>
        [JsonProperty("create_testcase_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTestcaseEndTime { get; set; }

        /// <summary>
        /// 缺陷关联时间段开始
        /// </summary>
        [JsonProperty("associate_defect_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateDefectStartTime { get; set; }

        /// <summary>
        /// 缺陷关联时间段截止
        /// </summary>
        [JsonProperty("associate_defect_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateDefectEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTestCaseAndDefectInfoRequestBody {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  branchId: ").Append(BranchId).Append("\n");
            sb.Append("  createTestcaseStartTime: ").Append(CreateTestcaseStartTime).Append("\n");
            sb.Append("  createTestcaseEndTime: ").Append(CreateTestcaseEndTime).Append("\n");
            sb.Append("  associateDefectStartTime: ").Append(AssociateDefectStartTime).Append("\n");
            sb.Append("  associateDefectEndTime: ").Append(AssociateDefectEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTestCaseAndDefectInfoRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTestCaseAndDefectInfoRequestBody input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.BranchId != input.BranchId || (this.BranchId != null && !this.BranchId.Equals(input.BranchId))) return false;
            if (this.CreateTestcaseStartTime != input.CreateTestcaseStartTime || (this.CreateTestcaseStartTime != null && !this.CreateTestcaseStartTime.Equals(input.CreateTestcaseStartTime))) return false;
            if (this.CreateTestcaseEndTime != input.CreateTestcaseEndTime || (this.CreateTestcaseEndTime != null && !this.CreateTestcaseEndTime.Equals(input.CreateTestcaseEndTime))) return false;
            if (this.AssociateDefectStartTime != input.AssociateDefectStartTime || (this.AssociateDefectStartTime != null && !this.AssociateDefectStartTime.Equals(input.AssociateDefectStartTime))) return false;
            if (this.AssociateDefectEndTime != input.AssociateDefectEndTime || (this.AssociateDefectEndTime != null && !this.AssociateDefectEndTime.Equals(input.AssociateDefectEndTime))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.BranchId != null) hashCode = hashCode * 59 + this.BranchId.GetHashCode();
                if (this.CreateTestcaseStartTime != null) hashCode = hashCode * 59 + this.CreateTestcaseStartTime.GetHashCode();
                if (this.CreateTestcaseEndTime != null) hashCode = hashCode * 59 + this.CreateTestcaseEndTime.GetHashCode();
                if (this.AssociateDefectStartTime != null) hashCode = hashCode * 59 + this.AssociateDefectStartTime.GetHashCode();
                if (this.AssociateDefectEndTime != null) hashCode = hashCode * 59 + this.AssociateDefectEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
