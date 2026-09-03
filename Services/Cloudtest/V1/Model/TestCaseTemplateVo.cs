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
    public class TestCaseTemplateVo 
    {

        /// <summary>
        /// 用例对应的告警模板id
        /// </summary>
        [JsonProperty("alertTemplateId", NullValueHandling = NullValueHandling.Ignore)]
        public string AlertTemplateId { get; set; }

        /// <summary>
        /// 测试用例id
        /// </summary>
        [JsonProperty("testcase_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestCaseTemplateVo {\n");
            sb.Append("  alertTemplateId: ").Append(AlertTemplateId).Append("\n");
            sb.Append("  testcaseId: ").Append(TestcaseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestCaseTemplateVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestCaseTemplateVo input)
        {
            if (input == null) return false;
            if (this.AlertTemplateId != input.AlertTemplateId || (this.AlertTemplateId != null && !this.AlertTemplateId.Equals(input.AlertTemplateId))) return false;
            if (this.TestcaseId != input.TestcaseId || (this.TestcaseId != null && !this.TestcaseId.Equals(input.TestcaseId))) return false;

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
                if (this.AlertTemplateId != null) hashCode = hashCode * 59 + this.AlertTemplateId.GetHashCode();
                if (this.TestcaseId != null) hashCode = hashCode * 59 + this.TestcaseId.GetHashCode();
                return hashCode;
            }
        }
    }
}
