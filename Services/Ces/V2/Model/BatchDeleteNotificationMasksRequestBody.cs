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
    /// 
    /// </summary>
    public class BatchDeleteNotificationMasksRequestBody 
    {

        /// <summary>
        /// 屏蔽规则编号
        /// </summary>
        [JsonProperty("notification_mask_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NotificationMaskIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteNotificationMasksRequestBody {\n");
            sb.Append("  notificationMaskIds: ").Append(NotificationMaskIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteNotificationMasksRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteNotificationMasksRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NotificationMaskIds == input.NotificationMaskIds ||
                    this.NotificationMaskIds != null &&
                    input.NotificationMaskIds != null &&
                    this.NotificationMaskIds.SequenceEqual(input.NotificationMaskIds)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.NotificationMaskIds != null)
                    hashCode = hashCode * 59 + this.NotificationMaskIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
