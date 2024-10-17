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
    public class NovaCreateServersRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public NovaCreateServersOption Server { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os:scheduler_hints", NullValueHandling = NullValueHandling.Ignore)]
        public NovaCreateServersSchedulerHint OsschedulerHints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NovaCreateServersRequestBody {\n");
            sb.Append("  server: ").Append(Server).Append("\n");
            sb.Append("  osschedulerHints: ").Append(OsschedulerHints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NovaCreateServersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NovaCreateServersRequestBody input)
        {
            if (input == null) return false;
            if (this.Server != input.Server || (this.Server != null && !this.Server.Equals(input.Server))) return false;
            if (this.OsschedulerHints != input.OsschedulerHints || (this.OsschedulerHints != null && !this.OsschedulerHints.Equals(input.OsschedulerHints))) return false;

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
                if (this.Server != null) hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.OsschedulerHints != null) hashCode = hashCode * 59 + this.OsschedulerHints.GetHashCode();
                return hashCode;
            }
        }
    }
}
