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
    /// 第三方语言模型配置
    /// </summary>
    public class ThirdPartyModelConfig 
    {

        /// <summary>
        /// 第三方语言模型应用ID。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 第三方语言模型应用密钥。
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 第三方语言模型地址。
        /// </summary>
        [JsonProperty("llm_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LlmUrl { get; set; }

        /// <summary>
        /// 是否采用流式响应。
        /// </summary>
        [JsonProperty("is_stream", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsStream { get; set; }

        /// <summary>
        /// 支持的多轮对话数量，取值大于1时，请求第三方语言模型时将携带历史对话信息。
        /// </summary>
        [JsonProperty("chat_rounds", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChatRounds { get; set; }

        /// <summary>
        /// SIS所在区域
        /// </summary>
        [JsonProperty("sis_region", NullValueHandling = NullValueHandling.Ignore)]
        public int? SisRegion { get; set; }

        /// <summary>
        /// SIS所在区域的projectId
        /// </summary>
        [JsonProperty("sis_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SisProjectId { get; set; }

        /// <summary>
        /// 是否开启热词（asr_type选择EI_SIS时生效）
        /// </summary>
        [JsonProperty("enable_hot_words", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHotWords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asr_type", NullValueHandling = NullValueHandling.Ignore)]
        public AsrTypeEnum AsrType { get; set; }
        /// <summary>
        /// ASR帐号（asr_type选择EI_SIS时不需要配置）。
        /// </summary>
        [JsonProperty("asr_account", NullValueHandling = NullValueHandling.Ignore)]
        public string AsrAccount { get; set; }

        /// <summary>
        /// ASR密钥（asr_type选择EI_SIS时不需要配置）。
        /// </summary>
        [JsonProperty("asr_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string AsrSecret { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThirdPartyModelConfig {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  llmUrl: ").Append(LlmUrl).Append("\n");
            sb.Append("  isStream: ").Append(IsStream).Append("\n");
            sb.Append("  chatRounds: ").Append(ChatRounds).Append("\n");
            sb.Append("  sisRegion: ").Append(SisRegion).Append("\n");
            sb.Append("  sisProjectId: ").Append(SisProjectId).Append("\n");
            sb.Append("  enableHotWords: ").Append(EnableHotWords).Append("\n");
            sb.Append("  asrType: ").Append(AsrType).Append("\n");
            sb.Append("  asrAccount: ").Append(AsrAccount).Append("\n");
            sb.Append("  asrSecret: ").Append(AsrSecret).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ThirdPartyModelConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ThirdPartyModelConfig input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppKey != input.AppKey || (this.AppKey != null && !this.AppKey.Equals(input.AppKey))) return false;
            if (this.LlmUrl != input.LlmUrl || (this.LlmUrl != null && !this.LlmUrl.Equals(input.LlmUrl))) return false;
            if (this.IsStream != input.IsStream || (this.IsStream != null && !this.IsStream.Equals(input.IsStream))) return false;
            if (this.ChatRounds != input.ChatRounds || (this.ChatRounds != null && !this.ChatRounds.Equals(input.ChatRounds))) return false;
            if (this.SisRegion != input.SisRegion || (this.SisRegion != null && !this.SisRegion.Equals(input.SisRegion))) return false;
            if (this.SisProjectId != input.SisProjectId || (this.SisProjectId != null && !this.SisProjectId.Equals(input.SisProjectId))) return false;
            if (this.EnableHotWords != input.EnableHotWords || (this.EnableHotWords != null && !this.EnableHotWords.Equals(input.EnableHotWords))) return false;
            if (this.AsrType != input.AsrType) return false;
            if (this.AsrAccount != input.AsrAccount || (this.AsrAccount != null && !this.AsrAccount.Equals(input.AsrAccount))) return false;
            if (this.AsrSecret != input.AsrSecret || (this.AsrSecret != null && !this.AsrSecret.Equals(input.AsrSecret))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppKey != null) hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.LlmUrl != null) hashCode = hashCode * 59 + this.LlmUrl.GetHashCode();
                if (this.IsStream != null) hashCode = hashCode * 59 + this.IsStream.GetHashCode();
                if (this.ChatRounds != null) hashCode = hashCode * 59 + this.ChatRounds.GetHashCode();
                if (this.SisRegion != null) hashCode = hashCode * 59 + this.SisRegion.GetHashCode();
                if (this.SisProjectId != null) hashCode = hashCode * 59 + this.SisProjectId.GetHashCode();
                if (this.EnableHotWords != null) hashCode = hashCode * 59 + this.EnableHotWords.GetHashCode();
                hashCode = hashCode * 59 + this.AsrType.GetHashCode();
                if (this.AsrAccount != null) hashCode = hashCode * 59 + this.AsrAccount.GetHashCode();
                if (this.AsrSecret != null) hashCode = hashCode * 59 + this.AsrSecret.GetHashCode();
                return hashCode;
            }
        }
    }
}
