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
    /// Response Object
    /// </summary>
    public class CreateApiTestSuiteByRepoFileResponse : SdkResponse
    {

        /// <summary>
        /// 生成的测试套的id
        /// </summary>
        [JsonProperty("testsuite_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TestsuiteId { get; set; }

        /// <summary>
        /// 生成的测试用例id列表
        /// </summary>
        [JsonProperty("testcase_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TestcaseIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateApiTestSuiteByRepoFileResponse {\n");
            sb.Append("  testsuiteId: ").Append(TestsuiteId).Append("\n");
            sb.Append("  testcaseIds: ").Append(TestcaseIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateApiTestSuiteByRepoFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateApiTestSuiteByRepoFileResponse input)
        {
            if (input == null) return false;
            if (this.TestsuiteId != input.TestsuiteId || (this.TestsuiteId != null && !this.TestsuiteId.Equals(input.TestsuiteId))) return false;
            if (this.TestcaseIds != input.TestcaseIds || (this.TestcaseIds != null && input.TestcaseIds != null && !this.TestcaseIds.SequenceEqual(input.TestcaseIds))) return false;

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
                if (this.TestsuiteId != null) hashCode = hashCode * 59 + this.TestsuiteId.GetHashCode();
                if (this.TestcaseIds != null) hashCode = hashCode * 59 + this.TestcaseIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
