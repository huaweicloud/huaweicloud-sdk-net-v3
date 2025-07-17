using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 传译员AI数字资产信息
    /// </summary>
    public class InterpreterAiDigitalInfo 
    {

        /// <summary>
        /// 数字资产类型：PUBLIC（系统公共）、PRIVATE（企业专用账号绑定）、LOCAL（企业本地通用）。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// AI传译员场景下绑定使用的数字资产ID（数字人或TTS音色）。
        /// </summary>
        [JsonProperty("digitalAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string DigitalAccount { get; set; }

        /// <summary>
        /// 数字资产名称。
        /// </summary>
        [JsonProperty("digitalName", NullValueHandling = NullValueHandling.Ignore)]
        public string DigitalName { get; set; }

        /// <summary>
        /// 专用数字资产绑定的发言人登录账号，翻译对象非匿名必填。
        /// </summary>
        [JsonProperty("presenterAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string PresenterAccount { get; set; }

        /// <summary>
        /// 专用数字资产绑定的发言人登录账号（匿名时），翻译对象匿名必填。
        /// </summary>
        [JsonProperty("presenterRealNameAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string PresenterRealNameAccount { get; set; }

        /// <summary>
        /// 专用数字资产绑定的发言人名称。
        /// </summary>
        [JsonProperty("presenterName", NullValueHandling = NullValueHandling.Ignore)]
        public string PresenterName { get; set; }

        /// <summary>
        /// 发言人用户的userUUID。
        /// </summary>
        [JsonProperty("presenterUserID", NullValueHandling = NullValueHandling.Ignore)]
        public string PresenterUserID { get; set; }

        /// <summary>
        /// 本地会议的会议id（第三方对接参数），数字资产为LOCAL时必填。
        /// </summary>
        [JsonProperty("localConfId", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalConfId { get; set; }

        /// <summary>
        /// 本地会议对接地址或域名。
        /// </summary>
        [JsonProperty("localConfAddr", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalConfAddr { get; set; }

        /// <summary>
        /// 本地会议对接鉴权信息。
        /// </summary>
        [JsonProperty("localAuthInfo", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalAuthInfo { get; set; }

        /// <summary>
        /// true：需要代理 false：不需要代理。
        /// </summary>
        [JsonProperty("localNeedProxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LocalNeedProxy { get; set; }

        /// <summary>
        /// 本地会议获取动态鉴权信息Url。
        /// </summary>
        [JsonProperty("localAuthUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalAuthUrl { get; set; }

        /// <summary>
        /// 本地会议鉴权AppId。
        /// </summary>
        [JsonProperty("localAuthAppId", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalAuthAppId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterpreterAiDigitalInfo {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  digitalAccount: ").Append(DigitalAccount).Append("\n");
            sb.Append("  digitalName: ").Append(DigitalName).Append("\n");
            sb.Append("  presenterAccount: ").Append(PresenterAccount).Append("\n");
            sb.Append("  presenterRealNameAccount: ").Append(PresenterRealNameAccount).Append("\n");
            sb.Append("  presenterName: ").Append(PresenterName).Append("\n");
            sb.Append("  presenterUserID: ").Append(PresenterUserID).Append("\n");
            sb.Append("  localConfId: ").Append(LocalConfId).Append("\n");
            sb.Append("  localConfAddr: ").Append(LocalConfAddr).Append("\n");
            sb.Append("  localAuthInfo: ").Append(LocalAuthInfo).Append("\n");
            sb.Append("  localNeedProxy: ").Append(LocalNeedProxy).Append("\n");
            sb.Append("  localAuthUrl: ").Append(LocalAuthUrl).Append("\n");
            sb.Append("  localAuthAppId: ").Append(LocalAuthAppId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InterpreterAiDigitalInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InterpreterAiDigitalInfo input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.DigitalAccount != input.DigitalAccount || (this.DigitalAccount != null && !this.DigitalAccount.Equals(input.DigitalAccount))) return false;
            if (this.DigitalName != input.DigitalName || (this.DigitalName != null && !this.DigitalName.Equals(input.DigitalName))) return false;
            if (this.PresenterAccount != input.PresenterAccount || (this.PresenterAccount != null && !this.PresenterAccount.Equals(input.PresenterAccount))) return false;
            if (this.PresenterRealNameAccount != input.PresenterRealNameAccount || (this.PresenterRealNameAccount != null && !this.PresenterRealNameAccount.Equals(input.PresenterRealNameAccount))) return false;
            if (this.PresenterName != input.PresenterName || (this.PresenterName != null && !this.PresenterName.Equals(input.PresenterName))) return false;
            if (this.PresenterUserID != input.PresenterUserID || (this.PresenterUserID != null && !this.PresenterUserID.Equals(input.PresenterUserID))) return false;
            if (this.LocalConfId != input.LocalConfId || (this.LocalConfId != null && !this.LocalConfId.Equals(input.LocalConfId))) return false;
            if (this.LocalConfAddr != input.LocalConfAddr || (this.LocalConfAddr != null && !this.LocalConfAddr.Equals(input.LocalConfAddr))) return false;
            if (this.LocalAuthInfo != input.LocalAuthInfo || (this.LocalAuthInfo != null && !this.LocalAuthInfo.Equals(input.LocalAuthInfo))) return false;
            if (this.LocalNeedProxy != input.LocalNeedProxy || (this.LocalNeedProxy != null && !this.LocalNeedProxy.Equals(input.LocalNeedProxy))) return false;
            if (this.LocalAuthUrl != input.LocalAuthUrl || (this.LocalAuthUrl != null && !this.LocalAuthUrl.Equals(input.LocalAuthUrl))) return false;
            if (this.LocalAuthAppId != input.LocalAuthAppId || (this.LocalAuthAppId != null && !this.LocalAuthAppId.Equals(input.LocalAuthAppId))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DigitalAccount != null) hashCode = hashCode * 59 + this.DigitalAccount.GetHashCode();
                if (this.DigitalName != null) hashCode = hashCode * 59 + this.DigitalName.GetHashCode();
                if (this.PresenterAccount != null) hashCode = hashCode * 59 + this.PresenterAccount.GetHashCode();
                if (this.PresenterRealNameAccount != null) hashCode = hashCode * 59 + this.PresenterRealNameAccount.GetHashCode();
                if (this.PresenterName != null) hashCode = hashCode * 59 + this.PresenterName.GetHashCode();
                if (this.PresenterUserID != null) hashCode = hashCode * 59 + this.PresenterUserID.GetHashCode();
                if (this.LocalConfId != null) hashCode = hashCode * 59 + this.LocalConfId.GetHashCode();
                if (this.LocalConfAddr != null) hashCode = hashCode * 59 + this.LocalConfAddr.GetHashCode();
                if (this.LocalAuthInfo != null) hashCode = hashCode * 59 + this.LocalAuthInfo.GetHashCode();
                if (this.LocalNeedProxy != null) hashCode = hashCode * 59 + this.LocalNeedProxy.GetHashCode();
                if (this.LocalAuthUrl != null) hashCode = hashCode * 59 + this.LocalAuthUrl.GetHashCode();
                if (this.LocalAuthAppId != null) hashCode = hashCode * 59 + this.LocalAuthAppId.GetHashCode();
                return hashCode;
            }
        }
    }
}
