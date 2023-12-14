using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// RocketMQ元数据迁移，RocketMQ topic元数据。
    /// </summary>
    public class MigrationRocketMqTopicConfig 
    {

        /// <summary>
        /// topic名称。
        /// </summary>
        [JsonProperty("topicName", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicName { get; set; }

        /// <summary>
        /// 是否有序消息。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Order { get; set; }

        /// <summary>
        /// topic权限。
        /// </summary>
        [JsonProperty("perm", NullValueHandling = NullValueHandling.Ignore)]
        public int? Perm { get; set; }

        /// <summary>
        /// 读队列个数。
        /// </summary>
        [JsonProperty("readQueueNums", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadQueueNums { get; set; }

        /// <summary>
        /// 写队列个数。
        /// </summary>
        [JsonProperty("writeQueueNums", NullValueHandling = NullValueHandling.Ignore)]
        public int? WriteQueueNums { get; set; }

        /// <summary>
        /// topic过滤类型。   - SINGLE_TAG：单标签   - MULTI_TAG：多标签
        /// </summary>
        [JsonProperty("topicFilterType", NullValueHandling = NullValueHandling.Ignore)]
        public string TopicFilterType { get; set; }

        /// <summary>
        /// topic系统标志位。
        /// </summary>
        [JsonProperty("topicSysFlag", NullValueHandling = NullValueHandling.Ignore)]
        public int? TopicSysFlag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrationRocketMqTopicConfig {\n");
            sb.Append("  topicName: ").Append(TopicName).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  perm: ").Append(Perm).Append("\n");
            sb.Append("  readQueueNums: ").Append(ReadQueueNums).Append("\n");
            sb.Append("  writeQueueNums: ").Append(WriteQueueNums).Append("\n");
            sb.Append("  topicFilterType: ").Append(TopicFilterType).Append("\n");
            sb.Append("  topicSysFlag: ").Append(TopicSysFlag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrationRocketMqTopicConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrationRocketMqTopicConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopicName == input.TopicName ||
                    (this.TopicName != null &&
                    this.TopicName.Equals(input.TopicName))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Perm == input.Perm ||
                    (this.Perm != null &&
                    this.Perm.Equals(input.Perm))
                ) && 
                (
                    this.ReadQueueNums == input.ReadQueueNums ||
                    (this.ReadQueueNums != null &&
                    this.ReadQueueNums.Equals(input.ReadQueueNums))
                ) && 
                (
                    this.WriteQueueNums == input.WriteQueueNums ||
                    (this.WriteQueueNums != null &&
                    this.WriteQueueNums.Equals(input.WriteQueueNums))
                ) && 
                (
                    this.TopicFilterType == input.TopicFilterType ||
                    (this.TopicFilterType != null &&
                    this.TopicFilterType.Equals(input.TopicFilterType))
                ) && 
                (
                    this.TopicSysFlag == input.TopicSysFlag ||
                    (this.TopicSysFlag != null &&
                    this.TopicSysFlag.Equals(input.TopicSysFlag))
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
                if (this.TopicName != null)
                    hashCode = hashCode * 59 + this.TopicName.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Perm != null)
                    hashCode = hashCode * 59 + this.Perm.GetHashCode();
                if (this.ReadQueueNums != null)
                    hashCode = hashCode * 59 + this.ReadQueueNums.GetHashCode();
                if (this.WriteQueueNums != null)
                    hashCode = hashCode * 59 + this.WriteQueueNums.GetHashCode();
                if (this.TopicFilterType != null)
                    hashCode = hashCode * 59 + this.TopicFilterType.GetHashCode();
                if (this.TopicSysFlag != null)
                    hashCode = hashCode * 59 + this.TopicSysFlag.GetHashCode();
                return hashCode;
            }
        }
    }
}
