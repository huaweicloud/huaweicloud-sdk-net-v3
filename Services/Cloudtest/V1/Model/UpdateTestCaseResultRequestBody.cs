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
    /// 更新测试用例状态请求体
    /// </summary>
    public class UpdateTestCaseResultRequestBody 
    {

        /// <summary>
        /// 注册测试类型服务接口返回的服务id
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 测试计划id
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 测试用例状态信息，数组长度小于等于50
        /// </summary>
        [JsonProperty("execute_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateTestCaseResultBean> ExecuteList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTestCaseResultRequestBody {\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  executeList: ").Append(ExecuteList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTestCaseResultRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTestCaseResultRequestBody input)
        {
            if (input == null) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.ExecuteList != input.ExecuteList || (this.ExecuteList != null && input.ExecuteList != null && !this.ExecuteList.SequenceEqual(input.ExecuteList))) return false;

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
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.ExecuteList != null) hashCode = hashCode * 59 + this.ExecuteList.GetHashCode();
                return hashCode;
            }
        }
    }
}
