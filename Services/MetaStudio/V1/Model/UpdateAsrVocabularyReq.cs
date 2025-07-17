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
    /// 修改热词表请求。
    /// </summary>
    public class UpdateAsrVocabularyReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vocabulary_type", NullValueHandling = NullValueHandling.Ignore)]
        public AsrVocabularyTypeEnum VocabularyType { get; set; }
        /// <summary>
        /// 奇妙问热词表名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mobvoi_vocabulary", NullValueHandling = NullValueHandling.Ignore)]
        public MobvoiVocabulary MobvoiVocabulary { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAsrVocabularyReq {\n");
            sb.Append("  vocabularyType: ").Append(VocabularyType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  mobvoiVocabulary: ").Append(MobvoiVocabulary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAsrVocabularyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAsrVocabularyReq input)
        {
            if (input == null) return false;
            if (this.VocabularyType != input.VocabularyType) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Language != input.Language) return false;
            if (this.MobvoiVocabulary != input.MobvoiVocabulary || (this.MobvoiVocabulary != null && !this.MobvoiVocabulary.Equals(input.MobvoiVocabulary))) return false;

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
                hashCode = hashCode * 59 + this.VocabularyType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.MobvoiVocabulary != null) hashCode = hashCode * 59 + this.MobvoiVocabulary.GetHashCode();
                return hashCode;
            }
        }
    }
}
