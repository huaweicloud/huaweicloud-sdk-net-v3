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
    /// 直播话术配置。
    /// </summary>
    public class LiveShootScriptItem 
    {

        /// <summary>
        /// **参数解释**： 剧本序号。 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("sequence_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNo { get; set; }

        /// <summary>
        /// **参数解释**： 段落标题。 **约束限制**： 不涉及 **取值范围**： 字符长度0-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("text_config", NullValueHandling = NullValueHandling.Ignore)]
        public TextConfig TextConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveAudioConfig AudioConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relation_product", NullValueHandling = NullValueHandling.Ignore)]
        public RelationProductInfo RelationProduct { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveShootScriptItem {\n");
            sb.Append("  sequenceNo: ").Append(SequenceNo).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  textConfig: ").Append(TextConfig).Append("\n");
            sb.Append("  audioConfig: ").Append(AudioConfig).Append("\n");
            sb.Append("  relationProduct: ").Append(RelationProduct).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveShootScriptItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveShootScriptItem input)
        {
            if (input == null) return false;
            if (this.SequenceNo != input.SequenceNo || (this.SequenceNo != null && !this.SequenceNo.Equals(input.SequenceNo))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.TextConfig != input.TextConfig || (this.TextConfig != null && !this.TextConfig.Equals(input.TextConfig))) return false;
            if (this.AudioConfig != input.AudioConfig || (this.AudioConfig != null && !this.AudioConfig.Equals(input.AudioConfig))) return false;
            if (this.RelationProduct != input.RelationProduct || (this.RelationProduct != null && !this.RelationProduct.Equals(input.RelationProduct))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.TextConfig != null) hashCode = hashCode * 59 + this.TextConfig.GetHashCode();
                if (this.AudioConfig != null) hashCode = hashCode * 59 + this.AudioConfig.GetHashCode();
                if (this.RelationProduct != null) hashCode = hashCode * 59 + this.RelationProduct.GetHashCode();
                return hashCode;
            }
        }
    }
}
