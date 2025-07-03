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
    /// Response Object
    /// </summary>
    public class ListAppEnvsResponse : SdkResponse
    {

        /// <summary>
        /// 环境信息列表。
        /// </summary>
        [JsonProperty("envs", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnvNodeModel> Envs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAppEnvsResponse {\n");
            sb.Append("  envs: ").Append(Envs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAppEnvsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAppEnvsResponse input)
        {
            if (input == null) return false;
            if (this.Envs != input.Envs || (this.Envs != null && input.Envs != null && !this.Envs.SequenceEqual(input.Envs))) return false;

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
                if (this.Envs != null) hashCode = hashCode * 59 + this.Envs.GetHashCode();
                return hashCode;
            }
        }
    }
}
