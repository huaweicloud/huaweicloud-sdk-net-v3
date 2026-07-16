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
    /// 数据实际输入信息，异构作业只支持OBS。
    /// </summary>
    public class AlgorithmRemote 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs", NullValueHandling = NullValueHandling.Ignore)]
        public RemoteObs Obs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlgorithmRemote {\n");
            sb.Append("  obs: ").Append(Obs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlgorithmRemote);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlgorithmRemote input)
        {
            if (input == null) return false;
            if (this.Obs != input.Obs || (this.Obs != null && !this.Obs.Equals(input.Obs))) return false;

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
                if (this.Obs != null) hashCode = hashCode * 59 + this.Obs.GetHashCode();
                return hashCode;
            }
        }
    }
}
