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
    /// Request Object
    /// </summary>
    public class ShowInstanceMessagesRequest 
    {

        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Topic名称。  Topic名称必须以字母开头且只支持大小写字母、中横线、下划线以及数字。
        /// </summary>
        [SDKProperty("topic", IsQuery = true)]
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 是否按照时间排序。
        /// </summary>
        [SDKProperty("asc", IsQuery = true)]
        [JsonProperty("asc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Asc { get; set; }

        /// <summary>
        /// 开始时间。  Unix毫秒时间戳。  查询消息偏移量时，为必选参数。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。  Unix毫秒时间戳。  查询消息偏移量时，为必选参数。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 每一页显示的message数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 页数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// 是否下载。
        /// </summary>
        [SDKProperty("download", IsQuery = true)]
        [JsonProperty("download", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Download { get; set; }

        /// <summary>
        /// 消息偏移量。  **查询消息内容时，为必选参数。**  若start_time、end_time参数不为空，该参数无效。
        /// </summary>
        [SDKProperty("message_offset", IsQuery = true)]
        [JsonProperty("message_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageOffset { get; set; }

        /// <summary>
        /// 分区。  **查询消息内容时，为必选参数。**  若start_time、end_time参数不为空，该参数无效。
        /// </summary>
        [SDKProperty("partition", IsQuery = true)]
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public string Partition { get; set; }

        /// <summary>
        /// 关键词。 取值范围为0~50。
        /// </summary>
        [SDKProperty("keyword", IsQuery = true)]
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceMessagesRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  asc: ").Append(Asc).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  download: ").Append(Download).Append("\n");
            sb.Append("  messageOffset: ").Append(MessageOffset).Append("\n");
            sb.Append("  partition: ").Append(Partition).Append("\n");
            sb.Append("  keyword: ").Append(Keyword).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceMessagesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceMessagesRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.Asc != input.Asc || (this.Asc != null && !this.Asc.Equals(input.Asc))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Download != input.Download || (this.Download != null && !this.Download.Equals(input.Download))) return false;
            if (this.MessageOffset != input.MessageOffset || (this.MessageOffset != null && !this.MessageOffset.Equals(input.MessageOffset))) return false;
            if (this.Partition != input.Partition || (this.Partition != null && !this.Partition.Equals(input.Partition))) return false;
            if (this.Keyword != input.Keyword || (this.Keyword != null && !this.Keyword.Equals(input.Keyword))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.Asc != null) hashCode = hashCode * 59 + this.Asc.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Download != null) hashCode = hashCode * 59 + this.Download.GetHashCode();
                if (this.MessageOffset != null) hashCode = hashCode * 59 + this.MessageOffset.GetHashCode();
                if (this.Partition != null) hashCode = hashCode * 59 + this.Partition.GetHashCode();
                if (this.Keyword != null) hashCode = hashCode * 59 + this.Keyword.GetHashCode();
                return hashCode;
            }
        }
    }
}
