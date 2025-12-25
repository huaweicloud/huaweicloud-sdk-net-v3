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
    public class ListNotificationMasksResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 通知屏蔽列表 
        /// </summary>
        [JsonProperty("notification_masks", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListNotificationMaskRespNotificationMasks> NotificationMasks { get; set; }

        /// <summary>
        /// **参数解释**： 通知屏蔽列表总数 **取值范围**： [0,99999] 
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotificationMasksResponse {\n");
            sb.Append("  notificationMasks: ").Append(NotificationMasks).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotificationMasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotificationMasksResponse input)
        {
            if (input == null) return false;
            if (this.NotificationMasks != input.NotificationMasks || (this.NotificationMasks != null && input.NotificationMasks != null && !this.NotificationMasks.SequenceEqual(input.NotificationMasks))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.NotificationMasks != null) hashCode = hashCode * 59 + this.NotificationMasks.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
