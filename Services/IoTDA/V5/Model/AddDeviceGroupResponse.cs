using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AddDeviceGroupResponse : SdkResponse
    {

        /// <summary>
        /// 设备组ID，用于唯一标识一个设备组，在创建设备组时由物联网平台分配。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 设备组名称，单个资源空间下不可重复。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 设备组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 父设备组ID，该设备组的父设备组ID。
        /// </summary>
        [JsonProperty("super_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SuperGroupId { get; set; }

        /// <summary>
        /// 设备组类型，分为动态设备组和静态设备组两种
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// 动态设备组规则
        /// </summary>
        [JsonProperty("dynamic_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string DynamicGroupRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDeviceGroupResponse {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  superGroupId: ").Append(SuperGroupId).Append("\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  dynamicGroupRule: ").Append(DynamicGroupRule).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddDeviceGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDeviceGroupResponse input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SuperGroupId != input.SuperGroupId || (this.SuperGroupId != null && !this.SuperGroupId.Equals(input.SuperGroupId))) return false;
            if (this.GroupType != input.GroupType || (this.GroupType != null && !this.GroupType.Equals(input.GroupType))) return false;
            if (this.DynamicGroupRule != input.DynamicGroupRule || (this.DynamicGroupRule != null && !this.DynamicGroupRule.Equals(input.DynamicGroupRule))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SuperGroupId != null) hashCode = hashCode * 59 + this.SuperGroupId.GetHashCode();
                if (this.GroupType != null) hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.DynamicGroupRule != null) hashCode = hashCode * 59 + this.DynamicGroupRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
