using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class LiveEventReportRequest 
    {

        /// <summary>
        /// 直播间ID。
        /// </summary>
        [SDKProperty("room_id", IsPath = true)]
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [SDKProperty("job_id", IsPath = true)]
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。  格式为(YYYYMMDD&#39;T&#39;HHMMSS&#39;Z&#39;)。
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带项目ID信息。
        /// </summary>
        [SDKProperty("X-Project-Id", IsHeader = true)]
        [JsonProperty("X-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// 第三方用户ID。不允许输入中文。
        /// </summary>
        [SDKProperty("X-App-UserId", IsHeader = true)]
        [JsonProperty("X-App-UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string XAppUserId { get; set; }

        /// <summary>
        /// 鉴权Key。通过HmacSHA256生成的鉴权key
        /// </summary>
        [SDKProperty("auth_key", IsQuery = true)]
        [JsonProperty("auth_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthKey { get; set; }

        /// <summary>
        /// 鉴权key过期时间。从1970年1月1日（UTC/GMT的午夜）开始所经过的毫秒数。
        /// </summary>
        [SDKProperty("expires_time", IsQuery = true)]
        [JsonProperty("expires_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpiresTime { get; set; }

        /// <summary>
        /// 鉴权Key。通过HmacSHA256生成的鉴权key
        /// </summary>
        [SDKProperty("x-mss-auth-key", IsHeader = true)]
        [JsonProperty("x-mss-auth-key", NullValueHandling = NullValueHandling.Ignore)]
        public string XMssAuthKey { get; set; }

        /// <summary>
        /// **参数解释**： 鉴权key过期时间。从1970年1月1日（UTC/GMT的午夜）开始所经过的毫秒数。
        /// </summary>
        [SDKProperty("x-mss-expires-time", IsHeader = true)]
        [JsonProperty("x-mss-expires-time", NullValueHandling = NullValueHandling.Ignore)]
        public long? XMssExpiresTime { get; set; }

        /// <summary>
        /// 是否刷新URL
        /// </summary>
        [SDKProperty("refresh_url", IsQuery = true)]
        [JsonProperty("refresh_url", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RefreshUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ReportLiveEventReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveEventReportRequest {\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  xAppUserId: ").Append(XAppUserId).Append("\n");
            sb.Append("  authKey: ").Append(AuthKey).Append("\n");
            sb.Append("  expiresTime: ").Append(ExpiresTime).Append("\n");
            sb.Append("  xMssAuthKey: ").Append(XMssAuthKey).Append("\n");
            sb.Append("  xMssExpiresTime: ").Append(XMssExpiresTime).Append("\n");
            sb.Append("  refreshUrl: ").Append(RefreshUrl).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveEventReportRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveEventReportRequest input)
        {
            if (input == null) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.XAppUserId != input.XAppUserId || (this.XAppUserId != null && !this.XAppUserId.Equals(input.XAppUserId))) return false;
            if (this.AuthKey != input.AuthKey || (this.AuthKey != null && !this.AuthKey.Equals(input.AuthKey))) return false;
            if (this.ExpiresTime != input.ExpiresTime || (this.ExpiresTime != null && !this.ExpiresTime.Equals(input.ExpiresTime))) return false;
            if (this.XMssAuthKey != input.XMssAuthKey || (this.XMssAuthKey != null && !this.XMssAuthKey.Equals(input.XMssAuthKey))) return false;
            if (this.XMssExpiresTime != input.XMssExpiresTime || (this.XMssExpiresTime != null && !this.XMssExpiresTime.Equals(input.XMssExpiresTime))) return false;
            if (this.RefreshUrl != input.RefreshUrl || (this.RefreshUrl != null && !this.RefreshUrl.Equals(input.RefreshUrl))) return false;
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
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.XAppUserId != null) hashCode = hashCode * 59 + this.XAppUserId.GetHashCode();
                if (this.AuthKey != null) hashCode = hashCode * 59 + this.AuthKey.GetHashCode();
                if (this.ExpiresTime != null) hashCode = hashCode * 59 + this.ExpiresTime.GetHashCode();
                if (this.XMssAuthKey != null) hashCode = hashCode * 59 + this.XMssAuthKey.GetHashCode();
                if (this.XMssExpiresTime != null) hashCode = hashCode * 59 + this.XMssExpiresTime.GetHashCode();
                if (this.RefreshUrl != null) hashCode = hashCode * 59 + this.RefreshUrl.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
