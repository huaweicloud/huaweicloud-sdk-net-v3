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
    public class JobVolumeResp 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("nfs", NullValueHandling = NullValueHandling.Ignore)]
        public NfsResp Nfs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobVolumeResp {\n");
            sb.Append("  nfs: ").Append(Nfs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobVolumeResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobVolumeResp input)
        {
            if (input == null) return false;
            if (this.Nfs != input.Nfs || (this.Nfs != null && !this.Nfs.Equals(input.Nfs))) return false;

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
                return hashCode;
            }
        }
    }
}
