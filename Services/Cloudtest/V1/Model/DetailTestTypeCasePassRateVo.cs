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
    /// 每个测试类型的用例通过率
    /// </summary>
    public class DetailTestTypeCasePassRateVo 
    {

        /// <summary>
        /// 测试类型
        /// </summary>
        [JsonProperty("test_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TestType { get; set; }

        /// <summary>
        /// 用例通过率
        /// </summary>
        [JsonProperty("case_pass_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CasePassRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetailTestTypeCasePassRateVo {\n");
            sb.Append("  testType: ").Append(TestType).Append("\n");
            sb.Append("  casePassRate: ").Append(CasePassRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetailTestTypeCasePassRateVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetailTestTypeCasePassRateVo input)
        {
            if (input == null) return false;
            if (this.TestType != input.TestType || (this.TestType != null && !this.TestType.Equals(input.TestType))) return false;
            if (this.CasePassRate != input.CasePassRate || (this.CasePassRate != null && !this.CasePassRate.Equals(input.CasePassRate))) return false;

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
                if (this.TestType != null) hashCode = hashCode * 59 + this.TestType.GetHashCode();
                if (this.CasePassRate != null) hashCode = hashCode * 59 + this.CasePassRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
