using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 资源。
    /// </summary>
    public class Resource 
    {

        /// <summary>
        /// 云服务资源类型名称。
        /// </summary>
        [JsonProperty("type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeName { get; set; }

        /// <summary>
        /// 统一资源名称模板，表示可以通过这类资源的统一资源名称对该授权项进行资源粒度的授权。
        /// </summary>
        [JsonProperty("urn_template", NullValueHandling = NullValueHandling.Ignore)]
        public string UrnTemplate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resource {\n");
            sb.Append("  typeName: ").Append(TypeName).Append("\n");
            sb.Append("  urnTemplate: ").Append(UrnTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Resource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Resource input)
        {
            if (input == null) return false;
            if (this.TypeName != input.TypeName || (this.TypeName != null && !this.TypeName.Equals(input.TypeName))) return false;
            if (this.UrnTemplate != input.UrnTemplate || (this.UrnTemplate != null && !this.UrnTemplate.Equals(input.UrnTemplate))) return false;

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
                if (this.TypeName != null) hashCode = hashCode * 59 + this.TypeName.GetHashCode();
                if (this.UrnTemplate != null) hashCode = hashCode * 59 + this.UrnTemplate.GetHashCode();
                return hashCode;
            }
        }
    }
}
