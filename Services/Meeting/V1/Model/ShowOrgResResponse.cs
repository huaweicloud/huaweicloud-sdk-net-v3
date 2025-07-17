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
    public class ShowOrgResResponse : SdkResponse
    {

        /// <summary>
        /// 企业管理员查询所属企业的资源使用信息。
        /// </summary>
        [JsonProperty("usedRecStorage", NullValueHandling = NullValueHandling.Ignore)]
        public double? UsedRecStorage { get; set; }

        /// <summary>
        /// 当前已用的会议并发数量。
        /// </summary>
        [JsonProperty("usedAccountsCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedAccountsCount { get; set; }

        /// <summary>
        /// 当前已用的直播推流资源。
        /// </summary>
        [JsonProperty("usedLiveCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedLiveCount { get; set; }

        /// <summary>
        /// 当前已用的直播推流资源。
        /// </summary>
        [JsonProperty("confCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfCount { get; set; }

        /// <summary>
        /// 当日会议总时长。
        /// </summary>
        [JsonProperty("confLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConfLength { get; set; }

        /// <summary>
        /// 当日活跃用户数。
        /// </summary>
        [JsonProperty("activeAttendeeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActiveAttendeeCount { get; set; }

        /// <summary>
        /// 当日总与会人数。
        /// </summary>
        [JsonProperty("totalAttendeeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalAttendeeCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOrgResResponse {\n");
            sb.Append("  usedRecStorage: ").Append(UsedRecStorage).Append("\n");
            sb.Append("  usedAccountsCount: ").Append(UsedAccountsCount).Append("\n");
            sb.Append("  usedLiveCount: ").Append(UsedLiveCount).Append("\n");
            sb.Append("  confCount: ").Append(ConfCount).Append("\n");
            sb.Append("  confLength: ").Append(ConfLength).Append("\n");
            sb.Append("  activeAttendeeCount: ").Append(ActiveAttendeeCount).Append("\n");
            sb.Append("  totalAttendeeCount: ").Append(TotalAttendeeCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOrgResResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOrgResResponse input)
        {
            if (input == null) return false;
            if (this.UsedRecStorage != input.UsedRecStorage || (this.UsedRecStorage != null && !this.UsedRecStorage.Equals(input.UsedRecStorage))) return false;
            if (this.UsedAccountsCount != input.UsedAccountsCount || (this.UsedAccountsCount != null && !this.UsedAccountsCount.Equals(input.UsedAccountsCount))) return false;
            if (this.UsedLiveCount != input.UsedLiveCount || (this.UsedLiveCount != null && !this.UsedLiveCount.Equals(input.UsedLiveCount))) return false;
            if (this.ConfCount != input.ConfCount || (this.ConfCount != null && !this.ConfCount.Equals(input.ConfCount))) return false;
            if (this.ConfLength != input.ConfLength || (this.ConfLength != null && !this.ConfLength.Equals(input.ConfLength))) return false;
            if (this.ActiveAttendeeCount != input.ActiveAttendeeCount || (this.ActiveAttendeeCount != null && !this.ActiveAttendeeCount.Equals(input.ActiveAttendeeCount))) return false;
            if (this.TotalAttendeeCount != input.TotalAttendeeCount || (this.TotalAttendeeCount != null && !this.TotalAttendeeCount.Equals(input.TotalAttendeeCount))) return false;

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
                if (this.UsedRecStorage != null) hashCode = hashCode * 59 + this.UsedRecStorage.GetHashCode();
                if (this.UsedAccountsCount != null) hashCode = hashCode * 59 + this.UsedAccountsCount.GetHashCode();
                if (this.UsedLiveCount != null) hashCode = hashCode * 59 + this.UsedLiveCount.GetHashCode();
                if (this.ConfCount != null) hashCode = hashCode * 59 + this.ConfCount.GetHashCode();
                if (this.ConfLength != null) hashCode = hashCode * 59 + this.ConfLength.GetHashCode();
                if (this.ActiveAttendeeCount != null) hashCode = hashCode * 59 + this.ActiveAttendeeCount.GetHashCode();
                if (this.TotalAttendeeCount != null) hashCode = hashCode * 59 + this.TotalAttendeeCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
