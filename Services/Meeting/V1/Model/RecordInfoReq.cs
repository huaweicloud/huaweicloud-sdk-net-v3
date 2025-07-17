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
    /// 录制会议文件信息请求体
    /// </summary>
    public class RecordInfoReq 
    {

        /// <summary>
        /// 会议uuid
        /// </summary>
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordInfoReq {\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  segmentOffset: ").Append(SegmentOffset).Append("\n");
            sb.Append("  segmentLimit: ").Append(SegmentLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordInfoReq input)
        {
            if (input == null) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.SegmentOffset != input.SegmentOffset || (this.SegmentOffset != null && !this.SegmentOffset.Equals(input.SegmentOffset))) return false;
            if (this.SegmentLimit != input.SegmentLimit || (this.SegmentLimit != null && !this.SegmentLimit.Equals(input.SegmentLimit))) return false;

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
                if (this.ConfUUID != null) hashCode = hashCode * 59 + this.ConfUUID.GetHashCode();
                if (this.SegmentOffset != null) hashCode = hashCode * 59 + this.SegmentOffset.GetHashCode();
                if (this.SegmentLimit != null) hashCode = hashCode * 59 + this.SegmentLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
