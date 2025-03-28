using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// This is a auto create Body Object
    /// </summary>
    public class UpdateServerAutoTerminateTimeRequestBody 
    {

        /// <summary>
        /// 定时删除时间
        /// </summary>
        [JsonProperty("auto_terminate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoTerminateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServerAutoTerminateTimeRequestBody {\n");
            sb.Append("  autoTerminateTime: ").Append(AutoTerminateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateServerAutoTerminateTimeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateServerAutoTerminateTimeRequestBody input)
        {
            if (input == null) return false;
            if (this.AutoTerminateTime != input.AutoTerminateTime || (this.AutoTerminateTime != null && !this.AutoTerminateTime.Equals(input.AutoTerminateTime))) return false;

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
                if (this.AutoTerminateTime != null) hashCode = hashCode * 59 + this.AutoTerminateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
