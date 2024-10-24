using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// OTT频道通用消息
    /// </summary>
    public class ModifyOttChannelEncoderSettings 
    {

        /// <summary>
        /// 频道推流域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 组名或应用名
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 频道ID。频道唯一标识，为必填项
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 转码模板配置
        /// </summary>
        [JsonProperty("encoder_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyOttChannelEncoderSettingsEncoderSettings> EncoderSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encoder_settings_expand", NullValueHandling = NullValueHandling.Ignore)]
        public EncoderSettingsExpand EncoderSettingsExpand { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyOttChannelEncoderSettings {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  encoderSettings: ").Append(EncoderSettings).Append("\n");
            sb.Append("  encoderSettingsExpand: ").Append(EncoderSettingsExpand).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyOttChannelEncoderSettings);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyOttChannelEncoderSettings input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.EncoderSettings != input.EncoderSettings || (this.EncoderSettings != null && input.EncoderSettings != null && !this.EncoderSettings.SequenceEqual(input.EncoderSettings))) return false;
            if (this.EncoderSettingsExpand != input.EncoderSettingsExpand || (this.EncoderSettingsExpand != null && !this.EncoderSettingsExpand.Equals(input.EncoderSettingsExpand))) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EncoderSettings != null) hashCode = hashCode * 59 + this.EncoderSettings.GetHashCode();
                if (this.EncoderSettingsExpand != null) hashCode = hashCode * 59 + this.EncoderSettingsExpand.GetHashCode();
                return hashCode;
            }
        }
    }
}
