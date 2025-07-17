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
    /// 网络研讨会通知配置。
    /// </summary>
    public class OpenNotifySetting 
    {

        /// <summary>
        /// 发送邮件日历是否开启。 * Y：开启 * N： 不开启 
        /// </summary>
        [JsonProperty("enableCalendar", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableCalendar { get; set; }

        /// <summary>
        /// 发送短信通知是否开启。 * Y：开启 * N： 不开启 
        /// </summary>
        [JsonProperty("enableSms", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableSms { get; set; }

        /// <summary>
        /// 发送邮件是否开启。 * Y：开启 * N： 不开启 
        /// </summary>
        [JsonProperty("enableEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string EnableEmail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenNotifySetting {\n");
            sb.Append("  enableCalendar: ").Append(EnableCalendar).Append("\n");
            sb.Append("  enableSms: ").Append(EnableSms).Append("\n");
            sb.Append("  enableEmail: ").Append(EnableEmail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenNotifySetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenNotifySetting input)
        {
            if (input == null) return false;
            if (this.EnableCalendar != input.EnableCalendar || (this.EnableCalendar != null && !this.EnableCalendar.Equals(input.EnableCalendar))) return false;
            if (this.EnableSms != input.EnableSms || (this.EnableSms != null && !this.EnableSms.Equals(input.EnableSms))) return false;
            if (this.EnableEmail != input.EnableEmail || (this.EnableEmail != null && !this.EnableEmail.Equals(input.EnableEmail))) return false;

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
                if (this.EnableCalendar != null) hashCode = hashCode * 59 + this.EnableCalendar.GetHashCode();
                if (this.EnableSms != null) hashCode = hashCode * 59 + this.EnableSms.GetHashCode();
                if (this.EnableEmail != null) hashCode = hashCode * 59 + this.EnableEmail.GetHashCode();
                return hashCode;
            }
        }
    }
}
