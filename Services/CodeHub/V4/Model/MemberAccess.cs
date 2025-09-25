using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MemberAccess 
    {

        /// <summary>
        /// **参数解释：** 访问级别。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("access_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessLevel { get; set; }

        /// <summary>
        /// **参数解释：** 通知级别。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("notification_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? NotificationLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberAccess {\n");
            sb.Append("  accessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  notificationLevel: ").Append(NotificationLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemberAccess);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MemberAccess input)
        {
            if (input == null) return false;
            if (this.AccessLevel != input.AccessLevel || (this.AccessLevel != null && !this.AccessLevel.Equals(input.AccessLevel))) return false;
            if (this.NotificationLevel != input.NotificationLevel || (this.NotificationLevel != null && !this.NotificationLevel.Equals(input.NotificationLevel))) return false;

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
                if (this.AccessLevel != null) hashCode = hashCode * 59 + this.AccessLevel.GetHashCode();
                if (this.NotificationLevel != null) hashCode = hashCode * 59 + this.NotificationLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
