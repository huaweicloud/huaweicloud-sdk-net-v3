using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 响应基础类
    /// </summary>
    public class RecordInfoDO 
    {

        /// <summary>
        /// 会议主题
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 会议录制开始时间
        /// </summary>
        [JsonProperty("beginTime", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 录制段落查询偏移量
        /// </summary>
        [JsonProperty("segmentOffset", NullValueHandling = NullValueHandling.Ignore)]
        public int? SegmentOffset { get; set; }

        /// <summary>
        /// 录制段落查询数量
        /// </summary>
        [JsonProperty("segmentLimit", NullValueHandling = NullValueHandling.Ignore)]
        public int? SegmentLimit { get; set; }

        /// <summary>
        /// 录制段落总数
        /// </summary>
        [JsonProperty("segmentCount", NullValueHandling = NullValueHandling.Ignore)]
        public long? SegmentCount { get; set; }

        /// <summary>
        /// 录制人工启动/停止分段列表
        /// </summary>
        [JsonProperty("segmentList", NullValueHandling = NullValueHandling.Ignore)]
        public List<SegmentDO> SegmentList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordInfoDO {\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  segmentOffset: ").Append(SegmentOffset).Append("\n");
            sb.Append("  segmentLimit: ").Append(SegmentLimit).Append("\n");
            sb.Append("  segmentCount: ").Append(SegmentCount).Append("\n");
            sb.Append("  segmentList: ").Append(SegmentList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordInfoDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordInfoDO input)
        {
            if (input == null) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.SegmentOffset != input.SegmentOffset || (this.SegmentOffset != null && !this.SegmentOffset.Equals(input.SegmentOffset))) return false;
            if (this.SegmentLimit != input.SegmentLimit || (this.SegmentLimit != null && !this.SegmentLimit.Equals(input.SegmentLimit))) return false;
            if (this.SegmentCount != input.SegmentCount || (this.SegmentCount != null && !this.SegmentCount.Equals(input.SegmentCount))) return false;
            if (this.SegmentList != input.SegmentList || (this.SegmentList != null && input.SegmentList != null && !this.SegmentList.SequenceEqual(input.SegmentList))) return false;

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
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.SegmentOffset != null) hashCode = hashCode * 59 + this.SegmentOffset.GetHashCode();
                if (this.SegmentLimit != null) hashCode = hashCode * 59 + this.SegmentLimit.GetHashCode();
                if (this.SegmentCount != null) hashCode = hashCode * 59 + this.SegmentCount.GetHashCode();
                if (this.SegmentList != null) hashCode = hashCode * 59 + this.SegmentList.GetHashCode();
                return hashCode;
            }
        }
    }
}
