using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateShareSpaceConfigReq 
    {

        /// <summary>
        /// 配置名称。
        /// </summary>
        [JsonProperty("config_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigName { get; set; }

        /// <summary>
        /// 配置值，使用Json字符串,&#39;{\&quot;share_space_name\&quot;:“协同空间”, \&quot;use_share_password\&quot;:是否使用协同密码：true/false, \&quot;allow_anonymous\&quot;:是否匿名加入协同:true/false, \&quot;audio_and_video\&quot;:是否使用音频,\&quot;AUDIO\&quot;/\&quot;NONE\&quot;/\&quot;AUDIO_AND_VIDEO\&quot;,\&quot;keyboard_mouse_ctl\&quot;:云桌面是否可用键鼠true/false,\&quot;anonymous_input_ctrl\&quot;:是否开启匿名用户键鼠输入权限true/false, \&quot;is_user_confirm_enabled\&quot;:是否需要用户应答true/false,\&quot;wait_confirm_time\&quot;:等待时间30-180s}。&#39;
        /// </summary>
        [JsonProperty("config_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateShareSpaceConfigReq {\n");
            sb.Append("  configName: ").Append(ConfigName).Append("\n");
            sb.Append("  configValue: ").Append(ConfigValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateShareSpaceConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateShareSpaceConfigReq input)
        {
            if (input == null) return false;
            if (this.ConfigName != input.ConfigName || (this.ConfigName != null && !this.ConfigName.Equals(input.ConfigName))) return false;
            if (this.ConfigValue != input.ConfigValue || (this.ConfigValue != null && !this.ConfigValue.Equals(input.ConfigValue))) return false;

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
                if (this.ConfigName != null) hashCode = hashCode * 59 + this.ConfigName.GetHashCode();
                if (this.ConfigValue != null) hashCode = hashCode * 59 + this.ConfigValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
