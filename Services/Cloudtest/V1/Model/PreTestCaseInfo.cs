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
    public class PreTestCaseInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alert_template", NullValueHandling = NullValueHandling.Ignore)]
        public AlertTemplate AlertTemplate { get; set; }

        /// <summary>
        /// 0 关闭，1开启
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }

        /// <summary>
        /// 用例列表
        /// </summary>
        [JsonProperty("testCases", NullValueHandling = NullValueHandling.Ignore)]
        public List<TestCaseBasicInfo> TestCases { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreTestCaseInfo {\n");
            sb.Append("  alertTemplate: ").Append(AlertTemplate).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  testCases: ").Append(TestCases).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreTestCaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreTestCaseInfo input)
        {
            if (input == null) return false;
            if (this.AlertTemplate != input.AlertTemplate || (this.AlertTemplate != null && !this.AlertTemplate.Equals(input.AlertTemplate))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.TestCases != input.TestCases || (this.TestCases != null && input.TestCases != null && !this.TestCases.SequenceEqual(input.TestCases))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.TestCases != null) hashCode = hashCode * 59 + this.TestCases.GetHashCode();
                return hashCode;
            }
        }
    }
}
