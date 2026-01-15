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
    /// 查询列信息请求体
    /// </summary>
    public class ShowColumnInfoReq 
    {

        /// <summary>
        /// 是否重新从node获取列信息
        /// </summary>
        [JsonProperty("refresh", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refresh { get; set; }

        /// <summary>
        /// 列所属的对象信息
        /// </summary>
        [JsonProperty("object_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ObjectIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowColumnInfoReq {\n");
            sb.Append("  refresh: ").Append(Refresh).Append("\n");
            sb.Append("  objectIds: ").Append(ObjectIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowColumnInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowColumnInfoReq input)
        {
            if (input == null) return false;
            if (this.Refresh != input.Refresh || (this.Refresh != null && !this.Refresh.Equals(input.Refresh))) return false;
            if (this.ObjectIds != input.ObjectIds || (this.ObjectIds != null && input.ObjectIds != null && !this.ObjectIds.SequenceEqual(input.ObjectIds))) return false;

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
                if (this.Refresh != null) hashCode = hashCode * 59 + this.Refresh.GetHashCode();
                if (this.ObjectIds != null) hashCode = hashCode * 59 + this.ObjectIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
