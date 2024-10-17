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
    /// Response Object
    /// </summary>
    public class ShowGaussMySqlFlavorsResponse : SdkResponse
    {

        /// <summary>
        /// 实例规格信息列表
        /// </summary>
        [JsonProperty("flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlFlavorsInfo> Flavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGaussMySqlFlavorsResponse {\n");
            sb.Append("  flavors: ").Append(Flavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGaussMySqlFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGaussMySqlFlavorsResponse input)
        {
            if (input == null) return false;
            if (this.Flavors != input.Flavors || (this.Flavors != null && input.Flavors != null && !this.Flavors.SequenceEqual(input.Flavors))) return false;

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
                if (this.Flavors != null) hashCode = hashCode * 59 + this.Flavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
