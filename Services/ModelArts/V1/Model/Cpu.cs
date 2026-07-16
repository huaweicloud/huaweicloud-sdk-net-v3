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
    /// cpu规格信息。
    /// </summary>
    public class Cpu 
    {

        /// <summary>
        /// cpu架构。
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public string Arch { get; set; }

        /// <summary>
        /// 核数。
        /// </summary>
        [JsonProperty("core_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoreNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cpu {\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  coreNum: ").Append(CoreNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Cpu);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Cpu input)
        {
            if (input == null) return false;
            if (this.Arch != input.Arch || (this.Arch != null && !this.Arch.Equals(input.Arch))) return false;
            if (this.CoreNum != input.CoreNum || (this.CoreNum != null && !this.CoreNum.Equals(input.CoreNum))) return false;

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
                if (this.Arch != null) hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.CoreNum != null) hashCode = hashCode * 59 + this.CoreNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
