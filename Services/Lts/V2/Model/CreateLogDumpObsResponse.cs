using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateLogDumpObsResponse : SdkResponse
    {

        /// <summary>
        /// 转储id。
        /// </summary>
        [JsonProperty("log_dump_obs_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogDumpObsId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLogDumpObsResponse {\n");
            sb.Append("  logDumpObsId: ").Append(LogDumpObsId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLogDumpObsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLogDumpObsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogDumpObsId == input.LogDumpObsId ||
                    (this.LogDumpObsId != null &&
                    this.LogDumpObsId.Equals(input.LogDumpObsId))
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
                if (this.LogDumpObsId != null)
                    hashCode = hashCode * 59 + this.LogDumpObsId.GetHashCode();
                return hashCode;
            }
        }
    }
}
