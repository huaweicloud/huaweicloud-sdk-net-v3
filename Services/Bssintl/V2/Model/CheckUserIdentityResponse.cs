using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckUserIdentityResponse : SdkResponse
    {

        /// <summary>
        /// 状态码。具体请参考状态码。
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述信息。
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 是否可以继续注册。该参数非必填，且只允许字符串,available: 该登录名称/手机号/邮箱可以继续注册,used_by_user: 该登录名称/手机号/邮箱不可以继续注册
        /// </summary>
        [JsonProperty("check_result", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckResult { get; set; }

        /// <summary>
        /// 手机号剩余可注册客户数量。该参数非必填，只有search_type&#x3D;mobile时，该字段才返回值。表示可以继续使用该手机号注册客户的数量。
        /// </summary>
        [JsonProperty("mobile_remain_available_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MobileRemainAvailableNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckUserIdentityResponse {\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  checkResult: ").Append(CheckResult).Append("\n");
            sb.Append("  mobileRemainAvailableNum: ").Append(MobileRemainAvailableNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckUserIdentityResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckUserIdentityResponse input)
        {
            if (input == null) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.CheckResult != input.CheckResult || (this.CheckResult != null && !this.CheckResult.Equals(input.CheckResult))) return false;
            if (this.MobileRemainAvailableNum != input.MobileRemainAvailableNum || (this.MobileRemainAvailableNum != null && !this.MobileRemainAvailableNum.Equals(input.MobileRemainAvailableNum))) return false;

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
                if (this.CheckResult != null) hashCode = hashCode * 59 + this.CheckResult.GetHashCode();
                if (this.MobileRemainAvailableNum != null) hashCode = hashCode * 59 + this.MobileRemainAvailableNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
