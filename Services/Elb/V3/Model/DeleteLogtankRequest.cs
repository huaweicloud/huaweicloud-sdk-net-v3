using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteLogtankRequest 
    {

        /// <summary>
        /// 云日志ID。
        /// </summary>
        [SDKProperty("logtank_id", IsPath = true)]
        [JsonProperty("logtank_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogtankId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteLogtankRequest {\n");
            sb.Append("  logtankId: ").Append(LogtankId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteLogtankRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteLogtankRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogtankId == input.LogtankId ||
                    (this.LogtankId != null &&
                    this.LogtankId.Equals(input.LogtankId))
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
                if (this.LogtankId != null)
                    hashCode = hashCode * 59 + this.LogtankId.GetHashCode();
                return hashCode;
            }
        }
    }
}
