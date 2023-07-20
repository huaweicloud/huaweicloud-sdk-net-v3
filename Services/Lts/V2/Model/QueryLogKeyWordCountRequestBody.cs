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
    /// 日志关键词统计请求体。
    /// </summary>
    public class QueryLogKeyWordCountRequestBody 
    {

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 步长间隔
        /// </summary>
        [JsonProperty("step_interval", NullValueHandling = NullValueHandling.Ignore)]
        public long? StepInterval { get; set; }

        /// <summary>
        /// 日志组ID
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 日志流ID
        /// </summary>
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 日志迭代查询，默认为false（不开启迭代），true为开启迭代。
        /// </summary>
        [JsonProperty("is_iterative", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIterative { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryLogKeyWordCountRequestBody {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  stepInterval: ").Append(StepInterval).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  isIterative: ").Append(IsIterative).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryLogKeyWordCountRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryLogKeyWordCountRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.StepInterval == input.StepInterval ||
                    (this.StepInterval != null &&
                    this.StepInterval.Equals(input.StepInterval))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.StreamId == input.StreamId ||
                    (this.StreamId != null &&
                    this.StreamId.Equals(input.StreamId))
                ) && 
                (
                    this.KeyWord == input.KeyWord ||
                    (this.KeyWord != null &&
                    this.KeyWord.Equals(input.KeyWord))
                ) && 
                (
                    this.IsIterative == input.IsIterative ||
                    (this.IsIterative != null &&
                    this.IsIterative.Equals(input.IsIterative))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StepInterval != null)
                    hashCode = hashCode * 59 + this.StepInterval.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.StreamId != null)
                    hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                if (this.KeyWord != null)
                    hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.IsIterative != null)
                    hashCode = hashCode * 59 + this.IsIterative.GetHashCode();
                return hashCode;
            }
        }
    }
}
