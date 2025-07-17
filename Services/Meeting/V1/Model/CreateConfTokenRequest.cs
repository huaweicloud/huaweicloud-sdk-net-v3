using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CreateConfTokenRequest 
    {

        /// <summary>
        /// 会议ID。 &gt; 创建会议时返回的conferenceID。不是vmrConferenceID。 
        /// </summary>
        [SDKProperty("conferenceID", IsQuery = true)]
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 会控Token。 &gt; * 仅会控Token保活场景需要携带 &gt; * 如果会话已过期并且请求中携带了密码，则进行重新鉴权并回复新的会控Token
        /// </summary>
        [SDKProperty("X-Conference-Authorization", IsHeader = true)]
        [JsonProperty("X-Conference-Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string XConferenceAuthorization { get; set; }

        /// <summary>
        /// 会议的主持人密码。 &gt; 对于会控Token保活场景，不对主持人密码鉴权。
        /// </summary>
        [SDKProperty("X-Password", IsHeader = true)]
        [JsonProperty("X-Password", NullValueHandling = NullValueHandling.Ignore)]
        public string XPassword { get; set; }

        /// <summary>
        /// 请求类型。 - 1: 业务固定为1。
        /// </summary>
        [SDKProperty("X-Login-Type", IsHeader = true)]
        [JsonProperty("X-Login-Type", NullValueHandling = NullValueHandling.Ignore)]
        public int? XLoginType { get; set; }

        /// <summary>
        /// 用户临时nonce token。
        /// </summary>
        [SDKProperty("X-Nonce", IsHeader = true)]
        [JsonProperty("X-Nonce", NullValueHandling = NullValueHandling.Ignore)]
        public string XNonce { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateConfTokenRequest {\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  xConferenceAuthorization: ").Append(XConferenceAuthorization).Append("\n");
            sb.Append("  xPassword: ").Append(XPassword).Append("\n");
            sb.Append("  xLoginType: ").Append(XLoginType).Append("\n");
            sb.Append("  xNonce: ").Append(XNonce).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateConfTokenRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateConfTokenRequest input)
        {
            if (input == null) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.XConferenceAuthorization != input.XConferenceAuthorization || (this.XConferenceAuthorization != null && !this.XConferenceAuthorization.Equals(input.XConferenceAuthorization))) return false;
            if (this.XPassword != input.XPassword || (this.XPassword != null && !this.XPassword.Equals(input.XPassword))) return false;
            if (this.XLoginType != input.XLoginType || (this.XLoginType != null && !this.XLoginType.Equals(input.XLoginType))) return false;
            if (this.XNonce != input.XNonce || (this.XNonce != null && !this.XNonce.Equals(input.XNonce))) return false;

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
                if (this.ConferenceID != null) hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.XConferenceAuthorization != null) hashCode = hashCode * 59 + this.XConferenceAuthorization.GetHashCode();
                if (this.XPassword != null) hashCode = hashCode * 59 + this.XPassword.GetHashCode();
                if (this.XLoginType != null) hashCode = hashCode * 59 + this.XLoginType.GetHashCode();
                if (this.XNonce != null) hashCode = hashCode * 59 + this.XNonce.GetHashCode();
                return hashCode;
            }
        }
    }
}
