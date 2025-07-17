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
    /// 与会者记录。
    /// </summary>
    public class ConfAttendeeRecordInfo 
    {

        /// <summary>
        /// 与会者名称。
        /// </summary>
        [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 号码。
        /// </summary>
        [JsonProperty("callNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string CallNumber { get; set; }

        /// <summary>
        /// 设备类型。
        /// </summary>
        [JsonProperty("deviceType", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceType { get; set; }

        /// <summary>
        /// 入会时间（UTC时间，单位毫秒）。
        /// </summary>
        [JsonProperty("joinTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? JoinTime { get; set; }

        /// <summary>
        /// 离会时间（UTC时间，单位毫秒）。
        /// </summary>
        [JsonProperty("leftTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? LeftTime { get; set; }

        /// <summary>
        /// 媒体类型。
        /// </summary>
        [JsonProperty("mediaType", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaType { get; set; }

        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfAttendeeRecordInfo {\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  callNumber: ").Append(CallNumber).Append("\n");
            sb.Append("  deviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  joinTime: ").Append(JoinTime).Append("\n");
            sb.Append("  leftTime: ").Append(LeftTime).Append("\n");
            sb.Append("  mediaType: ").Append(MediaType).Append("\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfAttendeeRecordInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfAttendeeRecordInfo input)
        {
            if (input == null) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.CallNumber != input.CallNumber || (this.CallNumber != null && !this.CallNumber.Equals(input.CallNumber))) return false;
            if (this.DeviceType != input.DeviceType || (this.DeviceType != null && !this.DeviceType.Equals(input.DeviceType))) return false;
            if (this.JoinTime != input.JoinTime || (this.JoinTime != null && !this.JoinTime.Equals(input.JoinTime))) return false;
            if (this.LeftTime != input.LeftTime || (this.LeftTime != null && !this.LeftTime.Equals(input.LeftTime))) return false;
            if (this.MediaType != input.MediaType || (this.MediaType != null && !this.MediaType.Equals(input.MediaType))) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;

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
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.CallNumber != null) hashCode = hashCode * 59 + this.CallNumber.GetHashCode();
                if (this.DeviceType != null) hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.JoinTime != null) hashCode = hashCode * 59 + this.JoinTime.GetHashCode();
                if (this.LeftTime != null) hashCode = hashCode * 59 + this.LeftTime.GetHashCode();
                if (this.MediaType != null) hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                return hashCode;
            }
        }
    }
}
