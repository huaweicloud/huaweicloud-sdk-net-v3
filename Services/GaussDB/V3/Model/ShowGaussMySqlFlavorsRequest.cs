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
    public class ShowGaussMySqlFlavorsRequest 
    {

        /// <summary>
        /// 语言。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 数据库引擎名称。
        /// </summary>
        [SDKProperty("database_name", IsPath = true)]
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// 数据库版本号，目前仅支持兼容MySQL 8.0。
        /// </summary>
        [SDKProperty("version_name", IsQuery = true)]
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 规格的可用区模式，现在仅支持\&quot;single\&quot;、\&quot;multi\&quot;，不区分大小写。
        /// </summary>
        [SDKProperty("availability_zone_mode", IsQuery = true)]
        [JsonProperty("availability_zone_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneMode { get; set; }

        /// <summary>
        /// 规格编码。
        /// </summary>
        [SDKProperty("spec_code", IsQuery = true)]
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGaussMySqlFlavorsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  availabilityZoneMode: ").Append(AvailabilityZoneMode).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGaussMySqlFlavorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGaussMySqlFlavorsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.DatabaseName != input.DatabaseName || (this.DatabaseName != null && !this.DatabaseName.Equals(input.DatabaseName))) return false;
            if (this.VersionName != input.VersionName || (this.VersionName != null && !this.VersionName.Equals(input.VersionName))) return false;
            if (this.AvailabilityZoneMode != input.AvailabilityZoneMode || (this.AvailabilityZoneMode != null && !this.AvailabilityZoneMode.Equals(input.AvailabilityZoneMode))) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.DatabaseName != null) hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.VersionName != null) hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.AvailabilityZoneMode != null) hashCode = hashCode * 59 + this.AvailabilityZoneMode.GetHashCode();
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
