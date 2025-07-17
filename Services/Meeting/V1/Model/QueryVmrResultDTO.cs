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
    /// 用户查询的云会议室或者个人会议ID详情。
    /// </summary>
    public class QueryVmrResultDTO 
    {

        /// <summary>
        /// 云会议室的ID。 &gt; 对应[[创建会议](https://support.huaweicloud.com/api-meeting/meeting_21_0014.html)](tag:hws)[[创建会议](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0014.html)](tag:hk)接口中的vmrID。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云会议室的固定会议ID或者个人会议ID。 &gt; 对应[[创建会议](https://support.huaweicloud.com/api-meeting/meeting_21_0014.html)](tag:hws)[[创建会议](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0014.html)](tag:hk)接口中的vmrConferenceID。 
        /// </summary>
        [JsonProperty("vmrId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrId { get; set; }

        /// <summary>
        /// 云会议室名称。
        /// </summary>
        [JsonProperty("vmrName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrName { get; set; }

        /// <summary>
        /// 来宾密码。
        /// </summary>
        [JsonProperty("gustPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string GustPwd { get; set; }

        /// <summary>
        /// 来宾与会链接。
        /// </summary>
        [JsonProperty("gustJoinUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string GustJoinUrl { get; set; }

        /// <summary>
        /// 主持人密码。
        /// </summary>
        [JsonProperty("chairPwd", NullValueHandling = NullValueHandling.Ignore)]
        public string ChairPwd { get; set; }

        /// <summary>
        /// 主持人与会链接。
        /// </summary>
        [JsonProperty("chairJoinUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ChairJoinUrl { get; set; }

        /// <summary>
        /// 允许来宾先入会。
        /// </summary>
        [JsonProperty("allowGustFirst", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowGustFirst { get; set; }

        /// <summary>
        /// 云会议室被使用后是否通知会议室所有者。
        /// </summary>
        [JsonProperty("gustFirstNotice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GustFirstNotice { get; set; }

        /// <summary>
        /// VMR模式。 * 0: 个人会议ID * 1: 云会议室 * 2: 网络研讨会 
        /// </summary>
        [JsonProperty("vmrMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrMode { get; set; }

        /// <summary>
        /// 云会议室套餐包的id，仅云会议室返回。
        /// </summary>
        [JsonProperty("vmrPkgId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrPkgId { get; set; }

        /// <summary>
        /// 云会议室套餐包的名称，仅云会议室返回。
        /// </summary>
        [JsonProperty("vmrPkgName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrPkgName { get; set; }

        /// <summary>
        /// 云会议室套餐包的会议并发方数，仅云会议室返回。
        /// </summary>
        [JsonProperty("vmrPkgParties", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrPkgParties { get; set; }

        /// <summary>
        /// 云会议室状态。 * 0：正常 * 1：停用 * 2：未分配 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryVmrResultDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  vmrId: ").Append(VmrId).Append("\n");
            sb.Append("  vmrName: ").Append(VmrName).Append("\n");
            sb.Append("  gustPwd: ").Append(GustPwd).Append("\n");
            sb.Append("  gustJoinUrl: ").Append(GustJoinUrl).Append("\n");
            sb.Append("  chairPwd: ").Append(ChairPwd).Append("\n");
            sb.Append("  chairJoinUrl: ").Append(ChairJoinUrl).Append("\n");
            sb.Append("  allowGustFirst: ").Append(AllowGustFirst).Append("\n");
            sb.Append("  gustFirstNotice: ").Append(GustFirstNotice).Append("\n");
            sb.Append("  vmrMode: ").Append(VmrMode).Append("\n");
            sb.Append("  vmrPkgId: ").Append(VmrPkgId).Append("\n");
            sb.Append("  vmrPkgName: ").Append(VmrPkgName).Append("\n");
            sb.Append("  vmrPkgParties: ").Append(VmrPkgParties).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryVmrResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryVmrResultDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.VmrId != input.VmrId || (this.VmrId != null && !this.VmrId.Equals(input.VmrId))) return false;
            if (this.VmrName != input.VmrName || (this.VmrName != null && !this.VmrName.Equals(input.VmrName))) return false;
            if (this.GustPwd != input.GustPwd || (this.GustPwd != null && !this.GustPwd.Equals(input.GustPwd))) return false;
            if (this.GustJoinUrl != input.GustJoinUrl || (this.GustJoinUrl != null && !this.GustJoinUrl.Equals(input.GustJoinUrl))) return false;
            if (this.ChairPwd != input.ChairPwd || (this.ChairPwd != null && !this.ChairPwd.Equals(input.ChairPwd))) return false;
            if (this.ChairJoinUrl != input.ChairJoinUrl || (this.ChairJoinUrl != null && !this.ChairJoinUrl.Equals(input.ChairJoinUrl))) return false;
            if (this.AllowGustFirst != input.AllowGustFirst || (this.AllowGustFirst != null && !this.AllowGustFirst.Equals(input.AllowGustFirst))) return false;
            if (this.GustFirstNotice != input.GustFirstNotice || (this.GustFirstNotice != null && !this.GustFirstNotice.Equals(input.GustFirstNotice))) return false;
            if (this.VmrMode != input.VmrMode || (this.VmrMode != null && !this.VmrMode.Equals(input.VmrMode))) return false;
            if (this.VmrPkgId != input.VmrPkgId || (this.VmrPkgId != null && !this.VmrPkgId.Equals(input.VmrPkgId))) return false;
            if (this.VmrPkgName != input.VmrPkgName || (this.VmrPkgName != null && !this.VmrPkgName.Equals(input.VmrPkgName))) return false;
            if (this.VmrPkgParties != input.VmrPkgParties || (this.VmrPkgParties != null && !this.VmrPkgParties.Equals(input.VmrPkgParties))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.VmrId != null) hashCode = hashCode * 59 + this.VmrId.GetHashCode();
                if (this.VmrName != null) hashCode = hashCode * 59 + this.VmrName.GetHashCode();
                if (this.GustPwd != null) hashCode = hashCode * 59 + this.GustPwd.GetHashCode();
                if (this.GustJoinUrl != null) hashCode = hashCode * 59 + this.GustJoinUrl.GetHashCode();
                if (this.ChairPwd != null) hashCode = hashCode * 59 + this.ChairPwd.GetHashCode();
                if (this.ChairJoinUrl != null) hashCode = hashCode * 59 + this.ChairJoinUrl.GetHashCode();
                if (this.AllowGustFirst != null) hashCode = hashCode * 59 + this.AllowGustFirst.GetHashCode();
                if (this.GustFirstNotice != null) hashCode = hashCode * 59 + this.GustFirstNotice.GetHashCode();
                if (this.VmrMode != null) hashCode = hashCode * 59 + this.VmrMode.GetHashCode();
                if (this.VmrPkgId != null) hashCode = hashCode * 59 + this.VmrPkgId.GetHashCode();
                if (this.VmrPkgName != null) hashCode = hashCode * 59 + this.VmrPkgName.GetHashCode();
                if (this.VmrPkgParties != null) hashCode = hashCode * 59 + this.VmrPkgParties.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
