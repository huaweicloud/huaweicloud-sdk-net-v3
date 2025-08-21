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
    /// ces查询响应内容
    /// </summary>
    public class CesQueryRespQuery 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("medialive_mpc", NullValueHandling = NullValueHandling.Ignore)]
        public CesDimsItem MedialiveMpc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pipeline", NullValueHandling = NullValueHandling.Ignore)]
        public CesDimsItem Pipeline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public CesDimsItem Audio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("medialive_cdn", NullValueHandling = NullValueHandling.Ignore)]
        public CesDimsItem MedialiveCdn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("medialive_package", NullValueHandling = NullValueHandling.Ignore)]
        public CesDimsItem MedialivePackage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("medialive_connect", NullValueHandling = NullValueHandling.Ignore)]
        public CesDimsItem MedialiveConnect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("medialive_tailor", NullValueHandling = NullValueHandling.Ignore)]
        public CesDimsItem MedialiveTailor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CesQueryRespQuery {\n");
            sb.Append("  medialiveMpc: ").Append(MedialiveMpc).Append("\n");
            sb.Append("  pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("  medialiveCdn: ").Append(MedialiveCdn).Append("\n");
            sb.Append("  medialivePackage: ").Append(MedialivePackage).Append("\n");
            sb.Append("  medialiveConnect: ").Append(MedialiveConnect).Append("\n");
            sb.Append("  medialiveTailor: ").Append(MedialiveTailor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CesQueryRespQuery);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CesQueryRespQuery input)
        {
            if (input == null) return false;
            if (this.MedialiveMpc != input.MedialiveMpc || (this.MedialiveMpc != null && !this.MedialiveMpc.Equals(input.MedialiveMpc))) return false;
            if (this.Pipeline != input.Pipeline || (this.Pipeline != null && !this.Pipeline.Equals(input.Pipeline))) return false;
            if (this.Audio != input.Audio || (this.Audio != null && !this.Audio.Equals(input.Audio))) return false;
            if (this.MedialiveCdn != input.MedialiveCdn || (this.MedialiveCdn != null && !this.MedialiveCdn.Equals(input.MedialiveCdn))) return false;
            if (this.MedialivePackage != input.MedialivePackage || (this.MedialivePackage != null && !this.MedialivePackage.Equals(input.MedialivePackage))) return false;
            if (this.MedialiveConnect != input.MedialiveConnect || (this.MedialiveConnect != null && !this.MedialiveConnect.Equals(input.MedialiveConnect))) return false;
            if (this.MedialiveTailor != input.MedialiveTailor || (this.MedialiveTailor != null && !this.MedialiveTailor.Equals(input.MedialiveTailor))) return false;

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
                if (this.MedialiveCdn != null) hashCode = hashCode * 59 + this.MedialiveCdn.GetHashCode();
                if (this.MedialivePackage != null) hashCode = hashCode * 59 + this.MedialivePackage.GetHashCode();
                if (this.MedialiveConnect != null) hashCode = hashCode * 59 + this.MedialiveConnect.GetHashCode();
                if (this.MedialiveTailor != null) hashCode = hashCode * 59 + this.MedialiveTailor.GetHashCode();
                return hashCode;
            }
        }
    }
}
