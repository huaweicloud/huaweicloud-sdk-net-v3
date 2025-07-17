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
    /// 开启/关闭同声传译请求体
    /// </summary>
    public class RestSimultaneousInterpretationBody 
    {

        /// <summary>
        /// * 0：停止同声传译 * 1：启动同声传译 
        /// </summary>
        [JsonProperty("simultaneousInterpretation", NullValueHandling = NullValueHandling.Ignore)]
        public int? SimultaneousInterpretation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSimultaneousInterpretationBody {\n");
            sb.Append("  simultaneousInterpretation: ").Append(SimultaneousInterpretation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSimultaneousInterpretationBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSimultaneousInterpretationBody input)
        {
            if (input == null) return false;
            if (this.SimultaneousInterpretation != input.SimultaneousInterpretation || (this.SimultaneousInterpretation != null && !this.SimultaneousInterpretation.Equals(input.SimultaneousInterpretation))) return false;

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
                if (this.SimultaneousInterpretation != null) hashCode = hashCode * 59 + this.SimultaneousInterpretation.GetHashCode();
                return hashCode;
            }
        }
    }
}
