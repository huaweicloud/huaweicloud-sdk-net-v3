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
    public class Thumbnail 
    {

        /// <summary>
        /// 是否压缩抽帧图片生成tar包 - 0：表示压缩 - 1：表示不压缩 
        /// </summary>
        [JsonProperty("tar", NullValueHandling = NullValueHandling.Ignore)]
        public int? Tar { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("out", NullValueHandling = NullValueHandling.Ignore)]
        public ObsObjInfo Out { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public ThumbnailPara Params { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Thumbnail {\n");
            sb.Append("  tar: ").Append(Tar).Append("\n");
            sb.Append("  Out: ").Append(Out).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Thumbnail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Thumbnail input)
        {
            if (input == null) return false;
            if (this.Tar != input.Tar || (this.Tar != null && !this.Tar.Equals(input.Tar))) return false;
            if (this.Out != input.Out || (this.Out != null && !this.Out.Equals(input.Out))) return false;
            if (this.Params != input.Params || (this.Params != null && !this.Params.Equals(input.Params))) return false;

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
                if (this.Tar != null) hashCode = hashCode * 59 + this.Tar.GetHashCode();
                if (this.Out != null) hashCode = hashCode * 59 + this.Out.GetHashCode();
                if (this.Params != null) hashCode = hashCode * 59 + this.Params.GetHashCode();
                return hashCode;
            }
        }
    }
}
