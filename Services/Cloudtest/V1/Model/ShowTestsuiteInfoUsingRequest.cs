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
    /// Request Object
    /// </summary>
    public class ShowTestsuiteInfoUsingRequest 
    {

        /// <summary>
        /// 用户Token。 通过调用IAM服务获取用户Token接口获取（响应消息头中X-Subject-Token的值）。
        /// </summary>
        [SDKProperty("X-Auth-Token", IsHeader = true)]
        [JsonProperty("X-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthToken { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [SDKProperty("service_id", IsPath = true)]
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [SDKProperty("suite_id", IsPath = true)]
        [JsonProperty("suite_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SuiteId { get; set; }

        /// <summary>
        /// 测试计划Id
        /// </summary>
        [SDKProperty("planId", IsQuery = true)]
        [JsonProperty("planId", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTestsuiteInfoUsingRequest {\n");
            sb.Append("  xAuthToken: ").Append(XAuthToken).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  suiteId: ").Append(SuiteId).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTestsuiteInfoUsingRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTestsuiteInfoUsingRequest input)
        {
            if (input == null) return false;
            if (this.XAuthToken != input.XAuthToken || (this.XAuthToken != null && !this.XAuthToken.Equals(input.XAuthToken))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.SuiteId != input.SuiteId || (this.SuiteId != null && !this.SuiteId.Equals(input.SuiteId))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;

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
                if (this.XAuthToken != null) hashCode = hashCode * 59 + this.XAuthToken.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.SuiteId != null) hashCode = hashCode * 59 + this.SuiteId.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                return hashCode;
            }
        }
    }
}
