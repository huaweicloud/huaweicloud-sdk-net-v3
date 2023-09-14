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
    /// 返回的日志流信息
    /// </summary>
    public class LogStreamResBody 
    {

        /// <summary>
        /// 创建时间 最小值：1577808000000 最大值：4102416000000
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// 日志流ID
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 日志流名称
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// 日志流所属标签
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tag { get; set; }

        /// <summary>
        /// 过滤器个数
        /// </summary>
        [JsonProperty("filter_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FilterCount { get; set; }

        /// <summary>
        /// 是否收藏日志流。
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogStreamResBody {\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  filterCount: ").Append(FilterCount).Append("\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogStreamResBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogStreamResBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.LogStreamId == input.LogStreamId ||
                    (this.LogStreamId != null &&
                    this.LogStreamId.Equals(input.LogStreamId))
                ) && 
                (
                    this.LogStreamName == input.LogStreamName ||
                    (this.LogStreamName != null &&
                    this.LogStreamName.Equals(input.LogStreamName))
                ) && 
                (
                    this.Tag == input.Tag ||
                    this.Tag != null &&
                    input.Tag != null &&
                    this.Tag.SequenceEqual(input.Tag)
                ) && 
                (
                    this.FilterCount == input.FilterCount ||
                    (this.FilterCount != null &&
                    this.FilterCount.Equals(input.FilterCount))
                ) && 
                (
                    this.IsFavorite == input.IsFavorite ||
                    (this.IsFavorite != null &&
                    this.IsFavorite.Equals(input.IsFavorite))
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
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LogStreamId != null)
                    hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogStreamName != null)
                    hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.FilterCount != null)
                    hashCode = hashCode * 59 + this.FilterCount.GetHashCode();
                if (this.IsFavorite != null)
                    hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                return hashCode;
            }
        }
    }
}
