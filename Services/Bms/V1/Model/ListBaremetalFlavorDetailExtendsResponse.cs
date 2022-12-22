using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListBaremetalFlavorDetailExtendsResponse : SdkResponse
    {

        /// <summary>
        /// 裸金属服务器规格列表，详情请参见表2 flavors数据结构说明。
        /// </summary>
        [JsonProperty("flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlavorsResp> Flavors { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBaremetalFlavorDetailExtendsResponse {\n");
            sb.Append("  flavors: ").Append(Flavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBaremetalFlavorDetailExtendsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBaremetalFlavorDetailExtendsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flavors == input.Flavors ||
                    this.Flavors != null &&
                    input.Flavors != null &&
                    this.Flavors.SequenceEqual(input.Flavors)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Flavors != null)
                    hashCode = hashCode * 59 + this.Flavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
