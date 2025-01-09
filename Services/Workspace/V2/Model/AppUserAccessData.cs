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
    /// 
    /// </summary>
    public class AppUserAccessData 
    {

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 接入失败数
        /// </summary>
        [JsonProperty("access_failed_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessFailedCount { get; set; }

        /// <summary>
        /// 最近一次接入失败时间，UTC时间，格式为：2022-05-11T11:45:42Z
        /// </summary>
        [JsonProperty("last_access_failed_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastAccessFailedTime { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppUserAccessData {\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  accessFailedCount: ").Append(AccessFailedCount).Append("\n");
            sb.Append("  lastAccessFailedTime: ").Append(LastAccessFailedTime).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppUserAccessData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppUserAccessData input)
        {
            if (input == null) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.AccessFailedCount != input.AccessFailedCount || (this.AccessFailedCount != null && !this.AccessFailedCount.Equals(input.AccessFailedCount))) return false;
            if (this.LastAccessFailedTime != input.LastAccessFailedTime || (this.LastAccessFailedTime != null && !this.LastAccessFailedTime.Equals(input.LastAccessFailedTime))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;

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
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.AccessFailedCount != null) hashCode = hashCode * 59 + this.AccessFailedCount.GetHashCode();
                if (this.LastAccessFailedTime != null) hashCode = hashCode * 59 + this.LastAccessFailedTime.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
