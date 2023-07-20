using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ScaleFlavors 
    {

        /// <summary>
        /// 规格码。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// CPU个数。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 内存大小（单位：GB）。
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public string Mem { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleFlavors {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleFlavors);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleFlavors input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Cpu == input.Cpu ||
                    (this.Cpu != null &&
                    this.Cpu.Equals(input.Cpu))
                ) && 
                (
                    this.Mem == input.Mem ||
                    (this.Mem != null &&
                    this.Mem.Equals(input.Mem))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Cpu != null)
                    hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null)
                    hashCode = hashCode * 59 + this.Mem.GetHashCode();
                return hashCode;
            }
        }
    }
}
