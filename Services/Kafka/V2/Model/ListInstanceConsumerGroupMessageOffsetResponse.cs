using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceConsumerGroupMessageOffsetResponse : SdkResponse
    {

        /// <summary>
        /// 消费组消息位点详情
        /// </summary>
        [JsonProperty("group_message_offsets", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupMessageOffsetsDetailEntity> GroupMessageOffsets { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceConsumerGroupMessageOffsetResponse {\n");
            sb.Append("  groupMessageOffsets: ").Append(GroupMessageOffsets).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceConsumerGroupMessageOffsetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceConsumerGroupMessageOffsetResponse input)
        {
            if (input == null) return false;
            if (this.GroupMessageOffsets != input.GroupMessageOffsets || (this.GroupMessageOffsets != null && input.GroupMessageOffsets != null && !this.GroupMessageOffsets.SequenceEqual(input.GroupMessageOffsets))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.GroupMessageOffsets != null) hashCode = hashCode * 59 + this.GroupMessageOffsets.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
