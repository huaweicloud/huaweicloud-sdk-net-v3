using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDM.V5.Model
{
    /// <summary>
    /// IP白名单 约束：只有企业版实例的APP_HTTPS/APP_AMQP/APP_MQTT协议支持配置IP白名单。 
    /// </summary>
    public class IPWhiteList 
    {

        /// <summary>
        /// **参数说明**：启用Ip白名单访问控制。 
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// **参数说明**：允许访问企业版实例的IP地址列表。 
        /// </summary>
        [JsonProperty("allow_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpAllowList> AllowList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPWhiteList {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  allowList: ").Append(AllowList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IPWhiteList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IPWhiteList input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.AllowList != input.AllowList || (this.AllowList != null && input.AllowList != null && !this.AllowList.SequenceEqual(input.AllowList))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.AllowList != null) hashCode = hashCode * 59 + this.AllowList.GetHashCode();
                return hashCode;
            }
        }
    }
}
