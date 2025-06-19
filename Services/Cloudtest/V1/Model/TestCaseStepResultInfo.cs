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
    /// 用例步骤结果信息
    /// </summary>
    public class TestCaseStepResultInfo 
    {

        /// <summary>
        /// 步骤结果值
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 步骤实际结果
        /// </summary>
        [JsonProperty("actual_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ActualResult { get; set; }

        /// <summary>
        /// 步骤期望结果
        /// </summary>
        [JsonProperty("expect_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectResult { get; set; }

        /// <summary>
        /// 用例操作步骤
        /// </summary>
        [JsonProperty("test_step", NullValueHandling = NullValueHandling.Ignore)]
        public string TestStep { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseStepResultInfo {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  actualResult: ").Append(ActualResult).Append("\n");
            sb.Append("  expectResult: ").Append(ExpectResult).Append("\n");
            sb.Append("  testStep: ").Append(TestStep).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseStepResultInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseStepResultInfo input)
        {
            if (input == null) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.ActualResult != input.ActualResult || (this.ActualResult != null && !this.ActualResult.Equals(input.ActualResult))) return false;
            if (this.ExpectResult != input.ExpectResult || (this.ExpectResult != null && !this.ExpectResult.Equals(input.ExpectResult))) return false;
            if (this.TestStep != input.TestStep || (this.TestStep != null && !this.TestStep.Equals(input.TestStep))) return false;

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
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.ActualResult != null) hashCode = hashCode * 59 + this.ActualResult.GetHashCode();
                if (this.ExpectResult != null) hashCode = hashCode * 59 + this.ExpectResult.GetHashCode();
                if (this.TestStep != null) hashCode = hashCode * 59 + this.TestStep.GetHashCode();
                return hashCode;
            }
        }
    }
}
