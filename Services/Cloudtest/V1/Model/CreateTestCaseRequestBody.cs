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
    /// 创建测试用例请求体
    /// </summary>
    public class CreateTestCaseRequestBody 
    {

        /// <summary>
        /// 页面上显示的用例名称，长度为[3-128]位字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 该值由注册接口返回,取值范围为10-9999
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 测试用例等级，可选值为[0,1,2,3,4]，不填时默认为2
        /// </summary>
        [JsonProperty("rank_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RankId { get; set; }

        /// <summary>
        /// 用例编号，不填该值时会自动生成，长度为[3-128]位字符
        /// </summary>
        [JsonProperty("testcase_number", NullValueHandling = NullValueHandling.Ignore)]
        public string TestcaseNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalServiceCaseInfo ExtendInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTestCaseRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  rankId: ").Append(RankId).Append("\n");
            sb.Append("  testcaseNumber: ").Append(TestcaseNumber).Append("\n");
            sb.Append("  extendInfo: ").Append(ExtendInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTestCaseRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTestCaseRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.RankId != input.RankId || (this.RankId != null && !this.RankId.Equals(input.RankId))) return false;
            if (this.TestcaseNumber != input.TestcaseNumber || (this.TestcaseNumber != null && !this.TestcaseNumber.Equals(input.TestcaseNumber))) return false;
            if (this.ExtendInfo != input.ExtendInfo || (this.ExtendInfo != null && !this.ExtendInfo.Equals(input.ExtendInfo))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.RankId != null) hashCode = hashCode * 59 + this.RankId.GetHashCode();
                if (this.TestcaseNumber != null) hashCode = hashCode * 59 + this.TestcaseNumber.GetHashCode();
                if (this.ExtendInfo != null) hashCode = hashCode * 59 + this.ExtendInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
