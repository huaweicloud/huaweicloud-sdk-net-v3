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
    public class TestcasePlanQueryParam 
    {

        /// <summary>
        /// 测试用例URI列表（测试用例URI和编号填其中一个即可）
        /// </summary>
        [JsonProperty("case_uri_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CaseUriList { get; set; }

        /// <summary>
        /// 测试用例编号列表（测试用例URI和编号填其中一个即可
        /// </summary>
        [JsonProperty("case_number_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CaseNumberList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestcasePlanQueryParam {\n");
            sb.Append("  caseUriList: ").Append(CaseUriList).Append("\n");
            sb.Append("  caseNumberList: ").Append(CaseNumberList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestcasePlanQueryParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestcasePlanQueryParam input)
        {
            if (input == null) return false;
            if (this.CaseUriList != input.CaseUriList || (this.CaseUriList != null && input.CaseUriList != null && !this.CaseUriList.SequenceEqual(input.CaseUriList))) return false;
            if (this.CaseNumberList != input.CaseNumberList || (this.CaseNumberList != null && input.CaseNumberList != null && !this.CaseNumberList.SequenceEqual(input.CaseNumberList))) return false;

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
                if (this.CaseUriList != null) hashCode = hashCode * 59 + this.CaseUriList.GetHashCode();
                if (this.CaseNumberList != null) hashCode = hashCode * 59 + this.CaseNumberList.GetHashCode();
                return hashCode;
            }
        }
    }
}
