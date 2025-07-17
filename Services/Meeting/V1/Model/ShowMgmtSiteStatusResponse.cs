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
    /// Response Object
    /// </summary>
    public class ShowMgmtSiteStatusResponse : SdkResponse
    {

        /// <summary>
        /// 管理站点状态 NORMAL:正常  FAULT:故障
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 链接入会跳转url
        /// </summary>
        [JsonProperty("redirectJoinUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string RedirectJoinUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMgmtSiteStatusResponse {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  redirectJoinUrl: ").Append(RedirectJoinUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMgmtSiteStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMgmtSiteStatusResponse input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RedirectJoinUrl != input.RedirectJoinUrl || (this.RedirectJoinUrl != null && !this.RedirectJoinUrl.Equals(input.RedirectJoinUrl))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RedirectJoinUrl != null) hashCode = hashCode * 59 + this.RedirectJoinUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
