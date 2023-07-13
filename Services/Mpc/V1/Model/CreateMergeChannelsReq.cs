using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateMergeChannelsReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("multi_audio", NullValueHandling = NullValueHandling.Ignore)]
        public MpcMultiAudio MultiAudio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMergeChannelsReq {\n");
            sb.Append("  multiAudio: ").Append(MultiAudio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateMergeChannelsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateMergeChannelsReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MultiAudio == input.MultiAudio ||
                    (this.MultiAudio != null &&
                    this.MultiAudio.Equals(input.MultiAudio))
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
                if (this.MultiAudio != null)
                    hashCode = hashCode * 59 + this.MultiAudio.GetHashCode();
                return hashCode;
            }
        }
    }
}
