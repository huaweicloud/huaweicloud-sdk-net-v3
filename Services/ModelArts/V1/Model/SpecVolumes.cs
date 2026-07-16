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
    /// 训练作业挂载卷信息。
    /// </summary>
    public class SpecVolumes 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nfs", NullValueHandling = NullValueHandling.Ignore)]
        public Nfs Nfs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pfs", NullValueHandling = NullValueHandling.Ignore)]
        public Pfs Pfs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs", NullValueHandling = NullValueHandling.Ignore)]
        public Obs Obs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecVolumes {\n");
            sb.Append("  nfs: ").Append(Nfs).Append("\n");
            sb.Append("  pfs: ").Append(Pfs).Append("\n");
            sb.Append("  obs: ").Append(Obs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SpecVolumes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SpecVolumes input)
        {
            if (input == null) return false;
            if (this.Nfs != input.Nfs || (this.Nfs != null && !this.Nfs.Equals(input.Nfs))) return false;
            if (this.Pfs != input.Pfs || (this.Pfs != null && !this.Pfs.Equals(input.Pfs))) return false;
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
                if (this.Nfs != null) hashCode = hashCode * 59 + this.Nfs.GetHashCode();
                if (this.Pfs != null) hashCode = hashCode * 59 + this.Pfs.GetHashCode();
                if (this.Obs != null) hashCode = hashCode * 59 + this.Obs.GetHashCode();
                return hashCode;
            }
        }
    }
}
