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
    public class QueryCorpGroupDTO 
    {

        /// <summary>
        /// 媒体接入分组id。
        /// </summary>
        [JsonProperty("groupId", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 分组名称。
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 分组类型。
        /// </summary>
        [JsonProperty("groupType", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupType { get; set; }

        /// <summary>
        /// 分组备注信息。
        /// </summary>
        [JsonProperty("remarks", NullValueHandling = NullValueHandling.Ignore)]
        public string Remarks { get; set; }

        /// <summary>
        /// 区域ID，仅服务列表类型场景必填。
        /// </summary>
        [JsonProperty("regionId", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 分组状态。 - 0: 正常 - 1: 停用，服务列表类型停用后创建企业就不会再自动分配到该分组 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCorpGroupDTO {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  remarks: ").Append(Remarks).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryCorpGroupDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCorpGroupDTO input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.GroupType != input.GroupType || (this.GroupType != null && !this.GroupType.Equals(input.GroupType))) return false;
            if (this.Remarks != input.Remarks || (this.Remarks != null && !this.Remarks.Equals(input.Remarks))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.GroupType != null) hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.Remarks != null) hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
