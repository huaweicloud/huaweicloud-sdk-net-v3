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
    /// 
    /// </summary>
    public class AnalysisInfoResult 
    {

        /// <summary>
        /// 角色类型, 目前仅支持 AGENT(座席), USER(用户)。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 情绪类型，目前支持NORMAL(正常)，ANGRY(愤怒)，UNKNOWN(未知)。 在识别配置中emotion为true时存在。
        /// </summary>
        [JsonProperty("emotion", NullValueHandling = NullValueHandling.Ignore)]
        public string Emotion { get; set; }

        /// <summary>
        /// 语速信息，单位是\&quot;每秒字数\&quot;。 在识别配置中speed为true时存在。
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public float? Speed { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalysisInfoResult {\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  emotion: ").Append(Emotion).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnalysisInfoResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AnalysisInfoResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Emotion == input.Emotion ||
                    (this.Emotion != null &&
                    this.Emotion.Equals(input.Emotion))
                ) && 
                (
                    this.Speed == input.Speed ||
                    (this.Speed != null &&
                    this.Speed.Equals(input.Speed))
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Emotion != null)
                    hashCode = hashCode * 59 + this.Emotion.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
                return hashCode;
            }
        }
    }
}
