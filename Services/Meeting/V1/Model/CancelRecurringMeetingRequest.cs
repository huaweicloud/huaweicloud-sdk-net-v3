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
    public class CancelRecurringMeetingRequest 
    {

        /// <summary>
        /// 标识是否为第三方portal过来的请求。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("X-Authorization-Type", IsHeader = true)]
        [JsonProperty("X-Authorization-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthorizationType { get; set; }

        /// <summary>
        /// 用户的UUID。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("userUUID", IsQuery = true)]
        [JsonProperty("userUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUUID { get; set; }

        /// <summary>
        /// 用于区分到哪个HCSO站点鉴权。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("X-Site-Id", IsHeader = true)]
        [JsonProperty("X-Site-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XSiteId { get; set; }

        /// <summary>
        /// 会议ID。
        /// </summary>
        [SDKProperty("conferenceID", IsQuery = true)]
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 取消会议操作类型。默认已召开的会议不能取消。 * 1：需要结束正在召开的会议 
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelRecurringMeetingRequest {\n");
            sb.Append("  xAuthorizationType: ").Append(XAuthorizationType).Append("\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  xSiteId: ").Append(XSiteId).Append("\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelRecurringMeetingRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CancelRecurringMeetingRequest input)
        {
            if (input == null) return false;
            if (this.XAuthorizationType != input.XAuthorizationType || (this.XAuthorizationType != null && !this.XAuthorizationType.Equals(input.XAuthorizationType))) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.XSiteId != input.XSiteId || (this.XSiteId != null && !this.XSiteId.Equals(input.XSiteId))) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.XAuthorizationType != null) hashCode = hashCode * 59 + this.XAuthorizationType.GetHashCode();
                if (this.UserUUID != null) hashCode = hashCode * 59 + this.UserUUID.GetHashCode();
                if (this.XSiteId != null) hashCode = hashCode * 59 + this.XSiteId.GetHashCode();
                if (this.ConferenceID != null) hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
