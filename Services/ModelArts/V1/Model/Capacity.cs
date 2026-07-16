using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 资源总容量。
    /// </summary>
    public class Capacity 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public Value Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("maxValue", NullValueHandling = NullValueHandling.Ignore)]
        public Value MaxValue { get; set; }

        /// <summary>
        /// UTC时间，格式yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;。
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// 统计间隔，1s表示1秒，1m表示1分钟，1h为1小时。
        /// </summary>
        [JsonProperty("window", NullValueHandling = NullValueHandling.Ignore)]
        public string Window { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Capacity {\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  maxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  window: ").Append(Window).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Capacity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Capacity input)
        {
            if (input == null) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.MaxValue != input.MaxValue || (this.MaxValue != null && !this.MaxValue.Equals(input.MaxValue))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.Window != input.Window || (this.Window != null && !this.Window.Equals(input.Window))) return false;

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
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.MaxValue != null) hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Window != null) hashCode = hashCode * 59 + this.Window.GetHashCode();
                return hashCode;
            }
        }
    }
}
