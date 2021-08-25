using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceInfo 
    {

        /// <summary>
        /// 开通该子服务时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否开通该子服务。
        /// </summary>
        [JsonProperty("subscribe_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SubscribeStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceInfo {\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  subscribeStatus: ").Append(SubscribeStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.SubscribeStatus == input.SubscribeStatus ||
                    (this.SubscribeStatus != null &&
                    this.SubscribeStatus.Equals(input.SubscribeStatus))
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
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.SubscribeStatus != null)
                    hashCode = hashCode * 59 + this.SubscribeStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
