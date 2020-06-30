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
    /// 条件中设备状态类型的信息，自定义结构。
    /// </summary>
    public class DeviceStatusCondition 
    {

        /// <summary>
        /// 状态列表，设备状态条件携带该参数。
        /// </summary>
        [JsonProperty("status_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StatusList { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceStatusCondition {\n");
            sb.Append("  statusList: ").Append(StatusList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeviceStatusCondition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeviceStatusCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatusList == input.StatusList ||
                    this.StatusList != null &&
                    input.StatusList != null &&
                    this.StatusList.SequenceEqual(input.StatusList)
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
                if (this.StatusList != null)
                    hashCode = hashCode * 59 + this.StatusList.GetHashCode();
                return hashCode;
            }
        }
    }
}
