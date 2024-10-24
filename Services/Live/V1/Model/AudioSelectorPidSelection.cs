using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// PID选择器
    /// </summary>
    public class AudioSelectorPidSelection 
    {

        /// <summary>
        /// 设置PID的值
        /// </summary>
        [JsonProperty("pid", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioSelectorPidSelection {\n");
            sb.Append("  pid: ").Append(Pid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioSelectorPidSelection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioSelectorPidSelection input)
        {
            if (input == null) return false;
            if (this.Pid != input.Pid || (this.Pid != null && !this.Pid.Equals(input.Pid))) return false;

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
                if (this.Pid != null) hashCode = hashCode * 59 + this.Pid.GetHashCode();
                return hashCode;
            }
        }
    }
}
