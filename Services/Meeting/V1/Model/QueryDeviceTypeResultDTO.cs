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
    /// 终端类型。
    /// </summary>
    public class QueryDeviceTypeResultDTO 
    {

        /// <summary>
        /// 终端类型，区分自研和第三方终端。 * TE：华为自研硬终端 * 3rd：第三方硬终端 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 终端型号，枚举类型。 * TE10 * TE20 * TE30 * TE40 * TE50 * TE60 * HUAWEI Box 300 * HUAWEI Box 500 * HUAWEI Box 600 * HUAWEI Box 700 * HUAWEI Box 900 * DP300 * HUAWEI Box 200 * HUAWEI Box 300 * HUAWEI Box 500 * HUAWEI Board * polycomcisco 
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// 是否支持激活码。
        /// </summary>
        [JsonProperty("enableActiveCode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableActiveCode { get; set; }

        /// <summary>
        /// 屏幕分辨率。1080P、720P等。
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public string Resolution { get; set; }

        /// <summary>
        /// 是否支持投影码。
        /// </summary>
        [JsonProperty("supportProjectionCode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportProjectionCode { get; set; }

        /// <summary>
        /// 是否支持SVC。
        /// </summary>
        [JsonProperty("supportSVC", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportSVC { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDeviceTypeResultDTO {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("  enableActiveCode: ").Append(EnableActiveCode).Append("\n");
            sb.Append("  resolution: ").Append(Resolution).Append("\n");
            sb.Append("  supportProjectionCode: ").Append(SupportProjectionCode).Append("\n");
            sb.Append("  supportSVC: ").Append(SupportSVC).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDeviceTypeResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDeviceTypeResultDTO input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;
            if (this.EnableActiveCode != input.EnableActiveCode || (this.EnableActiveCode != null && !this.EnableActiveCode.Equals(input.EnableActiveCode))) return false;
            if (this.Resolution != input.Resolution || (this.Resolution != null && !this.Resolution.Equals(input.Resolution))) return false;
            if (this.SupportProjectionCode != input.SupportProjectionCode || (this.SupportProjectionCode != null && !this.SupportProjectionCode.Equals(input.SupportProjectionCode))) return false;
            if (this.SupportSVC != input.SupportSVC || (this.SupportSVC != null && !this.SupportSVC.Equals(input.SupportSVC))) return false;

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
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.EnableActiveCode != null) hashCode = hashCode * 59 + this.EnableActiveCode.GetHashCode();
                if (this.Resolution != null) hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.SupportProjectionCode != null) hashCode = hashCode * 59 + this.SupportProjectionCode.GetHashCode();
                if (this.SupportSVC != null) hashCode = hashCode * 59 + this.SupportSVC.GetHashCode();
                return hashCode;
            }
        }
    }
}
