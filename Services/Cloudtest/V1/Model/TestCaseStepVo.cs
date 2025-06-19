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
    /// 用例测试步骤和预期结果
    /// </summary>
    public class TestCaseStepVo 
    {

        /// <summary>
        /// 测试步骤
        /// </summary>
        [JsonProperty("test_step", NullValueHandling = NullValueHandling.Ignore)]
        public string TestStep { get; set; }

        /// <summary>
        /// 预期结果
        /// </summary>
        [JsonProperty("expect_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseStepVo {\n");
            sb.Append("  testStep: ").Append(TestStep).Append("\n");
            sb.Append("  expectResult: ").Append(ExpectResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseStepVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseStepVo input)
        {
            if (input == null) return false;
            if (this.TestStep != input.TestStep || (this.TestStep != null && !this.TestStep.Equals(input.TestStep))) return false;
            if (this.ExpectResult != input.ExpectResult || (this.ExpectResult != null && !this.ExpectResult.Equals(input.ExpectResult))) return false;

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
                if (this.TestStep != null) hashCode = hashCode * 59 + this.TestStep.GetHashCode();
                if (this.ExpectResult != null) hashCode = hashCode * 59 + this.ExpectResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
