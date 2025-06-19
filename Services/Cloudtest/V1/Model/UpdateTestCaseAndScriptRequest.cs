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
    public class UpdateTestCaseAndScriptRequest 
    {

        /// <summary>
        /// 用户Token。  通过调用IAM服务获取用户Token接口获取（响应消息头中X-Subject-Token的值）。
        /// </summary>
        [SDKProperty("X-Auth-Token", IsHeader = true)]
        [JsonProperty("X-Auth-Token", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthToken { get; set; }

        /// <summary>
        /// 项目ID，固定长度32位字符（字母和数字）。
        /// </summary>
        [SDKProperty("project_id", IsPath = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// TMSS用例uri
        /// </summary>
        [SDKProperty("tmss_case_uri", IsPath = true)]
        [JsonProperty("tmss_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TmssCaseUri { get; set; }

        /// <summary>
        /// 新组合AW开关
        /// </summary>
        [SDKProperty("turn_on_awmapping", IsQuery = true)]
        [JsonProperty("turn_on_awmapping", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TurnOnAwmapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTestCaseReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTestCaseAndScriptRequest {\n");
            sb.Append("  xAuthToken: ").Append(XAuthToken).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  tmssCaseUri: ").Append(TmssCaseUri).Append("\n");
            sb.Append("  turnOnAwmapping: ").Append(TurnOnAwmapping).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTestCaseAndScriptRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTestCaseAndScriptRequest input)
        {
            if (input == null) return false;
            if (this.XAuthToken != input.XAuthToken || (this.XAuthToken != null && !this.XAuthToken.Equals(input.XAuthToken))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TmssCaseUri != input.TmssCaseUri || (this.TmssCaseUri != null && !this.TmssCaseUri.Equals(input.TmssCaseUri))) return false;
            if (this.TurnOnAwmapping != input.TurnOnAwmapping || (this.TurnOnAwmapping != null && !this.TurnOnAwmapping.Equals(input.TurnOnAwmapping))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TmssCaseUri != null) hashCode = hashCode * 59 + this.TmssCaseUri.GetHashCode();
                if (this.TurnOnAwmapping != null) hashCode = hashCode * 59 + this.TurnOnAwmapping.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
