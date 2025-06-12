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
    /// 热点问题信息。
    /// </summary>
    public class HotQuestionInfo 
    {

        /// <summary>
        /// 热点问题ID。
        /// </summary>
        [JsonProperty("hot_question_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HotQuestionId { get; set; }

        /// <summary>
        /// 热点问题。
        /// </summary>
        [JsonProperty("hot_question", NullValueHandling = NullValueHandling.Ignore)]
        public string HotQuestion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 机器人ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

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
            sb.Append("class HotQuestionInfo {\n");
            sb.Append("  hotQuestionId: ").Append(HotQuestionId).Append("\n");
            sb.Append("  hotQuestion: ").Append(HotQuestion).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
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
            return this.Equals(input as HotQuestionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HotQuestionInfo input)
        {
            if (input == null) return false;
            if (this.HotQuestionId != input.HotQuestionId || (this.HotQuestionId != null && !this.HotQuestionId.Equals(input.HotQuestionId))) return false;
            if (this.HotQuestion != input.HotQuestion || (this.HotQuestion != null && !this.HotQuestion.Equals(input.HotQuestion))) return false;
            if (this.Language != input.Language) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
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
                if (this.HotQuestionId != null) hashCode = hashCode * 59 + this.HotQuestionId.GetHashCode();
                if (this.HotQuestion != null) hashCode = hashCode * 59 + this.HotQuestion.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
