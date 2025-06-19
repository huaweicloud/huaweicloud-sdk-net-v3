using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AlertGroup 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dingTalkHookUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string DingTalkHookUrl { get; set; }

        /// <summary>
        /// 告警组名称
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 告警组ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("weChatWorkHookUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string WeChatWorkHookUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("weLinkGroupNo", NullValueHandling = NullValueHandling.Ignore)]
        public string WeLinkGroupNo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertGroup {\n");
            sb.Append("  dingTalkHookUrl: ").Append(DingTalkHookUrl).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  weChatWorkHookUrl: ").Append(WeChatWorkHookUrl).Append("\n");
            sb.Append("  weLinkGroupNo: ").Append(WeLinkGroupNo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlertGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlertGroup input)
        {
            if (input == null) return false;
            if (this.DingTalkHookUrl != input.DingTalkHookUrl || (this.DingTalkHookUrl != null && !this.DingTalkHookUrl.Equals(input.DingTalkHookUrl))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.WeChatWorkHookUrl != input.WeChatWorkHookUrl || (this.WeChatWorkHookUrl != null && !this.WeChatWorkHookUrl.Equals(input.WeChatWorkHookUrl))) return false;
            if (this.WeLinkGroupNo != input.WeLinkGroupNo || (this.WeLinkGroupNo != null && !this.WeLinkGroupNo.Equals(input.WeLinkGroupNo))) return false;

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
                if (this.DingTalkHookUrl != null) hashCode = hashCode * 59 + this.DingTalkHookUrl.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.WeChatWorkHookUrl != null) hashCode = hashCode * 59 + this.WeChatWorkHookUrl.GetHashCode();
                if (this.WeLinkGroupNo != null) hashCode = hashCode * 59 + this.WeLinkGroupNo.GetHashCode();
                return hashCode;
            }
        }
    }
}
