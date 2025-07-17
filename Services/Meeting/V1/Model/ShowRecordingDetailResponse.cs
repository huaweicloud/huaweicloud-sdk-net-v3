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
    /// Response Object
    /// </summary>
    public class ShowRecordingDetailResponse : SdkResponse
    {

        /// <summary>
        /// 会议UUID。
        /// </summary>
        [JsonProperty("confUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUUID { get; set; }

        /// <summary>
        /// 会议ID。
        /// </summary>
        [JsonProperty("confID", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfID { get; set; }

        /// <summary>
        /// 录播观看地址。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Url { get; set; }

        /// <summary>
        /// 录制时长（单位秒）。
        /// </summary>
        [JsonProperty("rcdTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? RcdTime { get; set; }

        /// <summary>
        /// 录制文件大小（MB）。
        /// </summary>
        [JsonProperty("rcdSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? RcdSize { get; set; }

        /// <summary>
        /// 会议主题。
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string Subject { get; set; }

        /// <summary>
        /// 会议预订者名称。
        /// </summary>
        [JsonProperty("scheduserName", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduserName { get; set; }

        /// <summary>
        /// 会议开始时间。
        /// </summary>
        [JsonProperty("startTime", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 录制文件是否转码完成。
        /// </summary>
        [JsonProperty("isDecodeFinish", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDecodeFinish { get; set; }

        /// <summary>
        /// 录制文件预计转码完成时间。
        /// </summary>
        [JsonProperty("decodeEndTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? DecodeEndTime { get; set; }

        /// <summary>
        /// 录播文件是否可观看。
        /// </summary>
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Available { get; set; }

        /// <summary>
        /// 观看/下载录播的鉴权方式。 - 0: 可通过链接观看/下载 - 1: 企业用户可观看/下载 - 2: 与会者可观看/下载
        /// </summary>
        [JsonProperty("recordAuthType", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordAuthType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRecordingDetailResponse {\n");
            sb.Append("  confUUID: ").Append(ConfUUID).Append("\n");
            sb.Append("  confID: ").Append(ConfID).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  rcdTime: ").Append(RcdTime).Append("\n");
            sb.Append("  rcdSize: ").Append(RcdSize).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("  scheduserName: ").Append(ScheduserName).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  isDecodeFinish: ").Append(IsDecodeFinish).Append("\n");
            sb.Append("  decodeEndTime: ").Append(DecodeEndTime).Append("\n");
            sb.Append("  available: ").Append(Available).Append("\n");
            sb.Append("  recordAuthType: ").Append(RecordAuthType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRecordingDetailResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRecordingDetailResponse input)
        {
            if (input == null) return false;
            if (this.ConfUUID != input.ConfUUID || (this.ConfUUID != null && !this.ConfUUID.Equals(input.ConfUUID))) return false;
            if (this.ConfID != input.ConfID || (this.ConfID != null && !this.ConfID.Equals(input.ConfID))) return false;
            if (this.Url != input.Url || (this.Url != null && input.Url != null && !this.Url.SequenceEqual(input.Url))) return false;
            if (this.RcdTime != input.RcdTime || (this.RcdTime != null && !this.RcdTime.Equals(input.RcdTime))) return false;
            if (this.RcdSize != input.RcdSize || (this.RcdSize != null && !this.RcdSize.Equals(input.RcdSize))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;
            if (this.ScheduserName != input.ScheduserName || (this.ScheduserName != null && !this.ScheduserName.Equals(input.ScheduserName))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.IsDecodeFinish != input.IsDecodeFinish || (this.IsDecodeFinish != null && !this.IsDecodeFinish.Equals(input.IsDecodeFinish))) return false;
            if (this.DecodeEndTime != input.DecodeEndTime || (this.DecodeEndTime != null && !this.DecodeEndTime.Equals(input.DecodeEndTime))) return false;
            if (this.Available != input.Available || (this.Available != null && !this.Available.Equals(input.Available))) return false;
            if (this.RecordAuthType != input.RecordAuthType || (this.RecordAuthType != null && !this.RecordAuthType.Equals(input.RecordAuthType))) return false;

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
                if (this.ConfID != null) hashCode = hashCode * 59 + this.ConfID.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.RcdTime != null) hashCode = hashCode * 59 + this.RcdTime.GetHashCode();
                if (this.RcdSize != null) hashCode = hashCode * 59 + this.RcdSize.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.ScheduserName != null) hashCode = hashCode * 59 + this.ScheduserName.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.IsDecodeFinish != null) hashCode = hashCode * 59 + this.IsDecodeFinish.GetHashCode();
                if (this.DecodeEndTime != null) hashCode = hashCode * 59 + this.DecodeEndTime.GetHashCode();
                if (this.Available != null) hashCode = hashCode * 59 + this.Available.GetHashCode();
                if (this.RecordAuthType != null) hashCode = hashCode * 59 + this.RecordAuthType.GetHashCode();
                return hashCode;
            }
        }
    }
}
