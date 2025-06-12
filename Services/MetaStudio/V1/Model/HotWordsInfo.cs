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
    /// 热词基本信息。
    /// </summary>
    public class HotWordsInfo 
    {

        /// <summary>
        /// 热词记录ID。
        /// </summary>
        [JsonProperty("hot_words_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HotWordsId { get; set; }

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hot_words_type", NullValueHandling = NullValueHandling.Ignore)]
        public HotWordsTypeEnum HotWordsType { get; set; }
        /// <summary>
        /// 热词ID(sis中配置)。
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotWordsInfo {\n");
            sb.Append("  hotWordsId: ").Append(HotWordsId).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  hotWordsType: ").Append(HotWordsType).Append("\n");
            sb.Append("  vocabularyId: ").Append(VocabularyId).Append("\n");
            sb.Append("  sisProjectId: ").Append(SisProjectId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HotWordsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HotWordsInfo input)
        {
            if (input == null) return false;
            if (this.HotWordsId != input.HotWordsId || (this.HotWordsId != null && !this.HotWordsId.Equals(input.HotWordsId))) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.HotWordsType != input.HotWordsType) return false;
            if (this.VocabularyId != input.VocabularyId || (this.VocabularyId != null && !this.VocabularyId.Equals(input.VocabularyId))) return false;
            if (this.SisProjectId != input.SisProjectId || (this.SisProjectId != null && !this.SisProjectId.Equals(input.SisProjectId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Language != input.Language) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                hashCode = hashCode * 59 + this.HotWordsType.GetHashCode();
                if (this.VocabularyId != null) hashCode = hashCode * 59 + this.VocabularyId.GetHashCode();
                if (this.SisProjectId != null) hashCode = hashCode * 59 + this.SisProjectId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
