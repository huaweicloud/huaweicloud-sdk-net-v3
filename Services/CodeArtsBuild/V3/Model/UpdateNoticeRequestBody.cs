using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 更新消息接口返回体
    /// </summary>
    public class UpdateNoticeRequestBody 
    {

        /// <summary>
        /// 通知类型
        /// </summary>
        [JsonProperty("notice_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NoticeType { get; set; }

        /// <summary>
        /// 开启的通知的种类
        /// </summary>
        [JsonProperty("enabled_event_type_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnabledEventTypeNames { get; set; }

        /// <summary>
        /// 是否开启消息通知。
        /// </summary>
        [JsonProperty("send_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string SendSwitch { get; set; }

        /// <summary>
        /// 通知参数配置
        /// </summary>
        [JsonProperty("param_config", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamConfig { get; set; }

        /// <summary>
        /// 是否使用项目级消息通知设置。
        /// </summary>
        [JsonProperty("use_project_notice", NullValueHandling = NullValueHandling.Ignore)]
        public string UseProjectNotice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNoticeRequestBody {\n");
            sb.Append("  noticeType: ").Append(NoticeType).Append("\n");
            sb.Append("  enabledEventTypeNames: ").Append(EnabledEventTypeNames).Append("\n");
            sb.Append("  sendSwitch: ").Append(SendSwitch).Append("\n");
            sb.Append("  paramConfig: ").Append(ParamConfig).Append("\n");
            sb.Append("  useProjectNotice: ").Append(UseProjectNotice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateNoticeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateNoticeRequestBody input)
        {
            if (input == null) return false;
            if (this.NoticeType != input.NoticeType || (this.NoticeType != null && !this.NoticeType.Equals(input.NoticeType))) return false;
            if (this.EnabledEventTypeNames != input.EnabledEventTypeNames || (this.EnabledEventTypeNames != null && input.EnabledEventTypeNames != null && !this.EnabledEventTypeNames.SequenceEqual(input.EnabledEventTypeNames))) return false;
            if (this.SendSwitch != input.SendSwitch || (this.SendSwitch != null && !this.SendSwitch.Equals(input.SendSwitch))) return false;
            if (this.ParamConfig != input.ParamConfig || (this.ParamConfig != null && !this.ParamConfig.Equals(input.ParamConfig))) return false;
            if (this.UseProjectNotice != input.UseProjectNotice || (this.UseProjectNotice != null && !this.UseProjectNotice.Equals(input.UseProjectNotice))) return false;

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
                if (this.NoticeType != null) hashCode = hashCode * 59 + this.NoticeType.GetHashCode();
                if (this.EnabledEventTypeNames != null) hashCode = hashCode * 59 + this.EnabledEventTypeNames.GetHashCode();
                if (this.SendSwitch != null) hashCode = hashCode * 59 + this.SendSwitch.GetHashCode();
                if (this.ParamConfig != null) hashCode = hashCode * 59 + this.ParamConfig.GetHashCode();
                if (this.UseProjectNotice != null) hashCode = hashCode * 59 + this.UseProjectNotice.GetHashCode();
                return hashCode;
            }
        }
    }
}
