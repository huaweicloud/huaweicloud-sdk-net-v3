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
    /// 创建应用请求。
    /// </summary>
    public class CreateRobotReq 
    {

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 对接第三方应用厂商类型。 &gt; 0：科大讯飞AIUI；1：华为云CBS；2：科大讯飞星火交互认知大模型；5：第三方驱动；6：第三方语言模型；7：交互助手；8：奇妙问
        /// </summary>
        [JsonProperty("app_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppType { get; set; }

        /// <summary>
        /// 智能交互对话房间ID。
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

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
        /// 语音识别后端点静音时长默认500ms
        /// </summary>
        [JsonProperty("tail_silence_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TailSilenceTime { get; set; }

        /// <summary>
        /// 提问文本审核开关
        /// </summary>
        [JsonProperty("enable_question_audit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableQuestionAudit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("huawei_ei_cbs", NullValueHandling = NullValueHandling.Ignore)]
        public HuaweiEiCbs HuaweiEiCbs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iflytek_aiui_config", NullValueHandling = NullValueHandling.Ignore)]
        public IflytekAiuiConfig IflytekAiuiConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("iflytek_spark", NullValueHandling = NullValueHandling.Ignore)]
        public IflytekSpark IflytekSpark { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("third_party_model_config", NullValueHandling = NullValueHandling.Ignore)]
        public ThirdPartyModelConfig ThirdPartyModelConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mobvoi_config", NullValueHandling = NullValueHandling.Ignore)]
        public MobvoiConfig MobvoiConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wise_brain_config", NullValueHandling = NullValueHandling.Ignore)]
        public WiseBrainConfig WiseBrainConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRobotReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  appType: ").Append(AppType).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  robotType: ").Append(RobotType).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  tailSilenceTime: ").Append(TailSilenceTime).Append("\n");
            sb.Append("  enableQuestionAudit: ").Append(EnableQuestionAudit).Append("\n");
            sb.Append("  huaweiEiCbs: ").Append(HuaweiEiCbs).Append("\n");
            sb.Append("  iflytekAiuiConfig: ").Append(IflytekAiuiConfig).Append("\n");
            sb.Append("  iflytekSpark: ").Append(IflytekSpark).Append("\n");
            sb.Append("  thirdPartyModelConfig: ").Append(ThirdPartyModelConfig).Append("\n");
            sb.Append("  mobvoiConfig: ").Append(MobvoiConfig).Append("\n");
            sb.Append("  wiseBrainConfig: ").Append(WiseBrainConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRobotReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRobotReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AppType != input.AppType || (this.AppType != null && !this.AppType.Equals(input.AppType))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.RobotType != input.RobotType) return false;
            if (this.Language != input.Language) return false;
            if (this.TailSilenceTime != input.TailSilenceTime || (this.TailSilenceTime != null && !this.TailSilenceTime.Equals(input.TailSilenceTime))) return false;
            if (this.EnableQuestionAudit != input.EnableQuestionAudit || (this.EnableQuestionAudit != null && !this.EnableQuestionAudit.Equals(input.EnableQuestionAudit))) return false;
            if (this.HuaweiEiCbs != input.HuaweiEiCbs || (this.HuaweiEiCbs != null && !this.HuaweiEiCbs.Equals(input.HuaweiEiCbs))) return false;
            if (this.IflytekAiuiConfig != input.IflytekAiuiConfig || (this.IflytekAiuiConfig != null && !this.IflytekAiuiConfig.Equals(input.IflytekAiuiConfig))) return false;
            if (this.IflytekSpark != input.IflytekSpark || (this.IflytekSpark != null && !this.IflytekSpark.Equals(input.IflytekSpark))) return false;
            if (this.ThirdPartyModelConfig != input.ThirdPartyModelConfig || (this.ThirdPartyModelConfig != null && !this.ThirdPartyModelConfig.Equals(input.ThirdPartyModelConfig))) return false;
            if (this.MobvoiConfig != input.MobvoiConfig || (this.MobvoiConfig != null && !this.MobvoiConfig.Equals(input.MobvoiConfig))) return false;
            if (this.WiseBrainConfig != input.WiseBrainConfig || (this.WiseBrainConfig != null && !this.WiseBrainConfig.Equals(input.WiseBrainConfig))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AppType != null) hashCode = hashCode * 59 + this.AppType.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                hashCode = hashCode * 59 + this.RobotType.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TailSilenceTime != null) hashCode = hashCode * 59 + this.TailSilenceTime.GetHashCode();
                if (this.EnableQuestionAudit != null) hashCode = hashCode * 59 + this.EnableQuestionAudit.GetHashCode();
                if (this.HuaweiEiCbs != null) hashCode = hashCode * 59 + this.HuaweiEiCbs.GetHashCode();
                if (this.IflytekAiuiConfig != null) hashCode = hashCode * 59 + this.IflytekAiuiConfig.GetHashCode();
                if (this.IflytekSpark != null) hashCode = hashCode * 59 + this.IflytekSpark.GetHashCode();
                if (this.ThirdPartyModelConfig != null) hashCode = hashCode * 59 + this.ThirdPartyModelConfig.GetHashCode();
                if (this.MobvoiConfig != null) hashCode = hashCode * 59 + this.MobvoiConfig.GetHashCode();
                if (this.WiseBrainConfig != null) hashCode = hashCode * 59 + this.WiseBrainConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
