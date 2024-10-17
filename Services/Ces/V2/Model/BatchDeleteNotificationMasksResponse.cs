using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteNotificationMasksResponse : SdkResponse
    {

        /// <summary>
        /// 删除成功的屏蔽规则ID
        /// </summary>
        [JsonProperty("notification_mask_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationMaskIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteNotificationMasksResponse {\n");
            sb.Append("  notificationMaskIds: ").Append(NotificationMaskIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteNotificationMasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteNotificationMasksResponse input)
        {
            if (input == null) return false;
            if (this.NotificationMaskIds != input.NotificationMaskIds || (this.NotificationMaskIds != null && input.NotificationMaskIds != null && !this.NotificationMaskIds.SequenceEqual(input.NotificationMaskIds))) return false;

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
                if (this.NotificationMaskIds != null) hashCode = hashCode * 59 + this.NotificationMaskIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
