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
    public class LivePlayingShootScriptItem 
    {

        /// <summary>
        /// 剧本序号。
        /// </summary>
        [JsonProperty("sequence_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? SequenceNo { get; set; }

        /// <summary>
        /// 段落标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 段落话术内容。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivePlayingShootScriptItem {\n");
            sb.Append("  sequenceNo: ").Append(SequenceNo).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LivePlayingShootScriptItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LivePlayingShootScriptItem input)
        {
            if (input == null) return false;
            if (this.SequenceNo != input.SequenceNo || (this.SequenceNo != null && !this.SequenceNo.Equals(input.SequenceNo))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;

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
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                return hashCode;
            }
        }
    }
}
