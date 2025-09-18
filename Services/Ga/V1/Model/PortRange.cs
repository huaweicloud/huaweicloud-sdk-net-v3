using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// port range
    /// </summary>
    public class PortRange 
    {

        /// <summary>
        /// 起始端口。
        /// </summary>
        [JsonProperty("from_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? FromPort { get; set; }

        /// <summary>
        /// 结束端口。
        /// </summary>
        [JsonProperty("to_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ToPort { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortRange {\n");
            sb.Append("  fromPort: ").Append(FromPort).Append("\n");
            sb.Append("  toPort: ").Append(ToPort).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PortRange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PortRange input)
        {
            if (input == null) return false;
            if (this.FromPort != input.FromPort || (this.FromPort != null && !this.FromPort.Equals(input.FromPort))) return false;
            if (this.ToPort != input.ToPort || (this.ToPort != null && !this.ToPort.Equals(input.ToPort))) return false;

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
                if (this.FromPort != null) hashCode = hashCode * 59 + this.FromPort.GetHashCode();
                if (this.ToPort != null) hashCode = hashCode * 59 + this.ToPort.GetHashCode();
                return hashCode;
            }
        }
    }
}
