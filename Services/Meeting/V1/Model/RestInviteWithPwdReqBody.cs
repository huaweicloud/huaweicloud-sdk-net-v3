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
    /// 会议信息。
    /// </summary>
    public class RestInviteWithPwdReqBody 
    {

        /// <summary>
        /// 被邀请者的SIP号码。
        /// </summary>
        [JsonProperty("callNum", NullValueHandling = NullValueHandling.Ignore)]
        public string CallNum { get; set; }

        /// <summary>
        /// 被邀请者所属企业ID。
        /// </summary>
        [JsonProperty("orgID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgID { get; set; }

        /// <summary>
        /// 会议ID。
        /// </summary>
        [JsonProperty("confID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfID { get; set; }

        /// <summary>
        /// 会议的密码（主持人或者来宾）。
        /// </summary>
        [JsonProperty("pwd", NullValueHandling = NullValueHandling.Ignore)]
        public string Pwd { get; set; }

        /// <summary>
        /// SIP号码类型。默认是0。 * 0：华为云会议的号码 * 1：VC会议的号码 
        /// </summary>
        [JsonProperty("numBelongsType", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumBelongsType { get; set; }

        /// <summary>
        /// 是否不叠加会场名（VDC场景下适用）。
        /// </summary>
        [JsonProperty("isNotOverlayPidName", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNotOverlayPidName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestInviteWithPwdReqBody {\n");
            sb.Append("  callNum: ").Append(CallNum).Append("\n");
            sb.Append("  orgID: ").Append(OrgID).Append("\n");
            sb.Append("  confID: ").Append(ConfID).Append("\n");
            sb.Append("  pwd: ").Append(Pwd).Append("\n");
            sb.Append("  numBelongsType: ").Append(NumBelongsType).Append("\n");
            sb.Append("  isNotOverlayPidName: ").Append(IsNotOverlayPidName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestInviteWithPwdReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestInviteWithPwdReqBody input)
        {
            if (input == null) return false;
            if (this.CallNum != input.CallNum || (this.CallNum != null && !this.CallNum.Equals(input.CallNum))) return false;
            if (this.OrgID != input.OrgID || (this.OrgID != null && !this.OrgID.Equals(input.OrgID))) return false;
            if (this.ConfID != input.ConfID || (this.ConfID != null && !this.ConfID.Equals(input.ConfID))) return false;
            if (this.Pwd != input.Pwd || (this.Pwd != null && !this.Pwd.Equals(input.Pwd))) return false;
            if (this.NumBelongsType != input.NumBelongsType || (this.NumBelongsType != null && !this.NumBelongsType.Equals(input.NumBelongsType))) return false;
            if (this.IsNotOverlayPidName != input.IsNotOverlayPidName || (this.IsNotOverlayPidName != null && !this.IsNotOverlayPidName.Equals(input.IsNotOverlayPidName))) return false;

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
                if (this.CallNum != null) hashCode = hashCode * 59 + this.CallNum.GetHashCode();
                if (this.OrgID != null) hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                if (this.ConfID != null) hashCode = hashCode * 59 + this.ConfID.GetHashCode();
                if (this.Pwd != null) hashCode = hashCode * 59 + this.Pwd.GetHashCode();
                if (this.NumBelongsType != null) hashCode = hashCode * 59 + this.NumBelongsType.GetHashCode();
                if (this.IsNotOverlayPidName != null) hashCode = hashCode * 59 + this.IsNotOverlayPidName.GetHashCode();
                return hashCode;
            }
        }
    }
}
