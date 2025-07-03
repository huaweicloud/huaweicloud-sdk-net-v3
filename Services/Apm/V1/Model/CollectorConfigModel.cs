using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 采集器配置。
    /// </summary>
    public class CollectorConfigModel 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("line_view_config", NullValueHandling = NullValueHandling.Ignore)]
        public LineViewConfigModel LineViewConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("detail_view_config", NullValueHandling = NullValueHandling.Ignore)]
        public DetailViewConfigModel DetailViewConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CollectorConfigModel {\n");
            sb.Append("  lineViewConfig: ").Append(LineViewConfig).Append("\n");
            sb.Append("  detailViewConfig: ").Append(DetailViewConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CollectorConfigModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CollectorConfigModel input)
        {
            if (input == null) return false;
            if (this.LineViewConfig != input.LineViewConfig || (this.LineViewConfig != null && !this.LineViewConfig.Equals(input.LineViewConfig))) return false;
            if (this.DetailViewConfig != input.DetailViewConfig || (this.DetailViewConfig != null && !this.DetailViewConfig.Equals(input.DetailViewConfig))) return false;

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
                if (this.LineViewConfig != null) hashCode = hashCode * 59 + this.LineViewConfig.GetHashCode();
                if (this.DetailViewConfig != null) hashCode = hashCode * 59 + this.DetailViewConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
