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
    /// 会控Token信息。
    /// </summary>
    public class TokenInfo 
    {

        /// <summary>
        /// 会控Token。有效期半个小时。
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 会控WebSocket建链鉴权Token。
        /// </summary>
        [JsonProperty("tmpWsToken", NullValueHandling = NullValueHandling.Ignore)]
        public string TmpWsToken { get; set; }

        /// <summary>
        /// 会控WebSocket建链URL。
        /// </summary>
        [JsonProperty("wsURL", NullValueHandling = NullValueHandling.Ignore)]
        public string WsURL { get; set; }

        /// <summary>
        /// 会议中的角色。 * 0 ：普通与会者 * 1 ：会议主持人 
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public int? Role { get; set; }

        /// <summary>
        /// 会控Token过期时间戳（单位：毫秒）。
        /// </summary>
        [JsonProperty("expireTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 会议预定者的用户UUID。
        /// </summary>
        [JsonProperty("userID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserID { get; set; }

        /// <summary>
        /// 会议所属企业ID。
        /// </summary>
        [JsonProperty("orgID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgID { get; set; }

        /// <summary>
        /// 终端请求时，返回终端入会后会场ID。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [JsonProperty("participantID", NullValueHandling = NullValueHandling.Ignore)]
        public string ParticipantID { get; set; }

        /// <summary>
        /// 会控Token有效时长（单位秒）。
        /// </summary>
        [JsonProperty("confTokenExpireTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfTokenExpireTime { get; set; }

        /// <summary>
        /// 云会议室会议的当前会议ID。
        /// </summary>
        [JsonProperty("vmrCurrentConfID", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrCurrentConfID { get; set; }

        /// <summary>
        /// 会控WebSocket消息推送支持类型。
        /// </summary>
        [JsonProperty("supportNotifyType", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportNotifyType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenInfo {\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  tmpWsToken: ").Append(TmpWsToken).Append("\n");
            sb.Append("  wsURL: ").Append(WsURL).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  userID: ").Append(UserID).Append("\n");
            sb.Append("  orgID: ").Append(OrgID).Append("\n");
            sb.Append("  participantID: ").Append(ParticipantID).Append("\n");
            sb.Append("  confTokenExpireTime: ").Append(ConfTokenExpireTime).Append("\n");
            sb.Append("  vmrCurrentConfID: ").Append(VmrCurrentConfID).Append("\n");
            sb.Append("  supportNotifyType: ").Append(SupportNotifyType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TokenInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TokenInfo input)
        {
            if (input == null) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.TmpWsToken != input.TmpWsToken || (this.TmpWsToken != null && !this.TmpWsToken.Equals(input.TmpWsToken))) return false;
            if (this.WsURL != input.WsURL || (this.WsURL != null && !this.WsURL.Equals(input.WsURL))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.UserID != input.UserID || (this.UserID != null && !this.UserID.Equals(input.UserID))) return false;
            if (this.OrgID != input.OrgID || (this.OrgID != null && !this.OrgID.Equals(input.OrgID))) return false;
            if (this.ParticipantID != input.ParticipantID || (this.ParticipantID != null && !this.ParticipantID.Equals(input.ParticipantID))) return false;
            if (this.ConfTokenExpireTime != input.ConfTokenExpireTime || (this.ConfTokenExpireTime != null && !this.ConfTokenExpireTime.Equals(input.ConfTokenExpireTime))) return false;
            if (this.VmrCurrentConfID != input.VmrCurrentConfID || (this.VmrCurrentConfID != null && !this.VmrCurrentConfID.Equals(input.VmrCurrentConfID))) return false;
            if (this.SupportNotifyType != input.SupportNotifyType || (this.SupportNotifyType != null && input.SupportNotifyType != null && !this.SupportNotifyType.SequenceEqual(input.SupportNotifyType))) return false;

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
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TmpWsToken != null) hashCode = hashCode * 59 + this.TmpWsToken.GetHashCode();
                if (this.WsURL != null) hashCode = hashCode * 59 + this.WsURL.GetHashCode();
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.UserID != null) hashCode = hashCode * 59 + this.UserID.GetHashCode();
                if (this.OrgID != null) hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                if (this.ParticipantID != null) hashCode = hashCode * 59 + this.ParticipantID.GetHashCode();
                if (this.ConfTokenExpireTime != null) hashCode = hashCode * 59 + this.ConfTokenExpireTime.GetHashCode();
                if (this.VmrCurrentConfID != null) hashCode = hashCode * 59 + this.VmrCurrentConfID.GetHashCode();
                if (this.SupportNotifyType != null) hashCode = hashCode * 59 + this.SupportNotifyType.GetHashCode();
                return hashCode;
            }
        }
    }
}
