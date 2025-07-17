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
    /// 节目基础信息。
    /// </summary>
    public class ProgramRequestBase 
    {

        /// <summary>
        /// 节目名称。
        /// </summary>
        [JsonProperty("programName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProgramName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramRequestBase {\n");
            sb.Append("  programName: ").Append(ProgramName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProgramRequestBase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProgramRequestBase input)
        {
            if (input == null) return false;
            if (this.ProgramName != input.ProgramName || (this.ProgramName != null && !this.ProgramName.Equals(input.ProgramName))) return false;

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
                if (this.ProgramName != null) hashCode = hashCode * 59 + this.ProgramName.GetHashCode();
                return hashCode;
            }
        }
    }
}
