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
    /// sis类型热词
    /// </summary>
    public class CreateSisHotWords 
    {

        /// <summary>
        /// 热词ID。
        /// </summary>
        [JsonProperty("vocabulary_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VocabularyId { get; set; }

        /// <summary>
        /// SIS服务所在区域projectId
        /// </summary>
        [JsonProperty("sis_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SisProjectId { get; set; }

        /// <summary>
        /// 对接SIS服务的区域。 &gt; 0：北京四；3：上海一；
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public int? Region { get; set; }

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
            sb.Append("class CreateSisHotWords {\n");
            sb.Append("  vocabularyId: ").Append(VocabularyId).Append("\n");
            sb.Append("  sisProjectId: ").Append(SisProjectId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSisHotWords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSisHotWords input)
        {
            if (input == null) return false;
            if (this.VocabularyId != input.VocabularyId || (this.VocabularyId != null && !this.VocabularyId.Equals(input.VocabularyId))) return false;
            if (this.SisProjectId != input.SisProjectId || (this.SisProjectId != null && !this.SisProjectId.Equals(input.SisProjectId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
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
                if (this.VocabularyId != null) hashCode = hashCode * 59 + this.VocabularyId.GetHashCode();
                if (this.SisProjectId != null) hashCode = hashCode * 59 + this.SisProjectId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
