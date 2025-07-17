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
    public class CreateAuthRandomRequest 
    {

        /// <summary>
        /// 会议ID
        /// </summary>
        [SDKProperty("conf_id", IsQuery = true)]
        [JsonProperty("conf_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfId { get; set; }

        /// <summary>
        /// 0-不支持来宾会前等待页能力（默认）、1-支持来宾会前等待页能力
        /// </summary>
        [SDKProperty("guest_waiting", IsQuery = true)]
        [JsonProperty("guest_waiting", NullValueHandling = NullValueHandling.Ignore)]
        public int? GuestWaiting { get; set; }

        /// <summary>
        /// 会议密码
        /// </summary>
        [SDKProperty("X-Password", IsHeader = true)]
        [JsonProperty("X-Password", NullValueHandling = NullValueHandling.Ignore)]
        public string XPassword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAuthRandomRequest {\n");
            sb.Append("  confId: ").Append(ConfId).Append("\n");
            sb.Append("  guestWaiting: ").Append(GuestWaiting).Append("\n");
            sb.Append("  xPassword: ").Append(XPassword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAuthRandomRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAuthRandomRequest input)
        {
            if (input == null) return false;
            if (this.ConfId != input.ConfId || (this.ConfId != null && !this.ConfId.Equals(input.ConfId))) return false;
            if (this.GuestWaiting != input.GuestWaiting || (this.GuestWaiting != null && !this.GuestWaiting.Equals(input.GuestWaiting))) return false;
            if (this.XPassword != input.XPassword || (this.XPassword != null && !this.XPassword.Equals(input.XPassword))) return false;

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
                if (this.ConfId != null) hashCode = hashCode * 59 + this.ConfId.GetHashCode();
                if (this.GuestWaiting != null) hashCode = hashCode * 59 + this.GuestWaiting.GetHashCode();
                if (this.XPassword != null) hashCode = hashCode * 59 + this.XPassword.GetHashCode();
                return hashCode;
            }
        }
    }
}
