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
    /// 切换会议显示策略请求。
    /// </summary>
    public class RestSwitchModeReqBody 
    {

        /// <summary>
        /// 会议显示策略。 - Fixed: 固定广播与会者 - VAS: 声控切换
        /// </summary>
        [JsonProperty("switchMode", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchMode { get; set; }

        /// <summary>
        /// 画面类型。单画面设置只针对声控模式。 - 0: 单画面 - 1: 多画面
        /// </summary>
        [JsonProperty("imageType", NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestSwitchModeReqBody {\n");
            sb.Append("  switchMode: ").Append(SwitchMode).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestSwitchModeReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestSwitchModeReqBody input)
        {
            if (input == null) return false;
            if (this.SwitchMode != input.SwitchMode || (this.SwitchMode != null && !this.SwitchMode.Equals(input.SwitchMode))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;

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
                if (this.SwitchMode != null) hashCode = hashCode * 59 + this.SwitchMode.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                return hashCode;
            }
        }
    }
}
