using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V3.Model
{
    /// <summary>
    /// 音频流数据输入
    /// </summary>
    public class AudioStreamCreateRequestData 
    {

        /// <summary>
        /// 音频流url地址，支持rtmp、rtmps、hls、http、https等主流协议。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 指定音频流中语种类型 zh: 中文,默认值为zh
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 返回音频片段结果的策略。可选值如下： false：返回风险等级为非pass的音频片段结果 true：返回所有风险等级的音频片段结果 说明： 1. 默认值为false； 2. 每隔10秒返回一次最近10秒音频流的审核结果。
        /// </summary>
        [JsonProperty("return_all_results", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReturnAllResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioStreamCreateRequestData {\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  returnAllResults: ").Append(ReturnAllResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioStreamCreateRequestData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioStreamCreateRequestData input)
        {
            if (input == null) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.ReturnAllResults != input.ReturnAllResults || (this.ReturnAllResults != null && !this.ReturnAllResults.Equals(input.ReturnAllResults))) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.ReturnAllResults != null) hashCode = hashCode * 59 + this.ReturnAllResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
