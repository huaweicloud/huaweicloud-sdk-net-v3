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
    public class DeleteRecordingsRequest 
    {

        /// <summary>
        /// 会议UUID列表，多个会议UUID之间以英文逗号隔开。
        /// </summary>
        [SDKProperty("confUUIDs", IsQuery = true)]
        [JsonProperty("confUUIDs", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUIDs { get; set; }

        /// <summary>
        /// 用户的UUID。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("userUUID", IsQuery = true)]
        [JsonProperty("userUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUUID { get; set; }

        /// <summary>
        /// 标识是否为第三方portal过来的请求。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("X-Authorization-Type", IsHeader = true)]
        [JsonProperty("X-Authorization-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthorizationType { get; set; }

        /// <summary>
        /// 用于区分到哪个HCSO站点鉴权。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("X-Site-Id", IsHeader = true)]
        [JsonProperty("X-Site-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XSiteId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRecordingsRequest {\n");
            sb.Append("  confUUIDs: ").Append(ConfUUIDs).Append("\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  xAuthorizationType: ").Append(XAuthorizationType).Append("\n");
            sb.Append("  xSiteId: ").Append(XSiteId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteRecordingsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteRecordingsRequest input)
        {
            if (input == null) return false;
            if (this.ConfUUIDs != input.ConfUUIDs || (this.ConfUUIDs != null && !this.ConfUUIDs.Equals(input.ConfUUIDs))) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.XAuthorizationType != input.XAuthorizationType || (this.XAuthorizationType != null && !this.XAuthorizationType.Equals(input.XAuthorizationType))) return false;
            if (this.XSiteId != input.XSiteId || (this.XSiteId != null && !this.XSiteId.Equals(input.XSiteId))) return false;

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
                if (this.ConfUUIDs != null) hashCode = hashCode * 59 + this.ConfUUIDs.GetHashCode();
                if (this.UserUUID != null) hashCode = hashCode * 59 + this.UserUUID.GetHashCode();
                if (this.XAuthorizationType != null) hashCode = hashCode * 59 + this.XAuthorizationType.GetHashCode();
                if (this.XSiteId != null) hashCode = hashCode * 59 + this.XSiteId.GetHashCode();
                return hashCode;
            }
        }
    }
}
