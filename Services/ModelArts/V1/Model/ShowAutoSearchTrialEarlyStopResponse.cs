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
    /// Response Object
    /// </summary>
    public class ShowAutoSearchTrialEarlyStopResponse : SdkResponse
    {

        /// <summary>
        /// 提前终止的trial的trial_id。
        /// </summary>
        [JsonProperty("earlystop_trial", NullValueHandling = NullValueHandling.Ignore)]
        public string EarlystopTrial { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAutoSearchTrialEarlyStopResponse {\n");
            sb.Append("  earlystopTrial: ").Append(EarlystopTrial).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAutoSearchTrialEarlyStopResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAutoSearchTrialEarlyStopResponse input)
        {
            if (input == null) return false;
            if (this.EarlystopTrial != input.EarlystopTrial || (this.EarlystopTrial != null && !this.EarlystopTrial.Equals(input.EarlystopTrial))) return false;

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
                if (this.EarlystopTrial != null) hashCode = hashCode * 59 + this.EarlystopTrial.GetHashCode();
                return hashCode;
            }
        }
    }
}
