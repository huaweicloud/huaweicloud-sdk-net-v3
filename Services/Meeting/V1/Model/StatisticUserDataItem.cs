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
    /// 会议用户统计数据的单个时间点数据。
    /// </summary>
    public class StatisticUserDataItem 
    {

        /// <summary>
        /// 日期/月份。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 登录用户数。 category &#x3D; user_login_info时有效。
        /// </summary>
        [JsonProperty("userLoginCount", NullValueHandling = NullValueHandling.Ignore)]
        public string UserLoginCount { get; set; }

        /// <summary>
        /// PC端登录用户数。 category &#x3D; user_login_info时有效。
        /// </summary>
        [JsonProperty("userPCLoginCount", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPCLoginCount { get; set; }

        /// <summary>
        /// 移动端登录用户数。 category &#x3D; user_login_info时有效。
        /// </summary>
        [JsonProperty("userMobileLoginCount", NullValueHandling = NullValueHandling.Ignore)]
        public string UserMobileLoginCount { get; set; }

        /// <summary>
        /// 激活用户数。 category &#x3D; user_activate_info时有效。
        /// </summary>
        [JsonProperty("userActivatedCount", NullValueHandling = NullValueHandling.Ignore)]
        public string UserActivatedCount { get; set; }

        /// <summary>
        /// 用户登录设备名称。 category &#x3D; user_login_device_info时有效。
        /// </summary>
        [JsonProperty("userLoginDevicesName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserLoginDevicesName { get; set; }

        /// <summary>
        /// 用户登录设备数。 category &#x3D; user_login_device_info时有效。
        /// </summary>
        [JsonProperty("userLoginDevicesCount", NullValueHandling = NullValueHandling.Ignore)]
        public string UserLoginDevicesCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticUserDataItem {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  userLoginCount: ").Append(UserLoginCount).Append("\n");
            sb.Append("  userPCLoginCount: ").Append(UserPCLoginCount).Append("\n");
            sb.Append("  userMobileLoginCount: ").Append(UserMobileLoginCount).Append("\n");
            sb.Append("  userActivatedCount: ").Append(UserActivatedCount).Append("\n");
            sb.Append("  userLoginDevicesName: ").Append(UserLoginDevicesName).Append("\n");
            sb.Append("  userLoginDevicesCount: ").Append(UserLoginDevicesCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatisticUserDataItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatisticUserDataItem input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.UserLoginCount != input.UserLoginCount || (this.UserLoginCount != null && !this.UserLoginCount.Equals(input.UserLoginCount))) return false;
            if (this.UserPCLoginCount != input.UserPCLoginCount || (this.UserPCLoginCount != null && !this.UserPCLoginCount.Equals(input.UserPCLoginCount))) return false;
            if (this.UserMobileLoginCount != input.UserMobileLoginCount || (this.UserMobileLoginCount != null && !this.UserMobileLoginCount.Equals(input.UserMobileLoginCount))) return false;
            if (this.UserActivatedCount != input.UserActivatedCount || (this.UserActivatedCount != null && !this.UserActivatedCount.Equals(input.UserActivatedCount))) return false;
            if (this.UserLoginDevicesName != input.UserLoginDevicesName || (this.UserLoginDevicesName != null && !this.UserLoginDevicesName.Equals(input.UserLoginDevicesName))) return false;
            if (this.UserLoginDevicesCount != input.UserLoginDevicesCount || (this.UserLoginDevicesCount != null && !this.UserLoginDevicesCount.Equals(input.UserLoginDevicesCount))) return false;

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
                if (this.UserLoginCount != null) hashCode = hashCode * 59 + this.UserLoginCount.GetHashCode();
                if (this.UserPCLoginCount != null) hashCode = hashCode * 59 + this.UserPCLoginCount.GetHashCode();
                if (this.UserMobileLoginCount != null) hashCode = hashCode * 59 + this.UserMobileLoginCount.GetHashCode();
                if (this.UserActivatedCount != null) hashCode = hashCode * 59 + this.UserActivatedCount.GetHashCode();
                if (this.UserLoginDevicesName != null) hashCode = hashCode * 59 + this.UserLoginDevicesName.GetHashCode();
                if (this.UserLoginDevicesCount != null) hashCode = hashCode * 59 + this.UserLoginDevicesCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
