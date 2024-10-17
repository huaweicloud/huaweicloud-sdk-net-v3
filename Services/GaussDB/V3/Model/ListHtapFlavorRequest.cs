using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListHtapFlavorRequest 
    {

        /// <summary>
        /// HTAP引擎名。 取值范围： - star-rocks - click-house
        /// </summary>
        [SDKProperty("engine_name", IsPath = true)]
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 可用区模式，当前仅支持single。
        /// </summary>
        [SDKProperty("availability_zone_mode", IsQuery = true)]
        [JsonProperty("availability_zone_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneMode { get; set; }

        /// <summary>
        /// 规格码，提供后仅查询指定规格码规格信息。
        /// </summary>
        [SDKProperty("spec_code", IsQuery = true)]
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 请求语言类型。默认en-us。 取值范围： - en-us - zh-cn
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 数据库版本号，不填默认3.1.6.0。
        /// </summary>
        [SDKProperty("version_name", IsQuery = true)]
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHtapFlavorRequest {\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  availabilityZoneMode: ").Append(AvailabilityZoneMode).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHtapFlavorRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHtapFlavorRequest input)
        {
            if (input == null) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.AvailabilityZoneMode != input.AvailabilityZoneMode || (this.AvailabilityZoneMode != null && !this.AvailabilityZoneMode.Equals(input.AvailabilityZoneMode))) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.VersionName != input.VersionName || (this.VersionName != null && !this.VersionName.Equals(input.VersionName))) return false;

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
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.AvailabilityZoneMode != null) hashCode = hashCode * 59 + this.AvailabilityZoneMode.GetHashCode();
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.VersionName != null) hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                return hashCode;
            }
        }
    }
}
