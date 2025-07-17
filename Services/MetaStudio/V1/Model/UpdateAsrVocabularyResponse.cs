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
    /// Response Object
    /// </summary>
    public class UpdateAsrVocabularyResponse : SdkResponse
    {

        /// <summary>
        /// 热词表ID。
        /// </summary>
        [JsonProperty("asr_vocabulary_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AsrVocabularyId { get; set; }

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
        /// 词表内容
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAsrVocabularyResponse {\n");
            sb.Append("  asrVocabularyId: ").Append(AsrVocabularyId).Append("\n");
            sb.Append("  vocabularyType: ").Append(VocabularyType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAsrVocabularyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAsrVocabularyResponse input)
        {
            if (input == null) return false;
            if (this.AsrVocabularyId != input.AsrVocabularyId || (this.AsrVocabularyId != null && !this.AsrVocabularyId.Equals(input.AsrVocabularyId))) return false;
            if (this.VocabularyType != input.VocabularyType) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Language != input.Language) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.AsrVocabularyId != null) hashCode = hashCode * 59 + this.AsrVocabularyId.GetHashCode();
                hashCode = hashCode * 59 + this.VocabularyType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
