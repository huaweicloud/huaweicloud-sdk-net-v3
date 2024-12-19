using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 单条schema信息
    /// </summary>
    public class ResourceSchemaResponse 
    {

        /// <summary>
        /// 资源类型.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// schema 内容.
        /// </summary>
        [JsonProperty("schema", NullValueHandling = NullValueHandling.Ignore)]
        public Object Schema { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceSchemaResponse {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  schema: ").Append(Schema).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceSchemaResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceSchemaResponse input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Schema != input.Schema || (this.Schema != null && !this.Schema.Equals(input.Schema))) return false;

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
                if (this.Schema != null) hashCode = hashCode * 59 + this.Schema.GetHashCode();
                return hashCode;
            }
        }
    }
}
