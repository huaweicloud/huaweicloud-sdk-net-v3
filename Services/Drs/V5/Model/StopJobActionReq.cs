using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 结束单个任务请求体。
    /// </summary>
    public class StopJobActionReq 
    {

        /// <summary>
        /// 强制结束任务时取值true，默认false。
        /// </summary>
        [JsonProperty("is_force_stop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForceStop { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopJobActionReq {\n");
            sb.Append("  isForceStop: ").Append(IsForceStop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StopJobActionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StopJobActionReq input)
        {
            if (input == null) return false;
            if (this.IsForceStop != input.IsForceStop || (this.IsForceStop != null && !this.IsForceStop.Equals(input.IsForceStop))) return false;

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
                if (this.IsForceStop != null) hashCode = hashCode * 59 + this.IsForceStop.GetHashCode();
                return hashCode;
            }
        }
    }
}
