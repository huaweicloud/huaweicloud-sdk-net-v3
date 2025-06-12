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
    public class ShowRobotResponse : SdkResponse
    {

        /// <summary>
        /// 应用ID。
        /// </summary>
        [JsonProperty("robot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RobotId { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 智能交互对话房间ID。
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 第三方应用ID。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 对接第三方应用厂商类型。 &gt; 0：科大讯飞AIUI；1：华为云CBS；2：科大讯飞星火交互认知大模型；5：第三方驱动；6：第三方语言模型；7：交互助手；8：奇妙问
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppType { get; set; }

        /// <summary>
        /// 应用的AccessKey或帐号。
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("robot_type", NullValueHandling = NullValueHandling.Ignore)]
        public RobotTypeEnum RobotType { get; set; }
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
        /// CBS所在区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public int? Region { get; set; }

        /// <summary>
        /// CBS所在区域的projectId
        /// </summary>
        [JsonProperty("cbs_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CbsProjectId { get; set; }

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
        /// 是否为正式环境
        /// </summary>
        [JsonProperty("is_ifly_production", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIflyProduction { get; set; }

        /// <summary>
        /// 语音识别后端点静音时长默认500ms
        /// </summary>
        [JsonProperty("tail_silence_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TailSilenceTime { get; set; }

        /// <summary>
        /// 奇妙问角色ID。
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

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
        /// 是否开启热词
        /// </summary>
        [JsonProperty("enable_hot_words", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableHotWords { get; set; }

        /// <summary>
        /// 是否开启提问文本审核开关
        /// </summary>
        [JsonProperty("enable_question_audit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableQuestionAudit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asr_type", NullValueHandling = NullValueHandling.Ignore)]
        public AsrTypeEnum AsrType { get; set; }
        /// <summary>
        /// ASR帐号。
        /// </summary>
        [JsonProperty("asr_account", NullValueHandling = NullValueHandling.Ignore)]
        public string AsrAccount { get; set; }

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
            sb.Append("class ShowRobotResponse {\n");
            sb.Append("  robotId: ").Append(RobotId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  robotType: ").Append(RobotType).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  cbsProjectId: ").Append(CbsProjectId).Append("\n");
            sb.Append("  llmUrl: ").Append(LlmUrl).Append("\n");
            sb.Append("  isStream: ").Append(IsStream).Append("\n");
            sb.Append("  chatRounds: ").Append(ChatRounds).Append("\n");
            sb.Append("  isIflyProduction: ").Append(IsIflyProduction).Append("\n");
            sb.Append("  tailSilenceTime: ").Append(TailSilenceTime).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  sisRegion: ").Append(SisRegion).Append("\n");
            sb.Append("  sisProjectId: ").Append(SisProjectId).Append("\n");
            sb.Append("  enableHotWords: ").Append(EnableHotWords).Append("\n");
            sb.Append("  enableQuestionAudit: ").Append(EnableQuestionAudit).Append("\n");
            sb.Append("  asrType: ").Append(AsrType).Append("\n");
            sb.Append("  asrAccount: ").Append(AsrAccount).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRobotResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRobotResponse input)
        {
            if (input == null) return false;
            if (this.RobotId != input.RobotId || (this.RobotId != null && !this.RobotId.Equals(input.RobotId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
            if (this.AppKey != input.AppKey || (this.AppKey != null && !this.AppKey.Equals(input.AppKey))) return false;
            if (this.RobotType != input.RobotType) return false;
            if (this.Language != input.Language) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.CbsProjectId != input.CbsProjectId || (this.CbsProjectId != null && !this.CbsProjectId.Equals(input.CbsProjectId))) return false;
            if (this.LlmUrl != input.LlmUrl || (this.LlmUrl != null && !this.LlmUrl.Equals(input.LlmUrl))) return false;
            if (this.IsStream != input.IsStream || (this.IsStream != null && !this.IsStream.Equals(input.IsStream))) return false;
            if (this.ChatRounds != input.ChatRounds || (this.ChatRounds != null && !this.ChatRounds.Equals(input.ChatRounds))) return false;
            if (this.IsIflyProduction != input.IsIflyProduction || (this.IsIflyProduction != null && !this.IsIflyProduction.Equals(input.IsIflyProduction))) return false;
            if (this.TailSilenceTime != input.TailSilenceTime || (this.TailSilenceTime != null && !this.TailSilenceTime.Equals(input.TailSilenceTime))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.SisRegion != input.SisRegion || (this.SisRegion != null && !this.SisRegion.Equals(input.SisRegion))) return false;
            if (this.SisProjectId != input.SisProjectId || (this.SisProjectId != null && !this.SisProjectId.Equals(input.SisProjectId))) return false;
            if (this.EnableHotWords != input.EnableHotWords || (this.EnableHotWords != null && !this.EnableHotWords.Equals(input.EnableHotWords))) return false;
            if (this.EnableQuestionAudit != input.EnableQuestionAudit || (this.EnableQuestionAudit != null && !this.EnableQuestionAudit.Equals(input.EnableQuestionAudit))) return false;
            if (this.AsrType != input.AsrType) return false;
            if (this.AsrAccount != input.AsrAccount || (this.AsrAccount != null && !this.AsrAccount.Equals(input.AsrAccount))) return false;
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
                if (this.RobotId != null) hashCode = hashCode * 59 + this.RobotId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.AppKey != null) hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                hashCode = hashCode * 59 + this.RobotType.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.CbsProjectId != null) hashCode = hashCode * 59 + this.CbsProjectId.GetHashCode();
                if (this.LlmUrl != null) hashCode = hashCode * 59 + this.LlmUrl.GetHashCode();
                if (this.IsStream != null) hashCode = hashCode * 59 + this.IsStream.GetHashCode();
                if (this.ChatRounds != null) hashCode = hashCode * 59 + this.ChatRounds.GetHashCode();
                if (this.IsIflyProduction != null) hashCode = hashCode * 59 + this.IsIflyProduction.GetHashCode();
                if (this.TailSilenceTime != null) hashCode = hashCode * 59 + this.TailSilenceTime.GetHashCode();
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.SisRegion != null) hashCode = hashCode * 59 + this.SisRegion.GetHashCode();
                if (this.SisProjectId != null) hashCode = hashCode * 59 + this.SisProjectId.GetHashCode();
                if (this.EnableHotWords != null) hashCode = hashCode * 59 + this.EnableHotWords.GetHashCode();
                if (this.EnableQuestionAudit != null) hashCode = hashCode * 59 + this.EnableQuestionAudit.GetHashCode();
                hashCode = hashCode * 59 + this.AsrType.GetHashCode();
                if (this.AsrAccount != null) hashCode = hashCode * 59 + this.AsrAccount.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
