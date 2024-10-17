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
    public class BatchStopServersRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os-stop", NullValueHandling = NullValueHandling.Ignore)]
        public BatchStopServersOption OsStop { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchStopServersRequestBody {\n");
            sb.Append("  osStop: ").Append(OsStop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchStopServersRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchStopServersRequestBody input)
        {
            if (input == null) return false;
            if (this.OsStop != input.OsStop || (this.OsStop != null && !this.OsStop.Equals(input.OsStop))) return false;

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
                if (this.OsStop != null) hashCode = hashCode * 59 + this.OsStop.GetHashCode();
                return hashCode;
            }
        }
    }
}
