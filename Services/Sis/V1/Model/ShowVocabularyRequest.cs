using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowVocabularyRequest 
    {

        /// <summary>
        /// 热词表id。
        /// </summary>
        [SDKProperty("vocabulary_id", IsPath = true)]
        [JsonProperty("vocabulary_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VocabularyId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVocabularyRequest {\n");
            sb.Append("  vocabularyId: ").Append(VocabularyId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVocabularyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVocabularyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VocabularyId == input.VocabularyId ||
                    (this.VocabularyId != null &&
                    this.VocabularyId.Equals(input.VocabularyId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.VocabularyId != null)
                    hashCode = hashCode * 59 + this.VocabularyId.GetHashCode();
                return hashCode;
            }
        }
    }
}
