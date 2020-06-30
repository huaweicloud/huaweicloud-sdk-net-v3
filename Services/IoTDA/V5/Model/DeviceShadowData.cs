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
    /// 设备影子数据结构体。
    /// </summary>
    public class DeviceShadowData 
    {

        /// <summary>
        /// 设备的服务ID，在设备关联的产品模型中定义。
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("desired", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceShadowProperties Desired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reported", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceShadowProperties Reported { get; set; }

        /// <summary>
        /// 设备影子的版本，携带改参数时平台会校验值必须等于当前影子版本，初始从0开始。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceShadowData {\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  desired: ").Append(Desired).Append("\n");
            sb.Append("  reported: ").Append(Reported).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeviceShadowData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeviceShadowData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.Desired == input.Desired ||
                    (this.Desired != null &&
                    this.Desired.Equals(input.Desired))
                ) && 
                (
                    this.Reported == input.Reported ||
                    (this.Reported != null &&
                    this.Reported.Equals(input.Reported))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.ServiceId != null)
                    hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.Desired != null)
                    hashCode = hashCode * 59 + this.Desired.GetHashCode();
                if (this.Reported != null)
                    hashCode = hashCode * 59 + this.Reported.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }
    }
}
