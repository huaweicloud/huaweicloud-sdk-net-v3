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
    /// 终端类型登录管控的选项。
    /// </summary>
    public class PoliciesClientClientTypeOptions 
    {

        /// <summary>
        /// 是否勾选Windows客户端。取值为： false：表示未勾选。 true：表示勾选。
        /// </summary>
        [JsonProperty("sc_type_window", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScTypeWindow { get; set; }

        /// <summary>
        /// 是否勾选macOS客户端。取值为： false：表示未勾选。 true：表示勾选。
        /// </summary>
        [JsonProperty("sc_type_mac", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScTypeMac { get; set; }

        /// <summary>
        /// 是否勾选Android客户端。取值为： false：表示未勾选。 true：表示勾选。
        /// </summary>
        [JsonProperty("sc_type_android", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScTypeAndroid { get; set; }

        /// <summary>
        /// 是否勾选Linux客户端。取值为： false：表示未勾选。 true：表示勾选。
        /// </summary>
        [JsonProperty("sc_type_linux", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScTypeLinux { get; set; }

        /// <summary>
        /// 是否勾选Web客户端。取值为： false：表示未勾选。 true：表示勾选。
        /// </summary>
        [JsonProperty("sc_type_h5", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScTypeH5 { get; set; }

        /// <summary>
        /// 是否勾选ios客户端。取值为： false：表示未勾选。 true：表示勾选。
        /// </summary>
        [JsonProperty("sc_type_ios", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScTypeIos { get; set; }

        /// <summary>
        /// 是否勾选鸿蒙客户端。取值为： false：表示未勾选。 true：表示勾选。
        /// </summary>
        [JsonProperty("sc_type_harmony_os", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScTypeHarmonyOs { get; set; }

        /// <summary>
        /// 是否勾选全部硬件终端。取值为： false：表示未勾选。 true：表示勾选。
        /// </summary>
        [JsonProperty("tc_type_all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TcTypeAll { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesClientClientTypeOptions {\n");
            sb.Append("  scTypeWindow: ").Append(ScTypeWindow).Append("\n");
            sb.Append("  scTypeMac: ").Append(ScTypeMac).Append("\n");
            sb.Append("  scTypeAndroid: ").Append(ScTypeAndroid).Append("\n");
            sb.Append("  scTypeLinux: ").Append(ScTypeLinux).Append("\n");
            sb.Append("  scTypeH5: ").Append(ScTypeH5).Append("\n");
            sb.Append("  scTypeIos: ").Append(ScTypeIos).Append("\n");
            sb.Append("  scTypeHarmonyOs: ").Append(ScTypeHarmonyOs).Append("\n");
            sb.Append("  tcTypeAll: ").Append(TcTypeAll).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesClientClientTypeOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesClientClientTypeOptions input)
        {
            if (input == null) return false;
            if (this.ScTypeWindow != input.ScTypeWindow || (this.ScTypeWindow != null && !this.ScTypeWindow.Equals(input.ScTypeWindow))) return false;
            if (this.ScTypeMac != input.ScTypeMac || (this.ScTypeMac != null && !this.ScTypeMac.Equals(input.ScTypeMac))) return false;
            if (this.ScTypeAndroid != input.ScTypeAndroid || (this.ScTypeAndroid != null && !this.ScTypeAndroid.Equals(input.ScTypeAndroid))) return false;
            if (this.ScTypeLinux != input.ScTypeLinux || (this.ScTypeLinux != null && !this.ScTypeLinux.Equals(input.ScTypeLinux))) return false;
            if (this.ScTypeH5 != input.ScTypeH5 || (this.ScTypeH5 != null && !this.ScTypeH5.Equals(input.ScTypeH5))) return false;
            if (this.ScTypeIos != input.ScTypeIos || (this.ScTypeIos != null && !this.ScTypeIos.Equals(input.ScTypeIos))) return false;
            if (this.ScTypeHarmonyOs != input.ScTypeHarmonyOs || (this.ScTypeHarmonyOs != null && !this.ScTypeHarmonyOs.Equals(input.ScTypeHarmonyOs))) return false;
            if (this.TcTypeAll != input.TcTypeAll || (this.TcTypeAll != null && !this.TcTypeAll.Equals(input.TcTypeAll))) return false;

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
                if (this.ScTypeWindow != null) hashCode = hashCode * 59 + this.ScTypeWindow.GetHashCode();
                if (this.ScTypeMac != null) hashCode = hashCode * 59 + this.ScTypeMac.GetHashCode();
                if (this.ScTypeAndroid != null) hashCode = hashCode * 59 + this.ScTypeAndroid.GetHashCode();
                if (this.ScTypeLinux != null) hashCode = hashCode * 59 + this.ScTypeLinux.GetHashCode();
                if (this.ScTypeH5 != null) hashCode = hashCode * 59 + this.ScTypeH5.GetHashCode();
                if (this.ScTypeIos != null) hashCode = hashCode * 59 + this.ScTypeIos.GetHashCode();
                if (this.ScTypeHarmonyOs != null) hashCode = hashCode * 59 + this.ScTypeHarmonyOs.GetHashCode();
                if (this.TcTypeAll != null) hashCode = hashCode * 59 + this.TcTypeAll.GetHashCode();
                return hashCode;
            }
        }
    }
}
