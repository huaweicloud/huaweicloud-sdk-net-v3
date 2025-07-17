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
    /// 修改会议配置请求。
    /// </summary>
    public class UpdateStartedConfigReqBody 
    {

        /// <summary>
        /// 锁定共享标志位。 * 0: 不锁定 * 1: 锁定 
        /// </summary>
        [JsonProperty("lockSharing", NullValueHandling = NullValueHandling.Ignore)]
        public int? LockSharing { get; set; }

        /// <summary>
        /// 允许加入会议的范围。 - 0: 所有用户 - 2: 企业内用户 - 3: 被邀请用户 
        /// </summary>
        [JsonProperty("callInRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public int? CallInRestriction { get; set; }

        /// <summary>
        /// 是否允许自己解除静音，默认为允许 - 0: 不允许 - 1: 允许 
        /// </summary>
        [JsonProperty("allowUnmuteByOneself", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllowUnmuteByOneself { get; set; }

        /// <summary>
        /// 会议聊天权限 1.全员禁止 2.仅允许私聊 3.仅允许公开聊天 4.允许自由聊天
        /// </summary>
        [JsonProperty("chatPermission", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChatPermission { get; set; }

        /// <summary>
        /// 网络研讨会观众允许呼入的范围 0：所有用户  2：企业内用户和被邀请用户
        /// </summary>
        [JsonProperty("audienceCallInRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudienceCallInRestriction { get; set; }

        /// <summary>
        /// 客户端本地录制权限的范围，默认为仅主持人支持本地录制 - 0: 所有用户 - 1：全部人可录制 - 2：部分人可录制 
        /// </summary>
        [JsonProperty("clientRecMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientRecMode { get; set; }

        /// <summary>
        /// 与会人自行开启摄像头 0:禁止 1:允许
        /// </summary>
        [JsonProperty("allowOpenCamera", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllowOpenCamera { get; set; }

        /// <summary>
        /// 是否允许与会人改名 0:不允许 1:允许
        /// </summary>
        [JsonProperty("allowRename", NullValueHandling = NullValueHandling.Ignore)]
        public int? AllowRename { get; set; }

        /// <summary>
        /// 锁定会议 0：解锁 1：锁定
        /// </summary>
        [JsonProperty("isLock", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsLock { get; set; }

        /// <summary>
        /// 抢共享权限设置 0:仅主持人/联席 1:所有人可抢共享
        /// </summary>
        [JsonProperty("freeShare", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeShare { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateStartedConfigReqBody {\n");
            sb.Append("  lockSharing: ").Append(LockSharing).Append("\n");
            sb.Append("  callInRestriction: ").Append(CallInRestriction).Append("\n");
            sb.Append("  allowUnmuteByOneself: ").Append(AllowUnmuteByOneself).Append("\n");
            sb.Append("  chatPermission: ").Append(ChatPermission).Append("\n");
            sb.Append("  audienceCallInRestriction: ").Append(AudienceCallInRestriction).Append("\n");
            sb.Append("  clientRecMode: ").Append(ClientRecMode).Append("\n");
            sb.Append("  allowOpenCamera: ").Append(AllowOpenCamera).Append("\n");
            sb.Append("  allowRename: ").Append(AllowRename).Append("\n");
            sb.Append("  isLock: ").Append(IsLock).Append("\n");
            sb.Append("  freeShare: ").Append(FreeShare).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateStartedConfigReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateStartedConfigReqBody input)
        {
            if (input == null) return false;
            if (this.LockSharing != input.LockSharing || (this.LockSharing != null && !this.LockSharing.Equals(input.LockSharing))) return false;
            if (this.CallInRestriction != input.CallInRestriction || (this.CallInRestriction != null && !this.CallInRestriction.Equals(input.CallInRestriction))) return false;
            if (this.AllowUnmuteByOneself != input.AllowUnmuteByOneself || (this.AllowUnmuteByOneself != null && !this.AllowUnmuteByOneself.Equals(input.AllowUnmuteByOneself))) return false;
            if (this.ChatPermission != input.ChatPermission || (this.ChatPermission != null && !this.ChatPermission.Equals(input.ChatPermission))) return false;
            if (this.AudienceCallInRestriction != input.AudienceCallInRestriction || (this.AudienceCallInRestriction != null && !this.AudienceCallInRestriction.Equals(input.AudienceCallInRestriction))) return false;
            if (this.ClientRecMode != input.ClientRecMode || (this.ClientRecMode != null && !this.ClientRecMode.Equals(input.ClientRecMode))) return false;
            if (this.AllowOpenCamera != input.AllowOpenCamera || (this.AllowOpenCamera != null && !this.AllowOpenCamera.Equals(input.AllowOpenCamera))) return false;
            if (this.AllowRename != input.AllowRename || (this.AllowRename != null && !this.AllowRename.Equals(input.AllowRename))) return false;
            if (this.IsLock != input.IsLock || (this.IsLock != null && !this.IsLock.Equals(input.IsLock))) return false;
            if (this.FreeShare != input.FreeShare || (this.FreeShare != null && !this.FreeShare.Equals(input.FreeShare))) return false;

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
                if (this.LockSharing != null) hashCode = hashCode * 59 + this.LockSharing.GetHashCode();
                if (this.CallInRestriction != null) hashCode = hashCode * 59 + this.CallInRestriction.GetHashCode();
                if (this.AllowUnmuteByOneself != null) hashCode = hashCode * 59 + this.AllowUnmuteByOneself.GetHashCode();
                if (this.ChatPermission != null) hashCode = hashCode * 59 + this.ChatPermission.GetHashCode();
                if (this.AudienceCallInRestriction != null) hashCode = hashCode * 59 + this.AudienceCallInRestriction.GetHashCode();
                if (this.ClientRecMode != null) hashCode = hashCode * 59 + this.ClientRecMode.GetHashCode();
                if (this.AllowOpenCamera != null) hashCode = hashCode * 59 + this.AllowOpenCamera.GetHashCode();
                if (this.AllowRename != null) hashCode = hashCode * 59 + this.AllowRename.GetHashCode();
                if (this.IsLock != null) hashCode = hashCode * 59 + this.IsLock.GetHashCode();
                if (this.FreeShare != null) hashCode = hashCode * 59 + this.FreeShare.GetHashCode();
                return hashCode;
            }
        }
    }
}
