using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// CPU阈值设置请求体
    /// </summary>
    public class SetCPUThresholdData 
    {

        /// <summary>
        /// CPU阈值设定值，单位为百分比(%)。 取值范围：0 - 100。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cpu { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetCPUThresholdData {\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetCPUThresholdData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetCPUThresholdData input)
        {
            if (input == null) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;

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
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                return hashCode;
            }
        }
    }
}
