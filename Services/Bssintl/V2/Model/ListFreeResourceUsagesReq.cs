using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListFreeResourceUsagesReq 
    {

        /// <summary>
        /// 资源项ID列表，每个最大64字节。 资源项ID，一个资源包中会含有多个资源项，一个使用量类型对应一个资源项。资源项ID来自查询资源包列表接口的响应。
        /// </summary>
        [JsonProperty("free_resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FreeResourceIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFreeResourceUsagesReq {\n");
            sb.Append("  freeResourceIds: ").Append(FreeResourceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFreeResourceUsagesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFreeResourceUsagesReq input)
        {
            if (input == null) return false;
            if (this.FreeResourceIds != input.FreeResourceIds || (this.FreeResourceIds != null && input.FreeResourceIds != null && !this.FreeResourceIds.SequenceEqual(input.FreeResourceIds))) return false;

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
                if (this.FreeResourceIds != null) hashCode = hashCode * 59 + this.FreeResourceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
