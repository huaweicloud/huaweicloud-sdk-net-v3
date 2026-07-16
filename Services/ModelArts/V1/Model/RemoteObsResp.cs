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
    /// 数据实际输出到OBS。
    /// </summary>
    public class RemoteObsResp 
    {

        /// <summary>
        /// **参数解释**：数据实际输出到OBS的路径。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("obs_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteObsResp {\n");
            sb.Append("  obsUrl: ").Append(ObsUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemoteObsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemoteObsResp input)
        {
            if (input == null) return false;
            if (this.ObsUrl != input.ObsUrl || (this.ObsUrl != null && !this.ObsUrl.Equals(input.ObsUrl))) return false;

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
                if (this.ObsUrl != null) hashCode = hashCode * 59 + this.ObsUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
