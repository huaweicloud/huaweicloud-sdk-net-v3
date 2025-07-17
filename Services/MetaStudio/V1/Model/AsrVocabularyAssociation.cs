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
    /// 热词表关联信息
    /// </summary>
    public class AsrVocabularyAssociation 
    {

        /// <summary>
        /// 热词记录ID
        /// </summary>
        [JsonProperty("hot_words_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HotWordsId { get; set; }

        /// <summary>
        /// 热词表ID
        /// </summary>
        [JsonProperty("vocabulary_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VocabularyId { get; set; }

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsrVocabularyAssociation {\n");
            sb.Append("  hotWordsId: ").Append(HotWordsId).Append("\n");
            sb.Append("  vocabularyId: ").Append(VocabularyId).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsrVocabularyAssociation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AsrVocabularyAssociation input)
        {
            if (input == null) return false;
            if (this.HotWordsId != input.HotWordsId || (this.HotWordsId != null && !this.HotWordsId.Equals(input.HotWordsId))) return false;
            if (this.VocabularyId != input.VocabularyId || (this.VocabularyId != null && !this.VocabularyId.Equals(input.VocabularyId))) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.Language != input.Language) return false;

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
                if (this.HotWordsId != null) hashCode = hashCode * 59 + this.HotWordsId.GetHashCode();
                if (this.VocabularyId != null) hashCode = hashCode * 59 + this.VocabularyId.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
