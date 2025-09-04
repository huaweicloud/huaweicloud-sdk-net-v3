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
    public class AddHarmonySoftBusResponse : SdkResponse
    {

        /// <summary>
        /// 鸿蒙软总线ID，用于唯一标识一个鸿蒙软总线，在创建鸿蒙软总线时由物联网平台分配。
        /// </summary>
        [JsonProperty("bus_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BusId { get; set; }

        /// <summary>
        /// 鸿蒙软总线名称，单个资源空间下不可重复。
        /// </summary>
        [JsonProperty("bus_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusName { get; set; }

        /// <summary>
        /// 设备组ID。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// **参数说明**：资源空间ID。此参数为非必选参数，存在多资源空间的用户需要使用该接口时，建议携带该参数指定创建的设备组归属到哪个资源空间下，否则创建的设备组将会归属到[默认资源空间](https://support.huaweicloud.com/usermanual-iothub/iot_01_0006.html#section0)下。 **取值范围**：长度不超过36，只允许字母、数字、下划线（_）、连接符（-）的组合。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 鸿蒙软总线组信息同步状态，结果范围：Synchronized，Synchronizing，ToBeSynchronized - Synchronized：已同步。 - Synchronizing：同步中。 - ToBeSynchronized：待同步。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddHarmonySoftBusResponse {\n");
            sb.Append("  busId: ").Append(BusId).Append("\n");
            sb.Append("  busName: ").Append(BusName).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddHarmonySoftBusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddHarmonySoftBusResponse input)
        {
            if (input == null) return false;
            if (this.BusId != input.BusId || (this.BusId != null && !this.BusId.Equals(input.BusId))) return false;
            if (this.BusName != input.BusName || (this.BusName != null && !this.BusName.Equals(input.BusName))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
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
                if (this.BusId != null) hashCode = hashCode * 59 + this.BusId.GetHashCode();
                if (this.BusName != null) hashCode = hashCode * 59 + this.BusName.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
