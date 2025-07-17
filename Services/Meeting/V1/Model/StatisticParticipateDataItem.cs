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
    /// 会议与会统计数据的单个时间点数据。
    /// </summary>
    public class StatisticParticipateDataItem 
    {

        /// <summary>
        /// 日期/月份。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 与会用户名称。 category &#x3D; user_participate_info时有效。
        /// </summary>
        [JsonProperty("confUserName", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUserName { get; set; }

        /// <summary>
        /// 与会用户账户。 category &#x3D; user_participate_info时有效。
        /// </summary>
        [JsonProperty("confUserAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUserAccount { get; set; }

        /// <summary>
        /// 与会用户所属部门。 category &#x3D; user_participate_info时有效。
        /// </summary>
        [JsonProperty("confUserDeptName", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUserDeptName { get; set; }

        /// <summary>
        /// 用户与会数。 category &#x3D; user_participate_info时有效。
        /// </summary>
        [JsonProperty("confUserCount", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUserCount { get; set; }

        /// <summary>
        /// 用户与会时长(秒)。 category &#x3D; user_participate_info时有效。
        /// </summary>
        [JsonProperty("confUserDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfUserDuration { get; set; }

        /// <summary>
        /// 与会硬件终端名称。 category &#x3D; hard_terminal_participate_info时有效。
        /// </summary>
        [JsonProperty("confHardTerminalName", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfHardTerminalName { get; set; }

        /// <summary>
        /// 与会硬件终端型号。 category &#x3D; hard_terminal_participate_info时有效。
        /// </summary>
        [JsonProperty("confHardTerminalModel", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfHardTerminalModel { get; set; }

        /// <summary>
        /// 与会硬件终端的用户ID。 category &#x3D; hard_terminal_participate_info时有效。
        /// </summary>
        [JsonProperty("confHardTerminalUserId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfHardTerminalUserId { get; set; }

        /// <summary>
        /// 硬件终端与会数。 category &#x3D; hard_terminal_participate_info时有效。
        /// </summary>
        [JsonProperty("confHardTerminalCount", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfHardTerminalCount { get; set; }

        /// <summary>
        /// 硬件终端与会时长(秒)。 category &#x3D; hard_terminal_participate_info时有效。
        /// </summary>
        [JsonProperty("confHardTerminalDuration", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfHardTerminalDuration { get; set; }

        /// <summary>
        /// 与会设备类型。 category &#x3D; participant_type_info时有效。
        /// </summary>
        [JsonProperty("deviceType", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceType { get; set; }

        /// <summary>
        /// 与会设备版本。 category &#x3D; participant_type_info时有效。
        /// </summary>
        [JsonProperty("deviceVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceVersion { get; set; }

        /// <summary>
        /// 设备与会数。 category &#x3D; participant_type_info时有效。
        /// </summary>
        [JsonProperty("deviceAttendanceCount", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceAttendanceCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticParticipateDataItem {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  confUserName: ").Append(ConfUserName).Append("\n");
            sb.Append("  confUserAccount: ").Append(ConfUserAccount).Append("\n");
            sb.Append("  confUserDeptName: ").Append(ConfUserDeptName).Append("\n");
            sb.Append("  confUserCount: ").Append(ConfUserCount).Append("\n");
            sb.Append("  confUserDuration: ").Append(ConfUserDuration).Append("\n");
            sb.Append("  confHardTerminalName: ").Append(ConfHardTerminalName).Append("\n");
            sb.Append("  confHardTerminalModel: ").Append(ConfHardTerminalModel).Append("\n");
            sb.Append("  confHardTerminalUserId: ").Append(ConfHardTerminalUserId).Append("\n");
            sb.Append("  confHardTerminalCount: ").Append(ConfHardTerminalCount).Append("\n");
            sb.Append("  confHardTerminalDuration: ").Append(ConfHardTerminalDuration).Append("\n");
            sb.Append("  deviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  deviceVersion: ").Append(DeviceVersion).Append("\n");
            sb.Append("  deviceAttendanceCount: ").Append(DeviceAttendanceCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatisticParticipateDataItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatisticParticipateDataItem input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.ConfUserName != input.ConfUserName || (this.ConfUserName != null && !this.ConfUserName.Equals(input.ConfUserName))) return false;
            if (this.ConfUserAccount != input.ConfUserAccount || (this.ConfUserAccount != null && !this.ConfUserAccount.Equals(input.ConfUserAccount))) return false;
            if (this.ConfUserDeptName != input.ConfUserDeptName || (this.ConfUserDeptName != null && !this.ConfUserDeptName.Equals(input.ConfUserDeptName))) return false;
            if (this.ConfUserCount != input.ConfUserCount || (this.ConfUserCount != null && !this.ConfUserCount.Equals(input.ConfUserCount))) return false;
            if (this.ConfUserDuration != input.ConfUserDuration || (this.ConfUserDuration != null && !this.ConfUserDuration.Equals(input.ConfUserDuration))) return false;
            if (this.ConfHardTerminalName != input.ConfHardTerminalName || (this.ConfHardTerminalName != null && !this.ConfHardTerminalName.Equals(input.ConfHardTerminalName))) return false;
            if (this.ConfHardTerminalModel != input.ConfHardTerminalModel || (this.ConfHardTerminalModel != null && !this.ConfHardTerminalModel.Equals(input.ConfHardTerminalModel))) return false;
            if (this.ConfHardTerminalUserId != input.ConfHardTerminalUserId || (this.ConfHardTerminalUserId != null && !this.ConfHardTerminalUserId.Equals(input.ConfHardTerminalUserId))) return false;
            if (this.ConfHardTerminalCount != input.ConfHardTerminalCount || (this.ConfHardTerminalCount != null && !this.ConfHardTerminalCount.Equals(input.ConfHardTerminalCount))) return false;
            if (this.ConfHardTerminalDuration != input.ConfHardTerminalDuration || (this.ConfHardTerminalDuration != null && !this.ConfHardTerminalDuration.Equals(input.ConfHardTerminalDuration))) return false;
            if (this.DeviceType != input.DeviceType || (this.DeviceType != null && !this.DeviceType.Equals(input.DeviceType))) return false;
            if (this.DeviceVersion != input.DeviceVersion || (this.DeviceVersion != null && !this.DeviceVersion.Equals(input.DeviceVersion))) return false;
            if (this.DeviceAttendanceCount != input.DeviceAttendanceCount || (this.DeviceAttendanceCount != null && !this.DeviceAttendanceCount.Equals(input.DeviceAttendanceCount))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.ConfUserName != null) hashCode = hashCode * 59 + this.ConfUserName.GetHashCode();
                if (this.ConfUserAccount != null) hashCode = hashCode * 59 + this.ConfUserAccount.GetHashCode();
                if (this.ConfUserDeptName != null) hashCode = hashCode * 59 + this.ConfUserDeptName.GetHashCode();
                if (this.ConfUserCount != null) hashCode = hashCode * 59 + this.ConfUserCount.GetHashCode();
                if (this.ConfUserDuration != null) hashCode = hashCode * 59 + this.ConfUserDuration.GetHashCode();
                if (this.ConfHardTerminalName != null) hashCode = hashCode * 59 + this.ConfHardTerminalName.GetHashCode();
                if (this.ConfHardTerminalModel != null) hashCode = hashCode * 59 + this.ConfHardTerminalModel.GetHashCode();
                if (this.ConfHardTerminalUserId != null) hashCode = hashCode * 59 + this.ConfHardTerminalUserId.GetHashCode();
                if (this.ConfHardTerminalCount != null) hashCode = hashCode * 59 + this.ConfHardTerminalCount.GetHashCode();
                if (this.ConfHardTerminalDuration != null) hashCode = hashCode * 59 + this.ConfHardTerminalDuration.GetHashCode();
                if (this.DeviceType != null) hashCode = hashCode * 59 + this.DeviceType.GetHashCode();
                if (this.DeviceVersion != null) hashCode = hashCode * 59 + this.DeviceVersion.GetHashCode();
                if (this.DeviceAttendanceCount != null) hashCode = hashCode * 59 + this.DeviceAttendanceCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
