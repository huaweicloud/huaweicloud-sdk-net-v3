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
    /// 批量删除测试用例请求体
    /// </summary>
    public class BatchDeleteTestCaseRequestBody 
    {

        /// <summary>
        /// 注册测试类型服务接口返回的服务id，取值范围为10-9999
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 测试用例唯一标识，数组长度小于50个
        /// </summary>
        [JsonProperty("testcase_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TestcaseIdList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteTestCaseRequestBody {\n");
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
            return this.Equals(input as BatchDeleteTestCaseRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteTestCaseRequestBody input)
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
