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
    public class ShowDesktopRemoteAssistanceInfoResponse : SdkResponse
    {

        /// <summary>
        /// 协同空间ID。
        /// </summary>
        [JsonProperty("share_space_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareSpaceId { get; set; }

        /// <summary>
        /// 协同空间邀请码(大写英文+数字,共8位)。
        /// </summary>
        [JsonProperty("invitation_code", NullValueHandling = NullValueHandling.Ignore)]
        public string InvitationCode { get; set; }

        /// <summary>
        /// 协同空间名称。
        /// </summary>
        [JsonProperty("share_space_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareSpaceName { get; set; }

        /// <summary>
        /// 协同空间密码。
        /// </summary>
        [JsonProperty("share_space_passwd", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareSpacePasswd { get; set; }

        /// <summary>
        /// 专线分享链接。
        /// </summary>
        [JsonProperty("private_share_link", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateShareLink { get; set; }

        /// <summary>
        /// 互联网分享链接。
        /// </summary>
        [JsonProperty("internet_share_link", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetShareLink { get; set; }

        /// <summary>
        /// 创建时间 UTC时间，格式为：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z。&#39;
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 协同空间状态 - OPEN 协同空间已创建 - CLOSE 协同空间已关闭 - WAIT_USER_CONFIRM 等待用户确认进入远程协助 - WAIT_USER_ACCESS 等待用户进入远程协助
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 失败原因。
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDesktopRemoteAssistanceInfoResponse {\n");
            sb.Append("  shareSpaceId: ").Append(ShareSpaceId).Append("\n");
            sb.Append("  invitationCode: ").Append(InvitationCode).Append("\n");
            sb.Append("  shareSpaceName: ").Append(ShareSpaceName).Append("\n");
            sb.Append("  shareSpacePasswd: ").Append(ShareSpacePasswd).Append("\n");
            sb.Append("  privateShareLink: ").Append(PrivateShareLink).Append("\n");
            sb.Append("  internetShareLink: ").Append(InternetShareLink).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDesktopRemoteAssistanceInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDesktopRemoteAssistanceInfoResponse input)
        {
            if (input == null) return false;
            if (this.ShareSpaceId != input.ShareSpaceId || (this.ShareSpaceId != null && !this.ShareSpaceId.Equals(input.ShareSpaceId))) return false;
            if (this.InvitationCode != input.InvitationCode || (this.InvitationCode != null && !this.InvitationCode.Equals(input.InvitationCode))) return false;
            if (this.ShareSpaceName != input.ShareSpaceName || (this.ShareSpaceName != null && !this.ShareSpaceName.Equals(input.ShareSpaceName))) return false;
            if (this.ShareSpacePasswd != input.ShareSpacePasswd || (this.ShareSpacePasswd != null && !this.ShareSpacePasswd.Equals(input.ShareSpacePasswd))) return false;
            if (this.PrivateShareLink != input.PrivateShareLink || (this.PrivateShareLink != null && !this.PrivateShareLink.Equals(input.PrivateShareLink))) return false;
            if (this.InternetShareLink != input.InternetShareLink || (this.InternetShareLink != null && !this.InternetShareLink.Equals(input.InternetShareLink))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.FailedReason != input.FailedReason || (this.FailedReason != null && !this.FailedReason.Equals(input.FailedReason))) return false;

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
                if (this.ShareSpaceId != null) hashCode = hashCode * 59 + this.ShareSpaceId.GetHashCode();
                if (this.InvitationCode != null) hashCode = hashCode * 59 + this.InvitationCode.GetHashCode();
                if (this.ShareSpaceName != null) hashCode = hashCode * 59 + this.ShareSpaceName.GetHashCode();
                if (this.ShareSpacePasswd != null) hashCode = hashCode * 59 + this.ShareSpacePasswd.GetHashCode();
                if (this.PrivateShareLink != null) hashCode = hashCode * 59 + this.PrivateShareLink.GetHashCode();
                if (this.InternetShareLink != null) hashCode = hashCode * 59 + this.InternetShareLink.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FailedReason != null) hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                return hashCode;
            }
        }
    }
}
