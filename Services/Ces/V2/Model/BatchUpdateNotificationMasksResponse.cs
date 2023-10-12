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
    public class BatchUpdateNotificationMasksResponse : SdkResponse
    {

        /// <summary>
        /// 创建成功的关联ID列表
        /// </summary>
        [JsonProperty("relation_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RelationIds { get; set; }

        /// <summary>
        /// 屏蔽规则ID
        /// </summary>
        [JsonProperty("notification_mask_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NotificationMaskId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateNotificationMasksResponse {\n");
            sb.Append("  relationIds: ").Append(RelationIds).Append("\n");
            sb.Append("  notificationMaskId: ").Append(NotificationMaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateNotificationMasksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateNotificationMasksResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RelationIds == input.RelationIds ||
                    this.RelationIds != null &&
                    input.RelationIds != null &&
                    this.RelationIds.SequenceEqual(input.RelationIds)
                ) && 
                (
                    this.NotificationMaskId == input.NotificationMaskId ||
                    (this.NotificationMaskId != null &&
                    this.NotificationMaskId.Equals(input.NotificationMaskId))
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
                if (this.RelationIds != null)
                    hashCode = hashCode * 59 + this.RelationIds.GetHashCode();
                if (this.NotificationMaskId != null)
                    hashCode = hashCode * 59 + this.NotificationMaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
