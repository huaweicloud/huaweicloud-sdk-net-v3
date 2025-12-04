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
        /// **参数解释**： 实例ID。获取方法如下：调用“查询所有实例列表”接口，从响应体中获取实例ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： Topic名称。 **约束限制**： Topic名称必须以字母开头且只支持大小写字母、中横线、下划线以及数字。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("topic", IsQuery = true)]
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// **参数解释**： 是否按照时间排序。 **约束限制**： 不涉及。 **取值范围**： - true：按照时间排序。 - false：不按照时间排序。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("asc", IsQuery = true)]
        [JsonProperty("asc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Asc { get; set; }

        /// <summary>
        /// **参数解释**： 开始时间。  Unix毫秒时间戳。  **约束限制**： 查询消息偏移量时，为必选参数。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间。  Unix毫秒时间戳。  **约束限制**： 查询消息偏移量时，为必选参数。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 每一页显示的消息数量。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// **参数解释**： 页数。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// **参数解释**： 是否下载消息到本地。 **约束限制**： 不涉及。 **取值范围**： - true：下载。 - false：不下载。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("download", IsQuery = true)]
        [JsonProperty("download", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Download { get; set; }

        /// <summary>
        /// **参数解释**： 消息偏移量。 **约束限制**： 查询消息内容时，为必选参数。  若start_time、end_time参数不为空，该参数无效。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("message_offset", IsQuery = true)]
        [JsonProperty("message_offset", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageOffset { get; set; }

        /// <summary>
        /// **参数解释**： 分区。 **约束限制**： 查询消息内容时，为必选参数。  若start_time、end_time参数不为空，该参数无效。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("partition", IsQuery = true)]
        [JsonProperty("partition", NullValueHandling = NullValueHandling.Ignore)]
        public string Partition { get; set; }

        /// <summary>
        /// **参数解释**： 设置查询消息的关键词。 **约束限制**： 不涉及。 **取值范围**： 0~50字符。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("keyword", IsQuery = true)]
        [JsonProperty("keyword", NullValueHandling = NullValueHandling.Ignore)]
        public string Keyword { get; set; }

        /// <summary>
        /// **参数解释**： 设置消息的KEY，查询结果为包含KEY的所有消息。 **约束限制**： 由于查询资源和性能限制，最大搜索10000条消息且所有消息总大小不超过200MB，最多返回包含KEY的前10条消息。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("key", IsQuery = true)]
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**： 设置消息正文中包含的关键词，查询结果为包含此关键词的消息。 **约束限制**： 多个关键字用%2C隔开，%2C是“,”的URL编码形式。 **取值范围**： include与exclude的关键词总数不得超过20个。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("include", IsQuery = true)]
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public string Include { get; set; }

        /// <summary>
        /// **参数解释**： 设置消息正文中需要排除的关键词，查询结果为不包含此关键词的消息。 **约束限制**： 多个关键字用%2C隔开，%2C是“,”的URL编码形式。 **取值范围**： include与exclude的关键词总数不得超过20个。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("exclude", IsQuery = true)]
        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public string Exclude { get; set; }



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
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  include: ").Append(Include).Append("\n");
            sb.Append("  exclude: ").Append(Exclude).Append("\n");
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
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Include != input.Include || (this.Include != null && !this.Include.Equals(input.Include))) return false;
            if (this.Exclude != input.Exclude || (this.Exclude != null && !this.Exclude.Equals(input.Exclude))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Include != null) hashCode = hashCode * 59 + this.Include.GetHashCode();
                if (this.Exclude != null) hashCode = hashCode * 59 + this.Exclude.GetHashCode();
                return hashCode;
            }
        }
    }
}
