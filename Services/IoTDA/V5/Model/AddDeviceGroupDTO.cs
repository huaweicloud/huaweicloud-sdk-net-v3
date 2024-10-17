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
    /// 创建设备组请求结构体
    /// </summary>
    public class AddDeviceGroupDTO 
    {

        /// <summary>
        /// **参数说明**：设备组名称，单个资源空间下不可重复。 **取值范围**：长度不超过64，只允许中文、字母、数字、以及_? &#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数说明**：设备组描述。 **取值范围**：长度不超过64，只允许中文、字母、数字、以及_? &#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数说明**：父设备组ID，携带该参数时表示在该设备组下创建一个子设备组,动态群组不支持该参数。 **取值范围**：长度不超过36，十六进制字符串和连接符（-）的组合。
        /// </summary>
        [JsonProperty("super_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SuperGroupId { get; set; }

        /// <summary>
        /// **参数说明**：资源空间ID。此参数为非必选参数，存在多资源空间的用户需要使用该接口时，建议携带该参数指定创建的设备组归属到哪个资源空间下，否则创建的设备组将会归属到[[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)](tag:hws)[[默认资源空间](https://support.huaweicloud.com/intl/zh-cn/usermanual-iothub/iot_01_0006.html#section0)](tag:hws_hk)下。 **取值范围**：长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// **参数说明**：设备组类型，默认为静态设备组；当设备组类型为动态设备组时，需要填写动态设备组组规则
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// **参数说明**：动态设备组规则语法和高级搜索保持一致，只需要填写where 子句内容，其余子句无需填写，todo补充说明
        /// </summary>
        [JsonProperty("dynamic_group_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string DynamicGroupRule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddDeviceGroupDTO {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  superGroupId: ").Append(SuperGroupId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
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
            return this.Equals(input as AddDeviceGroupDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddDeviceGroupDTO input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.SuperGroupId != input.SuperGroupId || (this.SuperGroupId != null && !this.SuperGroupId.Equals(input.SuperGroupId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SuperGroupId != null) hashCode = hashCode * 59 + this.SuperGroupId.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.GroupType != null) hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.DynamicGroupRule != null) hashCode = hashCode * 59 + this.DynamicGroupRule.GetHashCode();
                return hashCode;
            }
        }
    }
}
