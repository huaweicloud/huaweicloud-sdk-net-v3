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
    public class MixInfoLayout 
    {

        /// <summary>
        /// 原视频在合成视频中的位置布局配置
        /// </summary>
        [JsonProperty("panes", NullValueHandling = NullValueHandling.Ignore)]
        public List<PaneSetting> Panes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MixInfoLayout {\n");
            sb.Append("  panes: ").Append(Panes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MixInfoLayout);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MixInfoLayout input)
        {
            if (input == null) return false;
            if (this.Panes != input.Panes || (this.Panes != null && input.Panes != null && !this.Panes.SequenceEqual(input.Panes))) return false;

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
                if (this.Panes != null) hashCode = hashCode * 59 + this.Panes.GetHashCode();
                return hashCode;
            }
        }
    }
}
