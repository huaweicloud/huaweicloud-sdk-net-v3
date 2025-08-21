using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListCesInstanceRspBodyInstances 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("medialive_mpc", NullValueHandling = NullValueHandling.Ignore)]
        public ListCesInstanceRspBodyMedialiveMpc MedialiveMpc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pipeline", NullValueHandling = NullValueHandling.Ignore)]
        public ListCesInstanceRspBodyPipeline Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public ListCesInstanceRspBodyAudio Audio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCesInstanceRspBodyInstances {\n");
            sb.Append("  medialiveMpc: ").Append(MedialiveMpc).Append("\n");
            sb.Append("  pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCesInstanceRspBodyInstances);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCesInstanceRspBodyInstances input)
        {
            if (input == null) return false;
            if (this.MedialiveMpc != input.MedialiveMpc || (this.MedialiveMpc != null && !this.MedialiveMpc.Equals(input.MedialiveMpc))) return false;
            if (this.Pipeline != input.Pipeline || (this.Pipeline != null && !this.Pipeline.Equals(input.Pipeline))) return false;
            if (this.Audio != input.Audio || (this.Audio != null && !this.Audio.Equals(input.Audio))) return false;

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
                if (this.MedialiveMpc != null) hashCode = hashCode * 59 + this.MedialiveMpc.GetHashCode();
                if (this.Pipeline != null) hashCode = hashCode * 59 + this.Pipeline.GetHashCode();
                if (this.Audio != null) hashCode = hashCode * 59 + this.Audio.GetHashCode();
                return hashCode;
            }
        }
    }
}
