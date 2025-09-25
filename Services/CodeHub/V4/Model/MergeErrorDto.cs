using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MergeErrorDto 
    {

        /// <summary>
        /// 合并人名字
        /// </summary>
        [JsonProperty("merge_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeUserName { get; set; }

        /// <summary>
        /// 合入时间
        /// </summary>
        [JsonProperty("merge_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string MergeStartTime { get; set; }

        /// <summary>
        /// 错误标题
        /// </summary>
        [JsonProperty("error_title", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorTitle { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("http_code_status", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpCodeStatus { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeErrorDto {\n");
            sb.Append("  mergeUserName: ").Append(MergeUserName).Append("\n");
            sb.Append("  mergeStartTime: ").Append(MergeStartTime).Append("\n");
            sb.Append("  errorTitle: ").Append(ErrorTitle).Append("\n");
            sb.Append("  httpCodeStatus: ").Append(HttpCodeStatus).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MergeErrorDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MergeErrorDto input)
        {
            if (input == null) return false;
            if (this.MergeUserName != input.MergeUserName || (this.MergeUserName != null && !this.MergeUserName.Equals(input.MergeUserName))) return false;
            if (this.MergeStartTime != input.MergeStartTime || (this.MergeStartTime != null && !this.MergeStartTime.Equals(input.MergeStartTime))) return false;
            if (this.ErrorTitle != input.ErrorTitle || (this.ErrorTitle != null && !this.ErrorTitle.Equals(input.ErrorTitle))) return false;
            if (this.HttpCodeStatus != input.HttpCodeStatus || (this.HttpCodeStatus != null && !this.HttpCodeStatus.Equals(input.HttpCodeStatus))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;

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
                if (this.MergeUserName != null) hashCode = hashCode * 59 + this.MergeUserName.GetHashCode();
                if (this.MergeStartTime != null) hashCode = hashCode * 59 + this.MergeStartTime.GetHashCode();
                if (this.ErrorTitle != null) hashCode = hashCode * 59 + this.ErrorTitle.GetHashCode();
                if (this.HttpCodeStatus != null) hashCode = hashCode * 59 + this.HttpCodeStatus.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
