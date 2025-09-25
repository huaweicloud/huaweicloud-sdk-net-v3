using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NewExtensionDataSourceBindings 
    {

        /// <summary>
        /// **参数解释**： 目标地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("target", NullValueHandling = NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// **参数解释**： 扩展点id。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("endpointId", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointId { get; set; }

        /// <summary>
        /// **参数解释**： 数据源绑定名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("data_source_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DataSourceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewExtensionDataSourceBindings {\n");
            sb.Append("  target: ").Append(Target).Append("\n");
            sb.Append("  endpointId: ").Append(EndpointId).Append("\n");
            sb.Append("  dataSourceName: ").Append(DataSourceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NewExtensionDataSourceBindings);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NewExtensionDataSourceBindings input)
        {
            if (input == null) return false;
            if (this.Target != input.Target || (this.Target != null && !this.Target.Equals(input.Target))) return false;
            if (this.EndpointId != input.EndpointId || (this.EndpointId != null && !this.EndpointId.Equals(input.EndpointId))) return false;
            if (this.DataSourceName != input.DataSourceName || (this.DataSourceName != null && !this.DataSourceName.Equals(input.DataSourceName))) return false;

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
                if (this.Target != null) hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.EndpointId != null) hashCode = hashCode * 59 + this.EndpointId.GetHashCode();
                if (this.DataSourceName != null) hashCode = hashCode * 59 + this.DataSourceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
