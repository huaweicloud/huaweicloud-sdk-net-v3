using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 资源耗时详细信息
    /// </summary>
    public class ResourceTimeDetails 
    {

        /// <summary>
        /// **参数解释**: CPU时间（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("cpu_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CpuTime { get; set; }

        /// <summary>
        /// **参数解释**: IO上的时间花费（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("data_io_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? DataIoTime { get; set; }

        /// <summary>
        /// **参数解释**: 其余耗时（单位：微秒）。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("other_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? OtherTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceTimeDetails {\n");
            sb.Append("  cpuTime: ").Append(CpuTime).Append("\n");
            sb.Append("  dataIoTime: ").Append(DataIoTime).Append("\n");
            sb.Append("  otherTime: ").Append(OtherTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceTimeDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceTimeDetails input)
        {
            if (input == null) return false;
            if (this.CpuTime != input.CpuTime || (this.CpuTime != null && !this.CpuTime.Equals(input.CpuTime))) return false;
            if (this.DataIoTime != input.DataIoTime || (this.DataIoTime != null && !this.DataIoTime.Equals(input.DataIoTime))) return false;
            if (this.OtherTime != input.OtherTime || (this.OtherTime != null && !this.OtherTime.Equals(input.OtherTime))) return false;

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
                if (this.CpuTime != null) hashCode = hashCode * 59 + this.CpuTime.GetHashCode();
                if (this.DataIoTime != null) hashCode = hashCode * 59 + this.DataIoTime.GetHashCode();
                if (this.OtherTime != null) hashCode = hashCode * 59 + this.OtherTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
