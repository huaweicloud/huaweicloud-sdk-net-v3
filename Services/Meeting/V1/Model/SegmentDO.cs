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
    /// 录制切片段落
    /// </summary>
    public class SegmentDO 
    {

        /// <summary>
        /// 录制人工分段序号，每次启动录制，生成一个分段
        /// </summary>
        [JsonProperty("manualOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int? ManualOrder { get; set; }

        /// <summary>
        /// 录制片段内的文件自动切片序号（每次启动录制后，每三小时一个分片文件，多次人工启动重新从1开始）
        /// </summary>
        [JsonProperty("segmentOrder", NullValueHandling = NullValueHandling.Ignore)]
        public int? SegmentOrder { get; set; }

        /// <summary>
        /// 录制分段总文件大小（字节）
        /// </summary>
        [JsonProperty("segmentSize", NullValueHandling = NullValueHandling.Ignore)]
        public string SegmentSize { get; set; }

        /// <summary>
        /// 录制文件自动切片列表，每3小时文件切片一次
        /// </summary>
        [JsonProperty("fileList", NullValueHandling = NullValueHandling.Ignore)]
        public List<SegmentFileDO> FileList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentDO {\n");
            sb.Append("  manualOrder: ").Append(ManualOrder).Append("\n");
            sb.Append("  segmentOrder: ").Append(SegmentOrder).Append("\n");
            sb.Append("  segmentSize: ").Append(SegmentSize).Append("\n");
            sb.Append("  fileList: ").Append(FileList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SegmentDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SegmentDO input)
        {
            if (input == null) return false;
            if (this.ManualOrder != input.ManualOrder || (this.ManualOrder != null && !this.ManualOrder.Equals(input.ManualOrder))) return false;
            if (this.SegmentOrder != input.SegmentOrder || (this.SegmentOrder != null && !this.SegmentOrder.Equals(input.SegmentOrder))) return false;
            if (this.SegmentSize != input.SegmentSize || (this.SegmentSize != null && !this.SegmentSize.Equals(input.SegmentSize))) return false;
            if (this.FileList != input.FileList || (this.FileList != null && input.FileList != null && !this.FileList.SequenceEqual(input.FileList))) return false;

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
                if (this.ManualOrder != null) hashCode = hashCode * 59 + this.ManualOrder.GetHashCode();
                if (this.SegmentOrder != null) hashCode = hashCode * 59 + this.SegmentOrder.GetHashCode();
                if (this.SegmentSize != null) hashCode = hashCode * 59 + this.SegmentSize.GetHashCode();
                if (this.FileList != null) hashCode = hashCode * 59 + this.FileList.GetHashCode();
                return hashCode;
            }
        }
    }
}
