using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ImportPolicyGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 错误码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 错误详情。
        /// </summary>
        [JsonProperty("error_detail", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDetail { get; set; }

        /// <summary>
        /// 加密后的详细拒绝原因，用户可以自行调用STS服务的decode-authorization-message接口进行解密。
        /// </summary>
        [JsonProperty("encoded_authorization_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EncodedAuthorizationMessage { get; set; }

        /// <summary>
        /// 导入策略组所有名字列表。
        /// </summary>
        [JsonProperty("policy_group_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyGroupNameInfo> PolicyGroupNameList { get; set; }

        /// <summary>
        /// 导入策略组失败名字列表。
        /// </summary>
        [JsonProperty("failed_policy_group_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyGroupNameInfo> FailedPolicyGroupNameList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportPolicyGroupsResponse {\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  errorDetail: ").Append(ErrorDetail).Append("\n");
            sb.Append("  encodedAuthorizationMessage: ").Append(EncodedAuthorizationMessage).Append("\n");
            sb.Append("  policyGroupNameList: ").Append(PolicyGroupNameList).Append("\n");
            sb.Append("  failedPolicyGroupNameList: ").Append(FailedPolicyGroupNameList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportPolicyGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportPolicyGroupsResponse input)
        {
            if (input == null) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.ErrorDetail != input.ErrorDetail || (this.ErrorDetail != null && !this.ErrorDetail.Equals(input.ErrorDetail))) return false;
            if (this.EncodedAuthorizationMessage != input.EncodedAuthorizationMessage || (this.EncodedAuthorizationMessage != null && !this.EncodedAuthorizationMessage.Equals(input.EncodedAuthorizationMessage))) return false;
            if (this.PolicyGroupNameList != input.PolicyGroupNameList || (this.PolicyGroupNameList != null && input.PolicyGroupNameList != null && !this.PolicyGroupNameList.SequenceEqual(input.PolicyGroupNameList))) return false;
            if (this.FailedPolicyGroupNameList != input.FailedPolicyGroupNameList || (this.FailedPolicyGroupNameList != null && input.FailedPolicyGroupNameList != null && !this.FailedPolicyGroupNameList.SequenceEqual(input.FailedPolicyGroupNameList))) return false;

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
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                if (this.ErrorDetail != null) hashCode = hashCode * 59 + this.ErrorDetail.GetHashCode();
                if (this.EncodedAuthorizationMessage != null) hashCode = hashCode * 59 + this.EncodedAuthorizationMessage.GetHashCode();
                if (this.PolicyGroupNameList != null) hashCode = hashCode * 59 + this.PolicyGroupNameList.GetHashCode();
                if (this.FailedPolicyGroupNameList != null) hashCode = hashCode * 59 + this.FailedPolicyGroupNameList.GetHashCode();
                return hashCode;
            }
        }
    }
}
