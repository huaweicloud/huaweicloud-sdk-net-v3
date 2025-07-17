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
    public class ListNetworkQualityRequest 
    {

        /// <summary>
        /// 会议id
        /// </summary>
        [SDKProperty("conferenceid", IsQuery = true)]
        [JsonProperty("conferenceid", NullValueHandling = NullValueHandling.Ignore)]
        public string Conferenceid { get; set; }

        /// <summary>
        /// 会控Token，通过[[获取会控token](https://support.huaweicloud.com/api-meeting/meeting_21_0027.html)](tag:hws)[[获取会控token](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0027.html)](tag:hk)接口获得。
        /// </summary>
        [SDKProperty("confToken", IsHeader = true)]
        [JsonProperty("confToken", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfToken { get; set; }

        /// <summary>
        /// 会议的appId
        /// </summary>
        [SDKProperty("appid", IsQuery = true)]
        [JsonProperty("appid", NullValueHandling = NullValueHandling.Ignore)]
        public string Appid { get; set; }

        /// <summary>
        /// 会议UUID，MMR房间ID
        /// </summary>
        [SDKProperty("confuuid", IsQuery = true)]
        [JsonProperty("confuuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Confuuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public RestQosRequestDTO Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNetworkQualityRequest {\n");
            sb.Append("  conferenceid: ").Append(Conferenceid).Append("\n");
            sb.Append("  confToken: ").Append(ConfToken).Append("\n");
            sb.Append("  appid: ").Append(Appid).Append("\n");
            sb.Append("  confuuid: ").Append(Confuuid).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNetworkQualityRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNetworkQualityRequest input)
        {
            if (input == null) return false;
            if (this.Conferenceid != input.Conferenceid || (this.Conferenceid != null && !this.Conferenceid.Equals(input.Conferenceid))) return false;
            if (this.ConfToken != input.ConfToken || (this.ConfToken != null && !this.ConfToken.Equals(input.ConfToken))) return false;
            if (this.Appid != input.Appid || (this.Appid != null && !this.Appid.Equals(input.Appid))) return false;
            if (this.Confuuid != input.Confuuid || (this.Confuuid != null && !this.Confuuid.Equals(input.Confuuid))) return false;
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
                if (this.Conferenceid != null) hashCode = hashCode * 59 + this.Conferenceid.GetHashCode();
                if (this.ConfToken != null) hashCode = hashCode * 59 + this.ConfToken.GetHashCode();
                if (this.Appid != null) hashCode = hashCode * 59 + this.Appid.GetHashCode();
                if (this.Confuuid != null) hashCode = hashCode * 59 + this.Confuuid.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
