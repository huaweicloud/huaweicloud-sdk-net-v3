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
    public class ListDeviceGroupsByDeviceResponse : SdkResponse
    {

        /// <summary>
        /// 设备组信息列表。
        /// </summary>
        [JsonProperty("device_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListDeviceGroupSummary> DeviceGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDeviceGroupsByDeviceResponse {\n");
            sb.Append("  deviceGroups: ").Append(DeviceGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDeviceGroupsByDeviceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDeviceGroupsByDeviceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeviceGroups == input.DeviceGroups ||
                    this.DeviceGroups != null &&
                    input.DeviceGroups != null &&
                    this.DeviceGroups.SequenceEqual(input.DeviceGroups)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DeviceGroups != null)
                    hashCode = hashCode * 59 + this.DeviceGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
