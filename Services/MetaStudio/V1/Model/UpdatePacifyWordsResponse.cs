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
    public class UpdatePacifyWordsResponse : SdkResponse
    {

        /// <summary>
        /// 安抚话术ID。
        /// </summary>
        [JsonProperty("pacify_words_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PacifyWordsId { get; set; }

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
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 安抚话术类型 &gt; 0:通用安抚话术, 1:基于意图匹配安抚话术
        /// </summary>
        [JsonProperty("pacify_words_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PacifyWordsType { get; set; }

        /// <summary>
        /// 意图名称
        /// </summary>
        [JsonProperty("intent", NullValueHandling = NullValueHandling.Ignore)]
        public string Intent { get; set; }

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
            sb.Append("class UpdatePacifyWordsResponse {\n");
            sb.Append("  pacifyWordsId: ").Append(PacifyWordsId).Append("\n");
            sb.Append("  pacifyWords: ").Append(PacifyWords).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  pacifyWordsType: ").Append(PacifyWordsType).Append("\n");
            sb.Append("  intent: ").Append(Intent).Append("\n");
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
            return this.Equals(input as UpdatePacifyWordsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePacifyWordsResponse input)
        {
            if (input == null) return false;
            if (this.PacifyWordsId != input.PacifyWordsId || (this.PacifyWordsId != null && !this.PacifyWordsId.Equals(input.PacifyWordsId))) return false;
            if (this.PacifyWords != input.PacifyWords || (this.PacifyWords != null && !this.PacifyWords.Equals(input.PacifyWords))) return false;
            if (this.Language != input.Language) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.PacifyWordsType != input.PacifyWordsType || (this.PacifyWordsType != null && !this.PacifyWordsType.Equals(input.PacifyWordsType))) return false;
            if (this.Intent != input.Intent || (this.Intent != null && !this.Intent.Equals(input.Intent))) return false;
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
                if (this.PacifyWordsId != null) hashCode = hashCode * 59 + this.PacifyWordsId.GetHashCode();
                if (this.PacifyWords != null) hashCode = hashCode * 59 + this.PacifyWords.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.PacifyWordsType != null) hashCode = hashCode * 59 + this.PacifyWordsType.GetHashCode();
                if (this.Intent != null) hashCode = hashCode * 59 + this.Intent.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
