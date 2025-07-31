using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 音频质量评估结果
    /// </summary>
    public class AssessResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public AssessProperty Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sound", NullValueHandling = NullValueHandling.Ignore)]
        public AssessProperty Sound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("snr", NullValueHandling = NullValueHandling.Ignore)]
        public AssessProperty Snr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("reverb", NullValueHandling = NullValueHandling.Ignore)]
        public AssessProperty Reverb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dnsmos_ovrl", NullValueHandling = NullValueHandling.Ignore)]
        public AssessProperty DnsmosOvrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dnsmos_bak", NullValueHandling = NullValueHandling.Ignore)]
        public AssessProperty DnsmosBak { get; set; }

        /// <summary>
        /// 综合建议
        /// </summary>
        [JsonProperty("suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string Suggestion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssessResult {\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  sound: ").Append(Sound).Append("\n");
            sb.Append("  snr: ").Append(Snr).Append("\n");
            sb.Append("  reverb: ").Append(Reverb).Append("\n");
            sb.Append("  dnsmosOvrl: ").Append(DnsmosOvrl).Append("\n");
            sb.Append("  dnsmosBak: ").Append(DnsmosBak).Append("\n");
            sb.Append("  suggestion: ").Append(Suggestion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssessResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssessResult input)
        {
            if (input == null) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;
            if (this.Sound != input.Sound || (this.Sound != null && !this.Sound.Equals(input.Sound))) return false;
            if (this.Snr != input.Snr || (this.Snr != null && !this.Snr.Equals(input.Snr))) return false;
            if (this.Reverb != input.Reverb || (this.Reverb != null && !this.Reverb.Equals(input.Reverb))) return false;
            if (this.DnsmosOvrl != input.DnsmosOvrl || (this.DnsmosOvrl != null && !this.DnsmosOvrl.Equals(input.DnsmosOvrl))) return false;
            if (this.DnsmosBak != input.DnsmosBak || (this.DnsmosBak != null && !this.DnsmosBak.Equals(input.DnsmosBak))) return false;
            if (this.Suggestion != input.Suggestion || (this.Suggestion != null && !this.Suggestion.Equals(input.Suggestion))) return false;

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
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Sound != null) hashCode = hashCode * 59 + this.Sound.GetHashCode();
                if (this.Snr != null) hashCode = hashCode * 59 + this.Snr.GetHashCode();
                if (this.Reverb != null) hashCode = hashCode * 59 + this.Reverb.GetHashCode();
                if (this.DnsmosOvrl != null) hashCode = hashCode * 59 + this.DnsmosOvrl.GetHashCode();
                if (this.DnsmosBak != null) hashCode = hashCode * 59 + this.DnsmosBak.GetHashCode();
                if (this.Suggestion != null) hashCode = hashCode * 59 + this.Suggestion.GetHashCode();
                return hashCode;
            }
        }
    }
}
