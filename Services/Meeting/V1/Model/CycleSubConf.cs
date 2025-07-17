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
    public class CycleSubConf 
    {

        /// <summary>
        /// 子会议UUID。
        /// </summary>
        [JsonProperty("cycleSubConfID", NullValueHandling = NullValueHandling.Ignore)]
        public string CycleSubConfID { get; set; }

        /// <summary>
        /// 会议ID。
        /// </summary>
        [JsonProperty("conferenceID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConferenceID { get; set; }

        /// <summary>
        /// 会议的媒体类型。 * Voice：语音 * Video：标清视频 * HDVideo：高清视频 * Data：数据 
        /// </summary>
        [JsonProperty("mediaType", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaType { get; set; }

        /// <summary>
        /// 会议起始时间(格式：YYYY-MM-DD HH:MM)。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 会议结束时间(格式：YYYY-MM-DD HH:MM)。
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否自动开启云录制。 - 0: 不自动启动 - 1: 自动启动 
        /// </summary>
        [JsonProperty("isAutoRecord", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsAutoRecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("confConfigInfo", NullValueHandling = NullValueHandling.Ignore)]
        public CycleSubConfConfigDTO ConfConfigInfo { get; set; }

        /// <summary>
        /// 观看/下载录播的鉴权方式。 - 0: 可通过链接观看/下载 - 1: 企业用户可观看/下载 - 2: 与会者可观看/下载 
        /// </summary>
        [JsonProperty("recordAuthType", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordAuthType { get; set; }

        /// <summary>
        /// 会议描述。长度限制为200个字符。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CycleSubConf {\n");
            sb.Append("  cycleSubConfID: ").Append(CycleSubConfID).Append("\n");
            sb.Append("  conferenceID: ").Append(ConferenceID).Append("\n");
            sb.Append("  mediaType: ").Append(MediaType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
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
            return this.Equals(input as CycleSubConf);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CycleSubConf input)
        {
            if (input == null) return false;
            if (this.CycleSubConfID != input.CycleSubConfID || (this.CycleSubConfID != null && !this.CycleSubConfID.Equals(input.CycleSubConfID))) return false;
            if (this.ConferenceID != input.ConferenceID || (this.ConferenceID != null && !this.ConferenceID.Equals(input.ConferenceID))) return false;
            if (this.MediaType != input.MediaType || (this.MediaType != null && !this.MediaType.Equals(input.MediaType))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
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
                if (this.ConferenceID != null) hashCode = hashCode * 59 + this.ConferenceID.GetHashCode();
                if (this.MediaType != null) hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.IsAutoRecord != null) hashCode = hashCode * 59 + this.IsAutoRecord.GetHashCode();
                if (this.ConfConfigInfo != null) hashCode = hashCode * 59 + this.ConfConfigInfo.GetHashCode();
                if (this.RecordAuthType != null) hashCode = hashCode * 59 + this.RecordAuthType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
