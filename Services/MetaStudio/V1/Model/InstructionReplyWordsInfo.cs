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
    /// 指令回复话术信息。
    /// </summary>
    public class InstructionReplyWordsInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 回复话术，多个回复话术间用换行符\\n分隔。
        /// </summary>
        [JsonProperty("reply_words", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplyWords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstructionReplyWordsInfo {\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  replyWords: ").Append(ReplyWords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstructionReplyWordsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstructionReplyWordsInfo input)
        {
            if (input == null) return false;
            if (this.Language != input.Language) return false;
            if (this.ReplyWords != input.ReplyWords || (this.ReplyWords != null && !this.ReplyWords.Equals(input.ReplyWords))) return false;

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
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ReplyWords != null) hashCode = hashCode * 59 + this.ReplyWords.GetHashCode();
                return hashCode;
            }
        }
    }
}
