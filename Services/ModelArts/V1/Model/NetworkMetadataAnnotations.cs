using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 网络资源metadata信息中的annotations字段信息。
    /// </summary>
    public class NetworkMetadataAnnotations 
    {

        /// <summary>
        /// **参数解释**：网络的描述信息。 **取值范围**：不能包含字符!&lt;&gt;&#x3D;&amp;\&quot;&#39;。
        /// </summary>
        [JsonProperty("os.modelarts/description", NullValueHandling = NullValueHandling.Ignore)]
        public string OsModelartsDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkMetadataAnnotations {\n");
            sb.Append("  osModelartsDescription: ").Append(OsModelartsDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkMetadataAnnotations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkMetadataAnnotations input)
        {
            if (input == null) return false;
            if (this.OsModelartsDescription != input.OsModelartsDescription || (this.OsModelartsDescription != null && !this.OsModelartsDescription.Equals(input.OsModelartsDescription))) return false;

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
                if (this.OsModelartsDescription != null) hashCode = hashCode * 59 + this.OsModelartsDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
