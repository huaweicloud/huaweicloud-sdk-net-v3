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
    /// 任务关联用例信息
    /// </summary>
    public class CaseOperationVo 
    {

        /// <summary>
        /// 用例关联信息
        /// </summary>
        [JsonProperty("test_cases_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskAssignCaseVo> TestCasesInfo { get; set; }

        /// <summary>
        /// 前置用例关联信息
        /// </summary>
        [JsonProperty("set_up_cases_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskAssignCaseVo> SetUpCasesInfo { get; set; }

        /// <summary>
        /// 后置用例关联信息
        /// </summary>
        [JsonProperty("tear_down_cases_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskAssignCaseVo> TearDownCasesInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseOperationVo {\n");
            sb.Append("  testCasesInfo: ").Append(TestCasesInfo).Append("\n");
            sb.Append("  setUpCasesInfo: ").Append(SetUpCasesInfo).Append("\n");
            sb.Append("  tearDownCasesInfo: ").Append(TearDownCasesInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaseOperationVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaseOperationVo input)
        {
            if (input == null) return false;
            if (this.TestCasesInfo != input.TestCasesInfo || (this.TestCasesInfo != null && input.TestCasesInfo != null && !this.TestCasesInfo.SequenceEqual(input.TestCasesInfo))) return false;
            if (this.SetUpCasesInfo != input.SetUpCasesInfo || (this.SetUpCasesInfo != null && input.SetUpCasesInfo != null && !this.SetUpCasesInfo.SequenceEqual(input.SetUpCasesInfo))) return false;
            if (this.TearDownCasesInfo != input.TearDownCasesInfo || (this.TearDownCasesInfo != null && input.TearDownCasesInfo != null && !this.TearDownCasesInfo.SequenceEqual(input.TearDownCasesInfo))) return false;

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
                if (this.TestCasesInfo != null) hashCode = hashCode * 59 + this.TestCasesInfo.GetHashCode();
                if (this.SetUpCasesInfo != null) hashCode = hashCode * 59 + this.SetUpCasesInfo.GetHashCode();
                if (this.TearDownCasesInfo != null) hashCode = hashCode * 59 + this.TearDownCasesInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
