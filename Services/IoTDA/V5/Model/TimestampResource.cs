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
    /// 是否校验设备时间戳，若不为空则表示校验，如果设备连接参数（clientId、username）中包含时间戳建议开启校验。开启校验平台会对比设备携带时间戳与平台系统时间，若设备时间戳加一小时小于平台系统时间则校验失败。若想关闭校验则把value属性的值设置为空json:{}
    /// </summary>
    public class TimestampResource 
    {

        /// <summary>
        /// UNIX：表示为Unix时间戳秒级别长整数，FORMAT：表示为特定时间格式，需要在format字段中指定具体格式。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 时间日期格式。
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// 设备连接时具体时间戳值，可使用FunctionDefinition下的函数编程时间戳的取值，若想关闭时间戳校验则该字段值设置为空json:{}。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Object Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimestampResource {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TimestampResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TimestampResource input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Pattern != input.Pattern || (this.Pattern != null && !this.Pattern.Equals(input.Pattern))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Pattern != null) hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
