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
    /// 设备影子数据属性结构体。
    /// </summary>
    public class DeviceShadowProperties 
    {

        /// <summary>
        /// 设备影子的属性数据，Json格式，里面是一个个键值对，每个键都是产品模型中属性的参数名(property_name)，目前如样例所示只支持一层结构。 **注意**：JSON结构的key当前不支持特殊字符：点(.)、dollar符号($)、空char(十六进制的ASCII码为00),key为以上特殊字符无法正常刷新设备影子
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Object Properties { get; set; }

        /// <summary>
        /// 事件操作时间，格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("event_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EventTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceShadowProperties {\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("  eventTime: ").Append(EventTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeviceShadowProperties);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeviceShadowProperties input)
        {
            if (input == null) return false;
            if (this.Properties != input.Properties || (this.Properties != null && !this.Properties.Equals(input.Properties))) return false;
            if (this.EventTime != input.EventTime || (this.EventTime != null && !this.EventTime.Equals(input.EventTime))) return false;

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
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.EventTime != null) hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
