using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ConsumerGroupHeartBeatRequest 
    {

        /// <summary>
        /// 日志组ID，获取方式请参见：获取项目ID，获取账号ID，日志组ID、日志流ID。 缺省值：None 最小长度：36 最大长度：36
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 日志流ID，获取方式请参见：获取项目ID，获取账号ID，日志组ID、日志流ID 缺省值：None 最小长度：36 最大长度：36
        /// </summary>
        [SDKProperty("stream_id", IsPath = true)]
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }

        /// <summary>
        /// 消费组名
        /// </summary>
        [SDKProperty("consumer_group_name", IsPath = true)]
        [JsonProperty("consumer_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// 消费者名称
        /// </summary>
        [SDKProperty("consumer_name", IsQuery = true)]
        [JsonProperty("consumer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsumerGroupHeartBeatRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("  consumerGroupName: ").Append(ConsumerGroupName).Append("\n");
            sb.Append("  consumerName: ").Append(ConsumerName).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConsumerGroupHeartBeatRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConsumerGroupHeartBeatRequest input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.StreamId != input.StreamId || (this.StreamId != null && !this.StreamId.Equals(input.StreamId))) return false;
            if (this.ConsumerGroupName != input.ConsumerGroupName || (this.ConsumerGroupName != null && !this.ConsumerGroupName.Equals(input.ConsumerGroupName))) return false;
            if (this.ConsumerName != input.ConsumerName || (this.ConsumerName != null && !this.ConsumerName.Equals(input.ConsumerName))) return false;
            if (this.Body != input.Body || (this.Body != null && input.Body != null && !this.Body.SequenceEqual(input.Body))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.StreamId != null) hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                if (this.ConsumerGroupName != null) hashCode = hashCode * 59 + this.ConsumerGroupName.GetHashCode();
                if (this.ConsumerName != null) hashCode = hashCode * 59 + this.ConsumerName.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
