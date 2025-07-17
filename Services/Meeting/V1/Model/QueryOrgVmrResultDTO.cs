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
    /// 查询到的云会议室列表。
    /// </summary>
    public class QueryOrgVmrResultDTO 
    {

        /// <summary>
        /// 云会议室的ID。 &gt; 对应[[创建会议](https://support.huaweicloud.com/api-meeting/meeting_21_0014.html)](tag:hws)[[创建会议](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0014.html)](tag:hk)接口中的vmrID。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云会议室的固定会议ID。 &gt; 对应[[创建会议](https://support.huaweicloud.com/api-meeting/meeting_21_0014.html)](tag:hws)[[创建会议](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0014.html)](tag:hk)接口中的vmrConferenceID。 
        /// </summary>
        [JsonProperty("vmrId", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrId { get; set; }

        /// <summary>
        /// 云会议室名称。
        /// </summary>
        [JsonProperty("vmrName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrName { get; set; }

        /// <summary>
        /// 云会议室套餐名称。
        /// </summary>
        [JsonProperty("vmrPkgName", NullValueHandling = NullValueHandling.Ignore)]
        public string VmrPkgName { get; set; }

        /// <summary>
        /// 云会议室套餐会议并发方数。
        /// </summary>
        [JsonProperty("vmrPkgParties", NullValueHandling = NullValueHandling.Ignore)]
        public int? VmrPkgParties { get; set; }

        /// <summary>
        /// 最大观众与会方数（仅网络研讨会有效）。
        /// </summary>
        [JsonProperty("maxAudienceParties", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxAudienceParties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("member", NullValueHandling = NullValueHandling.Ignore)]
        public IdMarkDTO Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public IdMarkDTO Device { get; set; }

        /// <summary>
        /// 云会议室状态。 * 0：正常 * 1：冻结 * 2：未分配 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 到期时间的时间戳，单位毫秒。
        /// </summary>
        [JsonProperty("expireDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireDate { get; set; }

        /// <summary>
        /// 按次资源转商后，商用规格最大观众与会方数（仅网络研讨会有效）。
        /// </summary>
        [JsonProperty("commercialMaxAudienceParties", NullValueHandling = NullValueHandling.Ignore)]
        public int? CommercialMaxAudienceParties { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryOrgVmrResultDTO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  vmrId: ").Append(VmrId).Append("\n");
            sb.Append("  vmrName: ").Append(VmrName).Append("\n");
            sb.Append("  vmrPkgName: ").Append(VmrPkgName).Append("\n");
            sb.Append("  vmrPkgParties: ").Append(VmrPkgParties).Append("\n");
            sb.Append("  maxAudienceParties: ").Append(MaxAudienceParties).Append("\n");
            sb.Append("  member: ").Append(Member).Append("\n");
            sb.Append("  device: ").Append(Device).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  expireDate: ").Append(ExpireDate).Append("\n");
            sb.Append("  commercialMaxAudienceParties: ").Append(CommercialMaxAudienceParties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryOrgVmrResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryOrgVmrResultDTO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.VmrId != input.VmrId || (this.VmrId != null && !this.VmrId.Equals(input.VmrId))) return false;
            if (this.VmrName != input.VmrName || (this.VmrName != null && !this.VmrName.Equals(input.VmrName))) return false;
            if (this.VmrPkgName != input.VmrPkgName || (this.VmrPkgName != null && !this.VmrPkgName.Equals(input.VmrPkgName))) return false;
            if (this.VmrPkgParties != input.VmrPkgParties || (this.VmrPkgParties != null && !this.VmrPkgParties.Equals(input.VmrPkgParties))) return false;
            if (this.MaxAudienceParties != input.MaxAudienceParties || (this.MaxAudienceParties != null && !this.MaxAudienceParties.Equals(input.MaxAudienceParties))) return false;
            if (this.Member != input.Member || (this.Member != null && !this.Member.Equals(input.Member))) return false;
            if (this.Device != input.Device || (this.Device != null && !this.Device.Equals(input.Device))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ExpireDate != input.ExpireDate || (this.ExpireDate != null && !this.ExpireDate.Equals(input.ExpireDate))) return false;
            if (this.CommercialMaxAudienceParties != input.CommercialMaxAudienceParties || (this.CommercialMaxAudienceParties != null && !this.CommercialMaxAudienceParties.Equals(input.CommercialMaxAudienceParties))) return false;

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
                if (this.VmrPkgName != null) hashCode = hashCode * 59 + this.VmrPkgName.GetHashCode();
                if (this.VmrPkgParties != null) hashCode = hashCode * 59 + this.VmrPkgParties.GetHashCode();
                if (this.MaxAudienceParties != null) hashCode = hashCode * 59 + this.MaxAudienceParties.GetHashCode();
                if (this.Member != null) hashCode = hashCode * 59 + this.Member.GetHashCode();
                if (this.Device != null) hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExpireDate != null) hashCode = hashCode * 59 + this.ExpireDate.GetHashCode();
                if (this.CommercialMaxAudienceParties != null) hashCode = hashCode * 59 + this.CommercialMaxAudienceParties.GetHashCode();
                return hashCode;
            }
        }
    }
}
