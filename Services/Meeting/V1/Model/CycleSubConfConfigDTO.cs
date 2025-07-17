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
    /// 
    /// </summary>
    public class CycleSubConfConfigDTO 
    {

        /// <summary>
        /// 允许加入会议的范围。 - 0: 所有用户 - 2: 企业内用户 - 3: 被邀请用户 
        /// </summary>
        [JsonProperty("callInRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public int? CallInRestriction { get; set; }

        /// <summary>
        /// 允许加入网络研讨会的观众范围。 - 0：所有用户 - 2：企业内用户和被邀请用户 
        /// </summary>
        [JsonProperty("audienceCallInRestriction", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudienceCallInRestriction { get; set; }

        /// <summary>
        /// 是否允许来宾启动会议。 - false:禁止来宾启动会议 - true：允许来宾启动会议 &gt; 仅随机会议ID的会议生效。 
        /// </summary>
        [JsonProperty("allowGuestStartConf", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowGuestStartConf { get; set; }

        /// <summary>
        /// 是否启用等候室。
        /// </summary>
        [JsonProperty("enableWaitingRoom", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWaitingRoom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("showAudienceCountInfo", NullValueHandling = NullValueHandling.Ignore)]
        public ShowAudienceCountInfo ShowAudienceCountInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CycleSubConfConfigDTO {\n");
            sb.Append("  callInRestriction: ").Append(CallInRestriction).Append("\n");
            sb.Append("  audienceCallInRestriction: ").Append(AudienceCallInRestriction).Append("\n");
            sb.Append("  allowGuestStartConf: ").Append(AllowGuestStartConf).Append("\n");
            sb.Append("  enableWaitingRoom: ").Append(EnableWaitingRoom).Append("\n");
            sb.Append("  showAudienceCountInfo: ").Append(ShowAudienceCountInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CycleSubConfConfigDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CycleSubConfConfigDTO input)
        {
            if (input == null) return false;
            if (this.CallInRestriction != input.CallInRestriction || (this.CallInRestriction != null && !this.CallInRestriction.Equals(input.CallInRestriction))) return false;
            if (this.AudienceCallInRestriction != input.AudienceCallInRestriction || (this.AudienceCallInRestriction != null && !this.AudienceCallInRestriction.Equals(input.AudienceCallInRestriction))) return false;
            if (this.AllowGuestStartConf != input.AllowGuestStartConf || (this.AllowGuestStartConf != null && !this.AllowGuestStartConf.Equals(input.AllowGuestStartConf))) return false;
            if (this.EnableWaitingRoom != input.EnableWaitingRoom || (this.EnableWaitingRoom != null && !this.EnableWaitingRoom.Equals(input.EnableWaitingRoom))) return false;
            if (this.ShowAudienceCountInfo != input.ShowAudienceCountInfo || (this.ShowAudienceCountInfo != null && !this.ShowAudienceCountInfo.Equals(input.ShowAudienceCountInfo))) return false;

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
                if (this.CallInRestriction != null) hashCode = hashCode * 59 + this.CallInRestriction.GetHashCode();
                if (this.AudienceCallInRestriction != null) hashCode = hashCode * 59 + this.AudienceCallInRestriction.GetHashCode();
                if (this.AllowGuestStartConf != null) hashCode = hashCode * 59 + this.AllowGuestStartConf.GetHashCode();
                if (this.EnableWaitingRoom != null) hashCode = hashCode * 59 + this.EnableWaitingRoom.GetHashCode();
                if (this.ShowAudienceCountInfo != null) hashCode = hashCode * 59 + this.ShowAudienceCountInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
