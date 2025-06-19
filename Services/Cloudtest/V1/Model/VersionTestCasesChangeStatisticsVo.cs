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
    public class VersionTestCasesChangeStatisticsVo 
    {

        /// <summary>
        /// 新增用例数
        /// </summary>
        [JsonProperty("add_testcases_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddTestcasesNumber { get; set; }

        /// <summary>
        /// 复用用例数
        /// </summary>
        [JsonProperty("reuse_testcases_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReuseTestcasesNumber { get; set; }

        /// <summary>
        /// 修改用例数
        /// </summary>
        [JsonProperty("modifying_testcases_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ModifyingTestcasesNumber { get; set; }

        /// <summary>
        /// 修改时间时间戳
        /// </summary>
        [JsonProperty("update_date_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateDateTimestamp { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("update_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateDate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionTestCasesChangeStatisticsVo {\n");
            sb.Append("  addTestcasesNumber: ").Append(AddTestcasesNumber).Append("\n");
            sb.Append("  reuseTestcasesNumber: ").Append(ReuseTestcasesNumber).Append("\n");
            sb.Append("  modifyingTestcasesNumber: ").Append(ModifyingTestcasesNumber).Append("\n");
            sb.Append("  updateDateTimestamp: ").Append(UpdateDateTimestamp).Append("\n");
            sb.Append("  updateDate: ").Append(UpdateDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionTestCasesChangeStatisticsVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionTestCasesChangeStatisticsVo input)
        {
            if (input == null) return false;
            if (this.AddTestcasesNumber != input.AddTestcasesNumber || (this.AddTestcasesNumber != null && !this.AddTestcasesNumber.Equals(input.AddTestcasesNumber))) return false;
            if (this.ReuseTestcasesNumber != input.ReuseTestcasesNumber || (this.ReuseTestcasesNumber != null && !this.ReuseTestcasesNumber.Equals(input.ReuseTestcasesNumber))) return false;
            if (this.ModifyingTestcasesNumber != input.ModifyingTestcasesNumber || (this.ModifyingTestcasesNumber != null && !this.ModifyingTestcasesNumber.Equals(input.ModifyingTestcasesNumber))) return false;
            if (this.UpdateDateTimestamp != input.UpdateDateTimestamp || (this.UpdateDateTimestamp != null && !this.UpdateDateTimestamp.Equals(input.UpdateDateTimestamp))) return false;
            if (this.UpdateDate != input.UpdateDate || (this.UpdateDate != null && !this.UpdateDate.Equals(input.UpdateDate))) return false;

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
                if (this.AddTestcasesNumber != null) hashCode = hashCode * 59 + this.AddTestcasesNumber.GetHashCode();
                if (this.ReuseTestcasesNumber != null) hashCode = hashCode * 59 + this.ReuseTestcasesNumber.GetHashCode();
                if (this.ModifyingTestcasesNumber != null) hashCode = hashCode * 59 + this.ModifyingTestcasesNumber.GetHashCode();
                if (this.UpdateDateTimestamp != null) hashCode = hashCode * 59 + this.UpdateDateTimestamp.GetHashCode();
                if (this.UpdateDate != null) hashCode = hashCode * 59 + this.UpdateDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
