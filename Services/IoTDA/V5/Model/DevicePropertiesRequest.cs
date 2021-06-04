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
    /// 
    /// </summary>
    public class DevicePropertiesRequest 
    {

        /// <summary>
        /// **参数说明**：设备执行的属性，Json格式，里面是一个个健值对，如果serviceId不为空，每个健都是profile中属性的参数名（paraName）;如果serviceId为空则由用户自定义属性格式。设属性令示例：[{\&quot;service_id\&quot;: \&quot;Temperature\&quot;,\&quot;properties\&quot;: {\&quot;value\&quot;: 57}},{\&quot;service_id\&quot;: \&quot;Battery\&quot;,\&quot;properties\&quot;: {\&quot;level\&quot;: 80}}]，具体格式需要应用和设备约定。
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public Object Services { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevicePropertiesRequest {\n");
            sb.Append("  services: ").Append(Services).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DevicePropertiesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DevicePropertiesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Services == input.Services ||
                    (this.Services != null &&
                    this.Services.Equals(input.Services))
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
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                return hashCode;
            }
        }
    }
}
