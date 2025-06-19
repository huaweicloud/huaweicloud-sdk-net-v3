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
    /// 计划中批量添加测试用例请求体
    /// </summary>
    public class CreateTestCaseInPlanRequestBody 
    {

        /// <summary>
        /// 注册测试类型服务接口返回的服务id
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 计划下包含的用例个数，数组长度小于50个，只能包含一种测试类型
        /// </summary>
        [JsonProperty("testcase_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TestcaseIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTestCaseInPlanRequestBody {\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  testcaseIdList: ").Append(TestcaseIdList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTestCaseInPlanRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTestCaseInPlanRequestBody input)
        {
            if (input == null) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.TestcaseIdList != input.TestcaseIdList || (this.TestcaseIdList != null && input.TestcaseIdList != null && !this.TestcaseIdList.SequenceEqual(input.TestcaseIdList))) return false;

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
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.TestcaseIdList != null) hashCode = hashCode * 59 + this.TestcaseIdList.GetHashCode();
                return hashCode;
            }
        }
    }
}
