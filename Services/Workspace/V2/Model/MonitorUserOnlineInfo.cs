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
    /// 桌面监控用户在线状态信息
    /// </summary>
    public class MonitorUserOnlineInfo 
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
        /// 加密后的详细拒绝原因，用户可以自行调用STS服务的decode-authorization-message接口进行解密。
        /// </summary>
        [JsonProperty("encoded_authorization_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EncodedAuthorizationMessage { get; set; }

        /// <summary>
        /// 建立连接时间
        /// </summary>
        [JsonProperty("connection_setup_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionSetupTime { get; set; }

        /// <summary>
        /// 结束连接时间
        /// </summary>
        [JsonProperty("connection_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionEndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonitorUserOnlineInfo {\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  encodedAuthorizationMessage: ").Append(EncodedAuthorizationMessage).Append("\n");
            sb.Append("  connectionSetupTime: ").Append(ConnectionSetupTime).Append("\n");
            sb.Append("  connectionEndTime: ").Append(ConnectionEndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MonitorUserOnlineInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MonitorUserOnlineInfo input)
        {
            if (input == null) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;
            if (this.EncodedAuthorizationMessage != input.EncodedAuthorizationMessage || (this.EncodedAuthorizationMessage != null && !this.EncodedAuthorizationMessage.Equals(input.EncodedAuthorizationMessage))) return false;
            if (this.ConnectionSetupTime != input.ConnectionSetupTime || (this.ConnectionSetupTime != null && !this.ConnectionSetupTime.Equals(input.ConnectionSetupTime))) return false;
            if (this.ConnectionEndTime != input.ConnectionEndTime || (this.ConnectionEndTime != null && !this.ConnectionEndTime.Equals(input.ConnectionEndTime))) return false;

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
                if (this.EncodedAuthorizationMessage != null) hashCode = hashCode * 59 + this.EncodedAuthorizationMessage.GetHashCode();
                if (this.ConnectionSetupTime != null) hashCode = hashCode * 59 + this.ConnectionSetupTime.GetHashCode();
                if (this.ConnectionEndTime != null) hashCode = hashCode * 59 + this.ConnectionEndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
