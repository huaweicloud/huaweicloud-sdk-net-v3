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
    /// 剧本参数配置。
    /// </summary>
    public class ShootScriptItem 
    {

        /// <summary>
        /// **参数解释**： 剧本序号。 **约束限制**： 同一个剧本序号不重复。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("sequence_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shoot_script", NullValueHandling = NullValueHandling.Ignore)]
        public ShootScript ShootScript { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subtitle_file_info", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleFiles SubtitleFileInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShootScriptItem {\n");
            sb.Append("  sequenceNo: ").Append(SequenceNo).Append("\n");
            sb.Append("  shootScript: ").Append(ShootScript).Append("\n");
            sb.Append("  subtitleFileInfo: ").Append(SubtitleFileInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShootScriptItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShootScriptItem input)
        {
            if (input == null) return false;
            if (this.SequenceNo != input.SequenceNo || (this.SequenceNo != null && !this.SequenceNo.Equals(input.SequenceNo))) return false;
            if (this.ShootScript != input.ShootScript || (this.ShootScript != null && !this.ShootScript.Equals(input.ShootScript))) return false;
            if (this.SubtitleFileInfo != input.SubtitleFileInfo || (this.SubtitleFileInfo != null && !this.SubtitleFileInfo.Equals(input.SubtitleFileInfo))) return false;

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
                if (this.SequenceNo != null) hashCode = hashCode * 59 + this.SequenceNo.GetHashCode();
                if (this.ShootScript != null) hashCode = hashCode * 59 + this.ShootScript.GetHashCode();
                if (this.SubtitleFileInfo != null) hashCode = hashCode * 59 + this.SubtitleFileInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
