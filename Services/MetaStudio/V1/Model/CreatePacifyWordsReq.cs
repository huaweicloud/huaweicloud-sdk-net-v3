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
    /// 创建安抚话术请求。
    /// </summary>
    public class CreatePacifyWordsReq 
    {

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 安抚话术类型 &gt; 0:通用安抚话术, 1:意图匹配安抚话术
        /// </summary>
        [JsonProperty("pacify_words_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PacifyWordsType { get; set; }

        /// <summary>
        /// 意图名称
        /// </summary>
        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)]
        public string Intent { get; set; }

        /// <summary>
        /// 安抚话术。
        /// </summary>
        [JsonProperty("pacify_words", NullValueHandling = NullValueHandling.Ignore)]
        public string PacifyWords { get; set; }

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
            sb.Append("class CreatePacifyWordsReq {\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  pacifyWordsType: ").Append(PacifyWordsType).Append("\n");
            sb.Append("  intent: ").Append(Intent).Append("\n");
            sb.Append("  pacifyWords: ").Append(PacifyWords).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePacifyWordsReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePacifyWordsReq input)
        {
            if (input == null) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.PacifyWordsType != input.PacifyWordsType || (this.PacifyWordsType != null && !this.PacifyWordsType.Equals(input.PacifyWordsType))) return false;
            if (this.Intent != input.Intent || (this.Intent != null && !this.Intent.Equals(input.Intent))) return false;
            if (this.PacifyWords != input.PacifyWords || (this.PacifyWords != null && !this.PacifyWords.Equals(input.PacifyWords))) return false;
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
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.PacifyWordsType != null) hashCode = hashCode * 59 + this.PacifyWordsType.GetHashCode();
                if (this.Intent != null) hashCode = hashCode * 59 + this.Intent.GetHashCode();
                if (this.PacifyWords != null) hashCode = hashCode * 59 + this.PacifyWords.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
