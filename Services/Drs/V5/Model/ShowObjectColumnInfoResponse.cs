using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowObjectColumnInfoResponse : SdkResponse
    {

        /// <summary>
        /// 和列信息相关的对象
        /// </summary>
        [JsonProperty("object_with_column_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObjectWithColumnInfo> ObjectWithColumnInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowObjectColumnInfoResponse {\n");
            sb.Append("  objectWithColumnInfos: ").Append(ObjectWithColumnInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowObjectColumnInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowObjectColumnInfoResponse input)
        {
            if (input == null) return false;
            if (this.ObjectWithColumnInfos != input.ObjectWithColumnInfos || (this.ObjectWithColumnInfos != null && input.ObjectWithColumnInfos != null && !this.ObjectWithColumnInfos.SequenceEqual(input.ObjectWithColumnInfos))) return false;

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
                if (this.ObjectWithColumnInfos != null) hashCode = hashCode * 59 + this.ObjectWithColumnInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
