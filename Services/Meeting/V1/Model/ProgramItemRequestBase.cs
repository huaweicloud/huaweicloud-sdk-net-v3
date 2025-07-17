using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 节目素材信息 。
    /// </summary>
    public class ProgramItemRequestBase 
    {

        /// <summary>
        /// 素材ID。
        /// </summary>
        [JsonProperty("materialId", NullValueHandling = NullValueHandling.Ignore)]
        public string MaterialId { get; set; }

        /// <summary>
        /// 播放时长。
        /// </summary>
        [JsonProperty("playTime", NullValueHandling = NullValueHandling.Ignore)]
        public int? PlayTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgramItemRequestBase {\n");
            sb.Append("  materialId: ").Append(MaterialId).Append("\n");
            sb.Append("  playTime: ").Append(PlayTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProgramItemRequestBase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProgramItemRequestBase input)
        {
            if (input == null) return false;
            if (this.MaterialId != input.MaterialId || (this.MaterialId != null && !this.MaterialId.Equals(input.MaterialId))) return false;
            if (this.PlayTime != input.PlayTime || (this.PlayTime != null && !this.PlayTime.Equals(input.PlayTime))) return false;

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
                if (this.MaterialId != null) hashCode = hashCode * 59 + this.MaterialId.GetHashCode();
                if (this.PlayTime != null) hashCode = hashCode * 59 + this.PlayTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
