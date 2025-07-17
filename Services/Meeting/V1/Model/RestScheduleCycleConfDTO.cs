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
    /// 
    /// </summary>
    public class RestScheduleCycleConfDTO 
    {

        /// <summary>
        /// 子会议UUID。
        /// </summary>
        [JsonProperty("cycleSubConfID", NullValueHandling = NullValueHandling.Ignore)]
        public string CycleSubConfID { get; set; }

        /// <summary>
        /// 会议的媒体类型。 * Voice：语音会议 * HDVideo：视频会议 
        /// </summary>
        [JsonProperty("mediaTypes", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaTypes { get; set; }

        /// <summary>
        /// 会议开始时间（UTC时间）。格式：yyyy-MM-dd HH:mm。 &gt; * 如果没有指定开始时间或填空串，则表示会议马上开始 &gt; * 时间是UTC时间，即0时区的时间 
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 会议持续时长，单位分钟。默认30分钟。最大1440分钟（24小时），最小15分钟。 
        /// </summary>
        [JsonProperty("length", NullValueHandling = NullValueHandling.Ignore)]
        public int? Length { get; set; }

        /// <summary>
        /// 会议是否自动启动录制，在录播类型为：录播、录播+直播时才生效。默认为不自动启动。 * 1：自动启动录制 * 0：不自动启动录制 
        /// </summary>
        [JsonProperty("isAutoRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confConfigInfo", NullValueHandling = NullValueHandling.Ignore)]
        public CycleSubConfConfigDTO ConfConfigInfo { get; set; }

        /// <summary>
        /// 录播观看鉴权方式，在录播类型为:录播、直播+录播时有效。 * 0：可通过链接观看/下载 * 1：企业用户可观看/下载 * 2：与会者可观看/下载 
        /// </summary>
        [JsonProperty("recordAuthType", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordAuthType { get; set; }

        /// <summary>
        /// 会议描述，长度限制为200个字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestScheduleCycleConfDTO {\n");
            sb.Append("  cycleSubConfID: ").Append(CycleSubConfID).Append("\n");
            sb.Append("  mediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  length: ").Append(Length).Append("\n");
            sb.Append("  isAutoRecord: ").Append(IsAutoRecord).Append("\n");
            sb.Append("  confConfigInfo: ").Append(ConfConfigInfo).Append("\n");
            sb.Append("  recordAuthType: ").Append(RecordAuthType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestScheduleCycleConfDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestScheduleCycleConfDTO input)
        {
            if (input == null) return false;
            if (this.CycleSubConfID != input.CycleSubConfID || (this.CycleSubConfID != null && !this.CycleSubConfID.Equals(input.CycleSubConfID))) return false;
            if (this.MediaTypes != input.MediaTypes || (this.MediaTypes != null && !this.MediaTypes.Equals(input.MediaTypes))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.Length != input.Length || (this.Length != null && !this.Length.Equals(input.Length))) return false;
            if (this.IsAutoRecord != input.IsAutoRecord || (this.IsAutoRecord != null && !this.IsAutoRecord.Equals(input.IsAutoRecord))) return false;
            if (this.ConfConfigInfo != input.ConfConfigInfo || (this.ConfConfigInfo != null && !this.ConfConfigInfo.Equals(input.ConfConfigInfo))) return false;
            if (this.RecordAuthType != input.RecordAuthType || (this.RecordAuthType != null && !this.RecordAuthType.Equals(input.RecordAuthType))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.CycleSubConfID != null) hashCode = hashCode * 59 + this.CycleSubConfID.GetHashCode();
                if (this.MediaTypes != null) hashCode = hashCode * 59 + this.MediaTypes.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Length != null) hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.IsAutoRecord != null) hashCode = hashCode * 59 + this.IsAutoRecord.GetHashCode();
                if (this.ConfConfigInfo != null) hashCode = hashCode * 59 + this.ConfConfigInfo.GetHashCode();
                if (this.RecordAuthType != null) hashCode = hashCode * 59 + this.RecordAuthType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
